﻿using System;
using System.Collections.Generic;
using EPM.Wallet.Internal.Model;

namespace WalletInternalApi.Maintenance
{
    public interface IStatementApi : ITypedApi<StatementDto, Guid>
    {
        IEnumerable<StatementDto> GetStatementsByClient(string clientId);
        bool WriteAccountStatementData(AccountStatementDataDto dto);
    }
}