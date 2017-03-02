using System;
using EPM.Wallet.Internal.Model;
using EPM.Wallet.Internall.Api.Maintenance;

namespace EPM.Wallet.Internall.Api.Controllers
{
    public class BankAccountsController : TypedController<BankAccountDto, Guid>
    {
        public BankAccountsController(IBankAccountApi api) : base(api)
        {
        }
    }
}
