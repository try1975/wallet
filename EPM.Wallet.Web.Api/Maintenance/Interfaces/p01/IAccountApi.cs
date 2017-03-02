using System;
using System.Collections.Generic;
using EPM.Wallet.Common.Model;

namespace WalletWebApi.Maintenance
{
    public interface IAccountApi : ITypedApi<AccountDto, Guid>
    {
        IEnumerable<AccountDto> GetAccountsByClient(string clientId);
        AccountDto GetAccountByClient(string clientId, Guid accountId);
    }
}