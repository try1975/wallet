using System;
using EPM.Wallet.Common;
using EPM.Wallet.Internal.Model;
using EPM.Wallet.WinForms.Interfaces;

namespace EPM.Wallet.WinForms.Data
{
    public class DirectDebitDataManager : TypedDataMаnager<DirectDebitDto, Guid>, IDirectDebitDataManager
    {
        public DirectDebitDataManager() : base(WalletConstants.ClientAppApi.DirectDebits)
        {
        }
    }
}