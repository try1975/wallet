using System;
using System.Windows.Forms;
using EPM.Wallet.Internal.Model;
using EPM.Wallet.WinForms.Interfaces;

namespace EPM.Wallet.WinForms.Forms
{
    public partial class CardRequestNewForm : Form
    {
        private readonly IDataMаnager _dataManager;
        public CardRequestNewForm(IDataMаnager dataMаnager)
        {
            InitializeComponent();
            _dataManager = dataMаnager;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            CreateNewCard();
        }

        private async void CreateNewCard()
        {
            try
            {
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
                        Date = Date,
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

        private string Vendor => tbVendor.Text;

        private string Comment => tbComment.Text;


        public string CurrencyId
        {
            private get { return tbCurrencyId.Text; }
            set { tbCurrencyId.Text = value; }
        }

        private string CardNumber => tbCardNumber.Text;

        public string CardHolder
        {
            private get { return tbCardHolder.Text; }
            set { tbCardHolder.Text = value; }
        }

        private int ExpMonth => (int) udExpMonth.Value;

        private int ExpYear => (int) udExpYear.Value;

        public decimal Limit
        {
            private get { return udLimit.Value; }
            set { udLimit.Value = value; }
        }

        public string Subject { private get; set; }

        private string Body => tbMessageBody.Text;

        public string ClientId { private get; set; }
        public string ClientName
        {
            set { tbClientName.Text = value; }
        }

        public DateTime Date { private get; set; }

        #endregion //Details
    }
}