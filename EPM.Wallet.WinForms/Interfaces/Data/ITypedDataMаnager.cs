using System.Collections.Generic;
using System.Threading.Tasks;
using EPM.Wallet.Common.Interfaces;

namespace EPM.Wallet.WinForms.Interfaces
{
    public interface ITypedDataMànager<T, K> where T : class, IDto<K>
    {
        Task<IEnumerable<T>> GetItems();
        Task<T> GetItem(K id);
        Task<T> PostItem(T item);
        Task<T> PutItem(T item);
        Task<bool> DeleteItem(K id);
    }
}