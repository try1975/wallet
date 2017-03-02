using EPM.Wallet.Data.Entities;
using EPM.Wallet.Data.QueryProcessors;
using WalletWebApi.Model;

namespace WalletWebApi.Maintenance
{
    public class ClientAccountStatusApi : TypedApi<ClientAccountStatusDto, ClientAccountStatusEntity, string>, IClientAccountStatusApi
    {
        public ClientAccountStatusApi(IClientAccountStatusQuery query) : base(query)
        {
        }
    }
}