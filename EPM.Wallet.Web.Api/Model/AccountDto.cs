using System;

namespace WalletWebApi.Model
{
    public class AccountDto : IDto<Guid>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Comment { get; set; }
        public string CurrencyId { get; set; }
        public string ClientId { get; set; }
        //public Guid BankAccountId { get; set; }
        public string ClientAccountStatusId { get; set; }
        public decimal CurrentBalance { get; set; }

        public RequisiteDto Requisite { get; set; }
    }
}