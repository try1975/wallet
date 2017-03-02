using System;

namespace EPM.Wallet.Internal.Model
{
    public class TransferOutRequestDto
    {
        public Guid RequisiteId { get; set; }
        public string CurrencyId { get; set; }
        public decimal Amount { get; set; }
    }
}