using System;
using System.Collections.Generic;
using WalletWebApi.Model;

namespace WalletWebApi.Maintenance
{
    public interface IRequestApi : ITypedApi<RequestDto, Guid>
    {
        IEnumerable<RequestDto> RequestsByClient(string clientId);
    }
}