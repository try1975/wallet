namespace EPM.Wallet.Data.SqlServer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class V6 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Requests", "RequisiteId", c => c.Guid());
            CreateIndex("dbo.Requests", "RequisiteId");
            AddForeignKey("dbo.Requests", "RequisiteId", "dbo.Requisites", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Requests", "RequisiteId", "dbo.Requisites");
            DropIndex("dbo.Requests", new[] { "RequisiteId" });
            DropColumn("dbo.Requests", "RequisiteId");
        }
    }
}
