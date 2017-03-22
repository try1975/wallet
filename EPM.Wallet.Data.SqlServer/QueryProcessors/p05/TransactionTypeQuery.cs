using EPM.Wallet.Data.Entities;
using EPM.Wallet.Data.QueryProcessors;

namespace EPM.Wallet.Data.SqlServer.QueryProcessors
{
    public class TransactionTypeQuery : TypedQuery<TransactionTypeEntity, string>, ITransactionTypeQuery
    {
        public TransactionTypeQuery(WalletContext db) : base(db)
        {
        }
    }
}
