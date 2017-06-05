using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using AutoMapper;
using EPM.Wallet.Common.Enums;
using EPM.Wallet.Data.Entities;
using EPM.Wallet.Data.QueryProcessors;
using EPM.Wallet.Internal.Model;

namespace WalletInternalApi.Maintenance
{

    public class RequestApi : TypedApi<RequestInfoDto, RequestEntity, Guid>, IRequestApi
    {
        private readonly ICardRequestQuery _cardRequestQuery;
        private readonly IAccountRequestQuery _accountRequestQuery;

        public RequestApi(IRequestQuery query, ICardRequestQuery cardRequestQuery, IAccountRequestQuery accountRequestQuery) : base(query)
        {
            _cardRequestQuery = cardRequestQuery;
            _accountRequestQuery = accountRequestQuery;
        }

        public override IEnumerable<RequestInfoDto> GetItems()
        {
            var cardRequestList = _cardRequestQuery.GetEntities()
                .Include(z => z.Client)
                .Include(z => z.Requisite)
                .Include(z => z.Card)
                .ToList();

            var accountRequestList = _accountRequestQuery.GetEntities()
                .Include(z => z.Client)
                .Include(z => z.Requisite)
                .Include(z => z.Card)
                .Include(z => z.ClientAccount)
                .Include(z => z.BeneficiaryAccount)
                .ToList();

            var dtoList = cardRequestList.Select(entity => new RequestInfoDto()
            {
                Id = entity.Id,
                Date = entity.CreatedAt,
                ClientId = entity.ClientId,
                ClientName = entity.Client.Name,
                CurrencyId = entity.CurrencyId,
                CardId = entity.CardId,
                CardNumber = entity.CardId.HasValue ? entity.Card.CardNumber : string.Empty,
                RequisiteId = entity.RequisiteId,
                BankName = entity.RequisiteId.HasValue ? entity.Requisite.BankName : string.Empty,
                Iban = entity.RequisiteId.HasValue ? entity.Requisite.Iban : string.Empty,
                BankAddress = entity.RequisiteId.HasValue ? entity.Requisite.BankAddress : string.Empty,
                Bic = entity.RequisiteId.HasValue ? entity.Requisite.Bic : string.Empty,
                OwnerName = entity.RequisiteId.HasValue ? entity.Requisite.OwnerName : string.Empty,
                Note = entity.Note,
                RequestType = entity.RequestType,
                Type = entity.RequestType,
                SubType = entity.CardRequestType.ToString(),
                RequestStatus = entity.RequestStatus,
                Status = entity.RequestStatus.ToString(),
                Limit = entity.Limit,
                CardReissueType = entity.CardReissueType.ToString(),
                CardReissueReason = entity.CardReissueReason
            }).ToList();
            dtoList.AddRange(accountRequestList.Select(entity => new RequestInfoDto()
            {
                Id = entity.Id,
                Date = entity.CreatedAt,
                ClientId = entity.ClientId,
                ClientName = entity.Client.Name,
                CurrencyId = entity.CurrencyId,
                CardId = entity.CardId,
                CardNumber = entity.CardId.HasValue ? entity.Card.CardNumber : string.Empty,
                RequisiteId = entity.RequisiteId,
                BankName = entity.RequisiteId.HasValue ? entity.Requisite.BankName : string.Empty,
                Iban = entity.RequisiteId.HasValue ? entity.Requisite.Iban : string.Empty,
                BankAddress = entity.RequisiteId.HasValue ? entity.Requisite.BankAddress : string.Empty,
                Bic = entity.RequisiteId.HasValue ? entity.Requisite.Bic : string.Empty,
                OwnerName = entity.RequisiteId.HasValue ? entity.Requisite.OwnerName : string.Empty,
                Note = entity.Note,
                RequestType = entity.RequestType,
                Type = entity.RequestType,
                SubType = entity.AccountRequestType.ToString(),
                RequestStatus = entity.RequestStatus,
                Status = entity.RequestStatus.ToString(),
                ClientAccountId = entity.ClientAccountId,
                AccountName = entity.ClientAccountId.HasValue ? entity.ClientAccount.Name : string.Empty,
                AccountCurrencyId = entity.ClientAccount != null ? entity.ClientAccount.CurrencyId : string.Empty,
                AmountIn = entity.AmountIn,
                AmountOut = entity.AmountOut,
                BeneficiaryAccountId = entity.BeneficiaryAccountId,
                BeneficiaryAccountName = entity.BeneficiaryAccountId.HasValue ? entity.BeneficiaryAccount.Name : string.Empty,
                BeneficiaryCurrencyId = entity.BeneficiaryAccount != null ? entity.BeneficiaryAccount.CurrencyId : string.Empty,
                ValueDate = entity.ValueDate
            }));
            return dtoList.OrderByDescending(z => z.Date);
        }

        public IEnumerable<RequestDto> RequestsByClient(string clientId)
        {
            var list = Query.GetEntities()
                .Where(m => m.ClientId == clientId && m.RequestType == RequestType.Payment)
                .OrderByDescending(i => i.CreatedAt)
                .ToList()
                ;
            return Mapper.Map<List<RequestDto>>(list);
        }

        public override RequestInfoDto ChangeItem(RequestInfoDto dto)
        {
            var entity = Query.GetEntity(dto.Id);
            if (entity == null) return null;
            entity.RequestStatus = dto.RequestStatus;
            entity = Query.UpdateEntity(entity);
            dto.RequestStatus = entity.RequestStatus;
            return dto;
        }
    }
}