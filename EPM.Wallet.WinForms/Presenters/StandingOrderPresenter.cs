using System;
using EPM.Wallet.Internal.Model;
using EPM.Wallet.WinForms.Interfaces;

namespace EPM.Wallet.WinForms.Presenters
{
    public class StandingOrderPresenter : TypedPresenter<StandingOrderDto, Guid>
    {
        public StandingOrderPresenter(IStandingOrderView view, IStandingOrderDataManager typedDataMаnager, IDataMаnager dataMаnager)
            : base(view, typedDataMаnager, dataMаnager)
        {
            LoadLists();
        }

        private async void LoadLists()
        {
        }
    }
}
