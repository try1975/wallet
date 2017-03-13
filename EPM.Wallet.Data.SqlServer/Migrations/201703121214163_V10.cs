namespace EPM.Wallet.Data.SqlServer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class V10 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ClientAccounts", "StatementId", c => c.Guid());
            CreateIndex("dbo.ClientAccounts", "StatementId");
            AddForeignKey("dbo.ClientAccounts", "StatementId", "dbo.ClientStatements", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ClientAccounts", "StatementId", "dbo.ClientStatements");
            DropIndex("dbo.ClientAccounts", new[] { "StatementId" });
            DropColumn("dbo.ClientAccounts", "StatementId");
        }
    }
}
