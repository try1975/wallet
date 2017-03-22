using System;
using EPM.Wallet.Data.Entities;
using EPM.Wallet.Data.QueryProcessors;

namespace EPM.Wallet.Data.SqlServer.QueryProcessors
{
    public class TransactionQuery : TypedQuery<TransactionEntity, Guid>, ITransactionQuery
    {
        public TransactionQuery(WalletContext db) : base(db)
        {
        }

    }
}