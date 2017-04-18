using System.Collections.Generic;
using AutoMapper;
using EPM.Wallet.Data.Entities;
using EPM.Wallet.Data.QueryProcessors;
using log4net;
using WalletWebApi.Model;

namespace WalletWebApi.Maintenance
{
    public abstract class TypedApi<TV, TD, TK> : ITypedApi<TV, TK> where TD : class, IEntity<TK> where TV : class, IDto<TK>
    {
        protected readonly ITypedQuery<TD, TK> _query;
        protected static readonly ILog Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        protected TypedApi(ITypedQuery<TD, TK> query)
        {
            _query = query;
        }

        public virtual IEnumerable<TV> GetItems()
        {
            var list = _query.GetEntities();
            return Mapper.Map<List<TV>>(list);
        }

        public virtual TV GetItem(TK id)
        {
            return Mapper.Map<TV>(_query.GetEntity(id));
        }

        public TV AddItem(TV dto)
        {
            var entity = Mapper.Map<TD>(dto);
            return Mapper.Map<TV>(_query.InsertEntity(entity));
        }

        public TV ChangeItem(TV dto)
        {
            var entity = Mapper.Map<TD>(dto);
            return Mapper.Map<TV>(_query.UpdateEntity(entity));
        }

        public bool RemoveItem(TK id)
        {
            return _query.DeleteEntity(id);
        }
    }
}