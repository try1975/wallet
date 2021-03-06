﻿using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using EPM.Wallet.Data.Entities;
using EPM.Wallet.Data.QueryProcessors;
using WalletWebApi.Model;

namespace WalletWebApi.Maintenance
{

    public class MessageApi : TypedApi<MessageDto, MessageEntity, Guid>, IMessageApi
    {
        private readonly IClientQuery _clientQuery;

        public MessageApi(IMessageQuery query, IClientQuery clientQuery) : base(query)
        {
            _clientQuery = clientQuery;
        }

        public IEnumerable<MessageDto> GetMessagesByClient(string clientId, int from = 0, int count = 0)
        {
            var list = _query.GetEntities()
                .Where(m => m.ClientId == clientId && !m.DeletionDate.HasValue)
                .OrderByDescending(i => i.CreatedAt)
                .Skip(from)
                .Take(count > 0 ? count : 1000)
                .ToList()
                ;
            return Mapper.Map<List<MessageDto>>(list);
        }

        public IEnumerable<MessageDto> GetOutgoingMessagesByClient(string clientId, int from = 0, int count = 0)
        {
            var list = _query.GetEntities()
                .Where(m => m.ClientId == clientId && !m.DeletionDate.HasValue && m.IsOutgoing)
                .OrderByDescending(i => i.CreatedAt)
                .Skip(from)
                .Take(count > 0 ? count : 1000)
                .ToList()
                ;
            return Mapper.Map<List<MessageDto>>(list);
        }

        public IEnumerable<MessageDto> GetIncomingMessagesByClient(string clientId, DateTime fromDate, int from = 0, int count = 0)
        {
            var query = _query.GetEntities()
                   .Where(m => m.ClientId == clientId && !m.DeletionDate.HasValue && !m.IsOutgoing && m.CreatedAt >= fromDate)
                   .OrderByDescending(i => i.CreatedAt)
                   .Skip(from)
                   .Take(count > 0 ? count : 1000)
                   ;
            var list = query.ToList();
            return Mapper.Map<List<MessageDto>>(list);
        }

        public MessageDto GetMessageByClient(string clientId, Guid id)
        {
            var entity = _query.GetEntities()
                   .FirstOrDefault(m => m.ClientId == clientId && m.Id == id)
                   ;
            return Mapper.Map<MessageDto>(entity);
        }

        public MessageDto PostMessageByClient(string clientId, MessageDto dto)
        {
            //_clientQuery
            var entity = Mapper.Map<MessageEntity>(dto);
            entity.IsOutgoing = true;
            // ?? получать ид клиента из базы по коду
            entity.ClientId = clientId;
            entity = _query.InsertEntity(entity);
            // TODO: send message (or in controller?)
            return Mapper.Map<MessageDto>(entity);
        }

        public int CountUnreadMessagesByClient(string clientId)
        {
            return _query.GetEntities()
                .Count(m => m.ClientId == clientId && !m.DeletionDate.HasValue && !m.ReadDate.HasValue && !m.IsOutgoing);
        }

        public MessageDto MakeMessageReaded(string clientId, Guid id)
        {
            var entity = _query.GetEntities()
                   .FirstOrDefault(m => m.ClientId == clientId && m.Id == id)
                   ;
            if (entity == null) return null;
            if (entity.ReadDate.HasValue) return Mapper.Map<MessageDto>(entity);
            entity.ReadDate = DateTime.UtcNow;
            _query.UpdateEntity(entity);
            return Mapper.Map<MessageDto>(entity);
        }

        public bool MakeMessageInvisible(Guid id)
        {
            var entity = _query.GetEntity(id);
            if (entity == null) return false;
            if (entity.DeletionDate.HasValue) return false;
            entity.DeletionDate = DateTime.UtcNow;
            _query.UpdateEntity(entity);
            return true;
        }
    }
}