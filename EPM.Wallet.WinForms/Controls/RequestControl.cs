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
    public partial class RequestControl : UserControl, IRequestView
    {
        private readonly RequestPresenter _presenter;
        private BindingList<RequestDto> _bindingList;
        private BindingSource _bindingSource;

        public RequestControl(IDataMаnager dataMаnager)
        {
            InitializeComponent();
            _presenter = new RequestPresenter(this, dataMаnager);
        }

        #region IRequestView implementation

        #region Details

        public Guid Id
        {
            get
            {
                if (string.IsNullOrEmpty(tbId.Text)) return Guid.Empty;
                Guid id;
                return Guid.TryParse(tbId.Text, out id) ? id : Guid.Empty;
            }
            set { tbId.Text = value.ToString(); }
        }

        public string RequestName
        {
            get { return tbName.Text; }
            set { tbName.Text = value; }
        }

        public Guid BankId
        {
            get { return (Guid)cmbBank.SelectedValue; }
            set { cmbBank.SelectedValue = value; }
        }

        public string CurrencyId
        {
            get { return (string)cmbCurrency.SelectedValue; }
            set { cmbCurrency.SelectedValue = value; }
        }

        //public decimal CurrentBalance
        //{
        //    get
        //    {
        //        if (string.IsNullOrEmpty(tbBalance.Text)) return 0;
        //        decimal balance;
        //        return decimal.TryParse(tbBalance.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out balance)
        //            ? balance
        //            : 0;
        //    }
        //    set { tbBalance.Text = value.ToString(CultureInfo.InvariantCulture); }
        //}

        public string ClientId { get; set; }
        public string Type { get; set; }
        public string SubType { get; set; }
        public string Status { get; set; }
        

        #endregion //Details

        #region DetailsLists

        public List<RequestDto> Items { get; set; }

        public List<KeyValuePair<Guid, string>> BankList
        {
            set
            {
                cmbBank.DataSource = value;
                cmbBank.ValueMember = "Key";
                cmbBank.DisplayMember = "Value";
            }
        }

        public List<KeyValuePair<string, string>> CurrencyList
        {
            set
            {
                cmbCurrency.DataSource = value;
                cmbCurrency.ValueMember = "Key";
                cmbCurrency.DisplayMember = "Value";
            }
        }
        public List<KeyValuePair<string, string>> ClientList { get; set; }

        #endregion

        #region ListOperations

        public void RefreshItems()
        {
            _bindingList = new BindingList<RequestDto>(Items);
            _bindingSource = new BindingSource(_bindingList, null);
            dgvItems.DataSource = _bindingSource;
        }

        public void SetEventHandlers()
        {
            throw new NotImplementedException();
        }

        public void ItemAdded(RequestDto item)
        {
            Items.Add(item);
            _bindingSource.ResetBindings(false);
        }

        public void ItemUpdated(RequestDto item)
        {
            if (item == null) return;
            var existItem = Items.FirstOrDefault(i => i.Id.Equals(item.Id));
            if (existItem == null) return;
            Mapper.Map(item, existItem);
            _bindingSource.ResetBindings(false);
        }

        public void ItemRemoved(Guid id)
        {
            var existItem = Items.FirstOrDefault(i => i.Id == id);
            if (existItem == null) return;
            Items.Remove(existItem);
            _bindingSource.ResetBindings(false);
        }

        #endregion

        #region Enter mode

        public void EnterEditMode()
        {
            EnableInput();

            btnDelete.Enabled = false;
            btnCancel.Enabled = true;
            btnSave.Enabled = true;
            btnEdit.Enabled = false;
            btnAddNew.Enabled = false;
        }

        public void EnterDetailsMode()
        {
            DisableInput();

            btnDelete.Enabled = true;
            btnCancel.Enabled = false;
            btnSave.Enabled = false;
            btnEdit.Enabled = true;
            btnAddNew.Enabled = true;
        }

        public void EnterReadMode()
        {
            ClearInputFields();
            DisableInput();
            //ClearSelectedAccounts();
            //ClearFilter();

            btnDelete.Enabled = false;
            btnCancel.Enabled = false;
            btnSave.Enabled = false;
            btnEdit.Enabled = false;
            btnAddNew.Enabled = true;
        }

        public void EnterAddNewMode()
        {
            ClearInputFields();
            EnableInput();

            btnDelete.Enabled = false;
            btnCancel.Enabled = true;
            btnSave.Enabled = true;
            btnEdit.Enabled = false;
            btnAddNew.Enabled = false;
        }

        public void EnterMultiSelectMode()
        {
            ClearInputFields();
            DisableInput();

            btnDelete.Enabled = false;
            btnCancel.Enabled = false;
            btnSave.Enabled = false;
            btnEdit.Enabled = false;
            btnAddNew.Enabled = true;
        }

        #endregion //Enter mode

        #endregion //IRequestView implementation

        #region Event handlers

        private void SetDetailData()
        {
            var item = _bindingSource.Current;
            Mapper.Map(item, this);
            EnterDetailsMode();
        }

        private void dgvItems_SelectionChanged(object sender, EventArgs e)
        {
            SetDetailData();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            _presenter.AddNew();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            _presenter.Edit();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _presenter.Save();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _presenter.Cancel();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _presenter.Delete();
        }

        private void RequestControl_ParentChanged(object sender, EventArgs e)
        {
            var control = (Control)sender;
            if (control.Parent == null) return;
            _presenter.SetItems();
            _presenter.LoadLists();
        }

        #endregion //Event handlers

        #region Private methods

        public void ClearInputFields()
        {
            tbId.Clear();
            tbName.Clear();
            cmbBank.SelectedIndex = -1;
            cmbCurrency.SelectedIndex = -1;
        }

        public void EnableInput()
        {
            //tbId.Enabled = true;
            tbName.Enabled = true;
            cmbBank.Enabled = true;
            cmbCurrency.Enabled = true;
        }

        public void DisableInput()
        {
            tbId.Enabled = false;
            tbName.Enabled = false;
            cmbBank.Enabled = false;
            cmbCurrency.Enabled = false;
        }

        #endregion //Private methods

        
    }
}
