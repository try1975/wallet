﻿using System.Linq;
using System.Threading.Tasks;
using EPM.Wallet.Data.Entities;

namespace EPM.Wallet.Data.QueryProcessors
{
    public interface ITypedQuery<T, K> where T : class, IEntity<K>
    {
        IQueryable<T> GetEntities();
        T GetEntity(K id);
        Task<T> GetEntityAsync(K id);
        T InsertEntity(T entity);
        T UpdateEntity(T entity);
        bool DeleteEntity(K id);
    }
}