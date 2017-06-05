using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using AutoMapper;
using EPM.Wallet.Common.Enums;
using EPM.Wallet.Data.Entities;
using EPM.Wallet.Data.QueryProcessors;
using WalletWebApi.Model;

namespace WalletWebApi.Maintenance
{

    public class CardApi : TypedApi<CardDto, CardEntity, Guid>, ICardApi
    {
        public CardApi(ICardQuery query, IStatementQuery statementQuery) : base(query)
        {
        }

        public override IEnumerable<CardDto> GetItems()
        {
            var list = _query.GetEntities().Where(z => z.CardStatus==CardStatus.Active).ToList();
            return Mapper.Map<List<CardDto>>(list);
        }

        public IEnumerable<CardDto> GetCardsByClient(string clientId)
        {
            var list = _query.GetEntities().Where(z => z.ClientId.Equals(clientId, StringComparison.InvariantCultureIgnoreCase)
                                                    && z.CardStatus == CardStatus.Active)
                                                    .Include(z=>z.Statements)
                                                    .ToList();
            var cardDtoList = new List<CardDto>();
            foreach (var cardEntity in list)
            {
                var cardDto = Mapper.Map<CardDto>(cardEntity);
                if (cardEntity.Statements.Any())
                {
                    var firstOrDefault = cardEntity.Statements
                        .OrderByDescending(z=>z.ValueDate)
                        .FirstOrDefault();
                    if (firstOrDefault != null)
                        cardDto.StatementId=firstOrDefault.Id;
                }
                cardDtoList.Add(cardDto);
            }
            

            return cardDtoList;
        }

       
    }
}