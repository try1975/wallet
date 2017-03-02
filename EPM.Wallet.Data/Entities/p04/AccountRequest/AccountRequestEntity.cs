using System;
using EPM.Wallet.Common.Enums;

namespace EPM.Wallet.Data.Entities
{
    public class AccountRequestEntity : RequestEntity
    {
        public Guid? ClientAccountId { get; set; }
        public ClientAccountEntity ClientAccount { get; set; }

        public AccountRequestType AccountRequestType { get; set; }
        public decimal AmountIn { get; set; }
        public decimal AmountOut { get; set; }
        public Guid? BeneficiaryAccountId { get; set; }
        public Guid? RequisiteId { get; set; }
        public RequisiteEntity Requisite { get; set; }
    }
}