using EPM.Wallet.Internal.Model;
using WalletInternalApi.Maintenance;

namespace WalletInternalApi.Controllers
{
    public class CurrenciesController : TypedController<CurrencyDto, string>
    {
        public CurrenciesController(ICurrencyApi api) : base(api)
        {
        }
    }
}
