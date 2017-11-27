using System;
using System.Collections.Generic;
using System.Diagnostics;
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
                    StandingOrderId = o.StandingOrderId,
                    Balance = o.Balance
                }
                )
                .OrderByDescending(r => r.RegisterDate)
                .ThenBy(z=>z.AccountId)
                .ThenByDescending(z=>z.Id)
                .ToList();

            return Mapper.Map<List<TransactionDto>>(list);


            //var list = transactions.Join(_accountQuery.GetEntities(), o => o.AccountId, i => i.Id
            //    , (o, i) => new TransactionDto()
            //    {
            //        Id = o.Id,
            //        AccountId = o.AccountId,
            //        AccountName = i.Name,
            //        ClientId = i.ClientId,
            //        AccountCurrency = i.CurrencyId,
            //        RegisterDate = o.RegisterDate,
            //        ValueDate = o.ValueDate,
            //        Amount = o.Amount,
            //        CurrencyId = o.CurrencyId,
            //        AmountInCurrency = o.AmountInCurrency,
            //        FromTo = o.FromTo,
            //        Note = o.Note,
            //        RequestId = o.RequestId,
            //        StandingOrderId = o.StandingOrderId,
            //        Balance = o.Balance
            //    }
            //    )
            //    .OrderBy(r => r.RegisterDate)
            //    .ToList();

            //var balances = new Dictionary<Guid, decimal>();
            //foreach (var transaction in list)
            //{
            //    var balance = 0.00M;
            //    if (balances.ContainsKey(transaction.AccountId)) balance = balances[transaction.AccountId];
            //    balance += transaction.Amount;
            //    transaction.Balance = balance;
            //    balances[transaction.AccountId] = balance;
            //}
            //return Mapper.Map<List<TransactionDto>>(list.OrderByDescending(z => z.RegisterDate));
        }

        public override TransactionDto AddItem(TransactionDto dto)
        {
            var lastTransaction =
                Query.GetEntities()
                    .Where(z => z.AccountId == dto.AccountId && z.RegisterDate <= dto.RegisterDate)
                    .OrderByDescending(z => z.RegisterDate)
                    .ThenByDescending(z=>z.Id)
                    .FirstOrDefault();
            var account = _accountQuery.GetEntity(dto.AccountId);
            var balance = lastTransaction?.Balance ?? account.InitialBalance;
            var entity = Mapper.Map<TransactionEntity>(dto);
            balance += entity.Amount;
            entity.Balance = balance;

            using (var dbContextTransaction = Query.GetDbContext().Database.BeginTransaction())
            {
                try
                {
                    entity = Query.InsertEntity(entity);

                    var latestTransactions =
                        Query.GetEntities()
                            .Where(z => z.AccountId == dto.AccountId && z.RegisterDate > entity.RegisterDate)
                            .OrderBy(z => z.RegisterDate)
                            .ThenBy(z=>z.Id)
                            .ToList();
                    foreach (var transaction in latestTransactions)
                    {
                        balance += transaction.Amount;
                        transaction.Balance = balance;
                        Query.UpdateEntity(transaction);
                    }
                    account.CurrentBalance = balance;
                    _accountQuery.UpdateEntity(account);
                    dbContextTransaction.Commit();
                    return Mapper.Map<TransactionDto>(entity);
                }
                catch (Exception e)
                {
                    dbContextTransaction.Rollback();
                    Debug.WriteLine(e);
                    Log.Error(e);
                    throw;
                }
            }
        }

        public override TransactionDto ChangeItem(TransactionDto dto)
        {
            var entity = Query.GetEntity(dto.Id);
            if (entity == null) return null;
            // if not need recalc balances
            if (entity.AccountId == dto.AccountId && entity.RegisterDate == dto.RegisterDate &&
                entity.Amount == dto.Amount)
            {
                entity = Mapper.Map<TransactionEntity>(dto);
                entity = Query.UpdateEntity(entity);
                return Mapper.Map<TransactionDto>(entity);
            }
            var recalcMoment = new DateTime(Math.Min(entity.RegisterDate.Ticks, dto.RegisterDate.Ticks));

            var lastTransaction =
                Query.GetEntities()
                    .Where(z => z.AccountId == dto.AccountId && z.RegisterDate < recalcMoment)
                    .OrderByDescending(z => z.RegisterDate)
                    .ThenByDescending(z => z.Id)
                    .FirstOrDefault();
            var account = _accountQuery.GetEntity(dto.AccountId);
            var balance = lastTransaction?.Balance ?? account.InitialBalance;
            entity = Mapper.Map<TransactionEntity>(dto);
            //balance += entity.Amount;
            //entity.Balance = balance;

            using (var dbContextTransaction = Query.GetDbContext().Database.BeginTransaction())
            {
                try
                {
                    entity = Query.UpdateEntity(entity);

                    var latestTransactions =
                        Query.GetEntities()
                            .Where(z => z.AccountId == dto.AccountId && z.RegisterDate >= recalcMoment)
                            .OrderBy(z => z.RegisterDate)
                            .ThenBy(z => z.Id)
                            .ToList();
                    foreach (var transaction in latestTransactions)
                    {
                        balance += transaction.Amount;
                        transaction.Balance = balance;
                        Query.UpdateEntity(transaction);
                    }
                    account.CurrentBalance = balance;
                    _accountQuery.UpdateEntity(account);
                    dbContextTransaction.Commit();
                    return Mapper.Map<TransactionDto>(entity);
                }
                catch (Exception e)
                {
                    dbContextTransaction.Rollback();
                    Debug.WriteLine(e);
                    Log.Error(e);
                    throw;
                }
            }
        }

        public override bool RemoveItem(Guid id)
        {
            var entity = Query.GetEntity(id);
            if (entity == null) return false;
            //var startDate = entity.RegisterDate.Date;
            var lastTransaction =
                Query.GetEntities()
                    .Where(z => z.AccountId == entity.AccountId && z.RegisterDate < entity.RegisterDate)
                    .OrderByDescending(z => z.RegisterDate)
                    .ThenByDescending(z => z.Id)
                    .FirstOrDefault();
            var account = _accountQuery.GetEntity(entity.AccountId);
            var balance = lastTransaction?.Balance ?? account.InitialBalance;
            using (var dbContextTransaction = Query.GetDbContext().Database.BeginTransaction())
            {
                try
                {
                    var result = Query.DeleteEntity(entity.Id);
                    if (!result)
                    {
                        dbContextTransaction.Rollback();
                        return false;
                    }

                    var latestTransactions =
                        Query.GetEntities()
                            .Where(z => z.AccountId == entity.AccountId && z.RegisterDate >= entity.RegisterDate)
                            .OrderBy(z => z.RegisterDate)
                            .ThenBy(z => z.Id)
                            .ToList();
                    foreach (var transaction in latestTransactions)
                    {
                        balance += transaction.Amount;
                        transaction.Balance = balance;
                        Query.UpdateEntity(transaction);
                    }
                    account.CurrentBalance = balance;
                    _accountQuery.UpdateEntity(account);
                    dbContextTransaction.Commit();
                    return true;
                }
                catch (Exception e)
                {
                    dbContextTransaction.Rollback();
                    Debug.WriteLine(e);
                    Log.Error(e);
                    throw;
                }
            }
        }
    }
}