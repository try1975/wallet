using System;
using EPM.Wallet.Common.Interfaces;

namespace WalletWebApi.Model
{
    public class RequisiteDto : IDto<Guid>
    {
        public Guid Id { get; set; }

        public string Name { get; set; }
        //public string ClientId { get; set; }
        public string BankName { get; set; }
        public string Iban { get; set; }
        public string BankAddress { get; set; }
        public string Bic { get; set; }
        public string OwnerName { get; set; }
    }
}