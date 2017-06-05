using System;
using System.Collections.Generic;
using EPM.Wallet.Common.Enums;

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

        public ClientAccountStatus ClientAccountStatus { get; set; }

        public decimal CurrentBalance { get; set; }
        public decimal InitialBalance { get; set; }

        public Guid? RequisiteId { get; set; }
        public virtual RequisiteEntity Requisite { get; set; }

        public ICollection<AccountRequestEntity> Requests { get; set; }
        public ICollection<AccountRequestEntity> BeneficiaryRequests { get; set; }
        public ICollection<StatementEntity> Statements { get; set; }
        public ICollection<StandingOrderEntity> StandingOrders { get; set; }
        public ICollection<TransactionEntity> Transactions { get; set; }
        public ICollection<DirectDebitEntity> DirectDebits { get; set; }

        public Guid? StatementId { get; set; }
        public StatementEntity Statement { get; set; }
    }
}