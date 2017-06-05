using System;
using System.Collections.Generic;
using System.Windows.Forms;
using EPM.Wallet.Internal.Model;
using EPM.Wallet.WinForms.Interfaces;
using EPM.Wallet.WinForms.Presenters;

namespace EPM.Wallet.WinForms.Controls
{
    public partial class BankAccountControl : UserControl, IBankAccountView
    {
        private readonly IPresenter _presenter;
        private bool _isEventHandlerSets;

        public BankAccountControl(IBankAccountDataManager bankAccountDataManager, IDataMаnager dataMаnager)
        {
            InitializeComponent();
            _presenter = new BankAccountPresenter(this, bankAccountDataManager, dataMаnager);
        }

        #region IBankAccountView implementation

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

        public string BankAccountName
        {
            get { return tbName.Text; }
            set { tbName.Text = value; }
        }

        public Guid BankId
        {
            get { return (Guid) cmbBank.SelectedValue; }
            set { cmbBank.SelectedValue = value; }
        }

        public string CurrencyId
        {
            get { return (string) cmbCurrency.SelectedValue; }
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

        #endregion //Details

        #region DetailsLists

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

        #endregion //DetailsLists

        #endregion //IBankAccountView implementation

        #region IRefreshedView

        public void RefreshItems()
        {
            dgvItems.DataSource = _presenter.BindingSource;

            var column = dgvItems.Columns[nameof(BankAccountDto.Id)];
            if (column != null) column.Visible = false;
            column = dgvItems.Columns[nameof(BankAccountDto.BankId)];
            if (column != null) column.Visible = false;
        }

        public void SetEventHandlers()
        {
            if (_isEventHandlerSets) return;
            _isEventHandlerSets = true;

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