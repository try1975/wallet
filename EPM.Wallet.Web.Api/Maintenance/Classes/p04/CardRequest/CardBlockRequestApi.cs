using System;
using System.Diagnostics;
using EPM.Wallet.Common.Enums;
using EPM.Wallet.Common.Model;
using EPM.Wallet.Data.Entities;
using EPM.Wallet.Data.QueryProcessors;

namespace WalletWebApi.Maintenance
{
    public class CardBlockRequestApi : TypedApi<CardBlockRequestDto, CardBlockRequestEntity, Guid>, ICardBlockRequestApi
    {
        private readonly ICardQuery _cardQuery;
        public CardBlockRequestApi(ICardBlockRequestQuery query, ICardQuery cardQuery) : base(query)
        {
            _cardQuery = cardQuery;
        }

        public bool CreateCardBlockRequest(string clientId, Guid cardId)
        {
            if (cardId == Guid.Empty) return false;
            var card = _cardQuery.GetEntity(cardId);
            if (card == null) return false;
            if (!card.ClientId.Equals(clientId, StringComparison.InvariantCultureIgnoreCase)) return false;
            var entity = new CardBlockRequestEntity
            {
                ClientId = card.ClientId,
                CardId = cardId,
                RequestType = RequestType.Card,
                RequestStatus = RequestStatus.New,
                CardRequestType = CardRequestType.Block
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