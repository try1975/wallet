namespace EPM.Wallet.Data.SqlServer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class V23 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Transactions", "RegisterDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Transactions", "ValueDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.ClientStatements", "ValueDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ClientStatements", "ValueDate", c => c.DateTimeOffset(nullable: false, precision: 7));
            AlterColumn("dbo.Transactions", "ValueDate", c => c.DateTimeOffset(nullable: false, precision: 7));
            AlterColumn("dbo.Transactions", "RegisterDate", c => c.DateTimeOffset(nullable: false, precision: 7));
        }
    }
}
