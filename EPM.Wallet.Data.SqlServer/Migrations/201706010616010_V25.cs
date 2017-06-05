namespace EPM.Wallet.Data.SqlServer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class V25 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cards", "CardStatus", c => c.Int(nullable: false));
            DropColumn("dbo.Cards", "IsInactive");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Cards", "IsInactive", c => c.Boolean(nullable: false));
            DropColumn("dbo.Cards", "CardStatus");
        }
    }
}
