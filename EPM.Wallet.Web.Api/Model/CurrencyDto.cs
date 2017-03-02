using EPM.Wallet.Common.Interfaces;

namespace WalletWebApi.Model
{
    public class CurrencyDto : IDto<string>
    {
        public string Id { get; set; }
    }
}