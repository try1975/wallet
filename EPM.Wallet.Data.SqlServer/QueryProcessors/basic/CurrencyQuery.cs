using EPM.Wallet.Data.Entities;
using EPM.Wallet.Data.QueryProcessors;

namespace EPM.Wallet.Data.SqlServer.QueryProcessors
{
    public class CurrencyQuery : TypedQuery<CurrencyEntity, string>, ICurrencyQuery {
        public CurrencyQuery(WalletContext db) : base(db)
        {
        }
    }
}