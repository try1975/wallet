﻿using System;
using EPM.Wallet.Data.Entities;

namespace EPM.Wallet.Data.QueryProcessors
{
    public interface ITransactionQuery: ITypedQuery<TransactionEntity, Guid> { }
}