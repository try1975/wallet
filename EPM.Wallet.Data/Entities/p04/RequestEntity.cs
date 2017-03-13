using System;
using EPM.Wallet.Common.Enums;

namespace EPM.Wallet.Data.Entities
{
    public class RequestEntity : CommonEntity, IEntity<Guid>
    {
        public Guid Id { get; set; }
        public string ClientId { get; set; }
        public ClientEntity Client { get; set; }
        public string CurrencyId { get; set; }
        public CurrencyEntity Currency { get; set; }

        public Guid? CardId { get; set; }
        public CardEntity Card { get; set; }
        public RequestType RequestType { get; set; }
        public RequestStatus RequestStatus { get; set; }

        public string Note { get; set; }
    }
}