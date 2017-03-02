using System.Data.Entity;
using System.Net.Configuration;
using EPM.Wallet.Data.Entities;
using EPM.Wallet.Data.SqlServer.Mapping;
using EPM.Wallet.Data.SqlServer.Migrations;

namespace EPM.Wallet.Data.SqlServer
{
    [DbConfigurationType(typeof(ConfigContext))]
    public sealed class WalletContext : DbContext
    {
        public WalletContext(): base("name=WalletModel")
        {
            Database.Log += s => System.Diagnostics.Debug.WriteLine(s);
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        #region DbSets

        public DbSet<CurrencyEntity> Currencies { get; set; }
        public DbSet<ClientEntity> Clients { get; set; }
        public DbSet<BankEntity> Banks { get; set; }
        public DbSet<BankAccountEntity> BankAccounts { get; set; }
        public DbSet<ClientAccountStatusEntity> ClientAccountStatuses { get; set; }
        public DbSet<ClientAccountEntity> ClientAccounts { get; set; }
        public DbSet<CardEntity> Cards { get; set; }
        public DbSet<RequisiteEntity> Requisites { get; set; }
        public DbSet<MessageEntity> Messages { get; set; }
        public DbSet<StandingOrderEntity> StandingOrders { get; set; }
        public DbSet<RequestEntity> Requests { get; set; }
        public DbSet<AccountRequestEntity> AccountRequests { get; set; }
        public DbSet<CardLimitRequestEntity> CardLimitRequests { get; set; }
        public DbSet<CardReissueRequestEntity> CardReissueRequests { get; set; }
        public DbSet<CardBlockRequestEntity> CardBlockRequests { get; set; }
        public DbSet<CardNewRequestEntity> CardNewRequests { get; set; }

        #endregion



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            var prefix = "";
            modelBuilder.Configurations.Add(new CurrencyMap($"{prefix}{nameof(Currencies)}"));
            modelBuilder.Configurations.Add(new ClientMap($"{prefix}{nameof(Clients)}"));
            modelBuilder.Configurations.Add(new BankMap($"{prefix}{nameof(Banks)}"));
            modelBuilder.Configurations.Add(new BankAccountMap($"{prefix}{nameof(BankAccounts)}"));
            modelBuilder.Configurations.Add(new ClientAccountStatusMap($"{prefix}{nameof(ClientAccountStatuses)}"));
            modelBuilder.Configurations.Add(new ClientAccountMap($"{prefix}{nameof(ClientAccounts)}"));
            modelBuilder.Configurations.Add(new CardMap($"{prefix}{nameof(Cards)}"));
            modelBuilder.Configurations.Add(new RequisiteMap($"{prefix}{nameof(Requisites)}"));
            modelBuilder.Configurations.Add(new MessageMap($"{prefix}{nameof(Messages)}"));
            modelBuilder.Configurations.Add(new StandingOrderMap($"{prefix}{nameof(StandingOrders)}"));

            modelBuilder.Configurations.Add(new RequestMap($"{prefix}{nameof(Requests)}"));

            modelBuilder.Configurations.Add(new CardRequestMap($"{prefix}{nameof(Requests)}"));
            modelBuilder.Configurations.Add(new CardLimitRequestMap($"{prefix}{nameof(Requests)}"));
            modelBuilder.Configurations.Add(new CardReissueRequestMap($"{prefix}{nameof(Requests)}"));
            modelBuilder.Configurations.Add(new CardBlockRequestMap($"{prefix}{nameof(Requests)}"));
            modelBuilder.Configurations.Add(new CardNewRequestMap($"{prefix}{nameof(Requests)}"));

            modelBuilder.Configurations.Add(new AccountRequestMap($"{prefix}{nameof(Requests)}"));
        }
    }

    public class ConfigContext : DbConfiguration
    {
        public ConfigContext()
        {
            //SetDefaultConnectionFactory(new System.Data.Entity.Infrastructure.LocalDbConnectionFactory("v11.0"));
            //SetDefaultConnectionFactory(new System.Data.Entity.Infrastructure.SqlConnectionFactory("WalletModel"));
            //SetProviderServices("System.Data.SqlClient", System.Data.Entity.SqlServer.SqlProviderServices.Instance);

            //SetDatabaseInitializer(new CreateDatabaseIfNotExists<WalletContext>());
            SetDatabaseInitializer(new MigrateDatabaseToLatestVersion<WalletContext, Configuration>());
            
        }
    }
}
