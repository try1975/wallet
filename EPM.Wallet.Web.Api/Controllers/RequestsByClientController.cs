using System.Collections.Generic;
using System.Linq;
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
        private readonly IAccountRequestApi _accountRequestApi;

        public RequestsByClientController(IAccountRequestApi accountRequestApi)
        {
            _accountRequestApi = accountRequestApi;
        }

        [HttpGet]
        [Route("", Name = nameof(GetRequestsByClient)+  Ro.Route)]
        public IEnumerable<AccountRequestDto> GetRequestsByClient(string clientId, int from = 0, int count = 0)
        {
            var list = _accountRequestApi.RequestsByClient(clientId, from, count);
            var dtos = list as AccountRequestDto[] ?? list.ToArray();
            return dtos;
        }

        [HttpGet]
        [Route("TransferOuts/", Name = nameof(GetTransferOutRequestsByClient) + Ro.Route)]
        public IEnumerable<AccountRequestTransferOutDto> GetTransferOutRequestsByClient(string clientId, int from = 0, int count = 0)
        {
            return _accountRequestApi.GetTransferOutRequestsByClient(clientId, from, count);
        }
    }
}
