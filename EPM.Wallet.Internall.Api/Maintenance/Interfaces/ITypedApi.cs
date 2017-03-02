using System.Collections.Generic;
using EPM.Wallet.Common.Interfaces;

namespace EPM.Wallet.Internall.Api.Maintenance
{
    public interface ITypedApi<T,K> where T : class, IDto<K>
    {
        IEnumerable<T> GetItems();
        T GetItem(K id);
        T AddItem(T dto);
        T ChangeItem(T dto);
        bool RemoveItem(K id);
    }
}