using System;

namespace EPM.Wallet.Data.Entities
{
    public class MessageEntity : CommonEntity, IEntity<Guid>
    {
        public Guid Id { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public string ClientId { get; set; }
        public ClientEntity Client { get; set; }
        public DateTime? ReadDate { get; set; }

        public DateTime? DeletionDate { get; set; }
        public bool IsOutgoing { get; set; }
    }
}