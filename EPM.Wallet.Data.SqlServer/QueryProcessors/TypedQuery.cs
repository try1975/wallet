using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using EPM.Wallet.Data.Entities;
using EPM.Wallet.Data.QueryProcessors;

namespace EPM.Wallet.Data.SqlServer.QueryProcessors
{
    public abstract class TypedQuery<T, K> : ITypedQuery<T, K> where T : class, IEntity<K>
    {
        protected static readonly WalletContext Db = new WalletContext();
        protected readonly DbSet<T> _entities = Db.Set<T>();


        public virtual IQueryable<T> GetEntities()
        {
            return _entities.AsNoTracking();
        }

        public virtual T GetEntity(K id)
        {
            //return _entities.FirstOrDefault(t => t.Id.Equals(id));
            var entity = _entities.Find(id);
            return entity;
        }

        public async Task<T> GetEntityAsync(K id)
        {
            return await _entities.FindAsync(id);
        }

        public T InsertEntity(T entity)
        {
            using (var db = new WalletContext())
            {
                db.Set<T>().Add(entity);
                db.SaveChanges();
                return entity;
            }

            //_entities.Add(entity);
            //Db.SaveChanges();
            //return entity;
        }

        public T UpdateEntity(T entity)
        {
            /*db.Users.Attach(updatedUser);
var entry = db.Entry(updatedUser);
entry.Property(e => e.Email).IsModified = true;
// other changed properties
db.SaveChanges();*/

            //var entityInDb = _entities.Find(entity.Id);
            //if (entityInDb != null)
            //{
            //    Db.Entry(entityInDb).CurrentValues.SetValues(entity);
            //    Db.SaveChanges();
            //}

            //Db.Entry(entity).State = EntityState.Detached;

            //var autoDetection = Db.Configuration.AutoDetectChangesEnabled;
            //Db.Configuration.AutoDetectChangesEnabled = false;

            //_entities.Attach(entity);
            //Db.Entry(entity).State = EntityState.Modified;
            //Db.SaveChanges();
            //Db.Entry(entity).State = EntityState.Detached;
            //Db.Configuration.AutoDetectChangesEnabled = autoDetection;
            //return entity;



            //_entities.AddOrUpdate(entity);
            //Db.SaveChanges();
            //return entity;

            using (var db = new WalletContext())
            {
                db.Set<T>().AddOrUpdate(entity);
                db.SaveChanges();
                return entity;
            }
        }

        public bool DeleteEntity(K id)
        {
            var entity = _entities.Find(id);
            if (entity == null) return false;
            try
            {
                _entities.Attach(entity);
                _entities.Remove(entity);
                Db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
                return false;
            }
        }
    }
}