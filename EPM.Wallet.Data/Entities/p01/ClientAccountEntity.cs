using System;
using System.Collections.Generic;

namespace EPM.Wallet.Data.Entities
{
    public class ClientAccountEntity : CommonEntity, IEntity<Guid>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Comment { get; set; }
        public string CurrencyId { get; set; }
        public CurrencyEntity Currency { get; set; }
        public string ClientId { get; set; }
        public ClientEntity Client { get; set; }

        public Guid BankAccountId { get; set; }
        public BankAccountEntity BankAccount { get; set; }

        public string ClientAccountStatusId { get; set; }
        public ClientAccountStatusEntity ClientAccountStatus { get; set; }

        public decimal CurrentBalance { get; set; }

        public Guid? RequisiteId { get; set; }
        public virtual RequisiteEntity Requisite { get; set; }

        public ICollection<AccountRequestEntity> Requests { get; set; }
        public ICollection<StatementEntity> Statements { get; set; }

        public Guid? StatementId { get; set; }
        public StatementEntity Statement { get; set; }
    }
}