using System;
using EPM.Wallet.Data.Entities;
using EPM.Wallet.Data.QueryProcessors;

namespace EPM.Wallet.Data.SqlServer.QueryProcessors
{
    public class AccountQuery : TypedQuery<ClientAccountEntity, Guid>, IAccountQuery
    {
        public AccountQuery(WalletContext db) : base(db)
        {
        }
    }
}