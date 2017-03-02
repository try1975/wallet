using EPM.Wallet.Data.Entities;
using EPM.Wallet.Data.QueryProcessors;

namespace EPM.Wallet.Data.SqlServer.QueryProcessors
{
    public class ClientAccountStatusQuery : TypedQuery<ClientAccountStatusEntity, string>, IClientAccountStatusQuery { }
}