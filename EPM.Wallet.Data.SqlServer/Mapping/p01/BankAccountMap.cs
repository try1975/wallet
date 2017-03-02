using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using EPM.Wallet.Data.Entities;

namespace EPM.Wallet.Data.SqlServer.Mapping
{
    internal class BankAccountMap : EntityTypeConfiguration<BankAccountEntity>
    {
        public BankAccountMap(string tableName)
        {
            HasKey(e => e.Id);
            Property(e => e.Id)
               .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(e => e.Name)
                .HasMaxLength(250)
                .IsRequired()
                ;
            Property(e => e.CurrencyId)
                .IsRequired()
                ;
            HasRequired(s => s.Bank)
               .WithMany(l => l.BankAccounts)
               .HasForeignKey(s => s.BankId)
               .WillCascadeOnDelete(false)
               ;
            HasRequired(s => s.Currency)
               .WithMany(l => l.BankAccounts)
               .HasForeignKey(s => s.CurrencyId)
               .WillCascadeOnDelete(false)
               ;
            Property(e => e.CreatedBy)
                .HasMaxLength(10)
                ;
            Property(e => e.UpdatedBy)
                .HasMaxLength(10)
                ;
            ToTable($"{tableName}");
        }
    }
}
