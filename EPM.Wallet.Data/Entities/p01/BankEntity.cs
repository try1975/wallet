using System;
using System.Collections.Generic;

namespace EPM.Wallet.Data.Entities
{
    public class BankEntity : IEntity<Guid>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public IList<BankAccountEntity> BankAccounts { get; set; }
    }
}