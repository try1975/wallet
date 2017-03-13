using AutoMapper;
using AutoMapper.Configuration;
using EPM.Wallet.Data.QueryProcessors;
using EPM.Wallet.Data.SqlServer;
using EPM.Wallet.Data.SqlServer.QueryProcessors;
using Ninject;
using Ninject.Web.Common;
using WalletWebApi.AutoMappers;
using WalletWebApi.Maintenance;

namespace WalletWebApi
{
    /// <summary>
    ///     Class used to set up the Ninject DI container.
    /// </summary>
    public class ExternalNinjectConfigurator
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

        private static void AddBindings(IKernel container)
        {
            ConfigureOrm(container);
            ConfigureAutoMapper();

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

            container.Bind<IClientAccountStatusApi>().To<ClientAccountStatusApi>().InRequestScope();
            container.Bind<IClientAccountStatusQuery>().To<ClientAccountStatusQuery>().InRequestScope();

            container.Bind<ICardApi>().To<CardApi>().InRequestScope();
            container.Bind<ICardQuery>().To<CardQuery>().InRequestScope();

            container.Bind<IMessageApi>().To<MessageApi>().InRequestScope();
            container.Bind<IMessageQuery>().To<MessageQuery>().InRequestScope();

            container.Bind<IRequisiteApi>().To<RequisiteApi>().InRequestScope();
            container.Bind<IRequisiteQuery>().To<RequisiteQuery>().InRequestScope();

            container.Bind<IRequestApi>().To<RequestApi>().InTransientScope();
            container.Bind<IRequestQuery>().To<RequestQuery>().InTransientScope();

            container.Bind<IAccountRequestApi>().To<AccountRequestApi>().InTransientScope();
            container.Bind<IAccountRequestQuery>().To<AccountRequestQuery>().InTransientScope();

            container.Bind<ICardLimitRequestApi>().To<CardLimitRequestApi>().InTransientScope();
            container.Bind<ICardLimitRequestQuery>().To<CardLimitRequestQuery>().InTransientScope();

            container.Bind<ICardReissueRequestApi>().To<CardReissueRequestApi>().InTransientScope();
            container.Bind<ICardReissueRequestQuery>().To<CardReissueRequestQuery>().InTransientScope();

            container.Bind<ICardBlockRequestApi>().To<CardBlockRequestApi>().InTransientScope();
            container.Bind<ICardBlockRequestQuery>().To<CardBlockRequestQuery>().InTransientScope();

            container.Bind<ICardNewRequestApi>().To<CardNewRequestApi>().InTransientScope();
            container.Bind<ICardNewRequestQuery>().To<CardNewRequestQuery>().InTransientScope();

            container.Bind<IStandingOrderApi>().To<StandingOrderApi>().InTransientScope();
            container.Bind<IStandingOrderQuery>().To<StandingOrderQuery>().InTransientScope();

            container.Bind<IStatementApi>().To<StatementApi>().InTransientScope();
            container.Bind<IStatementQuery>().To<StatementQuery>().InTransientScope();

            #endregion
        }

        private static void ConfigureAutoMapper()
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
            Mapper.Initialize(cfg);
            //Mapper.AssertConfigurationIsValid();
        }

        private static void ConfigureOrm(IKernel container)
        {
            container.Bind<WalletContext>().ToSelf().InRequestScope();
        }
    }
}