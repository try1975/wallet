using System.Windows.Forms;
using EPM.Wallet.WinForms.Presenters;

namespace EPM.Wallet.WinForms.Interfaces
{
    public interface IPresenter
    {
        BindingSource BindingSource { get; }
        PresenterMode PresenterMode { get; }
        void SetDetailData();
        void AddNew();
        void Edit();
        void Save();
        void Cancel();
        void Delete();
    }
}