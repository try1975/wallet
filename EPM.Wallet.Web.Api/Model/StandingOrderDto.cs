using System;
using EPM.Wallet.Common.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace WalletWebApi.Model
{
    public class StandingOrderDto : IDto<Guid>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid ClientAccountId { get; set; }
        public decimal Amount { get; set; }
        public string CurrencyId { get; set; }
        public DateTime FirstDate { get; set; }
        public DateTime? LastDate { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public Frequency Frequency { get; set; }
        public string Note { get; set; }
        public Guid RequisiteId { get; set; }
    }
}