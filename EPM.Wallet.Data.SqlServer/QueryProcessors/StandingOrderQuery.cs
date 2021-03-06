﻿using System;
using EPM.Wallet.Data.Entities;
using EPM.Wallet.Data.QueryProcessors;

namespace EPM.Wallet.Data.SqlServer.QueryProcessors
{
    public class StandingOrderQuery : TypedQuery<StandingOrderEntity, Guid>, IStandingOrderQuery {
        public StandingOrderQuery(WalletContext db) : base(db)
        {
        }
    }
}