using System;
using System.Collections.Generic;
using EPM.Wallet.Internal.Model;

namespace WalletInternalApi.Maintenance
{
    public interface IRequestApi : ITypedApi<RequestInfoDto, Guid>
    {
        IEnumerable<RequestDto> RequestsByClient(string clientId);
    }
}