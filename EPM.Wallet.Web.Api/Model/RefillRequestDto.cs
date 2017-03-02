using System;

namespace WalletWebApi.Model
{
    public class RefillRequestDto
    {
        public Guid BeneficiaryAccountId { get; set; }
        public string CurrencyId { get; set; }
        public decimal Amount { get; set; }
    }
}