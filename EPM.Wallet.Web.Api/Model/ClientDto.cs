using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WalletWebApi.Model
{
    public class ClientDto : IDto<string>
    {
        [Required]
        [StringLength(10, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 4)]
        public string Id { get; set; }
        public string Name { get; set; }

        //[Editable(false)]
        public ICollection<CardDto> Cards { get; set; }
        public ICollection<AccountDto> ClientAccounts { get; set; }

    }
}
