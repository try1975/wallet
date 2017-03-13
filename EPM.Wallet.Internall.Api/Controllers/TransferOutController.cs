using System;
using EPM.Wallet.Internal.Model;
using WalletInternalApi.Maintenance;

namespace WalletInternalApi.Controllers
{
    public class TransferOutController : TypedController<TransferOutInfoDto, Guid>
    {
        public TransferOutController(ITransferOutApi api) : base(api)
        {
        }
    }
}
