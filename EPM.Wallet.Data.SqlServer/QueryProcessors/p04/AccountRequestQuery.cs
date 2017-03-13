using System;
using EPM.Wallet.Data.Entities;
using EPM.Wallet.Data.QueryProcessors;

namespace EPM.Wallet.Data.SqlServer.QueryProcessors
{
    public class AccountRequestQuery : TypedQuery<AccountRequestEntity, Guid>, IAccountRequestQuery {
        public AccountRequestQuery(WalletContext db) : base(db)
        {
        }
    }
}