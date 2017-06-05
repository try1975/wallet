using System;
using System.Collections.Generic;
using System.Windows.Forms;
using EPM.Wallet.WinForms.Interfaces;
using EPM.Wallet.WinForms.Presenters;

namespace EPM.Wallet.WinForms.Forms
{
    public partial class MessageByRequestForm : Form, IMessageView
    {
        private readonly MessagePresenter _messagePresenter;
        private bool _isEventHandlerSets;

        public MessageByRequestForm(IMessageDataManager messageDataManager, IDataMаnager dataMаnager)
        {
            InitializeComponent();
            _messagePresenter = new MessagePresenter(this, messageDataManager, dataMаnager, PresenterMode.AddNew);
        }

        #region Details

        public Guid Id { get; set; }
        public List<KeyValuePair<string, string>> ClientList { get; set; }
        public string Subject { get; set; }

        public string Body
        {
            get { return tbMessageBody.Text; }
            set { tbMessageBody.Text = value; }
        }

        public string ClientId { get; set; }
        public DateTime Date { get; set; }
        public DateTime? ReadDate { get; set; }
        public bool IsOutgoing { get; set; }

        #endregion //Details

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Body))
            {
                _messagePresenter.Save();
            }
            else
            {
                _messagePresenter.Cancel();
            }
        }

        public void RefreshItems() { }

        public void SetEventHandlers()
        {
            if (_isEventHandlerSets) return;
            _isEventHandlerSets = true;
        }

        public void EnterAddNewMode() { }

        public void EnterEditMode() { }

        public void EnterDetailsMode() { }

        public void EnterReadMode()
        {
            if (!string.IsNullOrEmpty(Body))
            {
                if (Id.Equals(Guid.Empty))
                {
                    DialogResult = DialogResult.Cancel;
                    return;
                }
            }
            DialogResult = DialogResult.OK;
        }

        public void EnterMultiSelectMode() { }

        public void ClearInputFields() { }

        public void EnableInput() { }

        public void DisableInput() { }
    }
}