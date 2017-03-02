using System;
using System.Linq;
using System.Windows.Forms;
using EPM.Wallet.WinForms.Interfaces;

namespace EPM.Wallet.WinForms
{
    public partial class Form1 : Form
    {
        private static readonly Random Randomizer = new Random();


        public Form1(IWalletControl walletControl)
        {
            InitializeComponent();

            var control = (Control) walletControl;
            control.Dock = DockStyle.Fill;
            panel1.Controls.Add(control);

        }

        private static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[Randomizer.Next(s.Length)]).ToArray());
        }

    }
}
