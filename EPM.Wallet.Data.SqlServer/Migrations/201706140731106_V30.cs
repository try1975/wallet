namespace EPM.Wallet.Data.SqlServer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class V30 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.StandingOrders", "LastRequestDate", c => c.DateTime());
            AddColumn("dbo.StandingOrders", "NextRequestDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.StandingOrders", "NextRequestDate");
            DropColumn("dbo.StandingOrders", "LastRequestDate");
        }
    }
}
