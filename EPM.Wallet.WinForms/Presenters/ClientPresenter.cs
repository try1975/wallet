using System;
using System.Linq;
using EPM.Wallet.WinForms.Interfaces;

namespace EPM.Wallet.WinForms.Presenters
{
    public class ClientPresenter
    {
        private readonly IDataMаnager _dataMаnager;
        private readonly IClientView _view;

        public ClientPresenter(IClientView view, IDataMаnager dataMаnager)
        {
            _view = view;
            _dataMаnager = dataMаnager;

            SetItems();
        }

        public async void SetItems()
        {
            _view.Items = (await _dataMаnager.GetClients()).ToList();
            _view.RefreshItems();
        }

        public void AddNew()
        {
            throw new NotImplementedException();
        }
    }
}