using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using AutoMapper;
using EPM.Wallet.Internal.Model;
using EPM.Wallet.WinForms.Interfaces;
using EPM.Wallet.WinForms.Presenters;

namespace EPM.Wallet.WinForms.Controls
{
    public partial class ClientAccountControl : UserControl, IClientAccountView
    {
        private readonly IPresenter _presenter;

        public ClientAccountControl(IClientAccountDataManager typedDataMаnager, IDataMаnager dataMаnager)
        {
            InitializeComponent();
            SetEventHandlers();
            _presenter = new ClientAccountPresenter(this, typedDataMаnager, dataMаnager);
        }

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

        public string ClientAccountName
        {
            get { return tbName.Text; }
            set { tbName.Text = value; }
        }

        public string ClientId
        {
            get { return (string)cmbClient.SelectedValue; }
            set { cmbClient.SelectedValue = value; }
        }

        public string CurrencyId
        {
            get { return (string)cmbCurrency.SelectedValue; }
            set { cmbCurrency.SelectedValue = value; }
        }
        public Guid BankAccountId { get; set; }

        public string ClientAccountStatusId
        {
            get { return (string) cmbClientAccountStatus.SelectedValue; }
            set { cmbClientAccountStatus.SelectedValue = value; }
        }
        public decimal CurrentBalance { get; set; }

        #endregion //Details

        #region DetailsLists

        public List<AccountDto> Items { get; set; }
        public List<KeyValuePair<string, string>> ClientList
        {
            set
            {
                cmbClient.DataSource = value;
                cmbClient.ValueMember = "Key";
                cmbClient.DisplayMember = "Value";
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
        public List<KeyValuePair<Guid, string>> BankAccounList { get; set; }

        public List<KeyValuePair<string, string>> ClientAccountStatusList
        {
            set
            {
                cmbClientAccountStatus.DataSource = value;
                cmbClientAccountStatus.ValueMember = "Key";
                cmbClientAccountStatus.DisplayMember = "Value";
            }
        }

        #endregion //DetailsLists

        #region interface methods

        public void RefreshItems()
        {
            dgvItems.DataSource = _presenter.BindingSource;
        }

        public void SetEventHandlers()
        {
            dgvItems.SelectionChanged += dgvItems_SelectionChanged;
            btnAddNew.Click += btnAddNew_Click;
            btnEdit.Click += btnEdit_Click;
            btnSave.Click += btnSave_Click;
            btnCancel.Click += btnCancel_Click;
            btnDelete.Click += btnDelete_Click;
        }

        #region Mode

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

            btnDelete.Enabled = false;
            btnCancel.Enabled = false;
            btnSave.Enabled = false;
            btnEdit.Enabled = false;
            btnAddNew.Enabled = true;
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

        public void ClearInputFields()
        {
            tbId.Clear();
            tbName.Clear();
            cmbClient.SelectedIndex = -1;
            cmbCurrency.SelectedIndex = -1;
            cmbClientAccountStatus.SelectedIndex = -1;
        }

        public void EnableInput()
        {
            //tbId.Enabled = true;
            tbName.Enabled = true;
            cmbClient.Enabled = true;
            cmbCurrency.Enabled = true;
            cmbClientAccountStatus.Enabled = true;
        }

        public void DisableInput()
        {
            tbId.Enabled = false;
            tbName.Enabled = false;
            cmbClient.Enabled = false;
            cmbCurrency.Enabled = false;
            cmbClientAccountStatus.Enabled = false;
        }

        #endregion

        public void ItemAdded(AccountDto item)
        {
            Items.Add(item);
            _presenter.BindingSource.ResetBindings(false);
        }

        public void ItemUpdated(AccountDto item)
        {
            if (item == null) return;
            var existItem = Items.FirstOrDefault(i => i.Id.Equals(item.Id));
            if (existItem == null) return;
            Mapper.Map(item, existItem);
            _presenter.BindingSource.ResetBindings(false);
        }

        public void ItemRemoved(Guid id)
        {
            var existItem = Items.FirstOrDefault(i => i.Id == id);
            if (existItem == null) return;
            Items.Remove(existItem);
            _presenter.BindingSource.ResetBindings(false);
        }

        #endregion //interface methods

        #region Event handlers

        private void dgvItems_SelectionChanged(object sender, EventArgs e)
        {
            _presenter.SetDetailData();
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

        #endregion
    }
}