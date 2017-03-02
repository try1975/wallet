using System;
using EPM.Wallet.Common;
using EPM.Wallet.Internal.Model;
using EPM.Wallet.WinForms.Interfaces;

namespace EPM.Wallet.WinForms.Data
{
    public class BankDataMànager : TypedDataMànager<BankDto, Guid>, IBankDataMànager
    {
        public BankDataMànager() : base(WalletConstants.ClientAppApi.Banks)
        {

        }
    }
}