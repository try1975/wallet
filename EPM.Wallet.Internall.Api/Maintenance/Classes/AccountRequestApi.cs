using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using EPM.Wallet.Common.Enums;
using EPM.Wallet.Data.Entities;
using EPM.Wallet.Data.QueryProcessors;
using EPM.Wallet.Internal.Model;

namespace WalletInternalApi.Maintenance
{
    public class AccountRequestApi : TypedApi<AccountRequestDto, AccountRequestEntity, Guid>, IAccountRequestApi
    {
        private readonly IAccountQuery _accountQuery;
        private readonly ICardQuery _cardQuery;
        private readonly IRequisiteQuery _requisiteQuery;
        private readonly IClientQuery _clientQuery;

        public AccountRequestApi(IAccountRequestQuery query,
                                IAccountQuery accountQuery,
                                ICardQuery cardQuery,
                                IRequisiteQuery requisiteQuery,
                                IClientQuery clientQuery) : base(query)
        {
            _accountQuery = accountQuery;
            _cardQuery = cardQuery;
            _requisiteQuery = requisiteQuery;
            _clientQuery = clientQuery;
        }

        public IEnumerable<AccountRequestDto> RequestsByClient(string clientId)
        {
            var list = Query.GetEntities()
               .Where(m => m.ClientId == clientId && m.RequestType == RequestType.Payment)
               .OrderByDescending(i => i.CreatedAt)
               .ToList()
               ;
            var dtoList = new List<AccountRequestDto>();
            foreach (var accountRequestEntity in list)
            {
                var dto = Mapper.Map<AccountRequestDto>(accountRequestEntity);
                if (accountRequestEntity.ClientAccountId.HasValue)
                {
                    var accountId = accountRequestEntity.ClientAccountId.Value;
                    dto.AccountName = _accountQuery.GetEntity(accountId).Name;
                }

                if (accountRequestEntity.AccountRequestType == AccountRequestType.Refill)
                {
                    if (accountRequestEntity.BeneficiaryAccountId.HasValue)
                    {
                        var accountId = accountRequestEntity.BeneficiaryAccountId.Value;
                        dto.BeneficiaryAccount = _accountQuery.GetEntity(accountId).Name;
                    }
                }
                if (accountRequestEntity.AccountRequestType == AccountRequestType.TransferOut)
                {
                    if (accountRequestEntity.RequisiteId.HasValue)
                    {
                        var requisiteId = accountRequestEntity.RequisiteId.Value;
                        dto.BeneficiaryAccount = _requisiteQuery.GetEntity(requisiteId).Name;
                    }
                }
                if(accountRequestEntity.AccountRequestType == AccountRequestType.TransferToCard)
                {
                    if (accountRequestEntity.CardId.HasValue)
                    {
                        var cardId = accountRequestEntity.CardId.Value;
                        dto.BeneficiaryCard = _cardQuery.GetEntity(cardId).CardNumber;
                    }
                }
                dtoList.Add(dto);
            }

            //return Mapper.Map<List<AccountRequestDto>>(list);
            return dtoList;
        }

        public bool CreateAccountNewRequest(string clientId, AccountNewRequestDto dto)
        {
            var currencyId = "EUR";
            if (!string.IsNullOrEmpty(dto.CurrencyId)) currencyId = dto.CurrencyId;
            var client = _clientQuery.GetEntities().FirstOrDefault(z => z.Id == clientId);
            if (client == null) return false;
            if (!client.Id.Equals(clientId, StringComparison.InvariantCultureIgnoreCase)) return false;
            var entity = new AccountRequestEntity
            {
                ClientId = clientId,
                CurrencyId = currencyId,
                RequestType = RequestType.Account,
                RequestStatus = RequestStatuses.GetPendingRequestStatus(),
                AccountRequestType = AccountRequestType.New
            };

            try
            {
                Query.InsertEntity(entity);
                return true;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
                Log.Error(e);
                throw;
            }
        }

