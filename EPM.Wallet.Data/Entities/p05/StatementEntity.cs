using System;

namespace EPM.Wallet.Data.Entities
{
    public class StatementEntity : CommonEntity, IEntity<Guid>
    {
        public Guid Id { get; set; }

        public string ClientId { get; set; }
        public ClientEntity Client { get; set; }

        public Guid? AccountId { get; set; }
        public ClientAccountEntity  ClientAccount { get; set; }

        public Guid? CardId { get; set; }
        public CardEntity Card { get; set; }

        public DateTimeOffset ValueDate { get; set; }

        public string Period { get; set; }

        public decimal PreviousBalance { get; set; }

        public decimal Credits { get; set; }

        public decimal Debits { get; set; }

        public decimal NewBalance { get; set; }

        public byte[] Content { get; set; }
        public string LoadedFrom { get; set; }

    }
}