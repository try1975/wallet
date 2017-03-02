﻿using System.Collections.Generic;
using AutoMapper;
using EPM.Wallet.Common.Interfaces;
using EPM.Wallet.Data.Entities;
using EPM.Wallet.Data.QueryProcessors;

namespace EPM.Wallet.Internall.Api.Maintenance
{
    public abstract class TypedApi<TV, D, K> : ITypedApi<TV, K> where D : class, IEntity<K> where TV : class, IDto<K>
    {
        protected readonly ITypedQuery<D, K> Query;

        protected TypedApi(ITypedQuery<D, K> query)
        {
            Query = query;
        }

        public virtual IEnumerable<TV> GetItems()
        {
            var list = Query.GetEntities();
            return Mapper.Map<List<TV>>(list);
        }

        public TV GetItem(K id)
        {
            return Mapper.Map<TV>(Query.GetEntity(id));
        }

        public TV AddItem(TV dto)
        {
            var entity = Mapper.Map<D>(dto);
            return Mapper.Map<TV>(Query.InsertEntity(entity));
        }

        public TV ChangeItem(TV dto)
        {
            var entity = Mapper.Map<D>(dto);
            return Mapper.Map<TV>(Query.UpdateEntity(entity));
        }

        public bool RemoveItem(K id)
        {
            return Query.DeleteEntity(id);
        }
    }
}