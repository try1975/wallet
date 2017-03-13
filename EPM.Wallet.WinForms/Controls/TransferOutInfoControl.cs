﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using AutoMapper;
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
            SetEventHandlers();
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
        public DateTime? ValueDate { get; set; }

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
        { get { return (RequestStatus)cmbRequestStatus.SelectedValue; }
            set { cmbRequestStatus.SelectedValue = value; } }
        public string Note { get; set; }
        public Guid? AccountId {
            get
            {
                if (string.IsNullOrEmpty(tbAccount.Text)) return Guid.Empty;
                Guid id;
                return Guid.TryParse(tbAccount.Text, out id) ? id : Guid.Empty;
            }
            set { tbAccount.Text = value.ToString(); }
        }
        public decimal AmountOut {
            get { return Convert.ToDecimal(tbAmountOut.Text); }
            set { tbAmountOut.Text = value.ToString(CultureInfo.InvariantCulture); }
        }
        public string BankName { get; set; }
        public string Iban { get; set; }
        public string BankAddress { get; set; }
        public string Bic { get; set; }
        public string OwnerName { get; set; }

        #endregion //Details

        #region DetailsLists

        public List<TransferOutInfoDto> Items { get; set; }

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

        #region ListOperations

        public void RefreshItems()
        {
            dgvItems.DataSource = _presenter.BindingSource;
        }

        public void ItemAdded(TransferOutInfoDto item)
        {
            Items.Add(item);
            _presenter.BindingSource.ResetBindings(false);
        }

        public void ItemUpdated(TransferOutInfoDto item)
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

        #endregion //ListOperations

        #endregion //ITransferOutView implementation

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
            tbAccount.Clear();
           // cmbTransferOutStatus.SelectedIndex = -1;
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
        }

        #endregion //Mode

        #region Event handlers

        public void SetEventHandlers()
        {
            dgvItems.SelectionChanged += dgvItems_SelectionChanged;
            btnAddNew.Click += btnAddNew_Click;
            btnEdit.Click += btnEdit_Click;
            btnSave.Click += btnSave_Click;
            btnCancel.Click += btnCancel_Click;
            btnDelete.Click += btnDelete_Click;
        }

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

        #endregion //Event handlers
    }
}
