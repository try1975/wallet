using System;

namespace EPM.Wallet.Common.Model
{
    public class TransferToCardRequestDto
    {
        public Guid CardId { get; set; }
        public string CurrencyId { get; set; }
        public decimal Amount { get; set; }
    }
}