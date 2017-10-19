using System;
using EPM.Wallet.Common.Enums;

namespace EPM.Wallet.Internal.Model
{
    public class AccountDto : IDto<Guid>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string ClientId { get; set; }
        public string CurrencyId { get; set; }
        public decimal CurrentBalance { get; set; }
        public ClientAccountStatus ClientAccountStatus { get; set; }
        public string Comment { get; set; }
        public string BeneficiaryName { get; set; }
        public string BeneficiaryAddress { get; set; }
        public string Reference { get; set; }
        public Guid BankAccountId { get; set; }

        public RequisiteDto Requisite { get; set; }
    }
}