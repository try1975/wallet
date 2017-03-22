using System;
using System.Collections.Generic;
using System.Windows.Forms;
using EPM.Wallet.Common.Enums;
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
            _presenter = new ClientAccountPresenter(this, typedDataMаnager, dataMаnager);
        }

        #region IClientAccountView implementation

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
            get { return (string) cmbClient.SelectedValue; }
            set { cmbClient.SelectedValue = value; }
        }

        public string CurrencyId
        {
            get
            {
                return (string) cmbCurrency.SelectedValue;
            }
            set
            {
                cmbCurrency.SelectedValue = value;
            }
        }

        public Guid BankAccountId
        {
            get { return (Guid)cmbBankAccount.SelectedValue; }
            set { cmbBankAccount.SelectedValue = value; }
        }

        public ClientAccountStatus ClientAccountStatus
        {
            get { return (ClientAccountStatus) cmbClientAccountStatus.SelectedValue; }
            set { cmbClientAccountStatus.SelectedValue = value; }
        }

        public decimal CurrentBalance { get; set; }

        public string Comment
        {
            get { return tbComment.Text; }
            set { tbComment.Text = value; }
        }

        #endregion //Details

        #region DetailsLists

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

        public List<KeyValuePair<Guid, string>> BankAccounList {
            set
            {
                cmbBankAccount.DataSource = value;
                cmbBankAccount.ValueMember = "Key";
                cmbBankAccount.DisplayMember = "Value";
            }
        }

        public List<KeyValuePair<ClientAccountStatus, string>> ClientAccountStatusList
        {
            set
            {
                cmbClientAccountStatus.DataSource = value;
                cmbClientAccountStatus.ValueMember = "Key";
                cmbClientAccountStatus.DisplayMember = "Value";
            }
        }

        #endregion //DetailsLists

        #endregion //IClientAccountView implementation

        #region IRefreshedView

        public void RefreshItems()
        {
            dgvItems.DataSource = _presenter.BindingSource;
            // hide columns
            var column = dgvItems.Columns[nameof(AccountDto.Id)];
            if (column != null) column.Visible = false;
            column = dgvItems.Columns[nameof(AccountDto.Requisite)];
            if (column != null) column.Visible = false;
            column = dgvItems.Columns[nameof(AccountDto.BankAccountId)];
            if (column != null) column.Visible = false;
        }

        public void SetEventHandlers()
        {
            dgvItems.FilterStringChanged += dgvItems_FilterStringChanged;
            dgvItems.SortStringChanged += dgvItems_SortStringChanged;

            btnAddNew.Click += btnAddNew_Click;
            btnEdit.Click += btnEdit_Click;
            btnSave.Click += btnSave_Click;
            btnCancel.Click += btnCancel_Click;
            btnDelete.Click += btnDelete_Click;
        }

        #endregion //IRefreshedView

        #region IEnterMode

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
            cmbBankAccount.SelectedIndex = -1;
        }

        public void EnableInput()
        {
            tbName.Enabled = true;
            if (_presenter.PresenterMode == PresenterMode.AddNew)
            {
                cmbClient.Enabled = true;
                cmbCurrency.Enabled = true;
            }
            cmbClientAccountStatus.Enabled = true;
            cmbBankAccount.Enabled = true;
            tbComment.Enabled = true;
        }

        public void DisableInput()
        {
            tbId.Enabled = false;
            tbName.Enabled = false;
            cmbClient.Enabled = false;
            cmbCurrency.Enabled = false;
            cmbClientAccountStatus.Enabled = false;
            cmbBankAccount.Enabled = false;
            tbComment.Enabled = false;
        }

        #endregion //IEnterMode

        #region Event handlers

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

        private void dgvItems_FilterStringChanged(object sender, EventArgs e)
        {
            _presenter.BindingSource.Filter = dgvItems.FilterString;
        }

        private void dgvItems_SortStringChanged(object sender, EventArgs e)
        {
            _presenter.BindingSource.Sort = dgvItems.SortString;
        }

        #endregion //Event handlers
    }
}