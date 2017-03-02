using System.Collections.Generic;
using System.Web.Http;
using EPM.Wallet.Common;
using WalletWebApi.Maintenance;
using WalletWebApi.Model;

namespace WalletWebApi.Controllers
{
    [RoutePrefix(WalletConstants.ClientAppApi.RequestsByClient)]
    [Authorize]
    public class RequestsByClientController : ApiController
    {
        private readonly IAccountRequestApi _api;

        public RequestsByClientController(IAccountRequestApi api)
        {
            _api = api;
        }

        [HttpGet]
        [Route("", Name = nameof(GetRequestsByClient)+  Ro.Route)]
        public IEnumerable<AccountRequestDto> GetRequestsByClient(string clientId)
        {
            return _api.RequestsByClient(clientId);
        }
    }
}
