using System.Windows.Forms;

namespace EPM.Wallet.WinForms.Interfaces
{
    public interface IPresenter
    {
        BindingSource BindingSource { get; }

        void SetDetailData();
        void AddNew();
        void Edit();
        void Save();
        void Cancel();
        void Delete();
    }
}