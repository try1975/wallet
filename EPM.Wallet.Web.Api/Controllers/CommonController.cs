using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Description;
using EPM.Wallet.Common;
using WalletWebApi.GetFiles;
using WalletWebApi.Maintenance;
using WalletWebApi.Model;

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
            var list = _currencyApi.GetItems();
            var dtos = list ?? new List<CurrencyDto>();
            return dtos;
        }

        [HttpGet]
        [ResponseType(typeof(ClientDto))]
        [Route(WalletConstants.ClientAppApi.Clients + "/{id}", Name = nameof(GetClient) + Ro.Route)]
        public IHttpActionResult GetClient(string id)
        {
            var item = _clientApi.GetItem(id);
            var baseUri = $"{Request.RequestUri.Scheme}://{Request.RequestUri.Host}:{Request.RequestUri.Port}";
            foreach (var account in item.ClientAccounts)
            {
                if (!account.StatementId.HasValue) continue;

                var uri = $"{baseUri}/GetFiles/{nameof(GetStatementFile)}.ashx?id={account.StatementId}";
                account.LastStatementLink = new Uri(uri);
            }
            return Ok(item);
        }
    }
}
