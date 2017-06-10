using System;
using System.Collections.Generic;

namespace EPM.Wallet.Data.Entities
{
    public class BankAccountEntity : CommonEntity, IEntity<Guid>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string BeneficiaryAddress { get; set; }
        public Guid BankId { get; set; }
        public BankEntity Bank { get; set; }
        public string CurrencyId { get; set; }
        public CurrencyEntity Currency { get; set; }
        public ICollection<ClientAccountEntity> ClientAccounts { get; set; }
    }
}