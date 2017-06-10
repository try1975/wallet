using System.Windows.Forms;
using EPM.Wallet.WinForms.Interfaces;

namespace EPM.Wallet.WinForms.Forms
{
    public partial class CardRequestReissueForm : Form
    {
        private readonly IDataMаnager _dataManager;
        public CardRequestReissueForm(IDataMаnager dataMаnager)
        {
            InitializeComponent();
            _dataManager = dataMаnager;
        }
    }
}
