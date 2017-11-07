using System;
using EPM.Wallet.Common.Enums;

namespace EPM.Wallet.Data.Entities
{
    public class DirectDebitEntity : CommonEntity, IEntity<Guid>
    {
        public Guid Id { get; set; }
        public Guid SourceAccountId { get; set; }
        public ClientAccountEntity SourceAccount { get; set; }
        public Guid CardId { get; set; }
        public CardEntity Card { get; set; }
        public string CurrencyId { get; set; }
        public CurrencyEntity Currency { get; set; }
        public bool DebitFromOtherIfIncefitient { get; set; }
        public decimal Amount { get; set; }
    }
}