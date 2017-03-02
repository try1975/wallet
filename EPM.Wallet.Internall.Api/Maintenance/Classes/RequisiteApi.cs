using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using EPM.Wallet.Data.Entities;
using EPM.Wallet.Data.QueryProcessors;
using EPM.Wallet.Internal.Model;

namespace WalletInternalApi.Maintenance
{

    public class RequisiteApi : TypedApi<RequisiteDto, RequisiteEntity, Guid>, IRequisiteApi
    {
        public RequisiteApi(IRequisiteQuery query) : base(query)
        {
        }
        public IEnumerable<RequisiteDto> GetRequisitesByClient(string clientId)
        {
            var list = Query.GetEntities()
                .Where(x => x.ClientId == clientId)
                .ToList()
                ;
            return Mapper.Map<List<RequisiteDto>>(list);
        }
    }
}