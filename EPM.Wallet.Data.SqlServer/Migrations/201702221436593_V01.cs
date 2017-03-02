namespace EPM.Wallet.Data.SqlServer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class V01 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Requests",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        ClientId = c.String(nullable: false, maxLength: 10),
                        RequestType = c.Int(nullable: false),
                        RequestStatus = c.Int(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        UpdatedAt = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        UpdatedBy = c.String(),
                        ClientAccountId = c.Guid(),
                        AccountRequestType = c.Int(),
                        AmountIn = c.Decimal(precision: 18, scale: 2),
                        AmountOut = c.Decimal(precision: 18, scale: 2),
                        CardId = c.Guid(),
                        CardRequestType = c.Int(),
                        Limit = c.Int(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cards", t => t.CardId)
                .ForeignKey("dbo.Clients", t => t.ClientId)
                .ForeignKey("dbo.ClientAccounts", t => t.ClientAccountId)
                .Index(t => t.ClientId)
                .Index(t => t.ClientAccountId)
                .Index(t => t.CardId);
            
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 10),
                        Name = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Cards",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        Comment = c.String(maxLength: 250),
                        ClientId = c.String(nullable: false, maxLength: 10),
                        CurrencyId = c.String(maxLength: 10),
                        CardNumber = c.String(nullable: false, maxLength: 50),
                        CardHolder = c.String(nullable: false, maxLength: 50),
                        ExpMonth = c.Int(nullable: false),
                        ExpYear = c.Int(nullable: false),
                        Limit = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Cvc = c.String(maxLength: 10),
                        Pin = c.String(maxLength: 10),
                        Vendor = c.String(maxLength: 10),
                        IsInactive = c.Boolean(nullable: false),
                        MainCardId = c.Guid(),
                        CreatedAt = c.DateTime(nullable: false),
                        UpdatedAt = c.DateTime(nullable: false),
                        CreatedBy = c.String(maxLength: 10),
                        UpdatedBy = c.String(maxLength: 10),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clients", t => t.ClientId)
                .ForeignKey("dbo.Currencies", t => t.CurrencyId)
                .ForeignKey("dbo.Cards", t => t.MainCardId)
                .Index(t => t.ClientId)
                .Index(t => t.CurrencyId)
                .Index(t => t.CardNumber, unique: true)
                .Index(t => t.MainCardId);
            
            CreateTable(
                "dbo.Currencies",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 10),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.BankAccounts",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 250),
                        BankId = c.Guid(nullable: false),
                        CurrencyId = c.String(nullable: false, maxLength: 10),
                        CreatedAt = c.DateTime(nullable: false),
                        UpdatedAt = c.DateTime(nullable: false),
                        CreatedBy = c.String(maxLength: 10),
                        UpdatedBy = c.String(maxLength: 10),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Banks", t => t.BankId)
                .ForeignKey("dbo.Currencies", t => t.CurrencyId)
                .Index(t => t.BankId)
                .Index(t => t.CurrencyId);
            
            CreateTable(
                "dbo.Banks",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true);
            
            CreateTable(
                "dbo.ClientAccounts",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 250),
                        Comment = c.String(maxLength: 250),
                        CurrencyId = c.String(nullable: false, maxLength: 10),
                        ClientId = c.String(nullable: false, maxLength: 10),
                        BankAccountId = c.Guid(nullable: false),
                        ClientAccountStatusId = c.String(nullable: false, maxLength: 10),
                        CurrentBalance = c.Decimal(nullable: false, precision: 18, scale: 9),
                        CreatedAt = c.DateTime(nullable: false),
                        UpdatedAt = c.DateTime(nullable: false),
                        CreatedBy = c.String(maxLength: 10),
                        UpdatedBy = c.String(maxLength: 10),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.BankAccounts", t => t.BankAccountId)
                .ForeignKey("dbo.Clients", t => t.ClientId)
                .ForeignKey("dbo.ClientAccountStatuses", t => t.ClientAccountStatusId)
                .ForeignKey("dbo.Currencies", t => t.CurrencyId)
                .Index(t => t.CurrencyId)
                .Index(t => t.ClientId)
                .Index(t => t.BankAccountId)
                .Index(t => t.ClientAccountStatusId);
            
            CreateTable(
                "dbo.ClientAccountStatuses",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 10),
                        Name = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Messages",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        Subject = c.String(maxLength: 128),
                        Body = c.String(nullable: false, maxLength: 250),
                        ClientId = c.String(nullable: false, maxLength: 10),
                        ReadDate = c.DateTime(),
                        DeletionDate = c.DateTime(),
                        IsOutgoing = c.Boolean(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        UpdatedAt = c.DateTime(nullable: false),
                        CreatedBy = c.String(maxLength: 10),
                        UpdatedBy = c.String(maxLength: 10),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clients", t => t.ClientId)
                .Index(t => t.ClientId);
            
            CreateTable(
                "dbo.Requisites",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 128),
                        ClientId = c.String(nullable: false, maxLength: 10),
                        BankName = c.String(maxLength: 128),
                        Iban = c.String(maxLength: 128),
                        IsVisible = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clients", t => t.ClientId)
                .Index(t => t.ClientId);
            
            CreateTable(
                "dbo.StandingOrders",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        Name = c.String(),
                        ClientAccountId = c.Guid(nullable: false),
                        BeneficiaryAccount = c.String(),
                        BeneficiaryNumber = c.String(),
                        Amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CurrencyId = c.String(maxLength: 10),
                        FirstDate = c.DateTime(nullable: false),
                        LastDate = c.DateTime(nullable: false),
                        Frequency = c.String(),
                        ReferenceNumber = c.String(),
                        BeneficiaryBank = c.String(),
                        RemitterName = c.String(),
                        DebitDescription = c.String(),
                        CreditDescription = c.String(),
                        CreatedAt = c.DateTime(nullable: false),
                        UpdatedAt = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        UpdatedBy = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ClientAccounts", t => t.ClientAccountId, cascadeDelete: true)
                .ForeignKey("dbo.Currencies", t => t.CurrencyId)
                .Index(t => t.ClientAccountId)
                .Index(t => t.CurrencyId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.StandingOrders", "CurrencyId", "dbo.Currencies");
            DropForeignKey("dbo.StandingOrders", "ClientAccountId", "dbo.ClientAccounts");
            DropForeignKey("dbo.Requests", "ClientAccountId", "dbo.ClientAccounts");
            DropForeignKey("dbo.Requisites", "ClientId", "dbo.Clients");
            DropForeignKey("dbo.Requests", "ClientId", "dbo.Clients");
            DropForeignKey("dbo.Messages", "ClientId", "dbo.Clients");
            DropForeignKey("dbo.Requests", "CardId", "dbo.Cards");
            DropForeignKey("dbo.Cards", "MainCardId", "dbo.Cards");
            DropForeignKey("dbo.Cards", "CurrencyId", "dbo.Currencies");
            DropForeignKey("dbo.BankAccounts", "CurrencyId", "dbo.Currencies");
            DropForeignKey("dbo.ClientAccounts", "CurrencyId", "dbo.Currencies");
            DropForeignKey("dbo.ClientAccounts", "ClientAccountStatusId", "dbo.ClientAccountStatuses");
            DropForeignKey("dbo.ClientAccounts", "ClientId", "dbo.Clients");
            DropForeignKey("dbo.ClientAccounts", "BankAccountId", "dbo.BankAccounts");
            DropForeignKey("dbo.BankAccounts", "BankId", "dbo.Banks");
            DropForeignKey("dbo.Cards", "ClientId", "dbo.Clients");
            DropIndex("dbo.StandingOrders", new[] { "CurrencyId" });
            DropIndex("dbo.StandingOrders", new[] { "ClientAccountId" });
            DropIndex("dbo.Requisites", new[] { "ClientId" });
            DropIndex("dbo.Messages", new[] { "ClientId" });
            DropIndex("dbo.ClientAccounts", new[] { "ClientAccountStatusId" });
            DropIndex("dbo.ClientAccounts", new[] { "BankAccountId" });
            DropIndex("dbo.ClientAccounts", new[] { "ClientId" });
            DropIndex("dbo.ClientAccounts", new[] { "CurrencyId" });
            DropIndex("dbo.Banks", new[] { "Name" });
            DropIndex("dbo.BankAccounts", new[] { "CurrencyId" });
            DropIndex("dbo.BankAccounts", new[] { "BankId" });
            DropIndex("dbo.Cards", new[] { "MainCardId" });
            DropIndex("dbo.Cards", new[] { "CardNumber" });
            DropIndex("dbo.Cards", new[] { "CurrencyId" });
            DropIndex("dbo.Cards", new[] { "ClientId" });
            DropIndex("dbo.Requests", new[] { "CardId" });
            DropIndex("dbo.Requests", new[] { "ClientAccountId" });
            DropIndex("dbo.Requests", new[] { "ClientId" });
            DropTable("dbo.StandingOrders");
            DropTable("dbo.Requisites");
            DropTable("dbo.Messages");
            DropTable("dbo.ClientAccountStatuses");
            DropTable("dbo.ClientAccounts");
            DropTable("dbo.Banks");
            DropTable("dbo.BankAccounts");
            DropTable("dbo.Currencies");
            DropTable("dbo.Cards");
            DropTable("dbo.Clients");
            DropTable("dbo.Requests");
        }
    }
}
