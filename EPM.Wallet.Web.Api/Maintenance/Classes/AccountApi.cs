using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using AutoMapper;
using EPM.Wallet.Data.Entities;
using EPM.Wallet.Data.QueryProcessors;
using WalletWebApi.Model;

namespace WalletWebApi.Maintenance
{
    public class AccountApi : TypedApi<AccountDto, ClientAccountEntity, Guid>, IAccountApi
    {
        private readonly ITransactionQuery _transactionQuery;

        public AccountApi(IAccountQuery query, ITransactionQuery transactionQuery) : base(query)
        {
            _transactionQuery = transactionQuery;
        }

        public IEnumerable<AccountDto> GetAccountsByClient(string clientId)
        {
            var list = _query.GetEntities()
                .Where(z => z.ClientId.Equals(clientId, StringComparison.InvariantCultureIgnoreCase))
                .Include(z=>z.BankAccount)
                .Include(z=>z.BankAccount.Bank)
                .ToList()
                ;
            foreach (var accountEntity in list)
            {
                //var transactions = _transactionQuery.GetEntities().Where(z => z.AccountId == accountEntity.Id).Sum(z => z.Amount);
                //accountEntity.CurrentBalance = balance;
                var requisiteEntity = new RequisiteEntity()
                {
                    Name = accountEntity.Name,
                    BankName = accountEntity.BankAccount.Bank.Name,
                    BankAddress = "",
                    Bic = "",
                    Iban = accountEntity.BankAccount.Name,
                    OwnerName = accountEntity.Name
                };
                accountEntity.Requisite = requisiteEntity;
            }
            return Mapper.Map<List<AccountDto>>(list);
        }

        public AccountDto GetAccountByClient(string clientId, Guid accountId)
        {
            var entity = _query.GetEntity(accountId);
            if (entity == null) return null;
            if (!entity.ClientId.Equals(clientId, StringComparison.InvariantCultureIgnoreCase)) return null;
            return Mapper.Map<AccountDto>(entity);
        }
    }
}