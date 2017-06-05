using System;
using EPM.Wallet.Common.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace EPM.Wallet.Internal.Model
{
    public class CardDto : IDto<Guid>
    {
        public Guid Id { get; set; }
        public string ClientId { get; set; }
        public string CurrencyId { get; set; }
        public string CardNumber { get; set; }
        public string CardHolder { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public CardStatus CardStatus { get; set; }
        public int ExpMonth { get; set; }
        public int ExpYear { get; set; }
        public decimal Limit { get; set; }
        public string Cvc { get; set; }
        public string Pin { get; set; }
        public string Vendor { get; set; }
        public string Comment { get; set; }

        public Uri LastStatementLink { get; set; }
    }
}
