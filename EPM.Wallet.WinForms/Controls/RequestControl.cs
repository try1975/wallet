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

        private string VisibleAccountName
        {
            get { return tbAccountName.Text; }
            set { tbAccountName.Text = value; }
        }

        public string AccountCurrencyId { get; set; }

        public Guid? BeneficiaryAccountId { get; set; }

        public string BeneficiaryAccountName { get; set; }

        public string VisibleBeneficiaryAccountName
        {
            get { return tbBeneficiaryAccountName.Text; }
            set { tbBeneficiaryAccountName.Text = value; }
        }

        public string BeneficiaryCurrencyId { get; set; }

        public DateTime? ValueDate
        {
            get
            {
                return string.IsNullOrEmpty(tbValueDate.Text) ? DateTime.UtcNow : DateTime.Parse(tbValueDate.Text);
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

        public int Limit
        {
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

        public string CardReissueType
        {
            get { return tbReissueType.Text; }
            set { tbReissueType.Text = value; }
        }
        public string CardReissueReason
        {
            get { return tbReissueReason.Text; }
            set { tbReissueReason.Text = value; }
        }

        public string Note {
            get { return tbNote.Text; }
            set { tbNote.Text = value; }
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
            //visibleColumn = dgvItems.Columns[nameof(RequestInfoDto.ValueDate)];
            //if (visibleColumn != null) visibleColumn.Visible = true;
            //visibleColumn = dgvItems.Columns[nameof(RequestInfoDto.ColorType)];
            //if (visibleColumn != null) visibleColumn.Visible = true;
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
            VisibleBeneficiaryAccountName = $"{BeneficiaryAccountName} [{ClientName}][{BeneficiaryCurrencyId}]";

            pnlCurrency.Visible = !string.IsNullOrEmpty(CurrencyId);

            var card = CardId.HasValue;
            //pnlCardNumber.Visible = card;

            var cardSetLimit = RequestType == RequestType.Card &&
                                     SubType.Equals(nameof(CardRequestType.SetLimit));
            if (cardSetLimit) pnlCurrency.Visible = false;
            pnlLimit.Visible = cardSetLimit;

            var cardReissue = RequestType == RequestType.Card &&
                                     SubType.Equals(nameof(CardRequestType.Reissue));

            pnlReissueType.Visible = cardReissue;
            pnlReissueReason.Visible = cardReissue;

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

            var form = new MessageByRequestForm(CompositionRoot.Resolve<IDataMаnager>())
            {
                ClientId = ClientId,
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
            // Card requests
            if (RequestType == RequestType.Card && SubType.Equals(nameof(CardRequestType.New)))
            {
                var form = new CardRequestNewForm(CompositionRoot.Resolve<IDataMаnager>())
                {
                    ClientId = ClientId,
                    CurrencyId = CurrencyId,
                    ClientName = $"{ClientId} [{ClientName}]",
                    CardHolder = ClientName,
                    Limit = 5000,
                    Subject = "New card request processed"
                };
                if (form.ShowDialog() != DialogResult.OK) return;
            }

            if (RequestType == RequestType.Card && SubType.Equals(nameof(CardRequestType.Reissue)))
            {
                var form = new CardRequestReissueForm(CompositionRoot.Resolve<IDataMаnager>())
                {
                    CardId = CardId,
                    ReissueType = CardReissueType,
                    ReissueReason = CardReissueReason,
                    ClientId = ClientId,
                    CurrencyId = CurrencyId,
                    ClientName = $"{ClientId} [{ClientName}]",
                    Subject = "Reissue card request processed"
                };
                if (form.ShowDialog() != DialogResult.OK) return;
            }

            if (RequestType == RequestType.Card && SubType.Equals(nameof(CardRequestType.SetLimit)))
            {
                if (CardId == null) return;
                var form = new CardRequestSetLimitForm(CompositionRoot.Resolve<IDataMаnager>())
                {
                    CardId = CardId.Value,
                    Limit = Limit,
                    ClientId = ClientId,
                    Subject = "Card Set Limit request processed",
                    Body = $"Card #{CardNumber} limit set to {Limit}"
                };
                if (form.ShowDialog() != DialogResult.OK) return;
            }

            if (RequestType == RequestType.Card && SubType.Equals(nameof(CardRequestType.Block)))
            {
                if (CardId == null) return;
                var form = new CardRequestBlockForm(CompositionRoot.Resolve<IDataMаnager>())
                {
                    CardId = CardId.Value,
                    Comment = $"Blocked {DateTime.UtcNow}",
                    ClientId = ClientId,
                    Subject = "Card Block request processed",
                    Body = $"Card #{CardNumber} blocked"
                };
                if (form.ShowDialog() != DialogResult.OK) return;
            }
            // Account requests
            if (RequestType == RequestType.Account && SubType.Equals(nameof(AccountRequestType.New)))
            {
                var form = new AccountRequestNewForm(CompositionRoot.Resolve<IDataMаnager>())
                {
                    ClientId = ClientId,
                    ClientName = $"{ClientId} [{ClientName}]",
                    CurrencyId = CurrencyId,
                    Subject = "Account New request processed"
                };
                if (form.ShowDialog() != DialogResult.OK) return;
            }
            // Payment requests
            if (RequestType == RequestType.Payment && SubType.Equals(nameof(AccountRequestType.TransferOut)))
            {
                var form = new TransactionRequestTransferOutForm(CompositionRoot.Resolve<IDataMаnager>())
                {
                    ValueDate = ValueDate ?? DateTime.UtcNow.Date,
                    AccountName = VisibleAccountName,
                    AmountInCurrency = -AmountOut,
                    CurrencyId = CurrencyId,
                    RequestId = Id,
                    FromTo = $"{BankName}/{BankAddress}",
                    Note = $"REF: {OwnerName}"
                };
                if (ClientAccountId.HasValue) form.AccountId = ClientAccountId.Value;

                if (form.ShowDialog() != DialogResult.OK) return;
            }

            if (RequestType == RequestType.Payment && SubType.Equals(nameof(AccountRequestType.TransferToCard)))
            {
                var fromTo =
                    $"{nameof(AccountRequestType.TransferToCard)}: ****{CardNumber.Substring(Math.Max(0, CardNumber.Length - 8))}";
                var form = new TransactionRequestTransferOutForm(CompositionRoot.Resolve<IDataMаnager>())
                {
                    ValueDate = ValueDate ?? DateTime.UtcNow.Date,
                    AccountName = VisibleAccountName,
                    AmountInCurrency = -AmountOut,
                    CurrencyId = CurrencyId,
                    RequestId = Id,
                    FromTo = fromTo
                };
                if (ClientAccountId.HasValue) form.AccountId = ClientAccountId.Value;

                if (form.ShowDialog() != DialogResult.OK) return;
            }

            if (RequestType == RequestType.Payment && SubType.Equals(nameof(AccountRequestType.Refill)))
            {
                var fromToOut = $"Refill to {VisibleBeneficiaryAccountName}";
                var fromToIn = $"Refill from {VisibleAccountName}";
                var form = new RefillForm(CompositionRoot.Resolve<IDataMаnager>())
                {
                    ValueDate = ValueDate ?? DateTime.UtcNow.Date,
                    AccountName = VisibleAccountName,
                    BeneficiaryAccountName = VisibleBeneficiaryAccountName,
                    AmountCurrencyOut = -AmountOut,
                    CurrencyId = CurrencyId,
                    RequestId = Id,
                    FromToOut = fromToOut,
                    FromToIn = fromToIn
                };
                if (ClientAccountId.HasValue) form.AccountId = ClientAccountId.Value;
                if (BeneficiaryAccountId.HasValue) form.BeneficiaryAccountId = BeneficiaryAccountId.Value;
                if (form.ShowDialog() != DialogResult.OK) return;
            }


            _presenter.Edit();
            RequestStatus = RequestStatus.Processed;
            _presenter.Save();
        }

        private void btnPending_Click(object sender, EventArgs e)
        {
            if (RequestStatus != RequestStatus.Rejected && RequestStatus != RequestStatus.Processed) return;
            _presenter.Edit();
            RequestStatus = RequestStatus.Pending;
            _presenter.Save();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            _presenter.Reopen();
        }

        #endregion //Event handlers
    }
}