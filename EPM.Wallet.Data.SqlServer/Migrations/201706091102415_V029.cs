namespace EPM.Wallet.Data.SqlServer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class V029 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Requisites", "BeneficiaryAddress", c => c.String(maxLength: 128));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Requisites", "BeneficiaryAddress");
        }
    }
}
