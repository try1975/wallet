using System;
using EPM.Wallet.Data.Entities;
using EPM.Wallet.Data.QueryProcessors;

namespace EPM.Wallet.Data.SqlServer.QueryProcessors
{
    public class CardBlockRequestQuery : TypedQuery<CardBlockRequestEntity, Guid>, ICardBlockRequestQuery {
        public CardBlockRequestQuery(WalletContext db) : base(db)
        {
        }
    }
}