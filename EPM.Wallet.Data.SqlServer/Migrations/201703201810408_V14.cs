namespace EPM.Wallet.Data.SqlServer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class V14 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ClientAccounts", "ClientAccountStatusId", "dbo.ClientAccountStatuses");
            DropIndex("dbo.ClientAccounts", new[] { "ClientAccountStatusId" });
            AddColumn("dbo.ClientAccounts", "ClientAccountStatus", c => c.Int(nullable: false));
            DropColumn("dbo.ClientAccounts", "ClientAccountStatusId");
            DropTable("dbo.ClientAccountStatuses");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.ClientAccountStatuses",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 10),
                        Name = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.ClientAccounts", "ClientAccountStatusId", c => c.String(nullable: false, maxLength: 10));
            DropColumn("dbo.ClientAccounts", "ClientAccountStatus");
            CreateIndex("dbo.ClientAccounts", "ClientAccountStatusId");
            AddForeignKey("dbo.ClientAccounts", "ClientAccountStatusId", "dbo.ClientAccountStatuses", "Id");
        }
    }
}
