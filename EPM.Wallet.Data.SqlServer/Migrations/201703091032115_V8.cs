namespace EPM.Wallet.Data.SqlServer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class V8 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Requests", "Note", c => c.String());
            AddColumn("dbo.Requests", "ValueDate", c => c.DateTime());
            AlterColumn("dbo.Requisites", "Name", c => c.String(nullable: false, maxLength: 400));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Requisites", "Name", c => c.String(nullable: false, maxLength: 128));
            DropColumn("dbo.Requests", "ValueDate");
            DropColumn("dbo.Requests", "Note");
        }
    }
}
