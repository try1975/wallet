using System;
using System.Collections.Generic;
using EPM.Wallet.Common.Model;

namespace EPM.Wallet.Internall.Api.Maintenance
{
    public interface IBankAccountApi : ITypedApi<BankAccountDto, Guid>
    {
        IEnumerable<BankAccountDto> GetBankAccountsByBankId(Guid bankId);
        IEnumerable<BankAccountDto> GetBankAccountsByBankName(string bankName);
    }
}