using System.Collections.Generic;
using EPM.Wallet.Common.Interfaces;

namespace EPM.Wallet.WinForms.Interfaces
{
    public interface ITypedView<T, K> : IRefreshedView, IEnterMode  where T : class, IDto<K>
    {
        #region DetailsLists

        List<T> Items { get; set; }

        #endregion

        #region Details

        K Id { get; set; }

        #endregion

        #region ListOperations

        void ItemAdded(T item);
        void ItemUpdated(T item);
        void ItemRemoved(K id);

        #endregion
    }
}