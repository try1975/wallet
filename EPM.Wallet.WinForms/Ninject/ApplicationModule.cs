using EPM.Wallet.WinForms.Controls;
using EPM.Wallet.WinForms.Data;
using EPM.Wallet.WinForms.Interfaces;
using Ninject.Modules;

namespace EPM.Wallet.WinForms.Ninject
{
    public class ApplicationModule : NinjectModule
    {
        public override void Load()
        {
            Bind(typeof(IDataMаnager)).To(typeof(DataMаnager));
            

            Bind(typeof(IWalletControl)).To(typeof(WalletControl));

            Bind<IBankView>().To<BankControl>().InSingletonScope();
            Bind<IBankDataMаnager>().To<BankDataMаnager>().InSingletonScope();


            Bind<IBankAccountView>().To<BankAccountControl>().InSingletonScope();
            Bind<IClientView>().To<ClientControl>().InSingletonScope();

            Bind<IClientAccountView>().To<ClientAccountControl>().InSingletonScope();
            Bind<IClientAccountDataManager>().To<ClientAccountDataManager>().InSingletonScope();

            Bind(typeof(ICardView)).To(typeof(CardControl));
            Bind(typeof(ICardDataMаnager)).To(typeof(CardDataMаnager));
        }
    }
}