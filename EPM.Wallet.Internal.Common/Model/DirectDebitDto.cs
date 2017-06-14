using System;

namespace EPM.Wallet.Internal.Model
{
    public class DirectDebitDto : IDto<Guid>
    {
        public Guid Id { get; set; }
        public Guid SourceAccountId { get; set; }
        public string SourceAccountName { get; set; }
        public Guid CardId { get; set; }
        public string CardNumber { get; set; }
        public string CurrencyId { get; set; }
        public bool DebitFromOtherIfIncefitient { get; set; }
    }
}