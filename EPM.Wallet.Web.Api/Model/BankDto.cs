using System;
using System.Collections.Generic;

namespace WalletWebApi.Model
{
    public class BankDto : IDto<Guid>
    {
        public BankDto()
        {
            //BankAccounts = new HashSet<BankAccount>();
        }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string BankAddress { get; set; }
        public string Bic { get; set; }

        public ICollection<BankAccountDto> BankAccounts { get; set; }
    }
}
