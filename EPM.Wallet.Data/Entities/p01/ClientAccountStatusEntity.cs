using System.Collections.Generic;

namespace EPM.Wallet.Data.Entities
{
    public class ClientAccountStatusEntity : IEntity<string>
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public ICollection<ClientAccountEntity> ClientAccounts { get; set; }
    }
}