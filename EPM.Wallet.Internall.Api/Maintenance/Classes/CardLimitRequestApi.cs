using System;
using System.Diagnostics;
using AutoMapper;
using EPM.Wallet.Common.Enums;
using EPM.Wallet.Data.Entities;
using EPM.Wallet.Data.QueryProcessors;
using EPM.Wallet.Internal.Model;

namespace WalletInternalApi.Maintenance
{
    public class CardLimitRequestApi : TypedApi<CardLimitRequestDto, CardLimitRequestEntity, Guid>, ICardLimitRequestApi
    {
        private readonly ICardQuery _cardQuery;

        public CardLimitRequestApi(ICardLimitRequestQuery query, ICardQuery cardQuery) : base(query)
        {
            _cardQuery = cardQuery;
        }

        public bool CreateCardLimitRequest(string clientId, CardLimitRequestDto dto)
        {
            if (dto.CardId == Guid.Empty) return false;
            var card = _cardQuery.GetEntity(dto.CardId);
            if (card == null) return false;
            if (!card.ClientId.Equals(clientId, StringComparison.InvariantCultureIgnoreCase)) return false;
            var entity = Mapper.Map<CardLimitRequestEntity>(dto);
            entity.ClientId = card.ClientId;
            entity.RequestType = RequestType.Card;
            entity.RequestStatus = RequestStatuses.GetPendingRequestStatus();
            entity.CardRequestType = CardRequestType.SetLimit;
            try
            {
                Query.InsertEntity(entity);
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