using System;
using System.Windows.Forms;
using EPM.Wallet.Common.Enums;
using EPM.Wallet.WinForms.Interfaces;
using EPM.Wallet.WinForms.Ninject;

namespace EPM.Wallet.WinForms.Controls
{
    public partial class WalletControl : UserControl, IWalletControl
    {
        private ClientAppVariant _clientAppVariant;

        public WalletControl()
        {
            InitializeComponent();
            ClientAppVariant = AppGlobal.ClientAppVariant;
        }

        private ClientAppVariant ClientAppVariant
        {
            get { return _clientAppVariant; }
            set
            {
                _clientAppVariant = value;
                if (_clientAppVariant == ClientAppVariant.Wallet)
                {
                    btnRequests.Text = @"Requests";
                    pnlCards.Visible = true;
                    return;
                }
                btnRequests.Text = @"Transfer Outs";
                pnlCards.Visible = false;
            }
        }

        private void AddControlToWorkArea(Control control, bool ctrlPressed = false)
        {
            if (ctrlPressed)
            {
                var childForm = new ChildForm {Text = control.Name};
                childForm.AddControlToWorkArea(control);
                childForm.Show();
                return;
            }
            control.Dock = DockStyle.Fill;
            pnlWorkArea.Controls.Clear();
            pnlWorkArea.Controls.Add(control);
        }

        private void btnRequests_Click(object sender, EventArgs e)
        {
            if (ClientAppVariant == ClientAppVariant.Dpa)
            {
                var transferOutInfoControl = CompositionRoot.Resolve<ITransferOutInfoView>();
                AddControlToWorkArea((Control) transferOutInfoControl, ModifierKeys.HasFlag(Keys.Control));
                return;
            }
            var requestControl = CompositionRoot.Resolve<IRequestView>();
            AddControlToWorkArea((Control) requestControl, ModifierKeys.HasFlag(Keys.Control));
        }

        private void btnBanks_Click(object sender, EventArgs e)
        {
            var bankControl = CompositionRoot.Resolve<IBankView>();
            AddControlToWorkArea((Control) bankControl, ModifierKeys.HasFlag(Keys.Control));
        }

        private void btnBankAccounts_Click(object sender, EventArgs e)
        {
            var bankAccountControl = CompositionRoot.Resolve<IBankAccountView>();
            AddControlToWorkArea((Control) bankAccountControl, ModifierKeys.HasFlag(Keys.Control));
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            var clientControl = CompositionRoot.Resolve<IClientView>();
            AddControlToWorkArea((Control) clientControl, ModifierKeys.HasFlag(Keys.Control));
        }

        private void btnClientAccounts_Click(object sender, EventArgs e)
        {
            var clientAccountControl = CompositionRoot.Resolve<IClientAccountView>();
            AddControlToWorkArea((Control) clientAccountControl, ModifierKeys.HasFlag(Keys.Control));
        }

        private void bntCards_Click(object sender, EventArgs e)
        {
            var cardControl = CompositionRoot.Resolve<ICardView>();
            AddControlToWorkArea((Control) cardControl, ModifierKeys.HasFlag(Keys.Control));
        }

        private void btnMessages_Click(object sender, EventArgs e)
        {
            var messageControl = CompositionRoot.Resolve<IMessageView>();
            AddControlToWorkArea((Control) messageControl, ModifierKeys.HasFlag(Keys.Control));
        }

        private void btnTransactions_Click(object sender, EventArgs e)
        {
            var transactionControl = CompositionRoot.Resolve<ITransactionView>();
            AddControlToWorkArea((Control) transactionControl, ModifierKeys.HasFlag(Keys.Control));
        }

        private void btnStatements_Click(object sender, EventArgs e)
        {
            var statementControl = CompositionRoot.Resolve<IStatementView>();
            AddControlToWorkArea((Control) statementControl, ModifierKeys.HasFlag(Keys.Control));
        }

        private void btnStandingOrders_Click(object sender, EventArgs e)
        {
            var standingOrderControl = CompositionRoot.Resolve<IStandingOrderView>();
            AddControlToWorkArea((Control) standingOrderControl, ModifierKeys.HasFlag(Keys.Control));
        }

        private void btnDirectDebits_Click(object sender, EventArgs e)
        {
            var directDebitControl = CompositionRoot.Resolve<IDirectDebitView>();
            AddControlToWorkArea((Control) directDebitControl, ModifierKeys.HasFlag(Keys.Control));
        }
    }
}