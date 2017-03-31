namespace EPM.Wallet.Data.SqlServer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class V21 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DirectDebits",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        SourceAccountId = c.Guid(nullable: false),
                        CardId = c.Guid(nullable: false),
                        CurrencyId = c.String(nullable: false, maxLength: 10),
                        DebitFromOtherIfIncefitient = c.Boolean(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        UpdatedAt = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        UpdatedBy = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cards", t => t.CardId)
                .ForeignKey("dbo.Currencies", t => t.CurrencyId)
                .ForeignKey("dbo.ClientAccounts", t => t.SourceAccountId)
                .Index(t => t.SourceAccountId)
                .Index(t => t.CardId)
                .Index(t => t.CurrencyId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DirectDebits", "SourceAccountId", "dbo.ClientAccounts");
            DropForeignKey("dbo.DirectDebits", "CurrencyId", "dbo.Currencies");
            DropForeignKey("dbo.DirectDebits", "CardId", "dbo.Cards");
            DropIndex("dbo.DirectDebits", new[] { "CurrencyId" });
            DropIndex("dbo.DirectDebits", new[] { "CardId" });
            DropIndex("dbo.DirectDebits", new[] { "SourceAccountId" });
            DropTable("dbo.DirectDebits");
        }
    }
}
