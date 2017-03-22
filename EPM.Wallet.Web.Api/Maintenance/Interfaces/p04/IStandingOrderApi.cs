using System;
using System.Collections.Generic;
using WalletWebApi.Model;

namespace WalletWebApi.Maintenance
{
    public interface IStandingOrderApi : ITypedApi<StandingOrderDto, Guid> {
        IEnumerable<StandingOrderInfoDto> GetStandingOrdersByClient(string clientId);
        StandingOrderInfoDto PostStandingOrderByClient(string clientId, StandingOrderDto dto);
        StandingOrderInfoDto PutStandingOrderByClient(string clientId, StandingOrderDto dto);
        bool DeleteStandingOrderByClient(string clientId, Guid id);
    }
}