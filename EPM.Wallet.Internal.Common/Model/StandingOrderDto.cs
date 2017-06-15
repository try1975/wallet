using System;
using EPM.Wallet.Common.Enums;

namespace EPM.Wallet.Internal.Model
{
    public class StandingOrderDto : IDto<Guid>
    {
        public Guid Id { get; set; }
        public Guid ClientAccountId { get; set; }
        public decimal Amount { get; set; }
        public string CurrencyId { get; set; }
        public DateTime FirstDate { get; set; }
        public DateTime? LastDate { get; set; }
        public DateTime? NextRequestDate { get; set; }
        public Frequency Frequency { get; set; }
        public string Note { get; set; }
        public Guid RequisiteId { get; set; }
        public StandingOrderStatus StandingOrderStatus { get; set; }
    }
}