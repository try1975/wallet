namespace Wallet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v001 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BankAccounts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Bank_Id = c.Int(),
                        Currency_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Banks", t => t.Bank_Id)
                .ForeignKey("dbo.Currencies", t => t.Currency_Id)
                .Index(t => t.Bank_Id)
                .Index(t => t.Currency_Id);
            
            CreateTable(
                "dbo.Banks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Currencies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ClientAccounts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        BankAccount_Id = c.Int(),
                        Client_Id = c.Int(),
                        Currency_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.BankAccounts", t => t.BankAccount_Id)
                .ForeignKey("dbo.Clients", t => t.Client_Id)
                .ForeignKey("dbo.Currencies", t => t.Currency_Id)
                .Index(t => t.BankAccount_Id)
                .Index(t => t.Client_Id)
                .Index(t => t.Currency_Id);
            
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ClientAccountStatusDictionaries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ClientAccountStatus",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CreatedAt = c.DateTime(nullable: false),
                        CreatedBy = c.Guid(nullable: false),
                        ClientAccount_Id = c.Int(),
                        ClientAccountStatusDictionary_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ClientAccounts", t => t.ClientAccount_Id)
                .ForeignKey("dbo.ClientAccountStatusDictionaries", t => t.ClientAccountStatusDictionary_Id)
                .Index(t => t.ClientAccount_Id)
                .Index(t => t.ClientAccountStatusDictionary_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ClientAccountStatus", "ClientAccountStatusDictionary_Id", "dbo.ClientAccountStatusDictionaries");
            DropForeignKey("dbo.ClientAccountStatus", "ClientAccount_Id", "dbo.ClientAccounts");
            DropForeignKey("dbo.ClientAccounts", "Currency_Id", "dbo.Currencies");
            DropForeignKey("dbo.ClientAccounts", "Client_Id", "dbo.Clients");
            DropForeignKey("dbo.ClientAccounts", "BankAccount_Id", "dbo.BankAccounts");
            DropForeignKey("dbo.BankAccounts", "Currency_Id", "dbo.Currencies");
            DropForeignKey("dbo.BankAccounts", "Bank_Id", "dbo.Banks");
            DropIndex("dbo.ClientAccountStatus", new[] { "ClientAccountStatusDictionary_Id" });
            DropIndex("dbo.ClientAccountStatus", new[] { "ClientAccount_Id" });
            DropIndex("dbo.ClientAccounts", new[] { "Currency_Id" });
            DropIndex("dbo.ClientAccounts", new[] { "Client_Id" });
            DropIndex("dbo.ClientAccounts", new[] { "BankAccount_Id" });
            DropIndex("dbo.BankAccounts", new[] { "Currency_Id" });
            DropIndex("dbo.BankAccounts", new[] { "Bank_Id" });
            DropTable("dbo.ClientAccountStatus");
            DropTable("dbo.ClientAccountStatusDictionaries");
            DropTable("dbo.Clients");
            DropTable("dbo.ClientAccounts");
            DropTable("dbo.Currencies");
            DropTable("dbo.Banks");
            DropTable("dbo.BankAccounts");
        }
    }
}
