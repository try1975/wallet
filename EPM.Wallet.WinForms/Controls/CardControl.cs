using System;
using System.Collections.Generic;
using System.Windows.Forms;
using EPM.Wallet.WinForms.Interfaces;
using EPM.Wallet.WinForms.Presenters;

namespace EPM.Wallet.WinForms.Controls
{
    public partial class CardControl : UserControl, ICardView
    {
        private readonly IPresenter _presenter;

        public CardControl(ICardDataMаnager typedDataMаnager, IDataMаnager dataMаnager)
        {
            InitializeComponent();
            _presenter = new CardPresenter(this, typedDataMаnager, dataMаnager);
        }

        #region ICardView

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

        public string ClientId
        {
            get { return (string) cmbClient.SelectedValue; }
            set { cmbClient.SelectedValue = value; }
        }

        public string CurrencyId
        {
            get { return (string) cmbCurrency.SelectedValue; }
            set { cmbCurrency.SelectedValue = value; }
        }

        public string CardNumber
        {
            get { return tbCardNumber.Text; }
            set { tbCardNumber.Text = value; }
        }

        public string CardHolder
        {
            get { return tbCardHolder.Text; }
            set { tbCardHolder.Text = value; }
        }

        public int ExpMonth
        {
            get { return (int) udExpMonth.Value; }
            set { udExpMonth.Text = $"{value}"; }
        }

        public int ExpYear
        {
            get { return (int) udExpYear.Value; }
            set { udExpYear.Text = $"{value}"; }
        }

        public decimal Limit
        {
            get { return udLimit.Value; }
            set { udLimit.Value = value; }
        }

        public string Vendor { get; set; }

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

        #endregion //DetailsLists

        #endregion //ICardView

        #region IRefreshedView

        public void RefreshItems()
        {
            dgvItems.DataSource = _presenter.BindingSource;
        }

        public void SetEventHandlers()
        {
            dgvItems.SelectionChanged += dgvItems_SelectionChanged;
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
            cmbClient.SelectedIndex = -1;
            cmbCurrency.SelectedIndex = -1;
            tbCardNumber.Clear();
            tbCardHolder.Clear();
            udExpMonth.Value = udExpMonth.Minimum;
            udExpYear.Value = udExpYear.Minimum;
            udLimit.Value = udLimit.Minimum;
        }

        public void EnableInput()
        {
            //tbId.Enabled = true;
            cmbClient.Enabled = true;
            cmbCurrency.Enabled = true;
            tbCardNumber.Enabled = true;
            tbCardHolder.Enabled = true;
            udExpMonth.Enabled = true;
            udExpYear.Enabled = true;
            udLimit.Enabled = true;
        }

        public void DisableInput()
        {
            tbId.Enabled = false;
            cmbClient.Enabled = false;
            cmbCurrency.Enabled = false;
            tbCardNumber.Enabled = false;
            tbCardHolder.Enabled = false;
            udExpMonth.Enabled = false;
            udExpYear.Enabled = false;
            udLimit.Enabled = false;
        }

        #endregion //IEnterMode

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

        private void dgvItems_FilterStringChanged(object sender, EventArgs e)
        {
            _presenter.BindingSource.Filter = dgvItems.FilterString;
        }

        private void dgvItems_SortStringChanged(object sender, EventArgs e)
        {
            _presenter.BindingSource.Sort = dgvItems.SortString;
        }

        #endregion
    }
}