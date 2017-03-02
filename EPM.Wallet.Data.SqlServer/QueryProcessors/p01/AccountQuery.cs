using System;
using System.Linq;
using EPM.Wallet.Data.Entities;
using EPM.Wallet.Data.QueryProcessors;

namespace EPM.Wallet.Data.SqlServer.QueryProcessors
{
    public class AccountQuery : TypedQuery<ClientAccountEntity, Guid>, IAccountQuery
    {
        //public override  IQueryable<ClientAccountEntity> GetEntities()
        //{
        //    return _entities.Include(z=>z.).AsNoTracking();
        //}
        //public override ClientAccountEntity GetEntity(Guid id)
        //{
        //    var accountEntity = base.GetEntity(id);
        //    Db.Entry(accountEntity).Reference(w => w.Requisite).Load();
        //    return accountEntity;
        //}
    }
}