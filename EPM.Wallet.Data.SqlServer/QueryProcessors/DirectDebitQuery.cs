using System;
using EPM.Wallet.Data.Entities;
using EPM.Wallet.Data.QueryProcessors;

namespace EPM.Wallet.Data.SqlServer.QueryProcessors
{
    public class DirectDebitQuery : TypedQuery<DirectDebitEntity, Guid>, IDirectDebitQuery
    {
        public DirectDebitQuery(WalletContext db) : base(db)
        {
        }
    }
}