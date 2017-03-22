﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;
using EPM.Wallet.Common.Enums;
using EPM.Wallet.Internal.Model;
using EPM.Wallet.WinForms.Interfaces;
using EPM.Wallet.WinForms.Presenters;

namespace EPM.Wallet.WinForms.Controls
{
    public partial class TransferOutInfoControl : UserControl, ITransferOutInfoView
    {
        private readonly IPresenter _presenter;

        public TransferOutInfoControl(ITransferOutInfoDataManager typedDataMаnager, IDataMаnager dataMаnager)
        {
            InitializeComponent();
            _presenter = new TransferOutInfoPresenter(this, typedDataMаnager, dataMаnager);
        }

        #region ITransferOutView implementation

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

        public DateTime Date { get; set; }

        public DateTime? ValueDate
        {
            get
            {
                if (!string.IsNullOrEmpty(tbValueDate.Text)) return DateTime.Parse(tbValueDate.Text);
                return null;
            }
            set
            {
                tbValueDate.Text = "";
                if (value.HasValue) tbValueDate.Text = value.ToString();
            }
        }

        public string ClientId
        {
            get { return tbClientId.Text; }
            set { tbClientId.Text = value; }
        }

        public string CurrencyId
        {
            get { return tbCurrencyId.Text; }
            set { tbCurrencyId.Text = value; }
        }

        public RequestStatus RequestStatus
        {
            get { return (RequestStatus) cmbRequestStatus.SelectedValue; }
            set { cmbRequestStatus.SelectedValue = value; }
        }

        public string Note
        {
            get { return tbNote.Text; }
            set { tbNote.Text = value; }
        }

        public Guid? AccountId
        {
            get
            {
                if (string.IsNullOrEmpty(tbAccount.Text)) return Guid.Empty;
                Guid id;
                return Guid.TryParse(tbAccount.Text, out id) ? id : Guid.Empty;
            }
            set { tbAccount.Text = value.ToString(); }
        }

        public decimal AmountOut
        {
            get
            {
                decimal decimalResult;
                return decimal.TryParse(tbAmountOut.Text, NumberStyles.Number, new CultureInfo("en-GB"),
                    out decimalResult)
                    ? decimalResult
                    : 0;
            }
            set { tbAmountOut.Text = value.ToString(CultureInfo.InvariantCulture); }
        }

        public string BankName
        {
            get { return tbBankName.Text; }
            set { tbBankName.Text = value; }
        }

        public string Iban
        {
            get { return tbIban.Text; }
            set { tbIban.Text = value; }
        }

        public string BankAddress
        {
            get { return tbBankAddress.Text; }
            set { tbBankAddress.Text = value; }
        }

        public string Bic
        {
            get { return tbBic.Text; }
            set { tbBic.Text = value; }
        }

        public string OwnerName
        {
            get { return tbOwnerName.Text; }
            set { tbOwnerName.Text = value; }
        }

        #endregion //Details

        #region DetailsLists

        public List<KeyValuePair<RequestStatus, string>> RequestStatusList
        {
            set
            {
                cmbRequestStatus.DataSource = value;
                cmbRequestStatus.ValueMember = "Key";
                cmbRequestStatus.DisplayMember = "Value";
            }
        }

        #endregion //DetailsLists

        #endregion //ITransferOutView implementation

        #region IRefreshedView

        public void RefreshItems()
        {
            dgvItems.DataSource = _presenter.BindingSource;
            // hide columns
            var column = dgvItems.Columns[nameof(TransferOutInfoDto.Id)];
            if (column != null) column.Visible = false;
            column = dgvItems.Columns[nameof(TransferOutInfoDto.AccountId)];
            if (column != null) column.Visible = false;
            // sort mode
            //column = dgvItems.Columns[nameof(TransferOutInfoDto.Date)];
            //if (column != null) column.SortMode=DataGridViewColumnSortMode.Automatic;
        }

        public void SetEventHandlers()
        {
            dgvItems.FilterStringChanged += dgvItems_FilterStringChanged;
            dgvItems.SortStringChanged += dgvItems_SortStringChanged;

            btnEdit.Click += btnEdit_Click;
            btnSave.Click += btnSave_Click;
            btnCancel.Click += btnCancel_Click;
        }

        #endregion //IRefreshedView

        #region IEnterMode

        public void EnterAddNewMode()
        {
            ClearInputFields();
            EnableInput();


            btnCancel.Enabled = true;
            btnSave.Enabled = true;
            btnEdit.Enabled = false;
        }

        public void EnterEditMode()
        {
            EnableInput();


            btnCancel.Enabled = true;
            btnSave.Enabled = true;
            btnEdit.Enabled = false;
        }

        public void EnterDetailsMode()
        {
            DisableInput();


            btnCancel.Enabled = false;
            btnSave.Enabled = false;
            btnEdit.Enabled = true;
        }

        public void EnterReadMode()
        {
            ClearInputFields();
            DisableInput();


            btnCancel.Enabled = false;
            btnSave.Enabled = false;
            btnEdit.Enabled = false;
        }

        public void EnterMultiSelectMode()
        {
            ClearInputFields();
            DisableInput();


            btnCancel.Enabled = false;
            btnSave.Enabled = false;
            btnEdit.Enabled = false;
        }

        public void ClearInputFields()
        {
            tbId.Clear();
            tbAccount.Clear();
            tbClientId.Clear();
            tbAmountOut.Clear();
            tbCurrencyId.Clear();
            cmbRequestStatus.SelectedIndex = -1;
            tbValueDate.Clear();
            tbBankName.Clear();
            tbIban.Clear();
            tbBankAddress.Clear();
            tbBic.Clear();
            tbOwnerName.Clear();
        }

        public void EnableInput()
        {
            cmbRequestStatus.Enabled = true;
        }

        public void DisableInput()
        {
            tbId.Enabled = false;
            tbAccount.Enabled = false;
            tbClientId.Enabled = false;
            tbAmountOut.Enabled = false;
            tbCurrencyId.Enabled = false;
            cmbRequestStatus.Enabled = false;
            tbValueDate.Enabled = false;
            tbBankName.Enabled = false;
            tbIban.Enabled = false;
            tbBankAddress.Enabled = false;
            tbBic.Enabled = false;
            tbOwnerName.Enabled = false;
        }

        #endregion //IEnterMode

        #region Event handlers

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