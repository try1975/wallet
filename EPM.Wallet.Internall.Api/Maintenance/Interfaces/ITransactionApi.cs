using System;
using EPM.Wallet.Internal.Model;

namespace WalletInternalApi.Maintenance
{
    public interface ITransactionApi : ITypedApi<TransactionDto, Guid>
    {
    }
}