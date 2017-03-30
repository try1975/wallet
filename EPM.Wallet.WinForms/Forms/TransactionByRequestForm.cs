﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;
using EPM.Wallet.Internal.Model;
using EPM.Wallet.WinForms.Interfaces;
using EPM.Wallet.WinForms.Presenters;

namespace EPM.Wallet.WinForms.Forms
{
    public partial class TransactionByRequestForm : Form, ITransactionView
    {
        private readonly IPresenter _presenter;
        public TransactionByRequestForm(ITransactionDataManager transactionDataManager, IDataMаnager dataMаnager)
        {
            InitializeComponent();
            _presenter = new TransactionPresenter(this, transactionDataManager, dataMаnager);
        }

        

        #region ITransactionView

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

        public Guid AccountId
        {
            get { return (Guid)cmbAccount.SelectedValue; }
            set { cmbAccount.SelectedValue = value; }
        }

        public DateTimeOffset RegisterDate
        {
            get
            {
                if (string.IsNullOrEmpty(tbRegisterDate.Text)) return DateTime.Now;
                return DateTime.Parse(tbRegisterDate.Text);
            }
            set { tbRegisterDate.Text = value.ToString(CultureInfo.CurrentCulture); }
        }

        public DateTimeOffset ValueDate
        {
            get
            {
                if (string.IsNullOrEmpty(tbValueDate.Text)) return DateTime.UtcNow;
                return DateTime.Parse(tbValueDate.Text);
            }
            set { tbValueDate.Text = value.ToString(CultureInfo.CurrentCulture); }
        }

        public decimal Amount
        {
            get
            {
                decimal decimalResult;
                return decimal.TryParse(tbAmount.Text, NumberStyles.Number, new CultureInfo("en-GB"),
                    out decimalResult)
                    ? decimalResult
                    : 0;
            }
            set { tbAmount.Text = value.ToString(CultureInfo.InvariantCulture); }
        }

        public string CurrencyId
        {
            get { return (string)cmbCurrency.SelectedValue; }
            set { cmbCurrency.SelectedValue = value; }
        }

        public decimal AmountInCurrency
        {
            get
            {
                decimal decimalResult;
                return decimal.TryParse(tbAmountInCurrency.Text, NumberStyles.Number, new CultureInfo("en-GB"),
                    out decimalResult)
                    ? decimalResult
                    : 0;
            }
            set { tbAmountInCurrency.Text = value.ToString(CultureInfo.InvariantCulture); }
        }

        public decimal Balance
        {
            get { return 0; }
            set { tbBalance.Text = value.ToString(CultureInfo.InvariantCulture); }
        }

        public string FromTo
        {
            get { return tbFromTo.Text; }
            set { tbFromTo.Text = value; }
        }

        public string Note
        {
            get { return tbNote.Text; }
            set { tbNote.Text = value; }
        }

        public Guid? RequestId { get; set; }
        public Guid? StandingOrderId { get; set; }

        public DateTime Date
        {
            get
            {
                if (string.IsNullOrEmpty(tbRegisterDate.Text)) return DateTime.UtcNow;
                return DateTime.Parse(tbRegisterDate.Text);
            }
            set { tbRegisterDate.Text = value.ToString(CultureInfo.CurrentCulture); }
        }

        #endregion //Details

        #region DetailsLists

        public List<KeyValuePair<Guid, string>> AccountList
        {
            set
            {
                cmbAccount.DataSource = value;
                cmbAccount.ValueMember = "Key";
                cmbAccount.DisplayMember = "Value";
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

        #endregion //ITransactionView

        #region IRefreshedView

        public void RefreshItems()
        {
            _presenter.AddNew();
        }

        public void SetEventHandlers()
        {
        }

        #endregion //IRefreshedView

        #region IEnterMode

        public void EnterEditMode()
        {
            EnableInput();
        }

        public void EnterDetailsMode()
        {
            DisableInput();
        }

        public void EnterReadMode()
        {
            ClearInputFields();
            DisableInput();
            //ClearSelectedAccounts();
            //ClearFilter();
        }

        public void EnterAddNewMode()
        {
            ClearInputFields();
            EnableInput();
        }

        public void EnterMultiSelectMode()
        {
            ClearInputFields();
            DisableInput();
        }

        public void ClearInputFields()
        {
            tbId.Clear();
            cmbAccount.SelectedIndex = -1;
            tbRegisterDate.Clear();
            tbValueDate.Clear();
            tbAmount.Clear();
            tbAmountInCurrency.Clear();
            cmbCurrency.SelectedIndex = -1;
            tbFromTo.Clear();
            tbNote.Clear();
        }

        public void EnableInput()
        {
            cmbAccount.Enabled = true;
            tbRegisterDate.Enabled = true;
            tbAmount.Enabled = true;
            tbAmountInCurrency.Enabled = true;
            cmbCurrency.Enabled = true;
            tbFromTo.Enabled = true;
            tbNote.Enabled = true;
        }

        public void DisableInput()
        {
            tbId.Enabled = false;
            cmbAccount.Enabled = false;
            tbRegisterDate.Enabled = false;
            tbValueDate.Enabled = false;
            tbAmount.Enabled = false;
            cmbCurrency.Enabled = false;
            tbAmountInCurrency.Enabled = false;
            tbFromTo.Enabled = false;
            tbNote.Enabled = false;
        }

        #endregion //IEnterMode

        #region Event handlers

        private void btnOk_Click(object sender, EventArgs e)
        {
            _presenter.Save();
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _presenter.Cancel();
            DialogResult = DialogResult.Cancel;
        }

        #endregion //Event handlers
    }
}