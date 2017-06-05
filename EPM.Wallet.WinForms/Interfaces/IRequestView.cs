using System;
using EPM.Wallet.Common.Enums;
using EPM.Wallet.Internal.Model;

namespace EPM.Wallet.WinForms.Interfaces
{
    public interface IRequestView : ITypedView<RequestInfoDto, Guid>
    {
        #region Details

        string ClientId { get; set; }
        string ClientName { get; set; }

        RequestType RequestType { get; set; }
        string Type { get; set; }
        string SubType { get; set; }

        string Status { get; set; }
        RequestStatus RequestStatus { get; set; }
        string CurrencyId { get; set; }

        Guid? CardId { get; set; }
        string CardNumber { get; set; }
        Guid? ClientAccountId { get; set; }
        string AccountName { get; set; }
        string AccountCurrencyId { get; set; }

        Guid? BeneficiaryAccountId { get; set; }
        string BeneficiaryAccountName { get; set; }
        string BeneficiaryCurrencyId { get; set; }

        string BankName { get; set; }
        string Iban { get; set; }
        string BankAddress { get; set; }
        string Bic { get; set; }
        string OwnerName { get; set; }

        DateTime? ValueDate { get; set; }

        decimal AmountIn { get; set; }
        decimal AmountOut { get; set; }

        #endregion // Details

        #region DetailsLists

        #endregion //DetailsLists
    }
}