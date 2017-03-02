namespace WalletWebApi.Model
{
    public class AccountRequestDto : RequestDto
    {
        public string AccountName { get; set; }
        public decimal AmountIn { get; set; }
        public decimal AmountOut { get; set; }
        public string BeneficiaryAccount { get; set; }
        public string BeneficiaryCard { get; set; }
        public string CurrencyId { get; set; }
    }
}