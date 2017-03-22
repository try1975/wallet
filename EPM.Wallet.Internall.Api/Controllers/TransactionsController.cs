using System;
using EPM.Wallet.Internal.Model;
using WalletInternalApi.Maintenance;

namespace WalletInternalApi.Controllers
{
    public class TransactionsController : TypedController<TransactionDto, Guid>
    {
        public TransactionsController(ITransactionApi api) : base(api)
        {
        }
    }
}
