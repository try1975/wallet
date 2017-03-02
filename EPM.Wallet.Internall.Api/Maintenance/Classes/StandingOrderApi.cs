using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using EPM.Wallet.Data.Entities;
using EPM.Wallet.Data.QueryProcessors;
using EPM.Wallet.Internal.Model;

namespace EPM.Wallet.Internall.Api.Maintenance
{

    public class StandingOrderApi : TypedApi<StandingOrderDto, StandingOrderEntity, Guid>, IStandingOrderApi
    {
        public StandingOrderApi(IStandingOrderQuery query) : base(query)
        {
        }

        public IEnumerable<StandingOrderDto> GetStandingOrdersByClient(string clientId)
        {
            var list = Query.GetEntities()
                .Where(m => m.ClientAccount.ClientId == clientId)
                .OrderByDescending(i => i.CreatedAt)
                .ToList()
                ;
            return Mapper.Map<List<StandingOrderDto>>(list);
        }
    }
}