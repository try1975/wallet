using System.Collections.Generic;
using EPM.Wallet.Common.Interfaces;

namespace EPM.Wallet.Internal.Model
{
    public class ClientDto : IDto<string>
    {
        public string Id { get; set; }
        public string Name { get; set; }

        //[Editable(false)]
        public ICollection<CardDto> Cards { get; set; }
        public ICollection<AccountDto> ClientAccounts { get; set; }

    }
}
