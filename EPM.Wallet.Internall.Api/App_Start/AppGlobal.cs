using System.Web.Configuration;

namespace WalletInternalApi
{
    public static class AppGlobal
    {
        public static string ExternalToken { get; }

        public static string ExchangeServiceUrl { get; }
        public static string ExchangeServiceUserName { get; }
        public static string ExchangeServicePassword { get; }

        public static string EmailMessage { get; }
        public static string EmailAccountTransferOut { get; }
        public static string EmailAccountTransferToCard { get; }
        public static string EmailAccountRefill { get; }
        public static string EmailAccountNew { get; }
        public static string EmailCardSetLimit { get; }
        public static string EmailCardReissue { get; }
        public static string EmailCardNew { get; }
        public static string EmailCardBlock { get; }

        static AppGlobal()
        {
            ExternalToken = WebConfigurationManager.AppSettings[nameof(ExternalToken)];

            ExchangeServiceUrl = WebConfigurationManager.AppSettings[nameof(ExchangeServiceUrl)];
            ExchangeServiceUserName = WebConfigurationManager.AppSettings[nameof(ExchangeServiceUserName)];
            ExchangeServicePassword = WebConfigurationManager.AppSettings[nameof(ExchangeServicePassword)];

            EmailMessage = WebConfigurationManager.AppSettings[nameof(EmailMessage)];

            EmailAccountTransferOut = WebConfigurationManager.AppSettings[nameof(EmailAccountTransferOut)];
            EmailAccountTransferToCard = WebConfigurationManager.AppSettings[nameof(EmailAccountTransferToCard)];
            EmailAccountRefill = WebConfigurationManager.AppSettings[nameof(EmailAccountRefill)];
            EmailAccountNew = WebConfigurationManager.AppSettings[nameof(EmailAccountNew)];

            EmailCardSetLimit = WebConfigurationManager.AppSettings[nameof(EmailCardSetLimit)];
            EmailCardReissue = WebConfigurationManager.AppSettings[nameof(EmailCardReissue)];
            EmailCardNew = WebConfigurationManager.AppSettings[nameof(EmailCardNew)];
            EmailCardBlock = WebConfigurationManager.AppSettings[nameof(EmailCardBlock)];
        }
    }
}