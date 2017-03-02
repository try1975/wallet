using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using EPM.Wallet.Data.Entities;

namespace EPM.Wallet.Data.SqlServer.Mapping
{
    internal class MessageMap : EntityTypeConfiguration<MessageEntity>
    {
        public MessageMap(string tableName)
        {
            HasKey(e => e.Id);
            Property(e => e.Id)
              .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(e => e.Subject)
                .IsOptional()
                .HasMaxLength(250)
                ;
            Property(e => e.Body)
                .IsRequired()
                //.HasMaxLength(250)
                ;
            Property(e => e.ClientId)
                .IsRequired()
                ;
            HasRequired(s => s.Client)
              .WithMany(l => l.ClientMessages)
              .HasForeignKey(s => s.ClientId)
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