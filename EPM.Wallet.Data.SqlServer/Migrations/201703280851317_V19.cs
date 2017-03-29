namespace EPM.Wallet.Data.SqlServer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class V19 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Transactions", "Sequence");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Transactions", "Sequence", c => c.Int(nullable: false, identity: true));
        }
    }
}
