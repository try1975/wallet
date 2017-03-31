using System;
using System.Collections.Generic;
using WalletWebApi.Model;

namespace WalletWebApi.Maintenance
{
    public interface IDirectDebitApi : ITypedApi<DirectDebitDto, Guid>
    {
        IEnumerable<DirectDebitDto> GetDirectDebitsByClient(string clientId);
        DirectDebitDto PostDirectDebitByClient(string clientId, DirectDebitDto dto);
        bool DeleteDirectDebitByClient(string clientId, Guid id);
    }
}