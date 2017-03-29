namespace EPM.Wallet.Data.SqlServer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class V20 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ClientStatements", "ClientId", "dbo.Clients");
            DropIndex("dbo.ClientStatements", new[] { "ClientId" });
            DropColumn("dbo.ClientStatements", "ClientId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ClientStatements", "ClientId", c => c.String(nullable: false, maxLength: 10));
            CreateIndex("dbo.ClientStatements", "ClientId");
            AddForeignKey("dbo.ClientStatements", "ClientId", "dbo.Clients", "Id");
        }
    }
}
