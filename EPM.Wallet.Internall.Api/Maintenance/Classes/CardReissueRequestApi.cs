using System;
using System.Diagnostics;
using AutoMapper;
using EPM.Wallet.Common.Enums;
using EPM.Wallet.Data.Entities;
using EPM.Wallet.Data.QueryProcessors;
using EPM.Wallet.Internal.Model;

namespace WalletInternalApi.Maintenance
{
    //class CardReissueRequestApi : TypedApi<CardReissueRequestDto, CardReissueRequestEntity, Guid>, ICardReissueRequestApi
    class CardReissueRequestApi : TypedApi<CardReissueRequestDto, CardRequestEntity, Guid>, ICardReissueRequestApi
    {
        private readonly ICardQuery _cardQuery;
        //public CardReissueRequestApi(ICardReissueRequestQuery query, ICardQuery cardQuery) : base(query)
        public CardReissueRequestApi(ICardRequestQuery query, ICardQuery cardQuery) : base(query)
        {
            _cardQuery = cardQuery;
        }

        public bool CreateCardReissueRequest(string clientId, CardReissueRequestDto dto)
        {
            if (dto.CardId == Guid.Empty) return false;
            var card = _cardQuery.GetEntity(dto.CardId);
            if (card == null) return false;
            if (!card.ClientId.Equals(clientId, StringComparison.InvariantCultureIgnoreCase)) return false;
            //var entity = Mapper.Map<CardReissueRequestEntity>(dto);
            var entity = Mapper.Map<CardRequestEntity>(dto);
            entity.ClientId = card.ClientId;
            entity.RequestType = RequestType.Card;
            entity.RequestStatus = RequestStatuses.GetPendingRequestStatus();
            entity.CardRequestType = CardRequestType.Reissue;
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