using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using EPM.Wallet.Data.Entities;

namespace EPM.Wallet.Data.SqlServer.Mapping
{
    public class DirectDebitsMap : EntityTypeConfiguration<DirectDebitEntity>
    {
        public DirectDebitsMap(string tableName)
        {
            HasKey(e => e.Id);
            Property(e => e.Id)
              .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            HasRequired(s => s.SourceAccount)
            .WithMany(l => l.DirectDebits)
            .HasForeignKey(s => s.SourceAccountId)
            .WillCascadeOnDelete(false)
            ;

            HasRequired(s => s.Card)
            .WithMany(l => l.DirectDebits)
            .HasForeignKey(s => s.CardId)
            .WillCascadeOnDelete(false)
            ;

            HasRequired(s => s.Currency)
            .WithMany(l => l.DirectDebits)
            .HasForeignKey(s => s.CurrencyId)
            .WillCascadeOnDelete(false)
            ;


            ToTable($"{tableName}");
        }
    }
}