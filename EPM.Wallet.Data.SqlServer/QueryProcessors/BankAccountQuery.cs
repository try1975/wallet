using System;
using EPM.Wallet.Data.Entities;
using EPM.Wallet.Data.QueryProcessors;

namespace EPM.Wallet.Data.SqlServer.QueryProcessors
{
    public class BankAccountQuery : TypedQuery<BankAccountEntity, Guid>, IBankAccountQuery {
        public BankAccountQuery(WalletContext db) : base(db)
        {
        }
    }
}