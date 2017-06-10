namespace EPM.Wallet.Data.SqlServer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class V028 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.BankAccounts", "BeneficiaryAddress", c => c.String(maxLength: 128));
            AddColumn("dbo.Banks", "BankAddress", c => c.String(maxLength: 128));
            AddColumn("dbo.Banks", "Bic", c => c.String(maxLength: 128));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Banks", "Bic");
            DropColumn("dbo.Banks", "BankAddress");
            DropColumn("dbo.BankAccounts", "BeneficiaryAddress");
        }
    }
}
