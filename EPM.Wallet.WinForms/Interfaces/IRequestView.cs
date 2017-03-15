using System;
using System.Collections.Generic;
using EPM.Wallet.Internal.Model;

namespace EPM.Wallet.WinForms.Interfaces
{
    public interface IRequestView : ITypedView<RequestDto, Guid>
    {
        #region Details

        string ClientId { get; set; }
        string CurrencyId { get; set; }

        string Type { get; set; }
        string SubType { get; set; }
        string Status { get; set; }

        #endregion // Details

        #region DetailsLists

        List<KeyValuePair<string, string>> ClientList { set; }
        List<KeyValuePair<string, string>> CurrencyList { set; }

        #endregion //DetailsLists
    }
}