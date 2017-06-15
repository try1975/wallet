namespace EPM.Wallet.Data.SqlServer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class V32 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.StandingOrders", "LastRequestDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.StandingOrders", "LastRequestDate", c => c.DateTime());
        }
    }
}
