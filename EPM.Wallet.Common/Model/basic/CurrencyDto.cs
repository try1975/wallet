using EPM.Wallet.Common.Interfaces;

namespace EPM.Wallet.Common.Model
{
    public class CurrencyDto : IDto<string>
    {
        public string Id { get; set; }
    }
}