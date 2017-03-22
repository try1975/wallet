using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using EPM.Wallet.Data.Entities;

namespace EPM.Wallet.Data.SqlServer.Mapping
{
    public class StandingOrderMap: EntityTypeConfiguration<StandingOrderEntity>
    {
        public StandingOrderMap(string tableName)
        {
            HasKey(e => e.Id);
            Property(e => e.Id)
              .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(e => e.Name)
                .HasMaxLength(250)
                .IsRequired()
                ;
            Property(e => e.Amount)
                .HasPrecision(18, 2)
                .IsRequired()
                ;

            HasRequired(s => s.ClientAccount)
            .WithMany(l => l.StandingOrders)
            .HasForeignKey(s => s.ClientAccountId)
            .WillCascadeOnDelete(false)
            ;

            HasRequired(s => s.Currency)
            .WithMany(l => l.StandingOrders)
            .HasForeignKey(s => s.CurrencyId)
            .WillCascadeOnDelete(false)
            ;

            HasRequired(s => s.Requisite)
            .WithMany(l => l.StandingOrders)
            .HasForeignKey(s => s.RequisiteId)
            .WillCascadeOnDelete(false)
            ;

            ToTable($"{tableName}");
        }
    }
}