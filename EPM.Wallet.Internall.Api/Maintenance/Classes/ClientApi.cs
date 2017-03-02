using EPM.Wallet.Data.Entities;
using EPM.Wallet.Data.QueryProcessors;
using EPM.Wallet.Internal.Model;

namespace WalletInternalApi.Maintenance
{

    public class ClientApi : TypedApi<ClientDto, ClientEntity, string>, IClientApi
    {
        public ClientApi(IClientQuery query) : base(query)
        {
        }
    }
}