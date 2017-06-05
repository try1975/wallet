using System;
using System.Collections.Generic;
using System.Windows.Forms;
using EPM.Wallet.Common.Enums;
using EPM.Wallet.Internal.Model;
using EPM.Wallet.WinForms.Interfaces;
using EPM.Wallet.WinForms.Presenters;

namespace EPM.Wallet.WinForms.Controls
{
    public partial class CardControl : UserControl, ICardView
    {
        private readonly IPresenter _presenter;
        private bool _isEventHandlerSets;

        public CardControl(ICardDataMаnager typedDataMаnager, IDataMаnager dataMаnager)
        {
            InitializeComponent();
            _presenter = new CardPresenter(this, typedDataMаnager, dataMаnager);
        }

        #region ICardView

        #region Details

        public Guid Id { get; set; }

        public CardStatus CardStatus {
            get { return (CardStatus)cmbCardStatus.SelectedValue; }
            set { cmbCardStatus.SelectedValue = value; }
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

        public string Cvc {
            get { return tbCvc.Text; }
            set { tbCvc.Text = value; }
        }
        public string Pin {
            get { return tbPin.Text; }
            set { tbPin.Text = value; }
        }

        public string Vendor {
            get { return tbVendor.Text; }
            set { tbVendor.Text = value; }
        }

        public string Comment {
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

        public List<KeyValuePair<CardStatus, string>> CardStatusList {
            set
            {
                cmbCardStatus.DataSource = value;
                cmbCardStatus.ValueMember = "Key";
                cmbCardStatus.DisplayMember = "Value";
            }
        }

        #endregion //DetailsLists

        #endregion //ICardView

        #region IRefreshedView

        public void RefreshItems()
        {
            dgvItems.DataSource = _presenter.BindingSource;

            var hidedColumn = dgvItems.Columns[nameof(CardDto.Id)];
            if (hidedColumn != null) hidedColumn.Visible = false;
        }

        public void SetEventHandlers()
        {
            if (_isEventHandlerSets) return;
            _isEventHandlerSets = true;

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
            cmbCardStatus.SelectedIndex = -1;
            cmbClient.SelectedIndex = -1;
            cmbCurrency.SelectedIndex = -1;
            tbCardNumber.Clear();
            tbCardHolder.Clear();
            udExpMonth.Value = udExpMonth.Minimum;
            udExpYear.Value = udExpYear.Minimum;
            udLimit.Value = udLimit.Minimum;
            tbCvc.Clear();
            tbPin.Clear();
            tbVendor.Clear();
            tbComment.Clear();
        }

        public void EnableInput()
        {
            cmbCardStatus.Enabled = true;
            cmbClient.Enabled = true;
            cmbCurrency.Enabled = true;
            tbCardNumber.Enabled = true;
            tbCardHolder.Enabled = true;
            udExpMonth.Enabled = true;
            udExpYear.Enabled = true;
            udLimit.Enabled = true;
            tbCvc.Enabled = true;
            tbPin.Enabled = true;
            tbVendor.Enabled = true;
            tbComment.Enabled = true;
        }

        public void DisableInput()
        {
            cmbCardStatus.Enabled = false;
            cmbClient.Enabled = false;
            cmbCurrency.Enabled = false;
            tbCardNumber.Enabled = false;
            tbCardHolder.Enabled = false;
            udExpMonth.Enabled = false;
            udExpYear.Enabled = false;
            udLimit.Enabled = false;
            tbCvc.Enabled = false;
            tbPin.Enabled = false;
            tbVendor.Enabled = false;
            tbComment.Enabled = false;
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