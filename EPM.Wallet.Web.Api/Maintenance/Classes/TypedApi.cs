using System.Collections.Generic;
using AutoMapper;
using EPM.Wallet.Common.Interfaces;
using EPM.Wallet.Data.Entities;
using EPM.Wallet.Data.QueryProcessors;

namespace WalletWebApi.Maintenance
{
    public abstract class TypedApi<TV, D, K> : ITypedApi<TV, K> where D : class, IEntity<K> where TV : class, IDto<K>
    {
        protected readonly ITypedQuery<D, K> _query;

        public TypedApi(ITypedQuery<D, K> query)
        {
            _query = query;
        }

        public virtual IEnumerable<TV> GetItems()
        {
            var list = _query.GetEntities();
            return Mapper.Map<List<TV>>(list);
        }

        public TV GetItem(K id)
        {
            return Mapper.Map<TV>(_query.GetEntity(id));
        }

        public TV AddItem(TV dto)
        {
            var entity = Mapper.Map<D>(dto);
            return Mapper.Map<TV>(_query.InsertEntity(entity));
        }

        public TV ChangeItem(TV dto)
        {
            var entity = Mapper.Map<D>(dto);
            return Mapper.Map<TV>(_query.UpdateEntity(entity));
        }

        public bool RemoveItem(K id)
        {
            return _query.DeleteEntity(id);
        }
    }
}