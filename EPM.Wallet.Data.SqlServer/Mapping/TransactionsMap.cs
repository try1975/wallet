using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using EPM.Wallet.Data.Entities;

namespace EPM.Wallet.Data.SqlServer.Mapping
{
    public class TransactionsMap : EntityTypeConfiguration<TransactionEntity>
    {
        public TransactionsMap(string tableName)
        {
            HasKey(e => e.Id);
            Property(e => e.Id)
              .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
              ;

            Property(e => e.RegisterDate)
                .HasColumnType("datetime2")
                ;

            Property(e => e.FromTo)
                .HasMaxLength(512)
                .IsRequired()
                ;

            HasRequired(s => s.ClientAccount)
            .WithMany(l => l.Transactions)
            .HasForeignKey(s => s.AccountId)
            .WillCascadeOnDelete(false)
            ;
            HasRequired(s => s.Currency)
            .WithMany(l => l.Transactions)
            .HasForeignKey(s => s.CurrencyId)
            .WillCascadeOnDelete(false)
            ;
            //HasRequired(s => s.TransactionType)
            //.WithMany(l => l.Transactions)
            //.HasForeignKey(s => s.TransactionTypeId)
            //.WillCascadeOnDelete(false)
            //;



            ToTable($"{tableName}");
        }
    }
}