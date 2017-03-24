using System;
using System.Collections.Generic;
using EPM.Wallet.Internal.Model;

namespace EPM.Wallet.WinForms.Interfaces
{
    public interface ITransactionView : ITypedView<TransactionDto, Guid>
    {
        #region DetailsList

        List<KeyValuePair<Guid, string>> AccountList { set; }
        List<KeyValuePair<string, string>> CurrencyList { set; }

        #endregion DetailsList

        #region Details

        Guid AccountId { get; set; }


        DateTimeOffset RegisterDate { get; set; }
        DateTimeOffset ValueDate { get; set; }
        decimal Amount { get; set; }
        string CurrencyId { get; set; }
        decimal AmountInCurrency { get; set; }
        decimal Balance { get; set; }

        string FromTo { get; set; }
        string Note { get; set; }

        Guid? RequestId { get; set; }

        Guid? StandingOrderId { get; set; }

        #endregion //Details
    }
}