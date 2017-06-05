using System;
using System.Collections.Generic;
using System.Windows.Forms;
using EPM.Wallet.WinForms.Interfaces;
using EPM.Wallet.WinForms.Presenters;

namespace EPM.Wallet.WinForms.Forms
{
    public partial class CardByRequestForm : Form, IMessageView, ICardView
    {
        private readonly CardPresenter _cardPresenter;
        private readonly MessagePresenter _messagePresenter;
        private bool _isEventHandlerSets;


        public CardByRequestForm(ICardDataMаnager cardDataMаnager, IMessageDataManager messageDataManager,
            IDataMаnager dataMаnager)
        {
            InitializeComponent();
            _cardPresenter = new CardPresenter(this, cardDataMаnager, dataMаnager, PresenterMode.AddNew);
            _messagePresenter = new MessagePresenter(this, messageDataManager, dataMаnager, PresenterMode.AddNew);
        }

        public string Vendor { get; set; }
        public List<KeyValuePair<string, string>> CurrencyList { get; set; }
        public string CurrencyId { get; set; }
        public string CardNumber { get; set; }
        public string CardHolder { get; set; }
        public int ExpMonth { get; set; }
        public int ExpYear { get; set; }
        public decimal Limit { get; set; }

        public void RefreshItems()
        {
            throw new NotImplementedException();
        }

        public void SetEventHandlers()
        {
            if (_isEventHandlerSets) return;
            _isEventHandlerSets = true;
        }

        public void EnterAddNewMode()
        {
            throw new NotImplementedException();
        }

        public void EnterEditMode()
        {
            throw new NotImplementedException();
        }

        public void EnterDetailsMode()
        {
            throw new NotImplementedException();
        }

        public void EnterReadMode()
        {
            throw new NotImplementedException();
        }

        public void EnterMultiSelectMode()
        {
            throw new NotImplementedException();
        }

        public void ClearInputFields()
        {
            throw new NotImplementedException();
        }

        public void EnableInput()
        {
            throw new NotImplementedException();
        }

        public void DisableInput()
        {
            throw new NotImplementedException();
        }

        public Guid Id { get; set; }
        public List<KeyValuePair<string, string>> ClientList { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public string ClientId { get; set; }
        public DateTime Date { get; set; }
        public DateTime? ReadDate { get; set; }
        public bool IsOutgoing { get; set; }

        private void btnOk_Click(object sender, EventArgs e)
        {
            //_presenter.Save();
            DialogResult = DialogResult.OK;
        }
    }
}