        public async Task<bool> CreateAccountRefillRequest(string clientId, Guid accountId, RefillRequestDto dto)
        {
            if (dto.BeneficiaryAccountId == Guid.Empty) return false;

            var accountTask = _accountQuery.GetEntityAsync(accountId);
            var beneficiaryTask = _accountQuery.GetEntityAsync(dto.BeneficiaryAccountId);
            await Task.WhenAll(accountTask, beneficiaryTask);

            var account = accountTask.Result;
            if (account == null) return false;
            if (!account.ClientId.Equals(clientId, StringComparison.InvariantCultureIgnoreCase)) return false;

            var beneficiary = beneficiaryTask.Result;
            if (beneficiary == null) return false;
            if (!beneficiary.ClientId.Equals(clientId, StringComparison.InvariantCultureIgnoreCase)) return false;

            var currencyId = "EUR";
            if (!string.IsNullOrEmpty(dto.CurrencyId)) currencyId = dto.CurrencyId;
            var entity = new AccountRequestEntity()
            {
                RequestType = RequestType.Payment,
                RequestStatus = RequestStatuses.GetPendingRequestStatus(),
                AccountRequestType = AccountRequestType.Refill,
                ClientId = account.ClientId,
                ClientAccountId = account.Id,
                BeneficiaryAccountId = beneficiary.Id,
                CurrencyId = currencyId,
                AmountOut = dto.Amount
            };
            try
            {
                Query.InsertEntity(entity);
                return true;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
                Log.Error(e);
                throw;
            }
        }

        public bool CreateAccountTransferToCardRequest(string clientId, Guid accountId, TransferToCardRequestDto dto)
        {
            var account = _accountQuery.GetEntity(accountId);
            if (account == null) return false;
            if (!account.ClientId.Equals(clientId, StringComparison.InvariantCultureIgnoreCase)) return false;
            if (dto.CardId == Guid.Empty) return false;
            var card = _cardQuery.GetEntity(dto.CardId);
            if (card == null) return false;
            if (!card.ClientId.Equals(clientId, StringComparison.InvariantCultureIgnoreCase)) return false;
            var currencyId = "EUR";
            if (!string.IsNullOrEmpty(dto.CurrencyId)) currencyId = dto.CurrencyId;
            var entity = new AccountRequestEntity()
            {
                RequestType = RequestType.Payment,
                RequestStatus = RequestStatuses.GetPendingRequestStatus(),
                AccountRequestType = AccountRequestType.TransferToCard,
                ClientId = account.ClientId,
                ClientAccountId = account.Id,
                CardId = card.Id,
                CurrencyId = currencyId,
                AmountOut = dto.Amount
            };
            try
            {
                Query.InsertEntity(entity);
                return true;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
                Log.Error(e);
                throw;
            }
        }

        public bool CreateAccountTransferOutRequest(string clientId, Guid accountId, TransferOutRequestDto dto)
        {
            var account = _accountQuery.GetEntity(accountId);
            if (account == null) return false;
            if (!account.ClientId.Equals(clientId, StringComparison.InvariantCultureIgnoreCase)) return false;
            if (dto.RequisiteId == Guid.Empty) return false;
            var requisite = _requisiteQuery.GetEntity(dto.RequisiteId);
            if (requisite == null) return false;
            if (!requisite.ClientId.Equals(clientId, StringComparison.InvariantCultureIgnoreCase)) return false;
            var currencyId = "EUR";
            if (!string.IsNullOrEmpty(dto.CurrencyId)) currencyId = dto.CurrencyId;
            var entity = new AccountRequestEntity()
            {
                RequestType = RequestType.Payment,
                RequestStatus = RequestStatuses.GetPendingRequestStatus(),
                AccountRequestType = AccountRequestType.TransferOut,
                ClientId = account.ClientId,
                ClientAccountId = account.Id,
                RequisiteId = requisite.Id,
                CurrencyId = currencyId,
                AmountOut = dto.Amount
            };
            try
            {
                Query.InsertEntity(entity);
                return true;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
                Log.Error(e);
                throw;
            }
        }
    }
}