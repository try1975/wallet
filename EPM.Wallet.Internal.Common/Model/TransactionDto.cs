using System;

namespace EPM.Wallet.Internal.Model
{
    public class TransactionDto : IDto<Guid>
    {
        public Guid Id { get; set; }
        public Guid AccountId { get; set; }
        public string AccountName { get; set; }
        public string ClientId { get; set; }
        public string AccountCurrency { get; set; }
        public DateTimeOffset RegisterDate { get; set; }
        public DateTimeOffset ValueDate { get; set; }
        public decimal Amount { get; set; }
        public string CurrencyId { get; set; }

        public decimal AmountInCurrency { get; set; }

        public decimal Balance { get; set; }

        public string FromTo { get; set; }
        public string Note { get; set; }

        public Guid? RequestId { get; set; }

        public Guid? StandingOrderId { get; set; }
    }
}