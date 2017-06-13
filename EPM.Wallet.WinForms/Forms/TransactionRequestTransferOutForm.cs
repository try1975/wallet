using System;
using System.Globalization;
using System.Windows.Forms;
using EPM.Wallet.Internal.Model;
using EPM.Wallet.WinForms.Interfaces;

namespace EPM.Wallet.WinForms.Forms
{
    public partial class TransactionRequestTransferOutForm : Form
    {
        private readonly IDataMаnager _dataMаnager;
        public TransactionRequestTransferOutForm(IDataMаnager dataMаnager)
        {
            InitializeComponent();
            _dataMаnager = dataMаnager;
        }

        private void TransactionRequestTransferOutForm_Load(object sender, EventArgs e)
        {
            SetAmount();
        }

        private async void SetAmount()
        {
            var accountDto = await _dataMаnager.GetClientAccount(AccountId);
            if (accountDto == null) return;
            if (accountDto.CurrencyId.Equals(CurrencyId))
            {
                Amount = AmountInCurrency;
            }
        }

        #region Details

        public Guid AccountId { private get; set; }

        public string AccountName
        {
            get { return tbAccountName.Text; }
            set { tbAccountName.Text = value; }
        }

        public DateTime ValueDate
        {
            private get
            {
                return string.IsNullOrEmpty(tbValueDate.Text) ? DateTime.UtcNow : DateTime.Parse(tbValueDate.Text);
            }
            set { tbValueDate.Text = value.ToString(CultureInfo.CurrentCulture); }
        }

        private decimal Amount
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
            }
        }

        public string CurrencyId
        {
            private get { return tbCurrencyId.Text; }
            set { tbCurrencyId.Text = value; }
        }

        public decimal AmountInCurrency
        {
            private get
            {
                decimal decimalResult;
                return decimal.TryParse(tbAmountInCurrency.Text, NumberStyles.Number, new CultureInfo("en-GB"),
                    out decimalResult)
                    ? decimalResult
                    : 0;
            }
            set { tbAmountInCurrency.Text = value.ToString("N2", new CultureInfo("en-GB")); }
        }

        public string FromTo
        {
            private get { return tbFromTo.Text; }
            set { tbFromTo.Text = value; }
        }

        public string Note
        {
            private get { return tbNote.Text; }
            set { tbNote.Text = value; }
        }

        public Guid? RequestId { private get; set; }
        //public Guid? StandingOrderId { get; set; }

        #endregion //Details


        #region Event handlers

        private void btnOk_Click(object sender, EventArgs e)
        {
            CreateNewTransaction();
        }

        private async void CreateNewTransaction()
        {
            if (Amount == 0)
            {
                MessageBox.Show(@"Amount can't be empty");
                return;
            }

            try
            {
                var dto = new TransactionDto()
                {
                    AccountId = AccountId,
                    CurrencyId = CurrencyId,
                    RegisterDate = DateTime.UtcNow,
                    ValueDate = ValueDate,
                    Amount = Amount,
                    AmountInCurrency = AmountInCurrency,
                    FromTo = FromTo,
                    Note = Note,
                    //StandingOrderId = StandingOrderId,
                    RequestId = RequestId

                };
                dto = await _dataMаnager.PostTransaction(dto);
                if (dto == null || dto.Id.Equals(Guid.Empty))
                {
                    MessageBox.Show(@"Transaction not created");
                    return;
                }
                DialogResult = DialogResult.OK;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        #endregion //Event handlers
    }
}