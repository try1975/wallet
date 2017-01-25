using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Wallet.Models.Entities
{
    public class ClientAccount
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public BankAccount BankAccount { get; set; }
        //public Currency Currency { get; set; }
        public Client Client { get; set; }
    }
}