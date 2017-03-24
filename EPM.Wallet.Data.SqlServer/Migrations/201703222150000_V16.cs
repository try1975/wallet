namespace EPM.Wallet.Data.SqlServer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class V16 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Transactions", "AmountInCurrency", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("dbo.Transactions", "AmountCurrency");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Transactions", "AmountCurrency", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("dbo.Transactions", "AmountInCurrency");
        }
    }
}
