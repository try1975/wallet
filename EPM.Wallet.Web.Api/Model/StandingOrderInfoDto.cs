using System;
using EPM.Wallet.Common.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace WalletWebApi.Model
{
    public class StandingOrderInfoDto : IDto<Guid>
    {
        public Guid Id { get; set; }
        public Guid AccountId { get; set; }
        public string AccountName { get; set; }
        public decimal Amount { get; set; }
        public string CurrencyId { get; set; }
        public DateTime FirstDate { get; set; }
        public DateTime? LastDate { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public Frequency Frequency { get; set; }
        public string Note { get; set; }
        public RequisiteDto Requisite { get; set; }
    }
}