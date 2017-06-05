using System.Data.Entity.ModelConfiguration;
using EPM.Wallet.Data.Entities;

namespace EPM.Wallet.Data.SqlServer.Mapping
{
    public class CardRequestMap : EntityTypeConfiguration<CardRequestEntity>
    {
        public CardRequestMap(string tableName)
        {

            Property(e => e.CardReissueReason)
               .IsOptional()
               .HasMaxLength(128)
               ;
            ToTable($"{tableName}");
        }
    }
}