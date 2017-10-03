using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using EPM.Wallet.Data.Entities;
using EPM.Wallet.Data.QueryProcessors;
using Z.EntityFramework.Plus;

namespace EPM.Wallet.Data.SqlServer.QueryProcessors
{
    public abstract class TypedQuery<T, TK> : ITypedQuery<T, TK> where T : class, IEntity<TK>
    {
        private readonly WalletContext _db;
        private readonly DbSet<T> _entities;

        protected TypedQuery(WalletContext db)
        {
            _db = db;
            _entities = _db.Set<T>();
        }

        public virtual IQueryable<T> GetEntities()
        {
            return _entities.AsNoTracking();
        }

        public virtual T GetEntity(TK id)
        {
            var entity = _entities.Find(id);
            return entity;
        }

        public async Task<T> GetEntityAsync(TK id)
        {
            return await _entities.FindAsync(id);
        }

        public T InsertEntity(T entity)
        {
            SetChangeAt(entity);

            _db.Set<T>().Add(entity);
            SaveChanges(entity);
            return entity;
        }

        public T UpdateEntity(T entity)
        {
            SetChangeAt(entity);

            _db.Set<T>().AddOrUpdate(entity);
            SaveChanges(entity);
            return entity;
        }

        public bool DeleteEntity(TK id)
        {
                var entity = _db.Set<T>().Find(id);
                if (entity == null) return false;
                try
                {
                    _db.Set<T>().Attach(entity);
                    _db.Set<T>().Remove(entity);
                    SaveChanges(entity);
                    return true;
                }
                catch (Exception e)
                {
                    Debug.WriteLine(e);
                    return false;
                }
        }

        public DbContext GetDbContext()
        {
            return _db;
        }

        private Audit GetAudit(T entity)
        {

            var piChangeBy = typeof(T).GetProperty(nameof(IMetaDataEntity.CreatedBy));
            var changeBy = piChangeBy?.GetValue(entity);

            return new Audit { CreatedBy = $"{changeBy}" };
        }

        private void SetChangeAt(T entity)
        {
            var piChangeAt = typeof(T).GetProperty(nameof(IMetaDataEntity.CreatedAt));
            piChangeAt?.SetValue(entity, DateTime.Now);
        }

        private void SaveChanges(T entity)
        {
            if (entity is IMetaDataEntity)
            {
                _db.SaveChanges(GetAudit(entity));
            }
            else
            {
                _db.SaveChanges();
            }
        }
    }
}