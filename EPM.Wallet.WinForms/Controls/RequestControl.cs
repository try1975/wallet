using System;
using System.Globalization;
using System.Windows.Forms;
using EPM.Wallet.Common.Enums;
using EPM.Wallet.Internal.Model;
using EPM.Wallet.WinForms.Forms;
using EPM.Wallet.WinForms.Interfaces;
using EPM.Wallet.WinForms.Ninject;
using EPM.Wallet.WinForms.Presenters;

namespace EPM.Wallet.WinForms.Controls
{
    public partial class RequestControl : UserControl, IRequestView
    {
        private readonly IPresenter _presenter;
        private bool _isEventHandlerSets;

        public RequestControl(IRequestDataManager requestDataManager, IDataMаnager dataMаnager)
        {
            InitializeComponent();
            _presenter = new RequestPresenter(this, requestDataManager, dataMаnager);
        }

        #region IRequestView implementation

        #region Details

        public Guid Id { get; set; }

        public string CurrencyId
        {
            get { return tbCurrencyId.Text; }
            set { tbCurrencyId.Text = value; }
        }

        public RequestStatus RequestStatus { get; set; }

        public string ClientId { get; set; }

        public string ClientName { get; set; }

        public RequestType RequestType { get; set; }
        public string Type { get; set; }
        public string SubType { get; set; }

        public string Status { get; set; }
        public Guid? CardId { get; set; }

        public string CardNumber
        {
            get { return tbCardNumber.Text; }
            set { tbCardNumber.Text = value; }
        }

        public Guid? ClientAccountId { get; set; }

        public string AccountName { get; set; }

        public string VisibleAccountName
        {
            get { return tbAccountName.Text; }
            set { tbAccountName.Text = value; }
        }

        public string AccountCurrencyId { get; set; }

        public Guid? BeneficiaryAccountId { get; set; }

        public string BeneficiaryAccountName
        {
            get { return tbBeneficiaryAccountName.Text; }
            set { tbBeneficiaryAccountName.Text = value; }
        }

        public string BeneficiaryCurrencyId { get; set; }

        public DateTime? ValueDate
        {
            get
            {
                if (string.IsNullOrEmpty(tbValueDate.Text)) return DateTime.UtcNow;
                return DateTime.Parse(tbValueDate.Text);
            }
            set
            {
                if (value != null) tbValueDate.Text = value.Value.ToString(CultureInfo.CurrentCulture);
                else tbValueDate.Clear();
            }
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

        public decimal AmountIn
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
            set { tbAmountOut.Text = value.ToString("N2", new CultureInfo("en-GB")); }
        }

        public int Limit {
            get
            {
                int intResult;
                return int.TryParse(tbLimit.Text, NumberStyles.Number, new CultureInfo("en-GB"),
                    out intResult)
                    ? intResult
                    : 0;
            }
            set { tbLimit.Text = value.ToString("N2", new CultureInfo("en-GB")); }
        }

        #endregion //Details

        #region DetailsLists

        #endregion

        #region ListOperations

        public void RefreshItems()
        {
            dgvItems.DataSource = _presenter.BindingSource;
            //hide columns
            foreach (var column in dgvItems.Columns)
            {
                ((DataGridViewColumn)column).Visible = false;
            }
            var visibleColumn = dgvItems.Columns[nameof(RequestInfoDto.Date)];
            if (visibleColumn != null) visibleColumn.Visible = true;
            visibleColumn = dgvItems.Columns[nameof(RequestInfoDto.ClientId)];
            if (visibleColumn != null) visibleColumn.Visible = true;
            visibleColumn = dgvItems.Columns[nameof(RequestInfoDto.Type)];
            if (visibleColumn != null) visibleColumn.Visible = true;
            visibleColumn = dgvItems.Columns[nameof(RequestInfoDto.SubType)];
            if (visibleColumn != null) visibleColumn.Visible = true;
            visibleColumn = dgvItems.Columns[nameof(RequestInfoDto.Status)];
            if (visibleColumn != null) visibleColumn.Visible = true;
        }

