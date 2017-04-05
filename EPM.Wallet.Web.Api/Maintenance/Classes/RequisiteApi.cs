using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using AutoMapper;
using EPM.Wallet.Data.Entities;
using EPM.Wallet.Data.QueryProcessors;
using WalletWebApi.Model;

namespace WalletWebApi.Maintenance
{

    public class RequisiteApi : TypedApi<RequisiteDto, RequisiteEntity, Guid>, IRequisiteApi
    {
        public RequisiteApi(IRequisiteQuery query) : base(query)
        {
        }
        public IEnumerable<RequisiteDto> GetRequisitesByClient(string clientId)
        {
            var list = _query.GetEntities()
                .Where(x => x.ClientId == clientId && x.IsVisible)
                .ToList()
                ;
            return Mapper.Map<List<RequisiteDto>>(list);
        }

        public RequisiteDto GetRequisiteByClient(string clientId, Guid id)
        {
            var entity = _query.GetEntities()
                .FirstOrDefault(x => x.ClientId == clientId && x.Id==id);
            return entity == null ? null : Mapper.Map<RequisiteDto>(entity);
        }

        public RequisiteDto PostRequisiteByClient(string clientId, RequisiteDto dto)
        {
            var entity = Mapper.Map<RequisiteEntity>(dto);
            // ?? получать ид клиента из базы по коду
            entity.ClientId = clientId;
            entity.Name = $"{dto.OwnerName} {dto.BankName} {dto.Iban}".Trim();
            entity.IsVisible = true;
            return Mapper.Map<RequisiteDto>(_query.InsertEntity(entity));
        }

        public RequisiteDto PutRequisiteByClient(string clientId, RequisiteDto dto)
        {
            var entity = _query.GetEntity(dto.Id);
            if (entity == null) return null;
            if (!entity.ClientId.Equals(clientId, StringComparison.InvariantCultureIgnoreCase)) return null;
            Mapper.Map(dto, entity);
            return Mapper.Map<RequisiteDto>(_query.UpdateEntity(entity));
        }

        public bool DeleteRequisiteByClient(string clientId, Guid id)
        {
            var entity = _query.GetEntity(id);
            if (entity == null) return false;
            if (!entity.ClientId.Equals(clientId, StringComparison.InvariantCultureIgnoreCase)) return false;
            entity.IsVisible = false;
            try
            {
                _query.UpdateEntity(entity);
                return true;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
                Log.Error(e);
                return false;
            }
        }
    }
}