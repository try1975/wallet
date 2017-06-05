using System;
using System.Diagnostics;
using EPM.Wallet.Common.Enums;
using EPM.Wallet.Data.Entities;
using EPM.Wallet.Data.QueryProcessors;
using EPM.Wallet.Internal.Model;

namespace WalletInternalApi.Maintenance
{
    //public class CardNewRequestApi : TypedApi<CardNewRequestDto, CardNewRequestEntity, Guid>, ICardNewRequestApi
    public class CardNewRequestApi : TypedApi<CardNewRequestDto, CardRequestEntity, Guid>, ICardNewRequestApi
    {
        private readonly IClientQuery _clientQuery;

        //public CardNewRequestApi(ICardNewRequestQuery query, IClientQuery clientQuery) : base(query)
        public CardNewRequestApi(ICardRequestQuery query, IClientQuery clientQuery) : base(query)
        {
            _clientQuery = clientQuery;
        }

        public bool CreateCardNewRequest(string clientId)
        {
            var client = _clientQuery.GetEntity(clientId);
            if (client == null) return false;
            //var entity = new CardNewRequestEntity
            var entity = new CardRequestEntity
            {
                ClientId = client.Id,
                CurrencyId = "EUR",
                RequestType = RequestType.Card,
                RequestStatus = RequestStatuses.GetPendingRequestStatus(),
                CardRequestType = CardRequestType.New
            };
            try
            {
                Query.InsertEntity(entity);
                return true;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
                Log.Error(e);
                throw;
            }
        }
    }
}