        public void SetEventHandlers()
        {
            if (_isEventHandlerSets) return;
            _isEventHandlerSets = true;

            btnRefresh.Click += btnRefresh_Click;
            dgvItems.FilterStringChanged += dgvItems_FilterStringChanged;
            dgvItems.SortStringChanged += dgvItems_SortStringChanged;

            btnReject.Click += btnReject_Click;
            btnProcessed.Click += btnProcessed_Click;
            btnPending.Click += btnPending_Click;
        }

        #endregion

        #region Enter mode

        public void EnterEditMode()
        {
            EnableInput();
        }

        public void EnterDetailsMode()
        {
            DisableInput();

            VisibleAccountName = $"{AccountName} [{ClientName}][{AccountCurrencyId}]";

            pnlCurrency.Visible = !string.IsNullOrEmpty(CurrencyId);

            var card = CardId.HasValue;
            //pnlCardNumber.Visible = card;

            var cardSetLimit = RequestType == RequestType.Card &&
                                     SubType.Equals(nameof(CardRequestType.SetLimit));
            if (cardSetLimit) pnlCurrency.Visible = false;
            pnlLimit.Visible = cardSetLimit;


            var cardNew = RequestType == RequestType.Card &&
                                     SubType.Equals(nameof(CardRequestType.New));

            var payment = RequestType == RequestType.Payment;
            pnlAccountName.Visible = payment;
            pnlAmountOut.Visible = payment;
            pnlValueDate.Visible = payment;

            var paymentTransferOut = RequestType == RequestType.Payment &&
                                     SubType.Equals(nameof(AccountRequestType.TransferOut));
            pnlBankName.Visible = paymentTransferOut;
            pnlIban.Visible = paymentTransferOut;
            pnlBankAddress.Visible = paymentTransferOut;
            pnlBic.Visible = paymentTransferOut;
            pnlOwnerName.Visible = paymentTransferOut;
            pnlValueDate.Visible = paymentTransferOut;

            var paymentRefill = RequestType == RequestType.Payment && SubType.Equals(nameof(AccountRequestType.Refill));
            pnlBeneficiaryAccountName.Visible = paymentRefill;

            var paymentTransferToCard = RequestType == RequestType.Payment &&
                                        SubType.Equals(nameof(AccountRequestType.TransferToCard));

            pnlCardNumber.Visible = card || paymentTransferToCard;

            btnReject.Enabled = RequestStatus.Equals(RequestStatus.Pending);
            btnProcessed.Enabled = RequestStatus.Equals(RequestStatus.Pending);
            btnPending.Enabled = !RequestStatus.Equals(RequestStatus.Pending);
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
            //tbAccountName.Clear();
        }

        public void EnableInput()
        {
        }

        public void DisableInput()
        {
        }

        #endregion //Enter mode

        #endregion //IRequestView implementation

        #region Event handlers

        private void dgvItems_FilterStringChanged(object sender, EventArgs e)
        {
            _presenter.BindingSource.Filter = dgvItems.FilterString;
        }

        private void dgvItems_SortStringChanged(object sender, EventArgs e)
        {
            _presenter.BindingSource.Sort = dgvItems.SortString;
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            if (RequestStatus != RequestStatus.Pending) return;


            var form = new MessageByRequestForm(CompositionRoot.Resolve<IMessageDataManager>(),
                CompositionRoot.Resolve<IDataMаnager>())
            {
                ClientId = ClientId,
                Date = DateTime.UtcNow,
                Subject = "Reject message"
            };
            if (form.ShowDialog() != DialogResult.OK) return;

            _presenter.Edit();
            RequestStatus = RequestStatus.Rejected;
            _presenter.Save();
        }

