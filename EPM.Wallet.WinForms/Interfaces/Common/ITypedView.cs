using EPM.Wallet.Internal;

namespace EPM.Wallet.WinForms.Interfaces
{
    public interface ITypedView<T, TK> : IRefreshedView, IEnterMode where T : class, IDto<TK>
    {
        #region Details

        TK Id { get; set; }

        #endregion
    }
}