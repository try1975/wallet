using System;
using EPM.Wallet.Internal.Model;
using EPM.Wallet.Internall.Api.Maintenance;

namespace EPM.Wallet.Internall.Api.Controllers
{
    public class BanksController :  TypedController<BankDto, Guid>
    {
        public BanksController(IBankApi api) : base(api)
        {
        }
    }
}
