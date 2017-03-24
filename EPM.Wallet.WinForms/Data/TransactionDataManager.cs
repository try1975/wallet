using System;
using EPM.Wallet.Common;
using EPM.Wallet.Internal.Model;
using EPM.Wallet.WinForms.Interfaces;

namespace EPM.Wallet.WinForms.Data
{
    public class TransactionDataManager : TypedDataMаnager<TransactionDto, Guid>, ITransactionDataManager
    {
        public TransactionDataManager() : base(WalletConstants.ClientAppApi.Transactions)
        {
        }
    }
}