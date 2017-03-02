using System;
using EPM.Wallet.Data.Entities;
using EPM.Wallet.Data.QueryProcessors;
using EPM.Wallet.Internal.Model;

namespace WalletInternalApi.Maintenance
{
    public class CardRequestApi : TypedApi<CardRequestDto, CardRequestEntity, Guid>, ICardRequestApi
    {
        public CardRequestApi(ICardRequestQuery query) : base(query)
        {
        }

        public bool CreateCardNewRequest(string clientId)
        {
            return false;
        }
    }
}