using System;

namespace WalletWebApi.Model
{
    public class TransferOutRequestDto
    {
        public Guid RequisiteId { get; set; }
        public string CurrencyId { get; set; }
        public decimal Amount { get; set; }

        public string Note { get; set; }
        public DateTime ValueDate { get; set; }
    }
}