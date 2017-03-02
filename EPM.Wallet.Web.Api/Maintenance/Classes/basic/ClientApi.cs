using EPM.Wallet.Common.Model;
using EPM.Wallet.Data.Entities;
using EPM.Wallet.Data.QueryProcessors;

namespace WalletWebApi.Maintenance
{

    public class ClientApi : TypedApi<ClientDto, ClientEntity, string>, IClientApi
    {
        public ClientApi(IClientQuery query) : base(query)
        {
        }
    }
}