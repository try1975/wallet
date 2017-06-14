using System;
using EPM.Wallet.Internal.Model;
using WalletInternalApi.Maintenance;

namespace WalletInternalApi.Controllers
{
    public class StandingOrdersController : TypedController<StandingOrderDto, Guid>
    {
        public StandingOrdersController(IStandingOrderApi api) : base(api)
        {
        }
    }
}
