using System;

namespace EPM.Wallet.Internal.Model
{
    public class BankAccountDto : IDto<Guid>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid BankId { get; set; }
        public string CurrencyId { get; set; }
    }
}
