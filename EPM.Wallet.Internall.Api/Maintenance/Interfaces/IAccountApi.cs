using System;
using System.Collections.Generic;
using EPM.Wallet.Internal.Model;

namespace WalletInternalApi.Maintenance
{
    public interface IAccountApi : ITypedApi<AccountDto, Guid>
    {
        IEnumerable<AccountDto> GetAccountsByClient(string clientId);
        AccountDto GetAccountByClient(string clientId, Guid accountId);

        bool WriteEpmAccountBalance(string code, decimal balance);
    }
}