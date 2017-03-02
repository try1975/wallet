namespace EPM.Wallet.Data.SqlServer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class V5 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Requests", "BeneficiaryAccountId", c => c.Guid());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Requests", "BeneficiaryAccountId");
        }
    }
}
