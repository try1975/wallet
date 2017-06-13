using System;
using System.Collections.Generic;
using System.Windows.Forms;
using EPM.Wallet.Internal.Model;
using EPM.Wallet.WinForms.Interfaces;
using EPM.Wallet.WinForms.Presenters;

namespace EPM.Wallet.WinForms.Forms
{
    public partial class MessageByRequestForm : Form
    {
        private readonly IDataMаnager _dataManager;

        public MessageByRequestForm(IDataMаnager dataMаnager)
        {
            InitializeComponent();
            _dataManager = dataMаnager;
        }

        #region Details

        public string Subject { private get; set; }

        private string Body => tbMessageBody.Text;

        public string ClientId { private get; set; }

        #endregion //Details

        private void btnOk_Click(object sender, EventArgs e)
        {
            CreateNewMessage();
        }

        private async void CreateNewMessage()
        {
            try
            {
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
    }
}