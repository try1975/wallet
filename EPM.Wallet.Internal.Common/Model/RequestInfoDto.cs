using System;
using EPM.Wallet.Common.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace EPM.Wallet.Internal.Model
{
    public class RequestInfoDto : IDto<Guid>
    {
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public string ClientId { get; set; }
        public string ClientName { get; set; }
        public string CurrencyId { get; set; }
        public Guid? CardId { get; set; }
        public string CardNumber { get; set; }
        public Guid? RequisiteId { get; set; }
        public string Note { get; set; }

        public RequestType RequestType { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public RequestType Type { get; set; }

        public string SubType { get; set; }
        public RequestStatus RequestStatus { get; set; }
        public string Status { get; set; }

        public Guid? ClientAccountId { get; set; }
        public string AccountName { get; set; }
        public string AccountCurrencyId { get; set; }

        public string BankName { get; set; }
        public string Iban { get; set; }
        public string BankAddress { get; set; }
        public string Bic { get; set; }
        public string OwnerName { get; set; }

        public decimal AmountIn { get; set; }
        public decimal AmountOut { get; set; }
        public Guid? BeneficiaryAccountId { get; set; }
        public string BeneficiaryAccountName { get; set; }
        public string BeneficiaryCurrencyId { get; set; }
        public DateTime? ValueDate { get; set; }


        public int Limit { get; set; }
        public string CardReissueType { get; set; }
        public string CardReissueReason { get; set; }

    }
}