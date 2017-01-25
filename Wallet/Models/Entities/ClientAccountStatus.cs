using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Wallet.Models.Entities
{
    public class ClientAccountStatus
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public DateTime CreatedAt { get; set; }
        public Guid CreatedBy { get; set; }
        public ClientAccount ClientAccount { get; set; }

        public ClientAccountStatusDictionary ClientAccountStatusDictionary { get; set; }
    }
}