        private void btnProcessed_Click(object sender, EventArgs e)
        {
            if (RequestStatus != RequestStatus.Pending) return;

            if (RequestType == RequestType.Card && SubType.Equals(nameof(CardRequestType.New)))
            {
                var form = new CardByRequestForm(CompositionRoot.Resolve<ICardDataMаnager>(),
                    CompositionRoot.Resolve<IMessageDataManager>(), CompositionRoot.Resolve<IDataMаnager>())
                {
                    ClientId = ClientId,
                    CurrencyId = CurrencyId,
                    CardHolder = ClientName,
                    Limit = 5000,
                    Date = DateTime.UtcNow,
                    Subject = "New card request processed"
                };
                if (form.ShowDialog() != DialogResult.OK) return;
            }
            if (RequestType == RequestType.Card && SubType.Equals(nameof(CardRequestType.SetLimit)))
            {
                if (CardId != null)
                {
                    var form = new CardRequestSetLimitForm(CompositionRoot.Resolve<IDataMаnager>())
                    {
                        CardId = CardId.Value,
                        Limit = Limit,
                        ClientId = ClientId,
                        Date = DateTime.UtcNow,
                        Subject = "Card Set Limit request processed",
                        Body = $"Card #{CardNumber} limit set to {Limit}"
                    };
                    if (form.ShowDialog() != DialogResult.OK) return;
                }
            }
            if (RequestType == RequestType.Card && SubType.Equals(nameof(CardRequestType.Block)))
            {
                if (CardId != null)
                {
                    var form = new CardRequestBlockForm(CompositionRoot.Resolve<IDataMаnager>())
                    {
                        CardId = CardId.Value,
                        Comment = $"Blocked {DateTime.UtcNow}",
                        ClientId = ClientId,
                        Date = DateTime.UtcNow,
                        Subject = "Card Block request processed",
                        Body = $"Card #{CardNumber} blocked"
                    };
                    if (form.ShowDialog() != DialogResult.OK) return;
                }
            }
            if (RequestType == RequestType.Card && SubType.Equals(nameof(CardRequestType.Reissue)))
            {
                var form = new CardByRequestForm(CompositionRoot.Resolve<ICardDataMаnager>(),
                    CompositionRoot.Resolve<IMessageDataManager>(), CompositionRoot.Resolve<IDataMаnager>());
                if (form.ShowDialog() != DialogResult.OK) return;
            }

            if (RequestType == RequestType.Payment && SubType.Equals(nameof(AccountRequestType.TransferOut)))
            {
                var form = new TransactionByRequestForm(CompositionRoot.Resolve<ITransactionDataManager>(),
                    CompositionRoot.Resolve<IDataMаnager>());

                if (ClientAccountId.HasValue) form.AccountId = ClientAccountId.Value;
                form.ValueDate = ValueDate ?? DateTime.UtcNow;
                form.AccountName = VisibleAccountName;
                form.Amount = -AmountOut;
                form.AmountInCurrency = -AmountOut;
                form.CurrencyId = CurrencyId;
                form.RequestId = Id;
                form.FromTo = $"{BankName}/{BankAddress}";
                form.Note = $"REF: {OwnerName}";

                if (form.ShowDialog() != DialogResult.OK) return;
            }
            if (RequestType == RequestType.Payment && SubType.Equals(nameof(AccountRequestType.TransferToCard)))
            {
                var form = new TransactionByRequestForm(CompositionRoot.Resolve<ITransactionDataManager>(),
                    CompositionRoot.Resolve<IDataMаnager>());

                if (ClientAccountId.HasValue) form.AccountId = ClientAccountId.Value;
                form.ValueDate = ValueDate ?? DateTime.UtcNow;
                form.AccountName = VisibleAccountName;
                form.Amount = -AmountOut;
                form.AmountInCurrency = -AmountOut;
                form.CurrencyId = CurrencyId;
                form.RequestId = Id;
                form.FromTo =
                    $"{nameof(AccountRequestType.TransferToCard)}: ****{CardNumber.Substring(Math.Max(0, CardNumber.Length - 8))}";

                if (form.ShowDialog() != DialogResult.OK) return;
            }
            _presenter.Edit();
            RequestStatus = RequestStatus.Processed;
            _presenter.Save();
        }

        private void btnPending_Click(object sender, EventArgs e)
        {
            if (RequestStatus == RequestStatus.Rejected || RequestStatus == RequestStatus.Processed)
            {
                _presenter.Edit();
                RequestStatus = RequestStatus.Pending;
                _presenter.Save();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            _presenter.Reopen();
        }

        #endregion //Event handlers

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}