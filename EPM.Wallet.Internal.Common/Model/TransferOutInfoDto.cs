using System;
using EPM.Wallet.Common.Enums;

namespace EPM.Wallet.Internal.Model
{
    public class TransferOutInfoDto : IDto<Guid>
    {
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public DateTime? ValueDate { get; set; }
        public string ClientId { get; set; }
        public string CurrencyId { get; set; }
        public RequestStatus RequestStatus { get; set; }
        public Guid? AccountId { get; set; }
        public decimal AmountOut { get; set; }
        public string Note { get; set; }

        // Requisite
        public string BankName { get; set; }
        public string Iban { get; set; }
        public string BankAddress { get; set; }
        public string Bic { get; set; }
        public string OwnerName { get; set; }
        public string AccountName { get; set; }
        public string AccountCurrency { get; set; }
    }
}