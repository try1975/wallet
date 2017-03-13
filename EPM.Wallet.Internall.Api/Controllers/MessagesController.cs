using System;
using EPM.Wallet.Internal.Model;
using WalletInternalApi.Maintenance;

namespace WalletInternalApi.Controllers
{
    public class MessagesController : TypedController<MessageDto, Guid>
    {
        public MessagesController(IMessageApi api) : base(api)
        {
        }
    }
}
