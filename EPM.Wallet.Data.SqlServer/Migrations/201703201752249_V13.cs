namespace EPM.Wallet.Data.SqlServer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class V13 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.StandingOrders", "ClientAccountId", "dbo.ClientAccounts");
            DropIndex("dbo.StandingOrders", new[] { "CurrencyId" });
            AddColumn("dbo.StandingOrders", "Note", c => c.String());
            AddColumn("dbo.StandingOrders", "RequisiteId", c => c.Guid(nullable: false));
            AlterColumn("dbo.StandingOrders", "Name", c => c.String(nullable: false, maxLength: 250));
            AlterColumn("dbo.StandingOrders", "CurrencyId", c => c.String(nullable: false, maxLength: 10));
            AlterColumn("dbo.StandingOrders", "LastDate", c => c.DateTime());
            AlterColumn("dbo.StandingOrders", "Frequency", c => c.Int(nullable: false));
            CreateIndex("dbo.StandingOrders", "CurrencyId");
            CreateIndex("dbo.StandingOrders", "RequisiteId");
            AddForeignKey("dbo.StandingOrders", "RequisiteId", "dbo.Requisites", "Id");
            AddForeignKey("dbo.StandingOrders", "ClientAccountId", "dbo.ClientAccounts", "Id");
            DropColumn("dbo.StandingOrders", "BeneficiaryAccount");
            DropColumn("dbo.StandingOrders", "BeneficiaryNumber");
            DropColumn("dbo.StandingOrders", "ReferenceNumber");
            DropColumn("dbo.StandingOrders", "BeneficiaryBank");
            DropColumn("dbo.StandingOrders", "RemitterName");
            DropColumn("dbo.StandingOrders", "DebitDescription");
            DropColumn("dbo.StandingOrders", "CreditDescription");
        }
        
        public override void Down()
        {
            AddColumn("dbo.StandingOrders", "CreditDescription", c => c.String());
            AddColumn("dbo.StandingOrders", "DebitDescription", c => c.String());
            AddColumn("dbo.StandingOrders", "RemitterName", c => c.String());
            AddColumn("dbo.StandingOrders", "BeneficiaryBank", c => c.String());
            AddColumn("dbo.StandingOrders", "ReferenceNumber", c => c.String());
            AddColumn("dbo.StandingOrders", "BeneficiaryNumber", c => c.String());
            AddColumn("dbo.StandingOrders", "BeneficiaryAccount", c => c.String());
            DropForeignKey("dbo.StandingOrders", "ClientAccountId", "dbo.ClientAccounts");
            DropForeignKey("dbo.StandingOrders", "RequisiteId", "dbo.Requisites");
            DropIndex("dbo.StandingOrders", new[] { "RequisiteId" });
            DropIndex("dbo.StandingOrders", new[] { "CurrencyId" });
            AlterColumn("dbo.StandingOrders", "Frequency", c => c.String());
            AlterColumn("dbo.StandingOrders", "LastDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.StandingOrders", "CurrencyId", c => c.String(maxLength: 10));
            AlterColumn("dbo.StandingOrders", "Name", c => c.String());
            DropColumn("dbo.StandingOrders", "RequisiteId");
            DropColumn("dbo.StandingOrders", "Note");
            CreateIndex("dbo.StandingOrders", "CurrencyId");
            AddForeignKey("dbo.StandingOrders", "ClientAccountId", "dbo.ClientAccounts", "Id", cascadeDelete: true);
        }
    }
}
