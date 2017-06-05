using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;
using EPM.Wallet.WinForms.Interfaces;
using EPM.Wallet.WinForms.Presenters;

namespace EPM.Wallet.WinForms.Forms
{
    public partial class TransactionByRequestForm : Form, ITransactionView
    {
        private readonly IPresenter _transactionPresenter;
        private bool _isEventHandlerSets;

        public TransactionByRequestForm(ITransactionDataManager transactionDataManager, IDataMаnager dataMаnager)
        {
            InitializeComponent();
            _transactionPresenter = new TransactionPresenter(this, transactionDataManager, dataMаnager,
                PresenterMode.AddNew);
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

        public Guid AccountId { get; set; }

        public string AccountName
        {
            get { return tbAccountName.Text; }
            set { tbAccountName.Text = value; }
        }

        public DateTime RegisterDate
        {
            get
            {
                if (string.IsNullOrEmpty(tbRegisterDate.Text)) return DateTime.UtcNow;
                return DateTime.Parse(tbRegisterDate.Text);
            }
            set { tbRegisterDate.Text = value.ToString(CultureInfo.CurrentCulture); }
        }

        public DateTime ValueDate
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
            set
            {
                tbAmount.Text = value.ToString("N2", new CultureInfo("en-GB"));
                ;
            }
        }

        public string CurrencyId
        {
            get { return (string) cmbCurrency.SelectedValue; }
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
            set { tbAmountInCurrency.Text = value.ToString("N2", new CultureInfo("en-GB")); }
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

        public List<KeyValuePair<Guid, string>> AccountList { get; set; }

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
            _transactionPresenter.AddNew();
        }

        public void SetEventHandlers()
        {
            if (_isEventHandlerSets) return;
            _isEventHandlerSets = true;
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
        }

        public void EnableInput()
        {
        }

        public void DisableInput()
        {
        }

        #endregion //IEnterMode

        #region Event handlers

        private void btnOk_Click(object sender, EventArgs e)
        {
            _transactionPresenter.Save();
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _transactionPresenter.Cancel();
            DialogResult = DialogResult.Cancel;
        }

        #endregion //Event handlers
    }
}