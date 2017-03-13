namespace EPM.Wallet.Data.SqlServer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class V9 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ClientStatements",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        ClientId = c.String(nullable: false, maxLength: 10),
                        AccountId = c.Guid(),
                        CardId = c.Guid(),
                        ValueDate = c.DateTimeOffset(nullable: false, precision: 7),
                        Period = c.String(maxLength: 128),
                        PreviousBalance = c.Decimal(nullable: false, precision: 18, scale: 3),
                        Credits = c.Decimal(nullable: false, precision: 18, scale: 3),
                        Debits = c.Decimal(nullable: false, precision: 18, scale: 3),
                        NewBalance = c.Decimal(nullable: false, precision: 18, scale: 3),
                        Content = c.Binary(),
                        LoadedFrom = c.String(maxLength: 512),
                        CreatedAt = c.DateTime(nullable: false),
                        UpdatedAt = c.DateTime(nullable: false),
                        CreatedBy = c.String(maxLength: 10),
                        UpdatedBy = c.String(maxLength: 10),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cards", t => t.CardId)
                .ForeignKey("dbo.Clients", t => t.ClientId)
                .ForeignKey("dbo.ClientAccounts", t => t.AccountId)
                .Index(t => t.ClientId)
                .Index(t => t.AccountId)
                .Index(t => t.CardId);
            
            AlterColumn("dbo.ClientAccounts", "CurrentBalance", c => c.Decimal(nullable: false, precision: 18, scale: 3));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ClientStatements", "AccountId", "dbo.ClientAccounts");
            DropForeignKey("dbo.ClientStatements", "ClientId", "dbo.Clients");
            DropForeignKey("dbo.ClientStatements", "CardId", "dbo.Cards");
            DropIndex("dbo.ClientStatements", new[] { "CardId" });
            DropIndex("dbo.ClientStatements", new[] { "AccountId" });
            DropIndex("dbo.ClientStatements", new[] { "ClientId" });
            AlterColumn("dbo.ClientAccounts", "CurrentBalance", c => c.Decimal(nullable: false, precision: 18, scale: 9));
            DropTable("dbo.ClientStatements");
        }
    }
}
