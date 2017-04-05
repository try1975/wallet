using System;
using System.Windows.Forms;
using EPM.Wallet.Common.Enums;
using EPM.Wallet.WinForms.Interfaces;

namespace EPM.Wallet.WinForms
{
    public partial class Form1 : Form
    {
        public Form1(IWalletControl walletControl)
        {
            InitializeComponent();
            
            var control = (Control) walletControl;
            control.Dock = DockStyle.Fill;
            panel1.Controls.Add(control);
        }
    }
}