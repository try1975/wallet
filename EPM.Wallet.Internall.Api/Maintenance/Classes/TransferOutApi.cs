using System;
using System.Collections.Generic;
using System.Linq;
using EPM.Wallet.Common.Enums;
using EPM.Wallet.Data.Entities;
using EPM.Wallet.Data.QueryProcessors;
using EPM.Wallet.Internal.Model;

namespace WalletInternalApi.Maintenance.Classes
{
    public class TransferOutApi : TypedApi<TransferOutInfoDto, AccountRequestEntity, Guid>, ITransferOutApi
    {
        private readonly IRequisiteQuery _requisiteQuery;

        public TransferOutApi(IAccountRequestQuery query, IRequisiteQuery requisiteQuery) : base(query)
        {
            _requisiteQuery = requisiteQuery;
        }

        public override IEnumerable<TransferOutInfoDto> GetItems()
        {


            var requests = Query.GetEntities()
                .Where(z => z.AccountRequestType == AccountRequestType.TransferOut)
                //.OrderByDescending(z=>z.CreatedAt)
                ;
            // TODO: change to LEFT join
            var list = requests.Join(_requisiteQuery.GetEntities(), o => o.RequisiteId, i => i.Id
                , (o, i) => new TransferOutInfoDto()
                {
                    Id = o.Id,
                    Date = o.CreatedAt,
                    ValueDate = o.ValueDate,
                    ClientId = o.ClientId,
                    CurrencyId = o.CurrencyId,
                    RequestStatus = o.RequestStatus,
                    Note = o.Note,
                    AccountId = o.ClientAccountId,
                    AmountOut = o.AmountOut,
                    // Requisites
                    BankName = i.BankName,
                    Iban = i.Iban,
                    BankAddress = i.BankAddress,
                    Bic = i.Bic,
                    OwnerName = i.OwnerName
                }
                )
                //.DefaultIfEmpty(new TransferOutInfoDto())
                .OrderByDescending(r => r.Date)
                .ToList();
            return list;
        }

        public override TransferOutInfoDto ChangeItem(TransferOutInfoDto dto)
        {
            var entity = Query.GetEntity(dto.Id);
            if (entity == null) return null;
            entity.RequestStatus = dto.RequestStatus;
            entity=Query.UpdateEntity(entity);
            dto.RequestStatus = entity.RequestStatus;
            return dto;
        }
    }
}