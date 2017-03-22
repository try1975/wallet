using System;
using System.Collections.Generic;

namespace EPM.Wallet.Data.Entities
{
    public class RequisiteEntity : IEntity<Guid>
    {
        public Guid Id { get; set; }

        public string Name { get; set; }
        public string ClientId { get; set; }
        public ClientEntity Client { get; set; }
        public string BankName { get; set; }
        public string Iban { get; set; }
        public string BankAddress { get; set; }
        public string Bic { get; set; }
        public string OwnerName { get; set; }
        public bool IsVisible { get; set; }
        public ICollection<AccountRequestEntity> Requests { get; set; }
        public ICollection<StandingOrderEntity> StandingOrders { get; set; }
    }
}