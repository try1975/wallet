using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using EPM.Wallet.Data.Entities;

namespace EPM.Wallet.Data.SqlServer.Mapping
{
    internal class ClientMap : EntityTypeConfiguration<ClientEntity>
    {
        public ClientMap(string tableName)
        {
            HasKey(e => e.Id);
            Property(e => e.Id)
                .HasMaxLength(10)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            ;
            Property(e => e.Name).HasMaxLength(128)
                .IsRequired()
                ;
            ToTable($"{tableName}");
        }
    }
}
