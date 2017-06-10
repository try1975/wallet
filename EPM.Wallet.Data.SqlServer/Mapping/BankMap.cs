using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;
using EPM.Wallet.Data.Entities;

namespace EPM.Wallet.Data.SqlServer.Mapping
{
    internal class BankMap : EntityTypeConfiguration<BankEntity>
    {
        public BankMap(string tableName)
        {
            HasKey(e => e.Id);
            Property(e => e.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(e => e.Name)
                .HasMaxLength(128)
                .IsRequired()
                .HasColumnAnnotation(IndexAnnotation.AnnotationName, new IndexAnnotation(new IndexAttribute("IX_Name", 1) { IsUnique = true }))
                ;

            Property(e => e.BankAddress)
                .HasMaxLength(128)
                ;
            Property(e => e.Bic)
                .HasMaxLength(128)
                ;

            ToTable($"{tableName}");
        }
    }
}