using System;
using System.Collections.Generic;
using System.Windows.Forms;
using EPM.Wallet.Common.Enums;
using EPM.Wallet.WinForms.Interfaces;
using EPM.Wallet.WinForms.Presenters;

namespace EPM.Wallet.WinForms.Forms
{
    public partial class CardByRequestForm : Form, IMessageView, ICardView
    {
        private readonly CardPresenter _cardPresenter;
        private readonly MessagePresenter _messagePresenter;
        private bool _isEventHandlerSets;
        private readonly CardRequestType _cardRequestType;


        public CardByRequestForm(ICardDataMаnager cardDataMаnager, IMessageDataManager messageDataManager,
            IDataMаnager dataMаnager, CardRequestType cardRequestType = CardRequestType.New)
        {
            InitializeComponent();
            _cardRequestType = cardRequestType;
            if (_cardRequestType == CardRequestType.SetLimit)
            {
                _cardPresenter = new CardPresenter(this, cardDataMаnager, dataMаnager, PresenterMode.Edit);
            }
            else
            {
                _cardPresenter = new CardPresenter(this, cardDataMаnager, dataMаnager, PresenterMode.AddNew);
            }

            _messagePresenter = new MessagePresenter(this, messageDataManager, dataMаnager, PresenterMode.AddNew);
        }

        #region Details

        public string Cvc
        {
            get { return tbCvc.Text; }
            set { tbCvc.Text = value; }
        }
        public string Pin
        {
            get { return tbPin.Text; }
            set { tbPin.Text = value; }
        }

        public string Vendor
        {
            get { return tbVendor.Text; }
            set { tbVendor.Text = value; }
        }

        public string Comment
        {
            get { return tbComment.Text; }
            set { tbComment.Text = value; }
        }


        public string CurrencyId
        {
            get { return tbCurrencyId.Text; }
            set { tbCurrencyId.Text = value; }
        }

        public string CardNumber
        {
            get { return tbCardNumber.Text; }
            set { tbCardNumber.Text = value; }
        }
        public string CardHolder
        {
            get { return tbCardHolder.Text; }
            set { tbCardHolder.Text = value; }
        }
        public int ExpMonth
        {
            get { return (int)udExpMonth.Value; }
            set { udExpMonth.Text = $"{value}"; }
        }

        public int ExpYear
        {
            get { return (int)udExpYear.Value; }
            set { udExpYear.Text = $"{value}"; }
        }

        public decimal Limit
        {
            get { return udLimit.Value; }
            set { udLimit.Value = value; }
        }

        public Guid Id { get; set; }

        public string Subject { get; set; }
        public string Body
        {
            get { return tbMessageBody.Text; }
            set { tbMessageBody.Text = value; }
        }

        public CardStatus CardStatus { get; set; }

        public string ClientId
        {
            get { return tbClientId.Text; }
            set { tbClientId.Text = value; }
        }
        public DateTime Date { get; set; }
        public DateTime? ReadDate { get; set; }
        public bool IsOutgoing { get; set; }

        #endregion //Details

        #region DetailLists
        public List<KeyValuePair<string, string>> ClientList { get; set; }
        public List<KeyValuePair<string, string>> CurrencyList { get; set; }
        public List<KeyValuePair<CardStatus, string>> CardStatusList { get; set; }
        #endregion//DetailLists

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
            if (_messagePresenter.PresenterMode == PresenterMode.Read &&
                _cardPresenter.PresenterMode == PresenterMode.Read)
            {

                DialogResult = DialogResult.OK;
            }
        }

        public void EnterMultiSelectMode() { }

        public void ClearInputFields() { }

        public void EnableInput() { }

        public void DisableInput() { }



        private void btnOk_Click(object sender, EventArgs e)
        {
            _cardPresenter.Save();
            if (!string.IsNullOrEmpty(Body))
            {
                _messagePresenter.Save();
            }
            else
            {
                _messagePresenter.Cancel();
            }
        }
    }
}