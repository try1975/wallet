using System;
using EPM.Wallet.Internal.Model;
using WalletInternalApi.Maintenance;

namespace WalletInternalApi.Controllers
{
    public class BankAccountsController : TypedController<BankAccountDto, Guid>
    {
        public BankAccountsController(IBankAccountApi api) : base(api)
        {
        }
    }
}
