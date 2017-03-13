using System;
using System.Collections.Generic;
using EPM.Wallet.Data.Entities;
using EPM.Wallet.Data.QueryProcessors;
using WalletWebApi.GetFiles;
using WalletWebApi.Model;

namespace WalletWebApi.Maintenance
{

    public class ClientApi : TypedApi<ClientDto, ClientEntity, string>, IClientApi
    {
        public ClientApi(IClientQuery query) : base(query)
        {
        }
    }
}