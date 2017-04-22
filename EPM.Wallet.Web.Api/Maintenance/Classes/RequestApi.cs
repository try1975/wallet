using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using AutoMapper;
using EPM.Wallet.Common.Enums;
using EPM.Wallet.Data.Entities;
using EPM.Wallet.Data.QueryProcessors;
using WalletWebApi.Model;

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
            //foreach (var requestEntity in list)
            //{
            //    if
            //}
            return Mapper.Map<List<RequestDto>>(list);
        }
    }
}