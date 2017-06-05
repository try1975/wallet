using System;
using System.Collections.Generic;
using EPM.Wallet.Common.Enums;
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
        CardStatus CardStatus { get; set; }
        int ExpMonth { get; set; }
        int ExpYear { get; set; }
        decimal Limit { get; set; }
        string Cvc { get; set; }
        string Pin { get; set; }
        string Vendor { get; set; }
        string Comment { get; set; }

        #endregion // Details

        #region DetailsLists

        List<KeyValuePair<string, string>> ClientList { set; }
        List<KeyValuePair<string, string>> CurrencyList { set; }
        List<KeyValuePair<CardStatus, string>> CardStatusList { set; }

        #endregion //DetailsLists
    }
}