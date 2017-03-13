using EPM.Wallet.Common;
using EPM.Wallet.Internal.Model;
using EPM.Wallet.WinForms.Interfaces;

namespace EPM.Wallet.WinForms.Data
{
    public class ClientDataManager : TypedDataMаnager<ClientDto, string>, IClientDataManager
    {
        public ClientDataManager() : base(WalletConstants.ClientAppApi.Clients)
        {

        }
    }
}