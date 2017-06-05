using System;
using System.Windows.Forms;

namespace EPM.Wallet.WinForms.Forms
{
    public partial class MessageByRequestForm : Form
    {
        public MessageByRequestForm()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            //_transactionPresenter.Save();
            DialogResult = DialogResult.OK;
        }
    }
}