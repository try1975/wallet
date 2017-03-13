using System;
using EPM.Wallet.Internal.Model;
using WalletInternalApi.Maintenance;

namespace WalletInternalApi.Controllers
{
    public class AccountsController : TypedController<AccountDto, Guid>
    {
        public AccountsController(IAccountApi api) : base(api)
        {
        }
    }
}

