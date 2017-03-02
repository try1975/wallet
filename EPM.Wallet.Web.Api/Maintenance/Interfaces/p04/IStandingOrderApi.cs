using System;
using System.Collections.Generic;
using WalletWebApi.Model;

namespace WalletWebApi.Maintenance
{
    public interface IStandingOrderApi : ITypedApi<StandingOrderDto, Guid> {
        IEnumerable<StandingOrderDto> GetStandingOrdersByClient(string clientId);
    }
}