using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using EPM.Wallet.Data.Entities;
using EPM.Wallet.Data.QueryProcessors;
using EPM.Wallet.Internal.Model;

namespace WalletInternalApi.Maintenance
{
    public class CurrencyApi : TypedApi<CurrencyDto, CurrencyEntity, string>, ICurrencyApi
    {
        public CurrencyApi(ICurrencyQuery query) : base(query)
        {
        }

        public override IEnumerable<CurrencyDto> GetItems()
        {
            var list = Query.GetEntities().OrderBy(cur => cur.SortOrder).ThenBy(cur => cur.Id);
            return Mapper.Map<List<CurrencyDto>>(list);
        }
    }
}