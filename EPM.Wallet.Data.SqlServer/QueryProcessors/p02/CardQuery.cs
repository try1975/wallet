using System;
using EPM.Wallet.Data.Entities;
using EPM.Wallet.Data.QueryProcessors;

namespace EPM.Wallet.Data.SqlServer.QueryProcessors
{
    public class CardQuery : TypedQuery<CardEntity, Guid>, ICardQuery {
        public CardQuery(WalletContext db) : base(db)
        {
        }
    }
}