namespace EPM.Wallet.Data.SqlServer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class V26 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Transactions", "RegisterDate", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Transactions", "RegisterDate", c => c.DateTime(nullable: false));
        }
    }
}
