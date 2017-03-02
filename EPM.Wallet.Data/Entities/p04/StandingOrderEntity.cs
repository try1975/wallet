using System;

namespace EPM.Wallet.Data.Entities
{
    public class StandingOrderEntity : CommonEntity, IEntity<Guid>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid ClientAccountId { get; set; }
        public ClientAccountEntity ClientAccount { get; set; }
        public string BeneficiaryAccount { get; set; }
        public string BeneficiaryNumber { get; set; }
        public decimal Amount { get; set; }
        public string CurrencyId { get; set; }
        public CurrencyEntity Currency { get; set; }
        public DateTime FirstDate { get; set; }
        public DateTime LastDate { get; set; }
        public string Frequency { get; set; }
        public string ReferenceNumber { get; set; }
        public string BeneficiaryBank { get; set; }
        public string RemitterName { get; set; }
        public string DebitDescription { get; set; }
        public string CreditDescription { get; set; }

    }
}
