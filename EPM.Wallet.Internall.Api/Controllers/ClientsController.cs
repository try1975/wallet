using EPM.Wallet.Common.Model;
using EPM.Wallet.Internall.Api.Maintenance;

namespace EPM.Wallet.Internall.Api.Controllers
{
    public class ClientsController : TypedController<ClientDto, string>
    {
        public ClientsController(IClientApi api) : base(api)
        {
        }
    }
}
