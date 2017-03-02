using System;

namespace EPM.Wallet.Common.Model
{
    public class RefillRequestDto
    {
        public Guid BeneficiaryAccountId { get; set; }
        public string CurrencyId { get; set; }
        public decimal Amount { get; set; }
    }
}