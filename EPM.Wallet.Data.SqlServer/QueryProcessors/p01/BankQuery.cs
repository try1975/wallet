using System;
using EPM.Wallet.Data.Entities;
using EPM.Wallet.Data.QueryProcessors;

namespace EPM.Wallet.Data.SqlServer.QueryProcessors
{
    public class BankQuery : TypedQuery<BankEntity, Guid>, IBankQuery {
        public BankQuery(WalletContext db) : base(db)
        {
        }
    }
}