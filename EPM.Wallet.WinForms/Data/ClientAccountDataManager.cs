using System;
using EPM.Wallet.Common;
using EPM.Wallet.Common.Model;
using EPM.Wallet.WinForms.Interfaces;

namespace EPM.Wallet.WinForms.Data
{
    public class ClientAccountDataManager : TypedDataMаnager<AccountDto, Guid>, IClientAccountDataManager
    {
        public ClientAccountDataManager() : base(WalletConstants.ClientAppApi.Accounts)
        {
        }
    }
}