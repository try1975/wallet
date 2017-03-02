using System;

namespace EPM.Wallet.Internal.Model
{
    public class RefillRequestDto
    {
        public Guid BeneficiaryAccountId { get; set; }
        public string CurrencyId { get; set; }
        public decimal Amount { get; set; }
    }
}