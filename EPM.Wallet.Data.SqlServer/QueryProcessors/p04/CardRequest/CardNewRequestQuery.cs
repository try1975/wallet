using System;
using EPM.Wallet.Data.Entities;
using EPM.Wallet.Data.QueryProcessors;

namespace EPM.Wallet.Data.SqlServer.QueryProcessors
{
    public class CardNewRequestQuery : TypedQuery<CardNewRequestEntity, Guid>, ICardNewRequestQuery {
        public CardNewRequestQuery(WalletContext db) : base(db)
        {
        }
    }
}