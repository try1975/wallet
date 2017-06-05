namespace EPM.Wallet.Data.SqlServer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class V27 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Requests", "StandingOrderId", c => c.Guid());
            CreateIndex("dbo.Requests", "StandingOrderId");
            AddForeignKey("dbo.Requests", "StandingOrderId", "dbo.StandingOrders", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Requests", "StandingOrderId", "dbo.StandingOrders");
            DropIndex("dbo.Requests", new[] { "StandingOrderId" });
            DropColumn("dbo.Requests", "StandingOrderId");
        }
    }
}
