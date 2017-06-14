using System;
using EPM.Wallet.Internal.Model;
using EPM.Wallet.WinForms.Interfaces;

namespace EPM.Wallet.WinForms.Presenters
{
    public class DirectDebitPresenter : TypedPresenter<DirectDebitDto, Guid>
    {
        public DirectDebitPresenter(IDirectDebitView view, IDirectDebitDataManager typedDataMаnager, IDataMаnager dataMаnager)
            : base(view, typedDataMаnager, dataMаnager)
        {
            LoadLists();
        }

        private async void LoadLists()
        {
        }
    }
}