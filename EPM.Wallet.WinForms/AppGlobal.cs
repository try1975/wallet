using System.Configuration;
using EPM.Wallet.Common.Enums;

namespace EPM.Wallet.WinForms
{
    public static class AppGlobal
    {
        static AppGlobal()
        {
            ClientAppVariant = ClientAppVariant.Wallet;
            StoredClientAppVariant = ConfigurationManager.AppSettings[nameof(StoredClientAppVariant)];
            if (!string.IsNullOrEmpty(StoredClientAppVariant))
            {
                if (StoredClientAppVariant.Equals(nameof(ClientAppVariant.Dpa)))
                    ClientAppVariant = ClientAppVariant.Dpa;
            }
        }

        private static string StoredClientAppVariant { get; }
        public static ClientAppVariant ClientAppVariant { get; }
    }
}