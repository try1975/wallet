﻿using System;
using EPM.Wallet.Data.Entities;
using EPM.Wallet.Data.QueryProcessors;

namespace EPM.Wallet.Data.SqlServer.QueryProcessors
{
    public class CardRequestQuery : TypedQuery<CardRequestEntity, Guid>, ICardRequestQuery {
        public CardRequestQuery(WalletContext db) : base(db)
        {
        }
    }
}