using System.Windows.Forms;

namespace EPM.Wallet.WinForms.Interfaces
{
    public interface IPresenter
    {
        BindingSource BindingSource { get; set; }

        void SetItems();
        void LoadLists();
        void SetDetailData();
        void AddNew();
        void Edit();
        void Save();
        void Cancel();
        void Create();
        void Update();
        void Delete();
    }
}