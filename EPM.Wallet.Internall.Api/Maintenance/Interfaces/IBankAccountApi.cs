﻿using System;
using System.Collections.Generic;
using EPM.Wallet.Internal.Model;

namespace WalletInternalApi.Maintenance
{
    public interface IBankAccountApi : ITypedApi<BankAccountDto, Guid>
    {
        IEnumerable<BankAccountDto> GetBankAccountsByBankId(Guid bankId);
        IEnumerable<BankAccountDto> GetBankAccountsByBankName(string bankName);
    }
}