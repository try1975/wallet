using System;
using WalletWebApi.Model;

namespace WalletWebApi.Maintenance
{
    public interface IBankApi : ITypedApi<BankDto, Guid> { }
}