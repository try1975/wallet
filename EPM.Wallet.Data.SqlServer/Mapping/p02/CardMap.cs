using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;
using EPM.Wallet.Data.Entities;

namespace EPM.Wallet.Data.SqlServer.Mapping
{
    internal class CardMap : EntityTypeConfiguration<CardEntity>
    {
        public CardMap(string tableName)
        {
            HasKey(e => e.Id);
            Property(e => e.Id)
              .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(e => e.CardNumber)
                .HasMaxLength(50)
                .IsRequired()
                .HasColumnAnnotation(IndexAnnotation.AnnotationName, new IndexAnnotation(new IndexAttribute("IX_CardNumber", 1) { IsUnique = true }))
                ;
            Property(e => e.Comment)
                .HasMaxLength(250)
                ;
            Property(e => e.CardHolder)
                .HasMaxLength(50)
                .IsRequired()
                ;
            Property(e => e.ExpMonth)
                .IsRequired()
                ;
            Property(e => e.ExpYear)
                .IsRequired()
                ;
            Property(e => e.Vendor)
                .HasMaxLength(10)
                ;
            Property(e => e.Pin)
                .HasMaxLength(10)
                ;
            Property(e => e.Cvc)
                .HasMaxLength(10)
                ;
            HasRequired(s => s.Client)
                .WithMany(l => l.Cards)
                .HasForeignKey(s => s.ClientId)
                .WillCascadeOnDelete(false)
                ;
            Property(e => e.MainCardId)
                .IsOptional()
                ;
            HasOptional(s => s.Currency)
                .WithMany(l => l.Cards)
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
