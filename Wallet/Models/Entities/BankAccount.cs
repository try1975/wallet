using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Wallet.Models.Entities
{
    public class BankAccount
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Bank Bank { get; set; }
        //public Currency Currency { get; set; }
    }
}