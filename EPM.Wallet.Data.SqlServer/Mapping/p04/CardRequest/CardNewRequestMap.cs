using System.Data.Entity.ModelConfiguration;
using EPM.Wallet.Data.Entities;

namespace EPM.Wallet.Data.SqlServer.Mapping
{
    public class CardNewRequestMap : EntityTypeConfiguration<CardNewRequestEntity>
    {
        public CardNewRequestMap(string tableName)
        {
            ToTable($"{tableName}");
        }
    }
}