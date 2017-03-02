namespace EPM.Wallet.Data.SqlServer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class V03 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ClientAccounts", "RequisiteId", c => c.Guid());
            CreateIndex("dbo.ClientAccounts", "RequisiteId");
            AddForeignKey("dbo.ClientAccounts", "RequisiteId", "dbo.Requisites", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ClientAccounts", "RequisiteId", "dbo.Requisites");
            DropIndex("dbo.ClientAccounts", new[] { "RequisiteId" });
            DropColumn("dbo.ClientAccounts", "RequisiteId");
        }
    }
}
