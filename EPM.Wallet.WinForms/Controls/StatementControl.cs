using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using EPM.Wallet.Internal.Model;
using EPM.Wallet.WinForms.Interfaces;
using EPM.Wallet.WinForms.Presenters;

namespace EPM.Wallet.WinForms.Controls
{
    public partial class StatementControl : UserControl, IStatementView
    {
        private readonly IPresenter _presenter;
        private Uri _statementLink;

        public StatementControl(IStatementDataManager statementDataManager, IDataMаnager dataMаnager)
        {
            InitializeComponent();
            _presenter = new StatementPresenter(this, statementDataManager, dataMаnager);
        }

        #region ITransactionView

        #region Details

        public Guid Id
        {
            get
            {
                if (string.IsNullOrEmpty(tbId.Text)) return Guid.Empty;
                Guid id;
                return Guid.TryParse(tbId.Text, out id) ? id : Guid.Empty;
            }
            set { tbId.Text = value.ToString(); }
        }

        public Guid AccountId
        {
            get { return (Guid)cmbAccount.SelectedValue; }
            set { cmbAccount.SelectedValue = value; }
        }

        public DateTimeOffset ValueDate
        {
            get
            {
                if (string.IsNullOrEmpty(tbValueDate.Text)) return DateTime.UtcNow;
                return DateTime.Parse(tbValueDate.Text);
            }
            set { tbValueDate.Text = value.ToString(CultureInfo.CurrentCulture); }
        }

        public string Period {
            get { return tbPeriod.Text; }
            set { tbPeriod.Text = value; }
        }

        public decimal PreviousBalance
        {
            get
            {
                decimal decimalResult;
                return decimal.TryParse(tbPreviosBalance.Text, NumberStyles.Number, new CultureInfo("en-GB"),
                    out decimalResult)
                    ? decimalResult
                    : 0;
            }
            set { tbPreviosBalance.Text = value.ToString(CultureInfo.InvariantCulture); }
        }

        public decimal Credits {
            get
            {
                decimal decimalResult;
                return decimal.TryParse(tbCredits.Text, NumberStyles.Number, new CultureInfo("en-GB"),
                    out decimalResult)
                    ? decimalResult
                    : 0;
            }
            set { tbCredits.Text = value.ToString(CultureInfo.InvariantCulture); }
        }

        public decimal Debits {
            get
            {
                decimal decimalResult;
                return decimal.TryParse(tbDebits.Text, NumberStyles.Number, new CultureInfo("en-GB"),
                    out decimalResult)
                    ? decimalResult
                    : 0;
            }
            set { tbDebits.Text = value.ToString(CultureInfo.InvariantCulture); }
        }

        public decimal NewBalance {
            get
            {
                decimal decimalResult;
                return decimal.TryParse(tbNewBalance.Text, NumberStyles.Number, new CultureInfo("en-GB"),
                    out decimalResult)
                    ? decimalResult
                    : 0;
            }
            set { tbNewBalance.Text = value.ToString(CultureInfo.InvariantCulture); }
        }

        public byte[] Content { get; set; }

        public string LoadedFrom
        {
            get { return tbLoadedFrom.Text; }
            set { tbLoadedFrom.Text = value; }
        }

        public Uri StatementLink
        {
            get { return _statementLink; }
            set
            {
                _statementLink = value;
                linkStatement.Text = LoadedFrom;
            }  
        }

        #endregion //Details

        #region DetailsLists

        public List<KeyValuePair<Guid, string>> AccountList
        {
            set
            {
                cmbAccount.DataSource = value;
                cmbAccount.ValueMember = "Key";
                cmbAccount.DisplayMember = "Value";
            }
        }

        #endregion //DetailsLists

        #endregion //ITransactionView

        #region IRefreshedView

        public void RefreshItems()
        {
            dgvItems.DataSource = _presenter.BindingSource;

            var column = dgvItems.Columns[nameof(StatementDto.Id)];
            if (column != null) column.Visible = false;
            column = dgvItems.Columns[nameof(StatementDto.Content)];
            if (column != null) column.Visible = false;
        }

