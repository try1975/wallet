using System;

namespace EPM.Wallet.Internal.Model
{
    public class TransferToCardRequestDto
    {
        public Guid CardId { get; set; }
        public string CurrencyId { get; set; }
        public decimal Amount { get; set; }
    }
}