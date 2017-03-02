using System.Collections.Generic;
using System.Web.Http;
using EPM.Wallet.Common;
using EPM.Wallet.Internal.Model;
using WalletInternalApi.Maintenance;

namespace WalletInternalApi.Controllers
{
    [RoutePrefix(WalletConstants.ClientAppApi.Clients)]
    [Authorize]
    public class ClientiController : ApiController
    {
        private readonly IClientApi _clientApi;
        public ClientiController(IClientApi clientApi)
        {
            _clientApi = clientApi;
        }

        [HttpGet]
        [Route("", Name = nameof(GetClients) + Ro.Route)]
        public IEnumerable<ClientDto> GetClients()
        {
            return  _clientApi.GetItems();
        }

    }
}
