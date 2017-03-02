using System;
using EPM.Wallet.Common.Interfaces;

namespace EPM.Wallet.Common.Model
{
    public class CardDto : IDto<Guid>
    {
        public Guid Id { get; set; }
        public string Comment { get; set; }
        public string ClientId { get; set; }
        public string CurrencyId { get; set; }
        public string CardNumber { get; set; }
        public string CardHolder { get; set; }
        public int ExpMonth { get; set; }
        public int ExpYear { get; set; }
        public decimal Limit { get; set; }
        public string Vendor { get; set; }
        public Uri LastStatementLink { get; set; }
    }
}
