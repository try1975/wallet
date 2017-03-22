using System;

namespace EPM.Wallet.Data.Entities
{
    public class TransactionEntity : CommonEntity, IEntity<Guid>
    {
        public Guid Id { get; set; }
        public Guid? AccountId { get; set; }
        public ClientAccountEntity ClientAccount { get; set; }

        public DateTimeOffset RegisterDate { get; set; }
        public DateTimeOffset ValueDate { get; set; }
        public decimal Amount { get; set; }
        public string CurrencyId { get; set; }
        public CurrencyEntity Currency { get; set; }

        public decimal AmountCurrency { get; set; }

        public decimal Balance { get; set; }

        public string FromTo { get; set; }
        public string Note { get; set; }

        //public string TransactionTypeId { get; set; }
        //public TransactionTypeEntity TransactionType { get; set; }

        public Guid? RequestId { get; set; }
        public RequestEntity Request { get; set; }

        public Guid? StandingOrderId { get; set; }
        public StandingOrderEntity StandingOrder { get; set; }

    }
}