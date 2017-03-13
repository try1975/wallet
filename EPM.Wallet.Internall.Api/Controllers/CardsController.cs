using System;
using EPM.Wallet.Internal.Model;
using WalletInternalApi.Maintenance;

namespace WalletInternalApi.Controllers
{
    public class CardsController : TypedController<CardDto, Guid>
    {
        public CardsController(ICardApi api) : base(api)
        {
        }
    }
}
