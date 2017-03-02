using System;
using System.Collections.Generic;
using EPM.Wallet.Common.Model;

namespace WalletWebApi.Maintenance
{
    public interface IRequestApi : ITypedApi<RequestDto, Guid>
    {
        IEnumerable<RequestDto> RequestsByClient(string clientId);
    }
}