using System;
using EPM.Wallet.Data.Entities;
using EPM.Wallet.Data.QueryProcessors;

namespace EPM.Wallet.Data.SqlServer.QueryProcessors
{
    public class StatementQuery : TypedQuery<StatementEntity, Guid>, IStatementQuery {
        public StatementQuery(WalletContext db) : base(db)
        {
        }
    }
}