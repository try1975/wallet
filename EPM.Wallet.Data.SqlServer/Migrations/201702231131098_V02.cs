namespace EPM.Wallet.Data.SqlServer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class V02 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Requests", "CardReissueType", c => c.Int());
            AddColumn("dbo.Requests", "CardReissueReason", c => c.String(maxLength: 128));
            AddColumn("dbo.Requisites", "BankAddress", c => c.String(maxLength: 128));
            AddColumn("dbo.Requisites", "Bic", c => c.String(maxLength: 128));
            AddColumn("dbo.Requisites", "OwnerName", c => c.String(maxLength: 128));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Requisites", "OwnerName");
            DropColumn("dbo.Requisites", "Bic");
            DropColumn("dbo.Requisites", "BankAddress");
            DropColumn("dbo.Requests", "CardReissueReason");
            DropColumn("dbo.Requests", "CardReissueType");
        }
    }
}
