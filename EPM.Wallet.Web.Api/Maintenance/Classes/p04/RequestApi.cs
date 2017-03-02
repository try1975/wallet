using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using EPM.Wallet.Common.Enums;
using EPM.Wallet.Common.Model;
using EPM.Wallet.Data.Entities;
using EPM.Wallet.Data.QueryProcessors;

namespace WalletWebApi.Maintenance
{

    public class RequestApi : TypedApi<RequestDto, RequestEntity, Guid>, IRequestApi
    {
        public RequestApi(IRequestQuery query) : base(query)
        {
        }

        public IEnumerable<RequestDto> RequestsByClient(string clientId)
        {
            var list = _query.GetEntities()
                .Where(m => m.ClientId == clientId && m.RequestType == RequestType.Payment)
                .OrderByDescending(i => i.CreatedAt)
                .ToList()
                ;
            return Mapper.Map<List<RequestDto>>(list);
        }
    }
}