using System;
using System.Collections.Generic;
using EPM.Wallet.Common.Enums;
using EPM.Wallet.Internal.Model;

namespace EPM.Wallet.WinForms.Interfaces
{
    public interface IClientAccountView : ITypedView<AccountDto, Guid>
    {
        #region Details

        string ClientAccountName { get; set; }
        string CurrencyId { get; set; }
        string ClientId { get; set; }
        Guid BankAccountId { get; set; }
        ClientAccountStatus ClientAccountStatus { get; set; }
        decimal CurrentBalance { get; set; }
        string Comment { get; set; }
        #endregion //Details

        #region DetailsLists

        List<KeyValuePair<string, string>> ClientList { set; }
        List<KeyValuePair<string, string>> CurrencyList { set; }
        List<KeyValuePair<Guid, string>> BankAccounList { set; }
        List<KeyValuePair<ClientAccountStatus, string>> ClientAccountStatusList { set; }

        #endregion
    }
}