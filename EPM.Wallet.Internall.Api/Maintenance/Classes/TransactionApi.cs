using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using EPM.Wallet.Data.Entities;
using EPM.Wallet.Data.QueryProcessors;
using EPM.Wallet.Internal.Model;

namespace WalletInternalApi.Maintenance
{
    public class TransactionApi : TypedApi<TransactionDto, TransactionEntity, Guid>, ITransactionApi
    {
        private readonly IAccountQuery _accountQuery;

        public TransactionApi(ITransactionQuery query, IAccountQuery accountQuery) : base(query)
        {
            _accountQuery = accountQuery;
        }

        public override IEnumerable<TransactionDto> GetItems()
        {

            //var list = Query.GetEntities().OrderBy(z => z.RegisterDate).ToList();
            var transactions = Query.GetEntities();

            var list = transactions.Join(_accountQuery.GetEntities(), o => o.AccountId, i => i.Id
                , (o, i) => new TransactionDto()
                {
                    Id = o.Id,
                    AccountId = o.AccountId,
                    AccountName = i.Name,
                    ClientId = i.ClientId,
                    AccountCurrency = i.CurrencyId,
                    RegisterDate = o.RegisterDate,
                    ValueDate = o.ValueDate,
                    Amount = o.Amount,
                    CurrencyId = o.CurrencyId,
                    AmountInCurrency = o.AmountInCurrency,
                    FromTo = o.FromTo,
                    Note = o.Note,
                    RequestId = o.RequestId,
                    StandingOrderId = o.StandingOrderId
                }
                )
                .OrderBy(r => r.RegisterDate)
                .ToList();

            var balances = new Dictionary<Guid, decimal>();
            foreach (var transaction in list)
            {
                var balance = 0.00M;
                if (balances.ContainsKey(transaction.AccountId)) balance = balances[transaction.AccountId];
                balance += transaction.Amount;
                transaction.Balance = balance;
                balances[transaction.AccountId] = balance;
            }
            return Mapper.Map<List<TransactionDto>>(list.OrderByDescending(z => z.RegisterDate));
        }

        //public override TransactionDto AddItem(TransactionDto dto)
        //{
        //    var lastTransaction =
        //        Query.GetEntities()
        //            .Where(z => z.AccountId == dto.AccountId && z.RegisterDate <= dto.RegisterDate)
        //            .OrderByDescending(z => z.RegisterDate)
        //            .FirstOrDefault();
        //    var balance = 0.00M;
        //    if (lastTransaction != null) balance = lastTransaction.Balance;
        //    var entity = Mapper.Map<TransactionEntity>(dto);
        //    balance = balance + entity.Amount;
        //    entity.Balance = balance;

        //    using (var dbContextTransaction = Query.GetDbContext().Database.BeginTransaction())
        //    {
        //        try
        //        {
        //            entity = Query.InsertEntity(entity);

        //            var latestTransactions =
        //                Query.GetEntities()
        //                    .Where(z => z.AccountId == dto.AccountId && z.RegisterDate >= dto.RegisterDate)
        //                    .OrderBy(z => z.RegisterDate)
        //                    .ToList();
        //            foreach (var transaction in latestTransactions)
        //            {
        //                balance = balance + transaction.Amount;
        //                transaction.Balance = balance;
        //                Query.UpdateEntity(transaction);
        //            }
        //            dbContextTransaction.Commit();
        //            return Mapper.Map<TransactionDto>(entity);
        //        }
        //        catch (Exception e)
        //        {
        //            Debug.WriteLine(e);
        //            dbContextTransaction.Rollback();
        //            throw;
        //        }
        //    }
        //}
    }
}