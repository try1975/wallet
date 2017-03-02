using System;
using EPM.Wallet.Common.Model;
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
