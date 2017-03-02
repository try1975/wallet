using System;
using EPM.Wallet.Common;
using EPM.Wallet.Internal.Model;
using EPM.Wallet.WinForms.Interfaces;

namespace EPM.Wallet.WinForms.Data
{
    public class BankDataM�nager : TypedDataM�nager<BankDto, Guid>, IBankDataM�nager
    {
        public BankDataM�nager() : base(WalletConstants.ClientAppApi.Banks)
        {

        }
    }
}