using System.Collections.Generic;

namespace EPM.Wallet.Data.Entities
{
    public class TransactionTypeEntity : IEntity<string>
    {
        public string Id { get; set; }
        public bool IsPositive { get; set; }

        //public ICollection<TransactionEntity> Transactions { get; set; }
    }
}