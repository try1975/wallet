using EPM.Wallet.Data.Entities;
using EPM.Wallet.Data.QueryProcessors;
using EPM.Wallet.Internal.Model;

namespace WalletInternalApi.Maintenance
{
    public class ClientAccountStatusApi : TypedApi<ClientAccountStatusDto, ClientAccountStatusEntity, string>, IClientAccountStatusApi
    {
        public ClientAccountStatusApi(IClientAccountStatusQuery query) : base(query)
        {
        }
    }
}