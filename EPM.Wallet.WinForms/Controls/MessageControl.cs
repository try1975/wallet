using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;
using EPM.Wallet.Internal.Model;
using EPM.Wallet.WinForms.Interfaces;
using EPM.Wallet.WinForms.Presenters;

namespace EPM.Wallet.WinForms.Controls
{
    public partial class MessageControl : UserControl, IMessageView
    {
        private readonly IPresenter _presenter;
        private bool _isEventHandlerSets;

        public MessageControl(IMessageDataManager messageDataManager, IDataMаnager dataMаnager)
        {
            InitializeComponent();
            _presenter = new MessagePresenter(this, messageDataManager, dataMаnager);
        }

        #region IMessageView

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

        public string Subject
        {
            get { return tbSubject.Text; }
            set { tbSubject.Text = value; }
        }

        public string Body
        {
            get { return tbBody.Text; }
            set { tbBody.Text = value; }
        }

        public string ClientId
        {
            get { return (string) cmbClient.SelectedValue; }
            set { cmbClient.SelectedValue = value; }
        }

        public DateTime Date
        {
            get
            {
                if (string.IsNullOrEmpty(tbDate.Text)) return DateTime.UtcNow;
                return DateTime.Parse(tbDate.Text);
            }
            set { tbDate.Text = value.ToString(CultureInfo.CurrentCulture); }
        }

        public DateTime? ReadDate
        {
            get
            {
                if (string.IsNullOrEmpty(tbReadDate.Text)) return null;
                return DateTime.Parse(tbReadDate.Text);
            }
            set
            {
                if (value.HasValue)
                {
                    tbReadDate.Text = value.ToString();
                }
                else
                {
                    tbReadDate.Clear();
                }
            }
        }

        public bool IsOutgoing { get; set; }

        #endregion //Details

        #region DetailsLists

        public List<KeyValuePair<string, string>> ClientList
        {
            set
            {
                cmbClient.DataSource = value;
                cmbClient.ValueMember = "Key";
                cmbClient.DisplayMember = "Value";
            }
        }

        #endregion

        #endregion //IMessageView

        #region IRefreshedView

        public void RefreshItems()
        {
            dgvItems.DataSource = _presenter.BindingSource;

            var column = dgvItems.Columns[nameof(MessageDto.Id)];
            if (column != null) column.Visible = false;
        }

        public void SetEventHandlers()
        {
            if (_isEventHandlerSets) return;
            _isEventHandlerSets = true;

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
            cmbClient.SelectedIndex = -1;
            tbDate.Clear();
            tbSubject.Clear();
            tbBody.Clear();
            tbReadDate.Clear();
        }

        public void EnableInput()
        {
            cmbClient.Enabled = true;
            tbSubject.Enabled = true;
            tbBody.Enabled = true;
            if (_presenter.PresenterMode == PresenterMode.Edit)
            {
                btnSetReaded.Enabled = true;
            }
        }

        public void DisableInput()
        {
            tbId.Enabled = false;
            cmbClient.Enabled = false;
            tbDate.Enabled = false;
            tbSubject.Enabled = false;
            tbBody.Enabled = false;
            tbReadDate.Enabled = false;
            btnSetReaded.Enabled = false;
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

        private void btnSetReaded_Click(object sender, EventArgs e)
        {
            if (_presenter.PresenterMode == PresenterMode.Edit && !ReadDate.HasValue && IsOutgoing)
                ReadDate = DateTime.UtcNow;
        }

        #endregion //Event handlers
    }
}