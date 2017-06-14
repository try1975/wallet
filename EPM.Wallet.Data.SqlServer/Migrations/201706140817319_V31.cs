namespace EPM.Wallet.Data.SqlServer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class V31 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.StandingOrders", "StandingOrderStatus", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.StandingOrders", "StandingOrderStatus");
        }
    }
}
