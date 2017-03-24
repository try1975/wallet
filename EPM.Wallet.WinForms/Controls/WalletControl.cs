using System;
using System.Windows.Forms;
using EPM.Wallet.WinForms.Interfaces;
using EPM.Wallet.WinForms.Ninject;

namespace EPM.Wallet.WinForms.Controls
{
    public partial class WalletControl : UserControl, IWalletControl
    {
        public WalletControl()
        {
            InitializeComponent();
        }

        private void AddControlToWorkArea(Control control)
        {
            control.Dock = DockStyle.Fill;
            pnlWorkArea.Controls.Clear();
            pnlWorkArea.Controls.Add(control);
        }

        private void btnBanks_Click(object sender, EventArgs e)
        {
            var bankControl = CompositionRoot.Resolve<IBankView>();
            AddControlToWorkArea((Control) bankControl);
        }

        private void btnBankAccounts_Click(object sender, EventArgs e)
        {
            var bankAccountControl = CompositionRoot.Resolve<IBankAccountView>();
            AddControlToWorkArea((Control) bankAccountControl);
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            var clientControl = CompositionRoot.Resolve<IClientView>();
            AddControlToWorkArea((Control) clientControl);
        }

        private void btnClientAccounts_Click(object sender, EventArgs e)
        {
            var clientAccountControl = CompositionRoot.Resolve<IClientAccountView>();
            AddControlToWorkArea((Control) clientAccountControl);
        }

        private void bntCards_Click(object sender, EventArgs e)
        {
            var cardControl = CompositionRoot.Resolve<ICardView>();
            AddControlToWorkArea((Control) cardControl);
        }

        private void btnRequests_Click(object sender, EventArgs e)
        {
            var transferOutInfoControl = CompositionRoot.Resolve<ITransferOutInfoView>();
            AddControlToWorkArea((Control) transferOutInfoControl);
        }

        private void btnMessages_Click(object sender, EventArgs e)
        {
            var messageControl = CompositionRoot.Resolve<IMessageView>();
            AddControlToWorkArea((Control) messageControl);
        }

        private void btnTransactions_Click(object sender, EventArgs e)
        {
            var transactionControl = CompositionRoot.Resolve<ITransactionView>();
            AddControlToWorkArea((Control)transactionControl);
        }
    }
}