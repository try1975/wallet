using System;
using System.Collections.Generic;
using EPM.Wallet.Common.Enums;

namespace EPM.Wallet.Data.Entities
{
    public class CardEntity : CommonEntity, IEntity<Guid>
    {
        public Guid Id { get; set; }
        public string Comment { get; set; }
        public string ClientId { get; set; }
        public ClientEntity Client { get; set; }
        public string CurrencyId { get; set; }
        public CurrencyEntity Currency { get; set; }
        public string CardNumber { get; set; }
        public string CardHolder { get; set; }
        public int ExpMonth { get; set; }
        public int ExpYear { get; set; }

        public decimal Limit { get; set; }

        public string Cvc { get; set; }
        public string Pin { get; set; }
        public string Vendor { get; set; }
        //public bool IsInactive { get; set; }
        public CardStatus CardStatus { get; set; }

        public Guid? MainCardId { get; set; }
        public CardEntity MainCard { get; set; }
        public ICollection<RequestEntity> Requests { get; set; }
        public ICollection<StatementEntity> Statements { get; set; }
        public ICollection<DirectDebitEntity> DirectDebits { get; set; }
    }
}
