using System;
using EPM.Wallet.Common.Enums;

namespace EPM.Wallet.Data.Entities
{
    public class StandingOrderEntity : CommonEntity, IEntity<Guid>
    {
        public Guid Id { get; set; }
        public Guid ClientAccountId { get; set; }
        public ClientAccountEntity ClientAccount { get; set; }
        public decimal Amount { get; set; }
        public string CurrencyId { get; set; }
        public CurrencyEntity Currency { get; set; }
        public DateTime FirstDate { get; set; }
        public DateTime? LastDate { get; set; }
        public DateTime? LastRequestDate { get; set; }
        public DateTime? NextRequestDate { get; set; }
        public Frequency Frequency { get; set; }
        public StandingOrderStatus StandingOrderStatus { get; set; }
        public string Note { get; set; }
        public Guid RequisiteId { get; set; }
        public RequisiteEntity Requisite { get; set; }

    }
}
