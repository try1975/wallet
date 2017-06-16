namespace EPM.Wallet.Data.SqlServer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class V33 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.StandingOrders", "IsInactive", c => c.Boolean(nullable: false));
            DropColumn("dbo.StandingOrders", "StandingOrderStatus");
        }
        
        public override void Down()
        {
            AddColumn("dbo.StandingOrders", "StandingOrderStatus", c => c.Int(nullable: false));
            DropColumn("dbo.StandingOrders", "IsInactive");
        }
    }
}
