using System;

namespace WalletWebApi.Model
{
    public class TransactionDto : IDto<Guid>
    {
        public Guid Id { get; set; }
        public DateTime ValueDate { get; set; }
        public decimal Amount { get; set; }
        public decimal Balance { get; set; }

        public string FromTo { get; set; }
        public string Note { get; set; }
        public RequisiteDto Requisite { get; set; }
        //public AccountRequestDto Request { get; set; }
    }
}