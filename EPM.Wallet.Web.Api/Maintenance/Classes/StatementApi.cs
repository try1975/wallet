using System;
using EPM.Wallet.Data.Entities;
using EPM.Wallet.Data.QueryProcessors;
using WalletWebApi.Model;

namespace WalletWebApi.Maintenance
{
    public class StatementApi : TypedApi<StatementDto, StatementEntity, Guid>, IStatementApi
    {
        public StatementApi(IStatementQuery query) : base(query)
        {
        }
    }
}