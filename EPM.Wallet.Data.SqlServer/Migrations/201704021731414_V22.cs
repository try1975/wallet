namespace EPM.Wallet.Data.SqlServer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class V22 : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.ClientAccounts", "Name", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.ClientAccounts", new[] { "Name" });
        }
    }
}
