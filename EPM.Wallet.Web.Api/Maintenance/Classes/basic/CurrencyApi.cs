using EPM.Wallet.Data.Entities;
using EPM.Wallet.Data.QueryProcessors;
using WalletWebApi.Model;

namespace WalletWebApi.Maintenance
{
    public class CurrencyApi : TypedApi<CurrencyDto, CurrencyEntity, string>, ICurrencyApi
    {
        public CurrencyApi(ICurrencyQuery query) : base(query)
        {
        }
    }
}