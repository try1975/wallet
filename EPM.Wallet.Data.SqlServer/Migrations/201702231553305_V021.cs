namespace EPM.Wallet.Data.SqlServer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class V021 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Requests", "CurrencyId", c => c.String(maxLength: 10));
            CreateIndex("dbo.Requests", "CurrencyId");
            AddForeignKey("dbo.Requests", "CurrencyId", "dbo.Currencies", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Requests", "CurrencyId", "dbo.Currencies");
            DropIndex("dbo.Requests", new[] { "CurrencyId" });
            DropColumn("dbo.Requests", "CurrencyId");
        }
    }
}
