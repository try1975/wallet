using System;
using System.Collections.Generic;
using EPM.Wallet.Common.Enums;
using EPM.Wallet.Internal.Model;

namespace EPM.Wallet.WinForms.Interfaces
{
    public interface ITransferOutInfoView:  ITypedView<TransferOutInfoDto, Guid>
    {
        #region Details
        DateTime Date { get; set; }
        DateTime? ValueDate { get; set; }
        string ClientId { get; set; }
        string CurrencyId { get; set; }
        RequestStatus RequestStatus { get; set; }
        string Note { get; set; }
        Guid? AccountId { get; set; }
        decimal AmountOut { get; set; }

        // Requisite
        string BankName { get; set; }
        string Iban { get; set; }
        string BankAddress { get; set; }
        string Bic { get; set; }
        string OwnerName { get; set; }
        #endregion //Details

        #region DetailsLists

        List<KeyValuePair<RequestStatus, string>> RequestStatusList { set; }

        #endregion //DetailsLists
    }
}