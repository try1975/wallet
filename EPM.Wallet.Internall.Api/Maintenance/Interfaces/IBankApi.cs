using System;
using EPM.Wallet.Internal.Model;

namespace WalletInternalApi.Maintenance
{
    public interface IBankApi : ITypedApi<BankDto, Guid> { }
}