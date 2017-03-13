using System;
using EPM.Wallet.Internal.Model;

namespace WalletInternalApi.Maintenance
{
    public interface ITransferOutApi : ITypedApi<TransferOutInfoDto, Guid>
    {
        
    }
}