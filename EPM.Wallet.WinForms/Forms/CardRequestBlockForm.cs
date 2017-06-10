using System;
using System.Windows.Forms;
using EPM.Wallet.Common.Enums;
using EPM.Wallet.Internal.Model;
using EPM.Wallet.WinForms.Interfaces;

namespace EPM.Wallet.WinForms.Forms
{
    public partial class CardRequestBlockForm : Form
    {
        private readonly IDataMаnager _dataManager;
        public CardRequestBlockForm(IDataMаnager dataMаnager)
        {
            InitializeComponent();
            _dataManager = dataMаnager;
        }

        public Guid CardId { private get; set; }
        public string Comment { private get; set; }

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
                cardDto.CardStatus = CardStatus.Blocked;
                cardDto.Comment = Comment;
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
