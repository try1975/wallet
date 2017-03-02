using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using AutoMapper;
using EPM.Wallet.Internal.Model;
using EPM.Wallet.WinForms.Interfaces;
using EPM.Wallet.WinForms.Presenters;

namespace EPM.Wallet.WinForms.Controls
{
    public partial class ClientControl : UserControl, IClientView
    {
        private readonly ClientPresenter _presenter;
        private BindingList<ClientDto> _bindingList;
        private BindingSource _bindingSource;

        public ClientControl(IDataMаnager dataMаnager)
        {
            InitializeComponent();
            _presenter = new ClientPresenter(this, dataMаnager);
        }

        #region IClientView implementation

        #region Details

        public string Id
        {
            get { return tbId.Text; }
            set { tbId.Text = value; }
        }

        public string ClientName
        {
            get { return tbName.Text; }
            set { tbName.Text = value; }
        }

        #endregion //Details

        #region DetailsLists

        public List<ClientDto> Items { get; set; }

        #endregion //DetailsListsc

        #region ListOperations

        public void RefreshItems()
        {
            _bindingList = new BindingList<ClientDto>(Items);
            _bindingSource = new BindingSource(_bindingList, null);
            dgvItems.DataSource = _bindingSource;
        }

        public void SetEventHandlers()
        {
            throw new NotImplementedException();
        }

        public void ItemAdded(ClientDto item)
        {
            Items.Add(item);
            _bindingSource.ResetBindings(false);
        }

        public void ItemUpdated(ClientDto item)
        {
            if (item == null) return;
            var existItem = Items.FirstOrDefault(i => i.Id.Equals(item.Id));
            if (existItem == null) return;
            Mapper.Map(item, existItem);
            _bindingSource.ResetBindings(false);
        }

        public void ItemRemoved(string id)
        {
            var existItem = Items.FirstOrDefault(i => i.Id.Equals(id, StringComparison.InvariantCultureIgnoreCase));
            if (existItem == null) return;
            Items.Remove(existItem);
            _bindingSource.ResetBindings(false);
        }

        #endregion //ListOperations

        #region Enter Mode

        public void EnterAddNewMode()
        {
            throw new NotImplementedException();
        }

        public void EnterEditMode()
        {
            throw new NotImplementedException();
        }

        public void EnterDetailsMode()
        {
            throw new NotImplementedException();
        }

        public void EnterReadMode()
        {
            throw new NotImplementedException();
        }

        public void EnterMultiSelectMode()
        {
            throw new NotImplementedException();
        }

        public void ClearInputFields()
        {
            throw new NotImplementedException();
        }

        public void EnableInput()
        {
            throw new NotImplementedException();
        }

        public void DisableInput()
        {
            throw new NotImplementedException();
        }

        #endregion //Enter Mode

        #endregion //IClientView implementation

        #region Event handlers

        private void SetDetailData()
        {
            var item = _bindingSource.Current;
            Mapper.Map(item, this);
            //EnterDetailsMode();
        }

        private void dgvItems_SelectionChanged(object sender, EventArgs e)
        {
            SetDetailData();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            _presenter.AddNew();
        }

        #endregion //Event handlers
    }
}