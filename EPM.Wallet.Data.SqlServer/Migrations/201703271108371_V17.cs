namespace EPM.Wallet.Data.SqlServer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class V17 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.StandingOrders", "Name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.StandingOrders", "Name", c => c.String(nullable: false, maxLength: 250));
        }
    }
}
