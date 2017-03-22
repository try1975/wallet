using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using EPM.Wallet.Data.Entities;
using EPM.Wallet.Data.QueryProcessors;
using WalletWebApi.Model;

namespace WalletWebApi.Maintenance
{
    public class TransactionApi : TypedApi<TransactionDto, TransactionEntity, Guid>, ITransactionApi
    {
        private readonly IAccountQuery _accountQuery;

        public TransactionApi(ITransactionQuery query, IAccountQuery accountQuery) : base(query)
        {
            _accountQuery = accountQuery;
        }


        public IEnumerable<TransactionDto> GetTransactionsByAccount(string clientId, Guid accountId)
        {
            var account = _accountQuery.GetEntities().FirstOrDefault(z => z.ClientId == clientId && z.Id == accountId);
            if (account == null) return null;
            var list = _query.GetEntities()
                .Where(z => z.AccountId == accountId)
                .OrderByDescending(i => i.RegisterDate)
                .ToList()
                ;
            return Mapper.Map<List<TransactionDto>>(list);
        }
    }
}