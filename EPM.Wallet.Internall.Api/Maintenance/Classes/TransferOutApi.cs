using System;
using System.Collections.Generic;
using System.Linq;
using EPM.Wallet.Common.Enums;
using EPM.Wallet.Data.Entities;
using EPM.Wallet.Data.QueryProcessors;
using EPM.Wallet.Internal.Model;

namespace WalletInternalApi.Maintenance
{
    public class TransferOutApi : TypedApi<TransferOutInfoDto, AccountRequestEntity, Guid>, ITransferOutApi
    {
        private readonly IRequisiteQuery _requisiteQuery;
        private readonly IAccountQuery _accountQuery;
        private readonly IClientQuery _clientQuery;

        public TransferOutApi(IAccountRequestQuery query, 
            IRequisiteQuery requisiteQuery, 
            IAccountQuery accountQuery,
            IClientQuery clientQuery) : base(query)
        {
            _requisiteQuery = requisiteQuery;
            _accountQuery = accountQuery;
            _clientQuery = clientQuery;
        }

        public override IEnumerable<TransferOutInfoDto> GetItems()
        {
            var requests = Query.GetEntities()
                .Where(z => z.AccountRequestType == AccountRequestType.TransferOut)
                ;
            var list = requests.Join(_requisiteQuery.GetEntities(), o => o.RequisiteId, i => i.Id,
                        (request, requisite) => new { request, requisite })
                        .Join(_accountQuery.GetEntities(), o => o.request.ClientAccountId, i => i.Id,
                        (rr, account) => new TransferOutInfoDto()
                            {
                                Id = rr.request.Id,
                                Date = rr.request.CreatedAt,
                                ValueDate = rr.request.ValueDate,
                                ClientId = rr.request.ClientId,
                                CurrencyId = rr.request.CurrencyId,
                                RequestStatus = rr.request.RequestStatus,
                                Note = rr.request.Note,
                                AccountId = rr.request.ClientAccountId,
                                AmountOut = rr.request.AmountOut,
                                // Requisites
                                BankName = rr.requisite.BankName,
                                Iban = rr.requisite.Iban,
                                BankAddress = rr.requisite.BankAddress,
                                Bic = rr.requisite.Bic,
                                OwnerName = rr.requisite.OwnerName,
                                // Accounts
                                AccountName = account.Name,
                                AccountCurrency = account.CurrencyId,
                                // Client
                                ClientName = rr.request.Client.Name
                            })
                .OrderByDescending(r => r.Date)
                .ToList();
            //var list = requests.Join(_requisiteQuery.GetEntities(), o => o.RequisiteId, i => i.Id,
            //            (request, requisite) => new { request, requisite })
            //            .Join(_accountQuery.GetEntities(), o => o.request.ClientAccountId, i => i.Id,
            //                (rr, account) => new TransferOutInfoDto()
            //                {
            //                    Id = rr.request.Id,
            //                    Date = rr.request.CreatedAt,
            //                    ValueDate = rr.request.ValueDate,
            //                    ClientId = rr.request.ClientId,
            //                    CurrencyId = rr.request.CurrencyId,
            //                    RequestStatus = rr.request.RequestStatus,
            //                    Note = rr.request.Note,
            //                    AccountId = rr.request.ClientAccountId,
            //                    AmountOut = rr.request.AmountOut,
            //                    // Requisites
            //                    BankName = rr.requisite.BankName,
            //                    Iban = rr.requisite.Iban,
            //                    BankAddress = rr.requisite.BankAddress,
            //                    Bic = rr.requisite.Bic,
            //                    OwnerName = rr.requisite.OwnerName,
            //                    // Accounts
            //                    AccountName = account.Name,
            //                    AccountCurrency = account.CurrencyId
            //                })
            //    .OrderByDescending(r => r.Date)
            //    .ToList();
            return list;
        }

        public override TransferOutInfoDto ChangeItem(TransferOutInfoDto dto)
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