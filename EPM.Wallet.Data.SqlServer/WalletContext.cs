using System.Data.Entity;
using EPM.Wallet.Data.Entities;
using EPM.Wallet.Data.SqlServer.Mapping;
using EPM.Wallet.Data.SqlServer.Migrations;
using Z.EntityFramework.Plus;

namespace EPM.Wallet.Data.SqlServer
{
    [DbConfigurationType(typeof(ConfigContext))]
    public sealed class WalletContext : DbContext
    {
        static WalletContext()
        {
            AuditManager.DefaultConfiguration.AutoSavePreAction = (context, audit) =>
                // ADD "Where(x => x.AuditEntryID == 0)" to allow multiple SaveChanges with same Audit
                ((WalletContext)context).AuditEntries.AddRange(audit.Entries);
        }

        public WalletContext(): base("name=WalletModel")
        {
            Database.Log += s => System.Diagnostics.Debug.WriteLine(s);
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        #region DbSets

        private DbSet<CurrencyEntity> Currencies { get; set; }
        private DbSet<ClientEntity> Clients { get; set; }
        private DbSet<BankEntity> Banks { get; set; }
        private DbSet<BankAccountEntity> BankAccounts { get; set; }
        private DbSet<ClientAccountEntity> ClientAccounts { get; set; }
        private DbSet<CardEntity> Cards { get; set; }
        private DbSet<RequisiteEntity> Requisites { get; set; }
        private DbSet<MessageEntity> Messages { get; set; }
        private DbSet<StandingOrderEntity> StandingOrders { get; set; }
        private DbSet<RequestEntity> Requests { get; set; }
        private DbSet<AccountRequestEntity> AccountRequests { get; set; }
        //private DbSet<CardLimitRequestEntity> CardLimitRequests { get; set; }
        //private DbSet<CardReissueRequestEntity> CardReissueRequests { get; set; }
        //private DbSet<CardBlockRequestEntity> CardBlockRequests { get; set; }
        //private DbSet<CardNewRequestEntity> CardNewRequests { get; set; }
        private DbSet<StatementEntity> Statements { get; set; }
        private DbSet<TransactionTypeEntity> TransactionTypes { get; set; }
        private DbSet<TransactionEntity> Transactions { get; set; }
        private DbSet<DirectDebitEntity> DirectDebits { get; set; }

        public DbSet<AuditEntry> AuditEntries { get; set; }
        public DbSet<AuditEntryProperty> AuditEntryProperties { get; set; }

        #endregion



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            const string prefix = "";
            modelBuilder.Configurations.Add(new CurrencyMap($"{prefix}{nameof(Currencies)}"));
            modelBuilder.Configurations.Add(new ClientMap($"{prefix}{nameof(Clients)}"));
            modelBuilder.Configurations.Add(new BankMap($"{prefix}{nameof(Banks)}"));
            modelBuilder.Configurations.Add(new BankAccountMap($"{prefix}{nameof(BankAccounts)}"));
            modelBuilder.Configurations.Add(new ClientAccountMap($"{prefix}{nameof(ClientAccounts)}"));
            modelBuilder.Configurations.Add(new CardMap($"{prefix}{nameof(Cards)}"));
            modelBuilder.Configurations.Add(new RequisiteMap($"{prefix}{nameof(Requisites)}"));
            modelBuilder.Configurations.Add(new MessageMap($"{prefix}{nameof(Messages)}"));
            modelBuilder.Configurations.Add(new StandingOrderMap($"{prefix}{nameof(StandingOrders)}"));

            modelBuilder.Configurations.Add(new RequestMap($"{prefix}{nameof(Requests)}"));

            modelBuilder.Configurations.Add(new CardRequestMap($"{prefix}{nameof(Requests)}"));
            //modelBuilder.Configurations.Add(new CardLimitRequestMap($"{prefix}{nameof(Requests)}"));
            //modelBuilder.Configurations.Add(new CardReissueRequestMap($"{prefix}{nameof(Requests)}"));
            //modelBuilder.Configurations.Add(new CardBlockRequestMap($"{prefix}{nameof(Requests)}"));
            //modelBuilder.Configurations.Add(new CardNewRequestMap($"{prefix}{nameof(Requests)}"));

            modelBuilder.Configurations.Add(new AccountRequestMap($"{prefix}{nameof(Requests)}"));
            modelBuilder.Configurations.Add(new StatementsMap($"{prefix}Client{nameof(Statements)}"));
            modelBuilder.Configurations.Add(new TransactionTypesMap($"{prefix}{nameof(TransactionTypes)}"));
            modelBuilder.Configurations.Add(new TransactionsMap($"{prefix}{nameof(Transactions)}"));
            modelBuilder.Configurations.Add(new DirectDebitsMap($"{prefix}{nameof(DirectDebits)}"));
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
