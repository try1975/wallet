namespace EPM.Wallet.Data.SqlServer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class V24 : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Requests", "BeneficiaryAccountId");
            AddForeignKey("dbo.Requests", "BeneficiaryAccountId", "dbo.ClientAccounts", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Requests", "BeneficiaryAccountId", "dbo.ClientAccounts");
            DropIndex("dbo.Requests", new[] { "BeneficiaryAccountId" });
        }
    }
}
