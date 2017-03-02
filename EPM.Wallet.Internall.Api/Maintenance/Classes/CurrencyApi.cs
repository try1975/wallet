using EPM.Wallet.Data.Entities;
using EPM.Wallet.Data.QueryProcessors;
using EPM.Wallet.Internal.Model;

namespace EPM.Wallet.Internall.Api.Maintenance
{
    public class CurrencyApi : TypedApi<CurrencyDto, CurrencyEntity, string>, ICurrencyApi
    {
        public CurrencyApi(ICurrencyQuery query) : base(query)
        {
        }
    }
}