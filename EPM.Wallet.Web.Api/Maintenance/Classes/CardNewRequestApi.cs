using System;
using System.Diagnostics;
using EPM.Wallet.Common.Enums;
using EPM.Wallet.Data.Entities;
using EPM.Wallet.Data.QueryProcessors;
using WalletWebApi.Model;

namespace WalletWebApi.Maintenance
{
    public class CardNewRequestApi : TypedApi<CardNewRequestDto, CardNewRequestEntity, Guid>, ICardNewRequestApi
    {
        private readonly IClientQuery _clientQuery;

        public CardNewRequestApi(ICardNewRequestQuery query, IClientQuery clientQuery) : base(query)
        {
            _clientQuery = clientQuery;
        }

        public bool CreateCardNewRequest(string clientId)
        {
            var client = _clientQuery.GetEntity(clientId);
            if (client == null) return false;
            var entity = new CardNewRequestEntity
            {
                ClientId = client.Id,
                CurrencyId = "EUR",
                RequestType = RequestType.Card,
                RequestStatus = RequestStatuses.GetPendingRequestStatus(),
                CardRequestType = CardRequestType.New
            };
            try
            {
                _query.InsertEntity(entity);
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                throw;
            }
        }
    }
}