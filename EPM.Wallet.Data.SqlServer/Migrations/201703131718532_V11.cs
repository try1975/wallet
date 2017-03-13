namespace EPM.Wallet.Data.SqlServer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class V11 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Requests", "AmountIn", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.Requests", "AmountOut", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.ClientAccounts", "CurrentBalance", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.ClientStatements", "PreviousBalance", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.ClientStatements", "Credits", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.ClientStatements", "Debits", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.ClientStatements", "NewBalance", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ClientStatements", "NewBalance", c => c.Decimal(nullable: false, precision: 18, scale: 3));
            AlterColumn("dbo.ClientStatements", "Debits", c => c.Decimal(nullable: false, precision: 18, scale: 3));
            AlterColumn("dbo.ClientStatements", "Credits", c => c.Decimal(nullable: false, precision: 18, scale: 3));
            AlterColumn("dbo.ClientStatements", "PreviousBalance", c => c.Decimal(nullable: false, precision: 18, scale: 3));
            AlterColumn("dbo.ClientAccounts", "CurrentBalance", c => c.Decimal(nullable: false, precision: 18, scale: 3));
            AlterColumn("dbo.Requests", "AmountOut", c => c.Decimal(precision: 18, scale: 3));
            AlterColumn("dbo.Requests", "AmountIn", c => c.Decimal(precision: 18, scale: 3));
        }
    }
}
