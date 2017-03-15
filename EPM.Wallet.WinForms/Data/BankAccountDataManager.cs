using System;
using EPM.Wallet.Common;
using EPM.Wallet.Internal.Model;
using EPM.Wallet.WinForms.Interfaces;

namespace EPM.Wallet.WinForms.Data
{
    public class BankAccountDataManager : TypedDataMаnager<BankAccountDto, Guid>, IBankAccountDataManager
    {
        public BankAccountDataManager() : base(WalletConstants.ClientAppApi.BankAccounts)
        {
        }
    }
}