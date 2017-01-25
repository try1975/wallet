using Wallet.Models.Entities;
using Wallet.Models.Mappings;


namespace Wallet.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public partial class WalletModel : DbContext
    {
        // Your context has been configured to use a 'WalletModel' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Wallet.Models.WalletModel' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'WalletModel' 
        // connection string in the application configuration file.
        public WalletModel()
            : base("name=WalletModel")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<WCurrency> Currencies { get; set; }
        public virtual DbSet<ClientAccountStatusDictionary> ClientAccountStatusDictionaries { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Bank> Banks { get; set; }
        public virtual DbSet<BankAccount> BankAccounts { get; set; }
        public virtual DbSet<ClientAccount> ClientAccounts { get; set; }
        public virtual DbSet<ClientAccountStatus> ClientAccountStatuses { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CurrencyMapping("Currencies"));
        }

    }
}