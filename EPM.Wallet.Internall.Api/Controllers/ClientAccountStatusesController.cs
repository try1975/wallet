using EPM.Wallet.Internal.Model;
using WalletInternalApi.Maintenance;

namespace WalletInternalApi.Controllers
{
    public class ClientAccountStatusesController : TypedController<ClientAccountStatusDto, string>
    {
        public ClientAccountStatusesController(IClientAccountStatusApi api) : base(api)
        {
        }
    }
}
