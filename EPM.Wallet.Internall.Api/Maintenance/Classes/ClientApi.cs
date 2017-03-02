using EPM.Wallet.Data.Entities;
using EPM.Wallet.Data.QueryProcessors;
using EPM.Wallet.Internal.Model;

namespace EPM.Wallet.Internall.Api.Maintenance
{

    public class ClientApi : TypedApi<ClientDto, ClientEntity, string>, IClientApi
    {
        public ClientApi(IClientQuery query) : base(query)
        {
        }
    }
}