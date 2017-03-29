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
    public class StatementApi : TypedApi<StatementDto, StatementEntity, Guid>, IStatementApi
    {
        private readonly IAccountQuery _accountQuery;

        public StatementApi(IStatementQuery query, IAccountQuery accountQuery) : base(query)
        {
            _accountQuery = accountQuery;
        }

        public override IEnumerable<StatementDto> GetItems()
        {
            return Query.GetEntities().Select(z => new StatementDto()
            {
                Id = z.Id,
                AccountId = z.AccountId,
                CardId = z.CardId,
                ValueDate = z.ValueDate,
                Period = z.Period,
                PreviousBalance = z.PreviousBalance,
                Credits = z.Credits,
                Debits = z.Debits,
                NewBalance = z.NewBalance,
                LoadedFrom = z.LoadedFrom
            }).ToList();
        }

        public IEnumerable<StatementDto> GetStatementsByClient(string clientId)
        {
            throw new NotImplementedException();
        }

        public bool WriteAccountStatementData(AccountStatementDataDto dto)
        {
            var accountEntity = _accountQuery.GetEntities().FirstOrDefault(e => e.Name == dto.AccountName);
            if (accountEntity == null) return false;
            try
            {
                var entity = Mapper.Map<StatementEntity>(dto);
                //entity.ClientId = accountEntity.ClientId;
                entity.AccountId = accountEntity.Id;
                Query.InsertEntity(entity);
                accountEntity.StatementId = entity.Id;
                _accountQuery.UpdateEntity(accountEntity);
                return true;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
                throw;
            }

        }
    }
}