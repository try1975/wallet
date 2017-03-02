using System;
using System.Collections.Generic;
using EPM.Wallet.Common.Model;

namespace WalletWebApi.Maintenance
{
    public interface IStandingOrderApi : ITypedApi<StandingOrderDto, Guid> {
        IEnumerable<StandingOrderDto> GetStandingOrdersByClient(string clientId);
    }
}