using System;
using EPM.Wallet.Common.Interfaces;

namespace WalletWebApi.Model
{
    public class BankAccountDto : IDto<Guid>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid BankId { get; set; }
        public string CurrencyId { get; set; }
    }
}
