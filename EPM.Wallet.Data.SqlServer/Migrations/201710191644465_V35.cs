namespace EPM.Wallet.Data.SqlServer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class V35 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ClientAccounts", "Reference", c => c.String(maxLength: 250));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ClientAccounts", "Reference");
        }
    }
}