        public void SetEventHandlers()
        {
            dgvItems.FilterStringChanged += dgvItems_FilterStringChanged;
            dgvItems.SortStringChanged += dgvItems_SortStringChanged;

            btnAddNew.Click += btnAddNew_Click;
            btnEdit.Click += btnEdit_Click;
            btnSave.Click += btnSave_Click;
            btnCancel.Click += btnCancel_Click;
            btnDelete.Click += btnDelete_Click;
        }

        #endregion //IRefreshedView

        #region IEnterMode

        public void EnterEditMode()
        {
            EnableInput();

            btnDelete.Enabled = false;
            btnCancel.Enabled = true;
            btnSave.Enabled = true;
            btnEdit.Enabled = false;
            btnAddNew.Enabled = false;
        }

        public void EnterDetailsMode()
        {
            DisableInput();

            btnDelete.Enabled = true;
            btnCancel.Enabled = false;
            btnSave.Enabled = false;
            btnEdit.Enabled = true;
            btnAddNew.Enabled = true;
        }

        public void EnterReadMode()
        {
            ClearInputFields();
            DisableInput();
            //ClearSelectedAccounts();
            //ClearFilter();

            btnDelete.Enabled = false;
            btnCancel.Enabled = false;
            btnSave.Enabled = false;
            btnEdit.Enabled = false;
            btnAddNew.Enabled = true;
        }

        public void EnterAddNewMode()
        {
            ClearInputFields();
            EnableInput();

            btnDelete.Enabled = false;
            btnCancel.Enabled = true;
            btnSave.Enabled = true;
            btnEdit.Enabled = false;
            btnAddNew.Enabled = false;
        }

        public void EnterMultiSelectMode()
        {
            ClearInputFields();
            DisableInput();

            btnDelete.Enabled = false;
            btnCancel.Enabled = false;
            btnSave.Enabled = false;
            btnEdit.Enabled = false;
            btnAddNew.Enabled = true;
        }

        public void ClearInputFields()
        {
            tbId.Clear();
            cmbAccount.SelectedIndex = -1;
            tbValueDate.Clear();
            tbPeriod.Clear();
            tbPreviosBalance.Clear();
            tbCredits.Clear();
            tbDebits.Clear();
            tbNewBalance.Clear();
            tbLoadedFrom.Clear();
            linkStatement.Text = "";
        }

        public void EnableInput()
        {
            cmbAccount.Enabled = true;
            tbPeriod.Enabled = true;
            tbPreviosBalance.Enabled = true;
            tbCredits.Enabled = true;
            tbDebits.Enabled = true;
            tbNewBalance.Enabled = true;
        }

        public void DisableInput()
        {
            tbId.Enabled = false;
            cmbAccount.Enabled = false;
            tbValueDate.Enabled = false;
            tbPeriod.Enabled = false;
            tbPreviosBalance.Enabled = false;
            tbCredits.Enabled = false;
            tbDebits.Enabled = false;
            tbNewBalance.Enabled = false;
            tbLoadedFrom.Enabled = false;
        }

        #endregion //IEnterMode

        #region Event handlers

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            _presenter.AddNew();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            _presenter.Edit();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _presenter.Save();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _presenter.Cancel();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _presenter.Delete();
        }

        private void dgvItems_FilterStringChanged(object sender, EventArgs e)
        {
            _presenter.BindingSource.Filter = dgvItems.FilterString;
        }

        private void dgvItems_SortStringChanged(object sender, EventArgs e)
        {
            _presenter.BindingSource.Sort = dgvItems.SortString;
        }

        private void btnLoadPdf_Click(object sender, EventArgs e)
        {
            using (var dlgOpen = new OpenFileDialog())
            {
                if (dlgOpen.ShowDialog() != DialogResult.OK) return;
                Content = File.ReadAllBytes(dlgOpen.FileName);
                LoadedFrom = Path.GetFileName(dlgOpen.FileName);
            }
        }

        private void linkStatement_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(StatementLink.AbsoluteUri);
        }

        #endregion //Event handlers
    }
}