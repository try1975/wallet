namespace EPM.Wallet.Data.SqlServer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class V15 : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Cards", new[] { "CardNumber" });
            CreateTable(
                "dbo.Transactions",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        AccountId = c.Guid(nullable: false),
                        RegisterDate = c.DateTimeOffset(nullable: false, precision: 7),
                        ValueDate = c.DateTimeOffset(nullable: false, precision: 7),
                        Amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CurrencyId = c.String(nullable: false, maxLength: 10),
                        AmountCurrency = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Balance = c.Decimal(nullable: false, precision: 18, scale: 2),
                        FromTo = c.String(nullable: false, maxLength: 512),
                        Note = c.String(),
                        RequestId = c.Guid(),
                        StandingOrderId = c.Guid(),
                        CreatedAt = c.DateTime(nullable: false),
                        UpdatedAt = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        UpdatedBy = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ClientAccounts", t => t.AccountId)
                .ForeignKey("dbo.Currencies", t => t.CurrencyId)
                .ForeignKey("dbo.Requests", t => t.RequestId)
                .ForeignKey("dbo.StandingOrders", t => t.StandingOrderId)
                .Index(t => t.AccountId)
                .Index(t => t.CurrencyId)
                .Index(t => t.RequestId)
                .Index(t => t.StandingOrderId);
            
            CreateTable(
                "dbo.TransactionTypes",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 10),
                        IsPositive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Transactions", "StandingOrderId", "dbo.StandingOrders");
            DropForeignKey("dbo.Transactions", "RequestId", "dbo.Requests");
            DropForeignKey("dbo.Transactions", "CurrencyId", "dbo.Currencies");
            DropForeignKey("dbo.Transactions", "AccountId", "dbo.ClientAccounts");
            DropIndex("dbo.Transactions", new[] { "StandingOrderId" });
            DropIndex("dbo.Transactions", new[] { "RequestId" });
            DropIndex("dbo.Transactions", new[] { "CurrencyId" });
            DropIndex("dbo.Transactions", new[] { "AccountId" });
            DropTable("dbo.TransactionTypes");
            DropTable("dbo.Transactions");
            CreateIndex("dbo.Cards", "CardNumber", unique: true);
        }
    }
}
