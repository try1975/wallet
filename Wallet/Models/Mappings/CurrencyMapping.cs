using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using Wallet.Models.Entities;

namespace Wallet.Models.Mappings
{
    public class CurrencyMapping : EntityTypeConfiguration<WCurrency>
    {
        public CurrencyMapping(string tableName)
        {
            HasKey(e => e.Id);
            Property(e => e.Name).IsRequired();
            Property(e => e.Name).HasMaxLength(50);
            ToTable($"{tableName}");
        }
    }
}