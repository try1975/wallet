using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using EPM.Wallet.Data.Entities;

namespace EPM.Wallet.Data.SqlServer.Mapping
{
    public class RequestMap : EntityTypeConfiguration<RequestEntity>
    {
        public RequestMap(string tableName)
        {
            HasKey(e => e.Id);
            Property(e => e.Id)
              .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            HasRequired(s => s.Client)
              .WithMany(l => l.Requests)
              .HasForeignKey(s => s.ClientId)
              .WillCascadeOnDelete(false)
              ;
            HasOptional(s => s.Currency)
            .WithMany(l => l.Requests)
            .HasForeignKey(s => s.CurrencyId)
            .WillCascadeOnDelete(false)
            ;
            HasOptional(s => s.Card)
             .WithMany(l => l.Requests)
             .HasForeignKey(s => s.CardId)
             .WillCascadeOnDelete(false)
             ;
            HasOptional(s => s.Requisite)
            .WithMany(l => l.Requests)
            .HasForeignKey(s => s.RequisiteId)
            .WillCascadeOnDelete(false)
            ;
            ToTable($"{tableName}");
        }
    }
}