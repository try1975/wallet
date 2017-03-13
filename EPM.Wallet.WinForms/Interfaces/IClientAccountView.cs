using System;
using System.Collections.Generic;
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
        string ClientAccountStatusId { get; set; }
        decimal CurrentBalance { get; set; }

        #endregion //Details

        #region DetailsLists

        List<KeyValuePair<string, string>> ClientList { set; }
        List<KeyValuePair<string, string>> CurrencyList { set; }
        List<KeyValuePair<Guid, string>> BankAccounList { set; }
        List<KeyValuePair<string, string>> ClientAccountStatusList { set; }

        #endregion
    }
}