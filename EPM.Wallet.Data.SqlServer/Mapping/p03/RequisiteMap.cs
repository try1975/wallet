using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using EPM.Wallet.Data.Entities;

namespace EPM.Wallet.Data.SqlServer.Mapping
{
    internal class RequisiteMap : EntityTypeConfiguration<RequisiteEntity> 
    {
        public RequisiteMap(string tableName)
        {
            HasKey(e => e.Id);
            Property(e => e.Id)
              .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(400)
                ;
            Property(e => e.ClientId)
                .IsRequired()
                ;
            Property(e => e.BankName)
                .HasMaxLength(128)
                ;
            Property(e => e.Iban)
                .HasMaxLength(128)
                ;
            Property(e => e.BankAddress)
                .HasMaxLength(128)
                ;
            Property(e => e.Bic)
                .HasMaxLength(128)
                ;
            Property(e => e.OwnerName)
                .HasMaxLength(128)
                ;

            HasRequired(s => s.Client)
              .WithMany(l => l.Requsites)
              .HasForeignKey(s => s.ClientId)
              .WillCascadeOnDelete(false)
              ;

            ToTable($"{tableName}");
        }
    }
}
