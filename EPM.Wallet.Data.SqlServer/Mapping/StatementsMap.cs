using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using EPM.Wallet.Data.Entities;

namespace EPM.Wallet.Data.SqlServer.Mapping
{
    public class StatementsMap : EntityTypeConfiguration<StatementEntity>
    {
        public StatementsMap(string tableName)
        {
            HasKey(e => e.Id);
            Property(e => e.Id)
              .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(e => e.PreviousBalance)
                .HasPrecision(18, 2)
                .IsRequired()
                ;
            Property(e => e.Credits)
                .HasPrecision(18, 2)
                .IsRequired()
                ;
            Property(e => e.Debits)
                .HasPrecision(18, 2)
                .IsRequired()
                ;
            Property(e => e.NewBalance)
                .HasPrecision(18, 2)
                .IsRequired()
                ;

            Property(e => e.Period)
                .HasMaxLength(128)
                .IsOptional()
                ;

            Property(e => e.LoadedFrom)
                .HasMaxLength(512)
                .IsOptional()
                ;

            HasRequired(s => s.Client)
              .WithMany(l => l.Statements)
              .HasForeignKey(s => s.ClientId)
              .WillCascadeOnDelete(false)
              ;
            HasOptional(s => s.ClientAccount)
            .WithMany(l => l.Statements)
            .HasForeignKey(s => s.AccountId)
            .WillCascadeOnDelete(false)
            ;
            HasOptional(s => s.Card)
             .WithMany(l => l.Statements)
             .HasForeignKey(s => s.CardId)
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