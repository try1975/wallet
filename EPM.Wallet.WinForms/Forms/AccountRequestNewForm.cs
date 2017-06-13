using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using EPM.Wallet.Internal.Model;
using EPM.Wallet.WinForms.Interfaces;

namespace EPM.Wallet.WinForms.Forms
{
    public partial class AccountRequestNewForm : Form
    {
        private readonly IDataMаnager _dataManager;

        public AccountRequestNewForm(IDataMаnager dataMаnager)
        {
            InitializeComponent();
            _dataManager = dataMаnager;
        }

        private void AccountRequestNewForm_Load(object sender, EventArgs e)
        {
            SetBankAccountList();
        }

        #region Dto

        #region AccountDto

        public string ClientName
        {
            set { tbClientName.Text = value; }
        }

        private string AccountName => tbName.Text;

        public string ClientId { private get; set; }

        public string CurrencyId
        {
            private get { return tbCurrencyId.Text; }
            set { tbCurrencyId.Text = value; }
        }

        //public decimal CurrentBalance { get; set; }

        private Guid BankAccountId => (Guid)cmbBankAccount.SelectedValue;

        private string Comment => tbComment.Text;

        private List<KeyValuePair<Guid, string>> BankAccounList
        {
            set
            {
                cmbBankAccount.DataSource = value;
                cmbBankAccount.ValueMember = "Key";
                cmbBankAccount.DisplayMember = "Value";
            }
        }

        #endregion //AccountDto

        #region MessageDto

        public string Subject { private get; set; }

        private string Body => tbMessageBody.Text;

        #endregion //MessageDto

        #endregion //Dto

        private void btnOk_Click(object sender, EventArgs e)
        {
            CreateNewAccount();
        }

        private async void CreateNewAccount()
        {
            try
            {
                var accountDto = new AccountDto()
                {
                    ClientId = ClientId,
                    Name = AccountName,
                    CurrencyId = CurrencyId,
                    BankAccountId = BankAccountId,
                    Comment = Comment
                };
                accountDto = await _dataManager.PostClientAccount(accountDto);
                if (accountDto == null || accountDto.Id.Equals(Guid.Empty))
                {
                    MessageBox.Show(@"Account not created");
                    return;
                }

                if (!string.IsNullOrEmpty(Body))
                {
                    var messageDto = new MessageDto()
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

        private async void SetBankAccountList()
        {
            var bankAccountDtos = await _dataManager.GetBankAccounts();
            if (bankAccountDtos != null)
            {
                var bankaccounts = bankAccountDtos.ToList();
                BankAccounList = bankaccounts.Where(z => z.CurrencyId == CurrencyId)
                    .Select(c => new KeyValuePair<Guid, string>(c.Id, $"{c.Name} [{c.CurrencyId}]"))
                    .OrderBy(kv => kv.Value)
                    .ToList();
            }
            else
            {
                BankAccounList = new List<KeyValuePair<Guid, string>>();
            }
        }
    }
}