using System.Windows.Forms;

namespace EPM.Wallet.WinForms
{
    public partial class ChildForm : Form
    {
        public ChildForm()
        {
            InitializeComponent();
        }

        public void AddControlToWorkArea(Control control)
        {
            control.Dock = DockStyle.Fill;
            Controls.Clear();
            Controls.Add(control);
        }
    }
}