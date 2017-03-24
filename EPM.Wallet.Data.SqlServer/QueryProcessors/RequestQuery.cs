using System;
using EPM.Wallet.Data.Entities;
using EPM.Wallet.Data.QueryProcessors;

namespace EPM.Wallet.Data.SqlServer.QueryProcessors
{
    public class RequestQuery : TypedQuery<RequestEntity, Guid>, IRequestQuery {
        public RequestQuery(WalletContext db) : base(db)
        {
        }
    }
}