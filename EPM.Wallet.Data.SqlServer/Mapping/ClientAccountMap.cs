using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using EPM.Wallet.Data.Entities;

namespace EPM.Wallet.Data.SqlServer.Mapping
{
    internal class ClientAccountMap : EntityTypeConfiguration<ClientAccountEntity>
    {
        public ClientAccountMap(string tableName)
        {
            HasKey(e => e.Id);
            Property(e => e.Id)
              .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(e => e.Name)
                .HasMaxLength(250)
                .IsRequired()
                ;
            Property(e => e.Comment)
                .HasMaxLength(250)
                ;
            Property(e => e.CurrentBalance)
                .HasPrecision(18, 2)
                .IsRequired()
                ;
            Property(e => e.ClientId)
                .IsRequired()
                ;
            Property(e => e.CurrencyId)
                .IsRequired()
                ;
            HasRequired(s => s.BankAccount)
               .WithMany(l => l.ClientAccounts)
               .HasForeignKey(s => s.BankAccountId)
               .WillCascadeOnDelete(false)
               ;
            HasRequired(s => s.Client)
               .WithMany(l => l.ClientAccounts)
               .HasForeignKey(s => s.ClientId)
               .WillCascadeOnDelete(false)
               ;
            HasRequired(s => s.Currency)
              .WithMany(l => l.ClientAccounts)
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
