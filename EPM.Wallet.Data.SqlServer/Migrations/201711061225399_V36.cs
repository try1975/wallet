namespace EPM.Wallet.Data.SqlServer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class V36 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.DirectDebits", "Amount", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.DirectDebits", "Amount");
        }
    }
}
