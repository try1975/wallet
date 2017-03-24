using System;
using EPM.Wallet.Data.Entities;
using EPM.Wallet.Data.QueryProcessors;

namespace EPM.Wallet.Data.SqlServer.QueryProcessors
{
    public class MessageQuery : TypedQuery<MessageEntity, Guid>, IMessageQuery {
        public MessageQuery(WalletContext db) : base(db)
        {
        }
    }
}