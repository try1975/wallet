using EPM.Wallet.Internal.Model;
using EPM.Wallet.Internall.Api.Maintenance;

namespace EPM.Wallet.Internall.Api.Controllers
{
    public class CurrenciesController : TypedController<CurrencyDto, string>
    {
        public CurrenciesController(ICurrencyApi api) : base(api)
        {
        }
    }
}
