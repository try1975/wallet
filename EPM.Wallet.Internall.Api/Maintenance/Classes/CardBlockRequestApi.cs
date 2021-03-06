﻿using System;
using System.Diagnostics;
using EPM.Wallet.Common.Enums;
using EPM.Wallet.Data.Entities;
using EPM.Wallet.Data.QueryProcessors;
using EPM.Wallet.Internal.Model;

namespace WalletInternalApi.Maintenance
{
    //public class CardBlockRequestApi : TypedApi<CardBlockRequestDto, CardBlockRequestEntity, Guid>, ICardBlockRequestApi
    public class CardBlockRequestApi : TypedApi<CardBlockRequestDto, CardRequestEntity, Guid>, ICardBlockRequestApi
    {
        private readonly ICardQuery _cardQuery;
        //public CardBlockRequestApi(ICardBlockRequestQuery query, ICardQuery cardQuery) : base(query)
        public CardBlockRequestApi(ICardRequestQuery query, ICardQuery cardQuery) : base(query)
        {
            _cardQuery = cardQuery;
        }

        public bool CreateCardBlockRequest(string clientId, Guid cardId)
        {
            if (cardId == Guid.Empty) return false;
            var card = _cardQuery.GetEntity(cardId);
            if (card == null) return false;
            if (!card.ClientId.Equals(clientId, StringComparison.InvariantCultureIgnoreCase)) return false;
            //var entity = new CardBlockRequestEntity
            var entity = new CardRequestEntity
            {
                ClientId = card.ClientId,
                CardId = cardId,
                RequestType = RequestType.Card,
                RequestStatus = RequestStatuses.GetPendingRequestStatus(),
                CardRequestType = CardRequestType.Block
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