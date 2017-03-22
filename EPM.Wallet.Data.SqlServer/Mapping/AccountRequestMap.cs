using System.Data.Entity.ModelConfiguration;
using EPM.Wallet.Data.Entities;

namespace EPM.Wallet.Data.SqlServer.Mapping
{
    public class AccountRequestMap : EntityTypeConfiguration<AccountRequestEntity>
    {
        public AccountRequestMap(string tableName)
        {

            Property(e => e.AmountIn)
                .HasPrecision(18, 2)
                .IsOptional()
                ;
            Property(e => e.AmountOut)
                .HasPrecision(18, 2)
                .IsOptional()
                ;
            HasOptional(s => s.ClientAccount)
             .WithMany(l => l.Requests)
             .HasForeignKey(s => s.ClientAccountId)
             .WillCascadeOnDelete(false)
             ;

            //HasOptional(s => s.BeneficiaryAccount)
            // .WithMany(l => l.Requests)
            // .HasForeignKey(s => s.BeneficiaryAccountId)
            // .WillCascadeOnDelete(false)
            // ;

            HasOptional(s => s.Requisite)
             .WithMany(l => l.Requests)
             .HasForeignKey(s => s.RequisiteId)
             .WillCascadeOnDelete(false)
             ;
            ToTable($"{tableName}");
        }
    }
}