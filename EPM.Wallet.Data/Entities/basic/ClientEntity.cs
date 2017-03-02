using System.Collections.Generic;

namespace EPM.Wallet.Data.Entities
{
    public class ClientEntity :IEntity<string>
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public ICollection<ClientAccountEntity> ClientAccounts { get; set; }
        public ICollection<CardEntity> Cards { get; set; }
        public ICollection<MessageEntity> ClientMessages { get; set; }
        public ICollection<RequisiteEntity> Requsites { get; set; }
        public ICollection<RequestEntity> Requests { get; set; }
    }
}