using System;
using System.Diagnostics;
using AutoMapper;
using EPM.Wallet.Common.Enums;
using EPM.Wallet.Common.Model;
using EPM.Wallet.Data.Entities;
using EPM.Wallet.Data.QueryProcessors;

namespace EPM.Wallet.Internall.Api.Maintenance
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
            entity.RequestStatus = RequestStatus.New;
            entity.CardRequestType = CardRequestType.SetLimit;
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