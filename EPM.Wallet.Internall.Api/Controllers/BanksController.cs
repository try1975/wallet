using System;
using EPM.Wallet.Internal.Model;
using WalletInternalApi.Maintenance;

namespace WalletInternalApi.Controllers
{
    public class BanksController :  TypedController<BankDto, Guid>
    {
        public BanksController(IBankApi api) : base(api)
        {
        }
    }
}
