using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Description;
using EPM.Wallet.Common;
using EPM.Wallet.Common.Model;
using WalletWebApi.Maintenance;

namespace WalletWebApi.Controllers
{
    [Authorize]
    public class CommonController : ApiController
    {
        private readonly ICurrencyApi _currencyApi;
        private readonly IClientApi _clientApi;

        public CommonController(ICurrencyApi currencyApi, IClientApi clientApi)
        {
            _currencyApi = currencyApi;
            _clientApi = clientApi;
        }

        [HttpGet]
        [Route(WalletConstants.ClientAppApi.Currencies, Name = nameof(GetCurrencies) + Ro.Route)]
        public IEnumerable<CurrencyDto> GetCurrencies()
        {
            return _currencyApi.GetItems();
        }

        [HttpGet]
        [ResponseType(typeof(ClientDto))]
        [Route(WalletConstants.ClientAppApi.Clients + "/{id}", Name = nameof(GetClient) + Ro.Route)]
        public IHttpActionResult GetClient(string id)
        {
            return Ok(_clientApi.GetItem(id));
        }
    }
}
