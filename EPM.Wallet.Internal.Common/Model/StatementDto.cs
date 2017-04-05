using System;
using Newtonsoft.Json;

namespace EPM.Wallet.Internal.Model
{
    public class StatementDto : IDto<Guid>
    {
        public Guid Id { get; set; }
        //public string ClientId { get; set; }
        public Guid? AccountId { get; set; }
        public Guid? CardId { get; set; }

        public DateTime ValueDate { get; set; }

        public string Period { get; set; }

        public decimal PreviousBalance { get; set; }

        public decimal Credits { get; set; }

        public decimal Debits { get; set; }

        public decimal NewBalance { get; set; }
        //[JsonIgnore]
        public byte[] Content { get; set; }
        public string LoadedFrom { get; set; }

        public Uri StatementLink { get; set; }
    }
}