using System;
using System.Globalization;
using System.Windows.Forms;
using EPM.Wallet.Internal.Model;
using EPM.Wallet.WinForms.Interfaces;

namespace EPM.Wallet.WinForms.Forms
{
    public partial class RefillForm : Form
    {
        private readonly IDataMаnager _dataMаnager;
        public RefillForm(IDataMаnager dataMаnager)
        {
            InitializeComponent();
            _dataMаnager = dataMаnager;
        }

        private void RefillForm_Load(object sender, EventArgs e)
        {
            SetAmount();
        }

        private async void SetAmount()
        {
            tbAmountCurrencyOut.Text = AmountCurrencyOut.ToString("N2", new CultureInfo("en-GB"));
            AmountCurrencyIn = AmountCurrencyOut * -1;

            var accountOutDto = await _dataMаnager.GetClientAccount(AccountId);
            if (accountOutDto == null) return;
            if (accountOutDto.CurrencyId.Equals(CurrencyId))
            {
                AmountOut = AmountCurrencyOut;
            }
            var accountInDto = await _dataMаnager.GetClientAccount(BeneficiaryAccountId);
            if (accountInDto == null) return;
            if (accountInDto.CurrencyId.Equals(CurrencyId))
            {
                AmountIn = AmountCurrencyOut * -1;
            }
        }

        #region Details

        public Guid AccountId { private get; set; }
        public Guid BeneficiaryAccountId { private get; set; }

        public string AccountName
        {
            get { return tbAccountName.Text; }
            set { tbAccountName.Text = value; }
        }

        public string BeneficiaryAccountName
        {
            get { return tbBeneficiaryAccountName.Text; }
            set { tbBeneficiaryAccountName.Text = value; }
        }

        public DateTime ValueDate
        {
            private get
            {
                return string.IsNullOrEmpty(tbValueDate.Text) ? DateTime.UtcNow : DateTime.Parse(tbValueDate.Text);
            }
            set { tbValueDate.Text = value.ToString(CultureInfo.CurrentCulture); }
        }

        private decimal AmountOut
        {
            get
            {
                decimal decimalResult;
                return decimal.TryParse(tbAmountOut.Text, NumberStyles.Number, new CultureInfo("en-GB"),
                    out decimalResult)
                    ? decimalResult
                    : 0;
            }
            set { tbAmountOut.Text = value.ToString("N2", new CultureInfo("en-GB")); }
        }

        private decimal AmountIn
        {
            get
            {
                decimal decimalResult;
                return decimal.TryParse(tbAmountIn.Text, NumberStyles.Number, new CultureInfo("en-GB"),
                    out decimalResult)
                    ? decimalResult
                    : 0;
            }
            set { tbAmountIn.Text = value.ToString("N2", new CultureInfo("en-GB")); }
        }

        public string CurrencyId
        {
            private get { return tbCurrencyId.Text; }
            set { tbCurrencyId.Text = value; }
        }

        private decimal AmountCurrencyIn { get; set; }

        public decimal AmountCurrencyOut { private get; set; }

        public string FromToOut
        {
            private get { return tbFromToOut.Text; }
            set { tbFromToOut.Text = value; }
        }

        public string FromToIn
        {
            private get { return tbFromToIn.Text; }
            set { tbFromToIn.Text = value; }
        }

        private string NoteOut => tbNoteOut.Text;

        private string NoteIn => tbNoteIn.Text;

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
            if (AmountOut == 0 || AmountIn == 0)
            {
                MessageBox.Show(@"Amount can't be empty");
                return;
            }

            try
            {
                var dtoOut = new TransactionDto
                {
                    AccountId = AccountId,
                    CurrencyId = CurrencyId,
                    RegisterDate = DateTime.UtcNow,
                    ValueDate = ValueDate,
                    Amount = AmountOut,
                    AmountInCurrency = AmountCurrencyOut,
                    FromTo = FromToOut,
                    Note = NoteOut,
                    //StandingOrderId = StandingOrderId,
                    RequestId = RequestId
                };
                dtoOut = await _dataMаnager.PostTransaction(dtoOut);
                if (dtoOut == null || dtoOut.Id.Equals(Guid.Empty))
                {
                    MessageBox.Show(@"Transaction not created");
                    return;
                }
                var dtoIn = new TransactionDto
                {
                    AccountId = BeneficiaryAccountId,
                    CurrencyId = CurrencyId,
                    RegisterDate = DateTime.UtcNow,
                    ValueDate = ValueDate,
                    Amount = AmountIn,
                    AmountInCurrency = AmountCurrencyIn,
                    FromTo = FromToIn,
                    Note = NoteIn,
                    //StandingOrderId = StandingOrderId,
                    RequestId = RequestId
                };
                dtoIn = await _dataMаnager.PostTransaction(dtoIn);
                if (dtoIn == null || dtoIn.Id.Equals(Guid.Empty))
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