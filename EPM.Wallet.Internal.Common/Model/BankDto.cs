using System;
using System.Collections.Generic;

namespace EPM.Wallet.Internal.Model
{
    public class BankDto : IDto<Guid>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public ICollection<BankAccountDto> BankAccounts { get; set; }
    }
}
