using System;
using System.Collections.Generic;
using EPM.Wallet.Common.Model;

namespace WalletWebApi.Maintenance
{
    public interface IBankAccountApi : ITypedApi<BankAccountDto, Guid>
    {
        IEnumerable<BankAccountDto> GetBankAccountsByBankId(Guid bankId);
        IEnumerable<BankAccountDto> GetBankAccountsByBankName(string bankName);
    }
}