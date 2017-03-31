using System.Collections.Generic;

namespace EPM.Wallet.Data.Entities
{
    public class CurrencyEntity : IEntity<string>
    {
        public string Id { get; set; }

        public int SortOrder { get; set; }

        public ICollection<BankAccountEntity> BankAccounts { get; set; }
        public ICollection<ClientAccountEntity> ClientAccounts { get; set; }
        public ICollection<CardEntity> Cards { get; set; }
        public ICollection<RequestEntity> Requests { get; set; }
        public ICollection<StandingOrderEntity> StandingOrders { get; set; }
        public ICollection<TransactionEntity> Transactions { get; set; }
        public ICollection<DirectDebitEntity> DirectDebits { get; set; }
    }
}