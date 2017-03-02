using System;
using System.Collections.Generic;
using EPM.Wallet.Common.Model;

namespace EPM.Wallet.Internall.Api.Maintenance
{
    public interface IStandingOrderApi : ITypedApi<StandingOrderDto, Guid> {
        IEnumerable<StandingOrderDto> GetStandingOrdersByClient(string clientId);
    }
}