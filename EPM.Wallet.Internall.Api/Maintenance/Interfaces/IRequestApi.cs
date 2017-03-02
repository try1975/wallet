using System;
using System.Collections.Generic;
using EPM.Wallet.Internal.Model;

namespace EPM.Wallet.Internall.Api.Maintenance
{
    public interface IRequestApi : ITypedApi<RequestDto, Guid>
    {
        IEnumerable<RequestDto> RequestsByClient(string clientId);
    }
}