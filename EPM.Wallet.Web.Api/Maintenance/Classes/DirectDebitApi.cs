using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using AutoMapper;
using EPM.Wallet.Data.Entities;
using EPM.Wallet.Data.QueryProcessors;
using WalletWebApi.Model;

namespace WalletWebApi.Maintenance
{
    public class DirectDebitApi : TypedApi<DirectDebitDto, DirectDebitEntity, Guid>, IDirectDebitApi
    {
        private readonly IAccountQuery _accountQuery;
        private readonly ICardQuery _cardQuery;

        public DirectDebitApi(IDirectDebitQuery query, IAccountQuery accountQuery, ICardQuery cardQuery) : base(query)
        {
            _accountQuery = accountQuery;
            _cardQuery = cardQuery;
        }

        public IEnumerable<DirectDebitDto> GetDirectDebitsByClient(string clientId)
        {
            var directDebits = _query.GetEntities()
                .Where(m => m.SourceAccount.ClientId.Equals(clientId) && m.Card.ClientId.Equals(clientId))
                .Include(nameof(DirectDebitEntity.SourceAccount))
                .Include(nameof(DirectDebitEntity.Card))
                ;

            var list = directDebits.Select(z => new DirectDebitDto()
            {
                Id = z.Id,
                SourceAccountId = z.SourceAccountId,
                SourceAccountName = z.SourceAccount.Name,
                CardId = z.CardId,
                CardNumber = z.Card.CardNumber,
                CurrencyId = z.CurrencyId,
                DebitFromOtherIfIncefitient = z.DebitFromOtherIfIncefitient,
                Amount = z.Amount
            }).ToList();
            return list;
        }

        public DirectDebitDto PostDirectDebitByClient(string clientId, DirectDebitDto dto)
        {
            var account = _accountQuery.GetEntities().FirstOrDefault(z => z.Id == dto.SourceAccountId && z.ClientId.Equals(clientId));
            if (account == null) return null;
            var card = _cardQuery.GetEntities().FirstOrDefault(z => z.Id == dto.CardId && z.ClientId.Equals(clientId));
            if (card == null) return null;
            var entity = Mapper.Map<DirectDebitEntity>(dto);
            entity = _query.InsertEntity(entity);
            var directDebitDto = Mapper.Map<DirectDebitDto>(entity);
            directDebitDto.SourceAccountName = account.Name;
            directDebitDto.CardNumber = card.CardNumber;
            //directDebitDto.SourceAccount = Mapper.Map<AccountDto>(account); 
            //directDebitDto.Card = Mapper.Map<CardDto>(card);
            return directDebitDto;
        }

        public DirectDebitDto PutDirectDebitByClient(string clientId, DirectDebitDto dto)
        {
            var account = _accountQuery.GetEntities().FirstOrDefault(z => z.Id == dto.SourceAccountId && z.ClientId.Equals(clientId));
            if (account == null) return null;
            var card = _cardQuery.GetEntities().FirstOrDefault(z => z.Id == dto.CardId && z.ClientId.Equals(clientId));
            if (card == null) return null;
            var entity = Mapper.Map<DirectDebitEntity>(dto);
            entity = _query.UpdateEntity(entity);
            var directDebitDto = Mapper.Map<DirectDebitDto>(entity);
            directDebitDto.SourceAccountName = account.Name;
            directDebitDto.CardNumber = card.CardNumber;
            return directDebitDto;
        }

        public bool DeleteDirectDebitByClient(string clientId, Guid id)
        {
            var entity = _query.GetEntities().FirstOrDefault(z => z.Id.Equals(id) && z.SourceAccount.ClientId.Equals(clientId));
            return entity != null && _query.DeleteEntity(id);
        }
    }
}