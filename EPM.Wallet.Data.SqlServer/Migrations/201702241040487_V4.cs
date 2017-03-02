namespace EPM.Wallet.Data.SqlServer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class V4 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Requests", "AmountIn", c => c.Decimal(precision: 18, scale: 3));
            AlterColumn("dbo.Requests", "AmountOut", c => c.Decimal(precision: 18, scale: 3));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Requests", "AmountOut", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.Requests", "AmountIn", c => c.Decimal(precision: 18, scale: 2));
        }
    }
}
