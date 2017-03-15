using System;
using System.Collections.Generic;
using EPM.Wallet.Internal.Model;

namespace EPM.Wallet.WinForms.Interfaces
{
    public interface ICardView : ITypedView<CardDto, Guid>
    {
        #region Details

        string ClientId { get; set; }
        string CurrencyId { get; set; }
        string CardNumber { get; set; }
        string CardHolder { get; set; }
        int ExpMonth { get; set; }
        int ExpYear { get; set; }
        decimal Limit { get; set; }
        string Vendor { get; set; }

        #endregion // Details

        #region DetailsLists

        List<KeyValuePair<string, string>> ClientList { set; }
        List<KeyValuePair<string, string>> CurrencyList { set; }

        #endregion //DetailsLists
    }
}