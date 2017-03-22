using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using EPM.Wallet.Data.Entities;
using EPM.Wallet.Data.QueryProcessors;
using EPM.Wallet.Internal.Model;

namespace WalletInternalApi.Maintenance
{

    public class CardApi : TypedApi<CardDto, CardEntity, Guid>, ICardApi
    {
        public CardApi(ICardQuery query) : base(query)
        {
        }

        public override IEnumerable<CardDto> GetItems()
        {
            var list = Query.GetEntities().Where(z => !z.IsInactive).ToList();
            return Mapper.Map<List<CardDto>>(list);
        }

        public IEnumerable<CardDto> GetCardsByClient(string clientId)
        {
            var list = Query.GetEntities().Where(z => z.ClientId.Equals(clientId, StringComparison.InvariantCultureIgnoreCase)
                                                    && !z.IsInactive)
                                                    .ToList();
            return Mapper.Map<List<CardDto>>(list);
        }

        public override CardDto ChangeItem(CardDto dto)
        {
            // TODO: check card number (equal 16 digits)
            var entity = Mapper.Map<CardEntity>(dto);
            return Mapper.Map<CardDto>(Query.UpdateEntity(entity));
        }
    }
}