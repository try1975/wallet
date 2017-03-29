namespace EPM.Wallet.Data.SqlServer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class V18 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ClientAccounts", "InitialBalance", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Transactions", "Sequence", c => c.Int(nullable: false, identity: true));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Transactions", "Sequence");
            DropColumn("dbo.ClientAccounts", "InitialBalance");
        }
    }
}
