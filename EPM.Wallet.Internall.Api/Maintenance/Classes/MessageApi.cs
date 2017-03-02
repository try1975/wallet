using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using EPM.Wallet.Data.Entities;
using EPM.Wallet.Data.QueryProcessors;
using EPM.Wallet.Internal.Model;

namespace WalletInternalApi.Maintenance
{

    public class MessageApi : TypedApi<MessageDto, MessageEntity, Guid>, IMessageApi
    {
        private readonly IClientQuery _clientQuery;

        public MessageApi(IMessageQuery query, IClientQuery clientQuery) : base(query)
        {
            _clientQuery = clientQuery;
        }

        public IEnumerable<MessageDto> GetMessagesByClient(string clientId)
        {
            var list = Query.GetEntities()
                .Where(m => m.ClientId == clientId && !m.DeletionDate.HasValue)
                .OrderByDescending(i => i.CreatedAt)
                .ToList()
                ;
            return Mapper.Map<List<MessageDto>>(list);
        }

        public IEnumerable<MessageDto> GetOutgoingMessagesByClient(string clientId)
        {
            var list = Query.GetEntities()
                .Where(m => m.ClientId == clientId && !m.DeletionDate.HasValue && m.IsOutgoing)
                .OrderByDescending(i => i.CreatedAt)
                .ToList()
                ;
            return Mapper.Map<List<MessageDto>>(list);
        }

        public IEnumerable<MessageDto> GetIncomingMessagesByClient(string clientId, DateTime fromDate)
        {
            var list = Query.GetEntities()
                   .Where(m => m.ClientId == clientId && !m.DeletionDate.HasValue && !m.IsOutgoing && m.CreatedAt >= fromDate)
                   .OrderByDescending(i => i.CreatedAt)
                   .ToList()
                   ;
            return Mapper.Map<List<MessageDto>>(list);
        }

        public MessageDto GetMessageByClient(string clientId, Guid id)
        {
            var entity = Query.GetEntities()
                   .FirstOrDefault(m => m.ClientId == clientId && m.Id == id)
                   ;
            return Mapper.Map<MessageDto>(entity);
        }

        public MessageDto PostMessageByClient(string clientId, MessageDto dto)
        {
            //_clientQuery
            var entity = Mapper.Map<MessageEntity>(dto);
            // ?? получать ид клиента из базы по коду
            entity.ClientId = clientId;
            return Mapper.Map<MessageDto>(Query.InsertEntity(entity));
        }

        public int CountUnreadMessagesByClient(string clientId)
        {
            return Query.GetEntities()
                .Count(m => m.ClientId == clientId && !m.DeletionDate.HasValue && !m.ReadDate.HasValue);
        }

        public MessageDto MakeMessageReaded(string clientId, Guid id)
        {
            var entity = Query.GetEntities()
                   .FirstOrDefault(m => m.ClientId == clientId && m.Id == id)
                   ;
            if (entity == null) return null;
            if (entity.ReadDate.HasValue) return Mapper.Map<MessageDto>(entity);
            entity.ReadDate = DateTime.UtcNow;
            Query.UpdateEntity(entity);
            return Mapper.Map<MessageDto>(entity);
        }

        public bool MakeMessageInvisible(Guid id)
        {
            var entity = Query.GetEntity(id);
            if (entity == null) return false;
            if (entity.DeletionDate.HasValue) return false;
            entity.DeletionDate = DateTime.UtcNow;
            Query.UpdateEntity(entity);
            return true;
        }
    }
}