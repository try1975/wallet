using System;
using System.Collections.Generic;
using EPM.Wallet.Internal.Model;

namespace EPM.Wallet.WinForms.Interfaces
{
    public interface IStatementView: ITypedView<StatementDto, Guid>
    {
        #region DetailsList

        List<KeyValuePair<Guid, string>> AccountList { set; }
        //List<KeyValuePair<Guid, string>> CardList { set; }

        #endregion DetailsList

        #region Details

        Guid AccountId { get; set; }
        DateTime ValueDate { get; set; }

        string Period { get; set; }

        decimal PreviousBalance { get; set; }

        decimal Credits { get; set; }

        decimal Debits { get; set; }

        decimal NewBalance { get; set; }

        byte[] Content { get; set; }
        string LoadedFrom { get; set; }

        Uri StatementLink { get; set; }

        #endregion //Details
    }
}