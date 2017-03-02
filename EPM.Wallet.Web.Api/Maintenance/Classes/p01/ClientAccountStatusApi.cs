using EPM.Wallet.Common.Model;
using EPM.Wallet.Data.Entities;
using EPM.Wallet.Data.QueryProcessors;

namespace WalletWebApi.Maintenance
{
    public class ClientAccountStatusApi : TypedApi<ClientAccountStatusDto, ClientAccountStatusEntity, string>, IClientAccountStatusApi
    {
        public ClientAccountStatusApi(IClientAccountStatusQuery query) : base(query)
        {
        }
    }
}