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
            Bind<IDataMаnager>().To<DataMаnager>().InSingletonScope();
            Bind<IWalletControl>().To<WalletControl>().InSingletonScope();

            Bind<IBankView>().To<BankControl>();
            Bind<IBankDataMаnager>().To<BankDataMаnager>().InSingletonScope();

            Bind<IBankAccountView>().To<BankAccountControl>();
            Bind<IBankAccountDataManager>().To<BankAccountDataManager>().InSingletonScope();

            Bind<IClientView>().To<ClientControl>();
            Bind<IClientDataManager>().To<ClientDataManager>().InSingletonScope();

            Bind<IClientAccountView>().To<ClientAccountControl>();
            Bind<IClientAccountDataManager>().To<ClientAccountDataManager>().InSingletonScope();

            Bind<ICardView>().To<CardControl>();
            Bind<ICardDataMаnager>().To<CardDataMаnager>().InSingletonScope();

            Bind<IRequestView>().To<RequestControl>();
            Bind<IRequestDataManager>().To<RequestDataManager>().InSingletonScope();

            Bind<IMessageView>().To<MessageControl>();
            Bind<IMessageDataManager>().To<MessageDataManager>().InSingletonScope();


            Bind<ITransferOutInfoView>().To<TransferOutInfoControl>();
            Bind<ITransferOutInfoDataManager>().To<TransferOutInfoDataManager>().InSingletonScope();

            Bind<ITransactionView>().To<TransactionControl>();
            Bind<ITransactionDataManager>().To<TransactionDataManager>().InSingletonScope();
        }
    }
}