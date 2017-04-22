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
    public class TransactionApi : TypedApi<TransactionDto, TransactionEntity, Guid>, ITransactionApi
    {
        private readonly IAccountQuery _accountQuery;

        public TransactionApi(ITransactionQuery query, IAccountQuery accountQuery) : base(query)
        {
            _accountQuery = accountQuery;
        }


        public IEnumerable<TransactionDto> GetTransactionsByAccount(string clientId, Guid accountId, int from, int count)
        {
            var account = _accountQuery.GetEntities().FirstOrDefault(z => z.ClientId.Equals(clientId) && z.Id == accountId);
            if (account == null) return null;
            var list = _query.GetEntities()
                .Where(z => z.AccountId == accountId)
                .Include(r=>r.Request.Requisite)
                .OrderByDescending(i => i.RegisterDate)
                .ThenByDescending(z => z.Id)
                .ToList()
                ;
            if (!list.Any()) return null;
            var firstTransaction = list.FirstOrDefault();
            var balance = 0.00M;
            if (firstTransaction != null)
            {
                balance = firstTransaction.Balance;
            }
            var byValueDateTransactions = list.OrderByDescending(z => z.ValueDate).ThenByDescending(z => z.Id).ToList();
            foreach (var transaction in byValueDateTransactions)
            {
                transaction.Balance = balance;
                balance -= transaction.Amount;
            }
            var transactionEntitiyList = byValueDateTransactions.Skip(from).Take(count > 0 ? count : 1000).ToList();
            var transactionDtoList = new List<TransactionDto>();
            foreach (var transactionEntity in transactionEntitiyList)
            {
                var transactionDto = Mapper.Map<TransactionDto>(transactionEntity);
                if (transactionEntity.Request?.Requisite != null)
                {
                    var requisiteDto = Mapper.Map<RequisiteDto>(transactionEntity.Request.Requisite);
                    transactionDto.Requisite = requisiteDto;
                }
                transactionDtoList.Add(transactionDto);
            }
            return transactionDtoList;
            //return Mapper.Map<List<TransactionDto>>(entityList);
        }
    }
}