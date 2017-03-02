using System.Collections.Generic;
using System.Web.Http;
using EPM.Wallet.Common;
using WalletWebApi.Maintenance;
using WalletWebApi.Model;

namespace WalletWebApi.Controllers
{
    [RoutePrefix(WalletConstants.ClientAppApi.RequisitesByClient)]
    [Authorize]
    public class RequisitesByClientController : ApiController
    {
        private readonly IRequisiteApi _requisiteApi;

        public RequisitesByClientController(IRequisiteApi requisiteApi)
        {
            _requisiteApi = requisiteApi;
        }   

        [HttpGet]
        [Route("", Name = nameof(GetRequisitesByClient) + Ro.Route)]
        public IEnumerable<RequisiteDto> GetRequisitesByClient(string clientId)
        {
            return _requisiteApi.GetRequisitesByClient(clientId);
        }
    }
}
