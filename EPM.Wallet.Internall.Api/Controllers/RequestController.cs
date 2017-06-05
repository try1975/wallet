using System;
using EPM.Wallet.Internal.Model;
using WalletInternalApi.Maintenance;

namespace WalletInternalApi.Controllers
{
    public class RequestsController : TypedController<RequestInfoDto, Guid>
    {
        public RequestsController(IRequestApi api) : base(api)
        {
        }
    }
}
