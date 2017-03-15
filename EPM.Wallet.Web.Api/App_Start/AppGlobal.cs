using System.Web.Configuration;

namespace WalletWebApi
{
    public static class AppGlobal
    {
  public static string EmailAboutTransferOut { get; }
        public static string EmailAboutMessage { get; }

        public static string ExternalToken { get; }

        static AppGlobal()
        {
            EmailAboutTransferOut = WebConfigurationManager.AppSettings[nameof(EmailAboutTransferOut)];
            EmailAboutMessage = WebConfigurationManager.AppSettings[nameof(EmailAboutMessage)];

            ExternalToken = WebConfigurationManager.AppSettings[nameof(ExternalToken)];
        }
    }
}