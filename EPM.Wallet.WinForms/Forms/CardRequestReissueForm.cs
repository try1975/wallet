using System;
using System.Windows.Forms;
using EPM.Wallet.Common.Enums;
using EPM.Wallet.Internal.Model;
using EPM.Wallet.WinForms.Interfaces;

namespace EPM.Wallet.WinForms.Forms
{
    public partial class CardRequestReissueForm : Form
    {
        private readonly IDataMаnager _dataManager;
        private CardDto _blockedCard;

        public CardRequestReissueForm(IDataMаnager dataMаnager)
        {
            InitializeComponent();
            _dataManager = dataMаnager;
        }

        private void CardRequestReissueForm_Load(object sender, EventArgs e)
        {
            GetBlockedCard();
        }

        private async void GetBlockedCard()
        {
            if (CardId != null) _blockedCard = await _dataManager.GetCard(CardId.Value);
            if (_blockedCard == null) return;
            CurrencyId = _blockedCard.CurrencyId;
            CardHolder = _blockedCard.CardHolder;
            Limit = _blockedCard.Limit;
            Vendor = _blockedCard.Vendor;
            Comment = $"Reissue #{_blockedCard.CardNumber}. Reason:{ReissueType} {ReissueReason}";
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            ReissuedCard();
        }

        private async void ReissuedCard()
        {
            try
            {
                if (string.IsNullOrEmpty(CardNumber))
                {
                    MessageBox.Show(@"Card number can not set to empty");
                    return;
                }

                _blockedCard.CardStatus = CardStatus.Blocked;
                _blockedCard.Comment = $"Blocked {DateTime.UtcNow}. Reason:{ReissueType} {ReissueReason}";
                await _dataManager.PostCard(_blockedCard);

                var cardDto = new CardDto
                {
                    ClientId = ClientId,
                    CurrencyId = CurrencyId,
                    CardNumber = CardNumber,
                    CardHolder = CardHolder,
                    ExpMonth = ExpMonth,
                    ExpYear = ExpYear,
                    Limit = Limit,
                    Cvc = Cvc,
                    Pin = Pin,
                    Vendor = Vendor,
                    Comment = Comment
                };
                cardDto = await _dataManager.PostCard(cardDto);
                if (cardDto == null || cardDto.Id.Equals(Guid.Empty))
                {
                    MessageBox.Show(@"Card not created");
                    return;
                }

                if (!string.IsNullOrEmpty(Body))
                {
                    var messageDto = new MessageDto
                    {
                        ClientId = ClientId,
                        Date = DateTime.UtcNow,
                        Subject = Subject,
                        Body = Body
                    };
                    await _dataManager.PostMessage(messageDto);
                }
                DialogResult = DialogResult.OK;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        #region Details

        private string Cvc => tbCvc.Text;

        private string Pin => tbPin.Text;

        private string Vendor
        {
            get { return tbVendor.Text; }
            set { tbVendor.Text = value; }
        }

        private string Comment
        {
            get { return tbComment.Text; }
            set { tbComment.Text = value; }
        }


        public string CurrencyId
        {
            private get { return tbCurrencyId.Text; }
            set { tbCurrencyId.Text = value; }
        }

        private string CardNumber => tbCardNumber.Text;

        private string CardHolder
        {
            get { return tbCardHolder.Text; }
            set { tbCardHolder.Text = value; }
        }

        private int ExpMonth => (int)udExpMonth.Value;

        private int ExpYear => (int)udExpYear.Value;

        private decimal Limit
        {
            get { return udLimit.Value; }
            set { udLimit.Value = value; }
        }

        public string Subject { private get; set; }

        private string Body => tbMessageBody.Text;

        public string ClientId { private get; set; }

        public string ClientName
        {
            set { tbClientName.Text = value; }
        }

        public Guid? CardId { private get; set; }

        public string ReissueType { private get; set; }

        public string ReissueReason { private get; set; }

        #endregion //Details
    }
}
