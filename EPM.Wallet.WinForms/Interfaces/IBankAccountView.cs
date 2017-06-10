using System;
using System.Collections.Generic;
using EPM.Wallet.Internal.Model;

namespace EPM.Wallet.WinForms.Interfaces
{
    public interface IBankAccountView : ITypedView<BankAccountDto, Guid>
    {
        #region Details

        string BankAccountName { get; set; }
        Guid BankId { get; set; }
        string CurrencyId { get; set; }
        string BeneficiaryAddress { get; set; }

        #endregion

        #region DetailsLists

        List<KeyValuePair<Guid, string>> BankList { set; }
        List<KeyValuePair<string, string>> CurrencyList { set; }

        #endregion
    }
}