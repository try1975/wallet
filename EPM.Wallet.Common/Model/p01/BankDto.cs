using System;
using System.Collections.Generic;
using EPM.Wallet.Common.Interfaces;

namespace EPM.Wallet.Common.Model
{
    public class BankDto : IDto<Guid>
    {
        public BankDto()
        {
            //BankAccounts = new HashSet<BankAccount>();
        }
        public Guid Id { get; set; }
        public string Name { get; set; }

        public ICollection<BankAccountDto> BankAccounts { get; set; }
    }
}
