using System;
using System.Windows.Forms;
using EPM.Wallet.Internal.Model;
using EPM.Wallet.WinForms.Interfaces;
using EPM.Wallet.WinForms.Presenters;

namespace EPM.Wallet.WinForms.Controls
{
    public partial class StandingOrderControl : UserControl, IStandingOrderView
    {
        private readonly IPresenter _presenter;
        private bool _isEventHandlerSets;

        public StandingOrderControl(IStandingOrderDataManager standingOrderDataManager, IDataMаnager dataMаnager)
        {
            InitializeComponent();
            _presenter = new StandingOrderPresenter(this, standingOrderDataManager, dataMаnager);
        }

        #region IStandingOrderView

        #region Details

        public Guid Id { get; set; }

        #endregion //Details

        #endregion //IStandingOrderView

        #region IRefreshedView

        public void RefreshItems()
        {
            dgvItems.DataSource = _presenter.BindingSource;
            var column = dgvItems.Columns[nameof(StandingOrderDto.Id)];
            if (column != null) column.Visible = false;
            column = dgvItems.Columns[nameof(StandingOrderDto.Amount)];
            if (column != null)
            {
                column.DefaultCellStyle.Format = "N2";
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
            column = dgvItems.Columns[nameof(StandingOrderDto.ClientAccountId)];
            if (column != null) column.Visible = false;
            column = dgvItems.Columns[nameof(StandingOrderDto.RequisiteId)];
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

        #endregion //Event handlers
    }
}