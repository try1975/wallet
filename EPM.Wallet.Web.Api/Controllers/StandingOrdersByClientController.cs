using System.Collections.Generic;
using System.Web.Http;
using EPM.Wallet.Common;
using WalletWebApi.Maintenance;
using WalletWebApi.Model;

namespace WalletWebApi.Controllers
{
    [RoutePrefix(prefix: WalletConstants.ClientAppApi.StandingOrdersByClient)]
    [Authorize]
    public class StandingOrdersByClientController : ApiController
    {
        private readonly IStandingOrderApi _standingOrderApi;

        public StandingOrdersByClientController(IStandingOrderApi standingOrderApi)
        {
            _standingOrderApi = standingOrderApi;
        }

        [HttpGet]
        [Route("", Name = nameof(GetStandingOrdersByClient) + Ro.Route)]
        public IEnumerable<StandingOrderDto> GetStandingOrdersByClient(string clientId)
        {
            return _standingOrderApi.GetStandingOrdersByClient(clientId);
        }
    }
}
