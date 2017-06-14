using AutoMapper;
using AutoMapper.Configuration;
using EPM.Wallet.Data.QueryProcessors;
using EPM.Wallet.Data.SqlServer;
using EPM.Wallet.Data.SqlServer.QueryProcessors;
using Ninject;
using Ninject.Web.Common;
using WalletInternalApi.AutoMappers;
using WalletInternalApi.Maintenance;

namespace WalletInternalApi.Ninject
{
    /// <summary>
    ///     Class used to set up the Ninject DI container.
    /// </summary>
    public class Configurator
    {
        /// <summary>
        ///     Entry method used by caller to configure the given
        ///     container with all of this application's
        ///     dependencies.
        /// </summary>
        public void Configure(IKernel container)
        {
            AddBindings(container);
        }

        private void AddBindings(IKernel container)
        {
            ConfigureOrm(container);
            ConfigureAutoMapper(container);

            #region Api and Query

            container.Bind<ICurrencyApi>().To<CurrencyApi>().InRequestScope();
            container.Bind<ICurrencyQuery>().To<CurrencyQuery>().InRequestScope();

            container.Bind<IClientApi>().To<ClientApi>().InRequestScope();
            container.Bind<IClientQuery>().To<ClientQuery>().InRequestScope();

            container.Bind<IBankApi>().To<BankApi>().InRequestScope();
            container.Bind<IBankQuery>().To<BankQuery>().InRequestScope();

            container.Bind<IBankAccountApi>().To<BankAccountApi>().InRequestScope();
            container.Bind<IBankAccountQuery>().To<BankAccountQuery>().InRequestScope();

            container.Bind<IAccountApi>().To<AccountApi>().InRequestScope();
            container.Bind<IAccountQuery>().To<AccountQuery>().InRequestScope();

            container.Bind<ICardApi>().To<CardApi>().InRequestScope();
            container.Bind<ICardQuery>().To<CardQuery>().InRequestScope();

            container.Bind<IMessageApi>().To<MessageApi>().InRequestScope();
            container.Bind<IMessageQuery>().To<MessageQuery>().InRequestScope();

            container.Bind<IRequisiteApi>().To<RequisiteApi>().InRequestScope();
            container.Bind<IRequisiteQuery>().To<RequisiteQuery>().InRequestScope();

            container.Bind<IRequestApi>().To<RequestApi>().InRequestScope();
            container.Bind<IRequestQuery>().To<RequestQuery>().InRequestScope();

            container.Bind<IAccountRequestApi>().To<AccountRequestApi>().InRequestScope();
            container.Bind<IAccountRequestQuery>().To<AccountRequestQuery>().InRequestScope();

            container.Bind<ICardRequestQuery>().To<CardRequestQuery>().InRequestScope();

            container.Bind<ICardLimitRequestApi>().To<CardLimitRequestApi>().InRequestScope();


            container.Bind<ICardReissueRequestApi>().To<CardReissueRequestApi>().InRequestScope();


            container.Bind<ICardBlockRequestApi>().To<CardBlockRequestApi>().InRequestScope();


            container.Bind<ICardNewRequestApi>().To<CardNewRequestApi>().InRequestScope();


            container.Bind<IStandingOrderApi>().To<StandingOrderApi>().InRequestScope();
            container.Bind<IStandingOrderQuery>().To<StandingOrderQuery>().InRequestScope();

            container.Bind<ITransferOutApi>().To<TransferOutApi>().InRequestScope();

            container.Bind<ITransactionApi>().To<TransactionApi>().InRequestScope();
            container.Bind<ITransactionQuery>().To<TransactionQuery>().InRequestScope();

            container.Bind<IStatementApi>().To<StatementApi>().InRequestScope();
            container.Bind<IStatementQuery>().To<StatementQuery>().InRequestScope();

            container.Bind<IDirectDebitApi>().To<DirectDebitApi>().InRequestScope();
            container.Bind<IDirectDebitQuery>().To<DirectDebitQuery>().InRequestScope();

            #endregion
        }

        private void ConfigureAutoMapper(IKernel container)
        {
            var cfg = new MapperConfigurationExpression();
            BankAutoMapper.Configure(cfg);
            BankAccountAutoMapper.Configure(cfg);
            CurrencyAutoMapper.Configure(cfg);
            ClientAutoMapper.Configure(cfg);
            CardAutoMapper.Configure(cfg);
            AccountAutoMapper.Configure(cfg);
            MessageAutoMapper.Configure(cfg);
            RequisiteAutoMapper.Configure(cfg);
            RequestAutoMapper.Configure(cfg);
            StandingOrderAutoMapper.Configure(cfg);
            StatementAutoMapper.Configure(cfg);
            TransactionAutoMapper.Configure(cfg);
            DirectDebitAutoMapper.Configure(cfg);
            Mapper.Initialize(cfg);
            //Mapper.AssertConfigurationIsValid();


            //container.Bind<IAutoMapperTypeConfigurator>()
            //    .To<ClientToClientEntityAutoMapperTypeConfigurator>()
            //    .InRequestScope/*InSingletonScope*/();
        }

        private void ConfigureOrm(IKernel container)
        {
            container.Bind<WalletContext>().ToSelf().InRequestScope();
        }
    }
}