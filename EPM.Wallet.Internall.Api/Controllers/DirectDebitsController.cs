using System;
using EPM.Wallet.Internal.Model;
using WalletInternalApi.Maintenance;

namespace WalletInternalApi.Controllers
{
    public class DirectDebitsController : TypedController<DirectDebitDto, Guid>
    {
        public DirectDebitsController(IDirectDebitApi api) : base(api)
        {
        }
    }
}
