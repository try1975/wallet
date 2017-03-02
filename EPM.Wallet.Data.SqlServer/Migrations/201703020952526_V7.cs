namespace EPM.Wallet.Data.SqlServer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class V7 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Messages", "Subject", c => c.String(maxLength: 250));
            AlterColumn("dbo.Messages", "Body", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Messages", "Body", c => c.String(nullable: false, maxLength: 250));
            AlterColumn("dbo.Messages", "Subject", c => c.String(maxLength: 128));
        }
    }
}
