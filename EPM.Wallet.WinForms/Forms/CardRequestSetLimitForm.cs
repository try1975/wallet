using System;
using System.Windows.Forms;
using EPM.Wallet.Internal.Model;
using EPM.Wallet.WinForms.Interfaces;

namespace EPM.Wallet.WinForms.Forms
{
    public partial class CardRequestSetLimitForm : Form
    {
        private readonly IDataMаnager _dataManager;

        public CardRequestSetLimitForm(IDataMаnager dataMаnager)
        {
            InitializeComponent();
            _dataManager = dataMаnager;
        }

        public Guid CardId { private get; set; }
        public int Limit { private get; set; }

        public string ClientId { private get; set; }
        public DateTime Date { private get; set; }
        public string Subject { private get; set; }

        public string Body
        {
            private get { return tbMessageBody.Text; }
            set { tbMessageBody.Text = value; }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            SetLimit();
        }

        private async void SetLimit()
        {
            var cardDto = await _dataManager.GetCard(CardId);
            if (cardDto != null)
            {
                cardDto.Limit = Limit;
                await _dataManager.PutCard(cardDto);
            }
            if (!string.IsNullOrEmpty(Body))
            {
                var messageDto = new MessageDto()
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
    }
}
