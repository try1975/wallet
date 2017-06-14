namespace EPM.Wallet.WinForms.Controls
{
    partial class CardControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlDetails = new System.Windows.Forms.Panel();
            this.pnlFields = new System.Windows.Forms.Panel();
            this.pnlComment = new System.Windows.Forms.Panel();
            this.tbComment = new System.Windows.Forms.TextBox();
            this.lblComment = new System.Windows.Forms.Label();
            this.pnlVendor = new System.Windows.Forms.Panel();
            this.tbVendor = new System.Windows.Forms.TextBox();
            this.lblVendor = new System.Windows.Forms.Label();
            this.pnlPin = new System.Windows.Forms.Panel();
            this.tbPin = new System.Windows.Forms.TextBox();
            this.lblPin = new System.Windows.Forms.Label();
            this.pnlCvc = new System.Windows.Forms.Panel();
            this.tbCvc = new System.Windows.Forms.TextBox();
            this.lblCvc = new System.Windows.Forms.Label();
            this.pnlLimit = new System.Windows.Forms.Panel();
            this.udLimit = new System.Windows.Forms.NumericUpDown();
            this.lblLimit = new System.Windows.Forms.Label();
            this.pnlExpYear = new System.Windows.Forms.Panel();
            this.udExpYear = new System.Windows.Forms.NumericUpDown();
            this.lblExpYear = new System.Windows.Forms.Label();
            this.pnlExpMonth = new System.Windows.Forms.Panel();
            this.udExpMonth = new System.Windows.Forms.NumericUpDown();
            this.lblExpMonth = new System.Windows.Forms.Label();
            this.pnlCardHolder = new System.Windows.Forms.Panel();
            this.tbCardHolder = new System.Windows.Forms.TextBox();
            this.lblCardHolder = new System.Windows.Forms.Label();
            this.pnlCardNumber = new System.Windows.Forms.Panel();
            this.tbCardNumber = new System.Windows.Forms.TextBox();
            this.lblCardNumber = new System.Windows.Forms.Label();
            this.pnlCurrency = new System.Windows.Forms.Panel();
            this.cmbCurrency = new System.Windows.Forms.ComboBox();
            this.lblCurrency = new System.Windows.Forms.Label();
            this.pnlClient = new System.Windows.Forms.Panel();
            this.cmbClient = new System.Windows.Forms.ComboBox();
            this.lblClient = new System.Windows.Forms.Label();
            this.pnlStatus = new System.Windows.Forms.Panel();
            this.cmbCardStatus = new System.Windows.Forms.ComboBox();
            this.lbStatus = new System.Windows.Forms.Label();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.dgvItems = new Zuby.ADGV.AdvancedDataGridView();
            this.pnlDetails.SuspendLayout();
            this.pnlFields.SuspendLayout();
            this.pnlComment.SuspendLayout();
            this.pnlVendor.SuspendLayout();
            this.pnlPin.SuspendLayout();
            this.pnlCvc.SuspendLayout();
            this.pnlLimit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udLimit)).BeginInit();
            this.pnlExpYear.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udExpYear)).BeginInit();
            this.pnlExpMonth.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udExpMonth)).BeginInit();
            this.pnlCardHolder.SuspendLayout();
            this.pnlCardNumber.SuspendLayout();
            this.pnlCurrency.SuspendLayout();
            this.pnlClient.SuspendLayout();
            this.pnlStatus.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDetails
            // 
            this.pnlDetails.Controls.Add(this.pnlFields);
            this.pnlDetails.Controls.Add(this.pnlButtons);
            this.pnlDetails.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlDetails.Location = new System.Drawing.Point(274, 0);
            this.pnlDetails.Name = "pnlDetails";
            this.pnlDetails.Size = new System.Drawing.Size(396, 550);
            this.pnlDetails.TabIndex = 5;
            // 
            // pnlFields
            // 
            this.pnlFields.Controls.Add(this.pnlComment);
            this.pnlFields.Controls.Add(this.pnlVendor);
            this.pnlFields.Controls.Add(this.pnlPin);
            this.pnlFields.Controls.Add(this.pnlCvc);
            this.pnlFields.Controls.Add(this.pnlLimit);
            this.pnlFields.Controls.Add(this.pnlExpYear);
            this.pnlFields.Controls.Add(this.pnlExpMonth);
            this.pnlFields.Controls.Add(this.pnlCardHolder);
            this.pnlFields.Controls.Add(this.pnlCardNumber);
            this.pnlFields.Controls.Add(this.pnlCurrency);
            this.pnlFields.Controls.Add(this.pnlClient);
            this.pnlFields.Controls.Add(this.pnlStatus);
            this.pnlFields.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFields.Location = new System.Drawing.Point(0, 41);
            this.pnlFields.Name = "pnlFields";
            this.pnlFields.Size = new System.Drawing.Size(396, 509);
            this.pnlFields.TabIndex = 1;
            // 
            // pnlComment
            // 
            this.pnlComment.Controls.Add(this.tbComment);
            this.pnlComment.Controls.Add(this.lblComment);
            this.pnlComment.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlComment.Location = new System.Drawing.Point(0, 363);
            this.pnlComment.Name = "pnlComment";
            this.pnlComment.Size = new System.Drawing.Size(396, 33);
            this.pnlComment.TabIndex = 14;
            // 
            // tbComment
            // 
            this.tbComment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbComment.Enabled = false;
            this.tbComment.Location = new System.Drawing.Point(97, 6);
            this.tbComment.Name = "tbComment";
            this.tbComment.Size = new System.Drawing.Size(283, 20);
            this.tbComment.TabIndex = 3;
            // 
            // lblComment
            // 
            this.lblComment.AutoSize = true;
            this.lblComment.Location = new System.Drawing.Point(7, 9);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(51, 13);
            this.lblComment.TabIndex = 0;
            this.lblComment.Text = "Comment";
            // 
            // pnlVendor
            // 
            this.pnlVendor.Controls.Add(this.tbVendor);
            this.pnlVendor.Controls.Add(this.lblVendor);
            this.pnlVendor.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlVendor.Location = new System.Drawing.Point(0, 330);
            this.pnlVendor.Name = "pnlVendor";
            this.pnlVendor.Size = new System.Drawing.Size(396, 33);
            this.pnlVendor.TabIndex = 13;
            // 
            // tbVendor
            // 
            this.tbVendor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbVendor.Enabled = false;
            this.tbVendor.Location = new System.Drawing.Point(97, 6);
            this.tbVendor.Name = "tbVendor";
            this.tbVendor.Size = new System.Drawing.Size(283, 20);
            this.tbVendor.TabIndex = 3;
            // 
            // lblVendor
            // 
            this.lblVendor.AutoSize = true;
            this.lblVendor.Location = new System.Drawing.Point(7, 9);
            this.lblVendor.Name = "lblVendor";
            this.lblVendor.Size = new System.Drawing.Size(41, 13);
            this.lblVendor.TabIndex = 0;
            this.lblVendor.Text = "Vendor";
            // 
            // pnlPin
            // 
            this.pnlPin.Controls.Add(this.tbPin);
            this.pnlPin.Controls.Add(this.lblPin);
            this.pnlPin.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPin.Location = new System.Drawing.Point(0, 297);
            this.pnlPin.Name = "pnlPin";
            this.pnlPin.Size = new System.Drawing.Size(396, 33);
            this.pnlPin.TabIndex = 12;
            // 
            // tbPin
            // 
            this.tbPin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPin.Enabled = false;
            this.tbPin.Location = new System.Drawing.Point(97, 6);
            this.tbPin.Name = "tbPin";
            this.tbPin.Size = new System.Drawing.Size(283, 20);
            this.tbPin.TabIndex = 3;
            // 
            // lblPin
            // 
            this.lblPin.AutoSize = true;
            this.lblPin.Location = new System.Drawing.Point(7, 9);
            this.lblPin.Name = "lblPin";
            this.lblPin.Size = new System.Drawing.Size(22, 13);
            this.lblPin.TabIndex = 0;
            this.lblPin.Text = "Pin";
            // 
            // pnlCvc
            // 
            this.pnlCvc.Controls.Add(this.tbCvc);
            this.pnlCvc.Controls.Add(this.lblCvc);
            this.pnlCvc.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCvc.Location = new System.Drawing.Point(0, 264);
            this.pnlCvc.Name = "pnlCvc";
            this.pnlCvc.Size = new System.Drawing.Size(396, 33);
            this.pnlCvc.TabIndex = 11;
            // 
            // tbCvc
            // 
            this.tbCvc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCvc.Enabled = false;
            this.tbCvc.Location = new System.Drawing.Point(97, 6);
            this.tbCvc.Name = "tbCvc";
            this.tbCvc.Size = new System.Drawing.Size(283, 20);
            this.tbCvc.TabIndex = 3;
            // 
            // lblCvc
            // 
            this.lblCvc.AutoSize = true;
            this.lblCvc.Location = new System.Drawing.Point(7, 9);
            this.lblCvc.Name = "lblCvc";
            this.lblCvc.Size = new System.Drawing.Size(26, 13);
            this.lblCvc.TabIndex = 0;
            this.lblCvc.Text = "Cvc";
            // 
            // pnlLimit
            // 
            this.pnlLimit.Controls.Add(this.udLimit);
            this.pnlLimit.Controls.Add(this.lblLimit);
            this.pnlLimit.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLimit.Location = new System.Drawing.Point(0, 231);
            this.pnlLimit.Name = "pnlLimit";
            this.pnlLimit.Size = new System.Drawing.Size(396, 33);
            this.pnlLimit.TabIndex = 10;
            // 
            // udLimit
            // 
            this.udLimit.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.udLimit.Location = new System.Drawing.Point(97, 7);
            this.udLimit.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.udLimit.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.udLimit.Name = "udLimit";
            this.udLimit.Size = new System.Drawing.Size(120, 20);
            this.udLimit.TabIndex = 1;
            this.udLimit.Value = new decimal(new int[] {
            2017,
            0,
            0,
            0});
            // 
            // lblLimit
            // 
            this.lblLimit.AutoSize = true;
            this.lblLimit.Location = new System.Drawing.Point(7, 9);
            this.lblLimit.Name = "lblLimit";
            this.lblLimit.Size = new System.Drawing.Size(28, 13);
            this.lblLimit.TabIndex = 0;
            this.lblLimit.Text = "Limit";
            // 
            // pnlExpYear
            // 
            this.pnlExpYear.Controls.Add(this.udExpYear);
            this.pnlExpYear.Controls.Add(this.lblExpYear);
            this.pnlExpYear.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlExpYear.Location = new System.Drawing.Point(0, 198);
            this.pnlExpYear.Name = "pnlExpYear";
            this.pnlExpYear.Size = new System.Drawing.Size(396, 33);
            this.pnlExpYear.TabIndex = 9;
            // 
            // udExpYear
            // 
            this.udExpYear.Location = new System.Drawing.Point(97, 7);
            this.udExpYear.Maximum = new decimal(new int[] {
            2050,
            0,
            0,
            0});
            this.udExpYear.Minimum = new decimal(new int[] {
            2017,
            0,
            0,
            0});
            this.udExpYear.Name = "udExpYear";
            this.udExpYear.Size = new System.Drawing.Size(120, 20);
            this.udExpYear.TabIndex = 1;
            this.udExpYear.Value = new decimal(new int[] {
            2017,
            0,
            0,
            0});
            // 
            // lblExpYear
            // 
            this.lblExpYear.AutoSize = true;
            this.lblExpYear.Location = new System.Drawing.Point(7, 9);
            this.lblExpYear.Name = "lblExpYear";
            this.lblExpYear.Size = new System.Drawing.Size(47, 13);
            this.lblExpYear.TabIndex = 0;
            this.lblExpYear.Text = "ExpYear";
            // 
            // pnlExpMonth
            // 
            this.pnlExpMonth.Controls.Add(this.udExpMonth);
            this.pnlExpMonth.Controls.Add(this.lblExpMonth);
            this.pnlExpMonth.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlExpMonth.Location = new System.Drawing.Point(0, 165);
            this.pnlExpMonth.Name = "pnlExpMonth";
            this.pnlExpMonth.Size = new System.Drawing.Size(396, 33);
            this.pnlExpMonth.TabIndex = 8;
            // 
            // udExpMonth
            // 
            this.udExpMonth.Location = new System.Drawing.Point(97, 7);
            this.udExpMonth.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.udExpMonth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udExpMonth.Name = "udExpMonth";
            this.udExpMonth.Size = new System.Drawing.Size(120, 20);
            this.udExpMonth.TabIndex = 1;
            this.udExpMonth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblExpMonth
            // 
            this.lblExpMonth.AutoSize = true;
            this.lblExpMonth.Location = new System.Drawing.Point(7, 9);
            this.lblExpMonth.Name = "lblExpMonth";
            this.lblExpMonth.Size = new System.Drawing.Size(55, 13);
            this.lblExpMonth.TabIndex = 0;
            this.lblExpMonth.Text = "ExpMonth";
            // 
            // pnlCardHolder
            // 
            this.pnlCardHolder.Controls.Add(this.tbCardHolder);
            this.pnlCardHolder.Controls.Add(this.lblCardHolder);
            this.pnlCardHolder.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCardHolder.Location = new System.Drawing.Point(0, 132);
            this.pnlCardHolder.Name = "pnlCardHolder";
            this.pnlCardHolder.Size = new System.Drawing.Size(396, 33);
            this.pnlCardHolder.TabIndex = 7;
            // 
            // tbCardHolder
            // 
            this.tbCardHolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCardHolder.Enabled = false;
            this.tbCardHolder.Location = new System.Drawing.Point(97, 6);
            this.tbCardHolder.Name = "tbCardHolder";
            this.tbCardHolder.Size = new System.Drawing.Size(283, 20);
            this.tbCardHolder.TabIndex = 3;
            // 
            // lblCardHolder
            // 
            this.lblCardHolder.AutoSize = true;
            this.lblCardHolder.Location = new System.Drawing.Point(7, 9);
            this.lblCardHolder.Name = "lblCardHolder";
            this.lblCardHolder.Size = new System.Drawing.Size(63, 13);
            this.lblCardHolder.TabIndex = 0;
            this.lblCardHolder.Text = "Card Holder";
            // 
            // pnlCardNumber
            // 
            this.pnlCardNumber.Controls.Add(this.tbCardNumber);
            this.pnlCardNumber.Controls.Add(this.lblCardNumber);
            this.pnlCardNumber.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCardNumber.Location = new System.Drawing.Point(0, 99);
            this.pnlCardNumber.Name = "pnlCardNumber";
            this.pnlCardNumber.Size = new System.Drawing.Size(396, 33);
            this.pnlCardNumber.TabIndex = 6;
            // 
            // tbCardNumber
            // 
            this.tbCardNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCardNumber.Enabled = false;
            this.tbCardNumber.Location = new System.Drawing.Point(97, 6);
            this.tbCardNumber.Name = "tbCardNumber";
            this.tbCardNumber.Size = new System.Drawing.Size(283, 20);
            this.tbCardNumber.TabIndex = 3;
            // 
            // lblCardNumber
            // 
            this.lblCardNumber.AutoSize = true;
            this.lblCardNumber.Location = new System.Drawing.Point(7, 9);
            this.lblCardNumber.Name = "lblCardNumber";
            this.lblCardNumber.Size = new System.Drawing.Size(69, 13);
            this.lblCardNumber.TabIndex = 0;
            this.lblCardNumber.Text = "Card Number";
            // 
            // pnlCurrency
            // 
            this.pnlCurrency.Controls.Add(this.cmbCurrency);
            this.pnlCurrency.Controls.Add(this.lblCurrency);
            this.pnlCurrency.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCurrency.Location = new System.Drawing.Point(0, 66);
            this.pnlCurrency.Name = "pnlCurrency";
            this.pnlCurrency.Size = new System.Drawing.Size(396, 33);
            this.pnlCurrency.TabIndex = 5;
            // 
            // cmbCurrency
            // 
            this.cmbCurrency.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbCurrency.FormattingEnabled = true;
            this.cmbCurrency.Location = new System.Drawing.Point(97, 6);
            this.cmbCurrency.Name = "cmbCurrency";
            this.cmbCurrency.Size = new System.Drawing.Size(283, 21);
            this.cmbCurrency.TabIndex = 1;
            // 
            // lblCurrency
            // 
            this.lblCurrency.AutoSize = true;
            this.lblCurrency.Location = new System.Drawing.Point(7, 9);
            this.lblCurrency.Name = "lblCurrency";
            this.lblCurrency.Size = new System.Drawing.Size(49, 13);
            this.lblCurrency.TabIndex = 0;
            this.lblCurrency.Text = "Currency";
            // 
            // pnlClient
            // 
            this.pnlClient.Controls.Add(this.cmbClient);
            this.pnlClient.Controls.Add(this.lblClient);
            this.pnlClient.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlClient.Location = new System.Drawing.Point(0, 33);
            this.pnlClient.Name = "pnlClient";
            this.pnlClient.Size = new System.Drawing.Size(396, 33);
            this.pnlClient.TabIndex = 4;
            // 
            // cmbClient
            // 
            this.cmbClient.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbClient.FormattingEnabled = true;
            this.cmbClient.Location = new System.Drawing.Point(97, 6);
            this.cmbClient.Name = "cmbClient";
            this.cmbClient.Size = new System.Drawing.Size(283, 21);
            this.cmbClient.TabIndex = 1;
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Location = new System.Drawing.Point(7, 9);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(33, 13);
            this.lblClient.TabIndex = 0;
            this.lblClient.Text = "Client";
            // 
            // pnlStatus
            // 
            this.pnlStatus.Controls.Add(this.cmbCardStatus);
            this.pnlStatus.Controls.Add(this.lbStatus);
            this.pnlStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlStatus.Location = new System.Drawing.Point(0, 0);
            this.pnlStatus.Name = "pnlStatus";
            this.pnlStatus.Size = new System.Drawing.Size(396, 33);
            this.pnlStatus.TabIndex = 3;
            // 
            // cmbCardStatus
            // 
            this.cmbCardStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbCardStatus.FormattingEnabled = true;
            this.cmbCardStatus.Location = new System.Drawing.Point(97, 7);
            this.cmbCardStatus.Name = "cmbCardStatus";
            this.cmbCardStatus.Size = new System.Drawing.Size(283, 21);
            this.cmbCardStatus.TabIndex = 4;
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(6, 9);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(37, 13);
            this.lbStatus.TabIndex = 3;
            this.lbStatus.Text = "Status";
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.btnDelete);
            this.pnlButtons.Controls.Add(this.btnCancel);
            this.pnlButtons.Controls.Add(this.btnSave);
            this.pnlButtons.Controls.Add(this.btnEdit);
            this.pnlButtons.Controls.Add(this.btnAddNew);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlButtons.Location = new System.Drawing.Point(0, 0);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(396, 41);
            this.pnlButtons.TabIndex = 2;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(294, 12);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(213, 12);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(148, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(59, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(78, 12);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(61, 23);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(10, 12);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(61, 23);
            this.btnAddNew.TabIndex = 0;
            this.btnAddNew.Text = "Add new";
            this.btnAddNew.UseVisualStyleBackColor = true;
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter1.Location = new System.Drawing.Point(271, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 550);
            this.splitter1.TabIndex = 7;
            this.splitter1.TabStop = false;
            // 
            // pnlGrid
            // 
            this.pnlGrid.Controls.Add(this.dgvItems);
            this.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrid.Location = new System.Drawing.Point(0, 0);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(271, 550);
            this.pnlGrid.TabIndex = 8;
            // 
            // dgvItems
            // 
            this.dgvItems.AllowUserToAddRows = false;
            this.dgvItems.AllowUserToDeleteRows = false;
            this.dgvItems.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvItems.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvItems.FilterAndSortEnabled = true;
            this.dgvItems.Location = new System.Drawing.Point(0, 0);
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.ReadOnly = true;
            this.dgvItems.Size = new System.Drawing.Size(271, 550);
            this.dgvItems.TabIndex = 1;
            // 
            // CardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlGrid);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.pnlDetails);
            this.Name = "CardControl";
            this.Size = new System.Drawing.Size(670, 550);
            this.pnlDetails.ResumeLayout(false);
            this.pnlFields.ResumeLayout(false);
            this.pnlComment.ResumeLayout(false);
            this.pnlComment.PerformLayout();
            this.pnlVendor.ResumeLayout(false);
            this.pnlVendor.PerformLayout();
            this.pnlPin.ResumeLayout(false);
            this.pnlPin.PerformLayout();
            this.pnlCvc.ResumeLayout(false);
            this.pnlCvc.PerformLayout();
            this.pnlLimit.ResumeLayout(false);
            this.pnlLimit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udLimit)).EndInit();
            this.pnlExpYear.ResumeLayout(false);
            this.pnlExpYear.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udExpYear)).EndInit();
            this.pnlExpMonth.ResumeLayout(false);
            this.pnlExpMonth.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udExpMonth)).EndInit();
            this.pnlCardHolder.ResumeLayout(false);
            this.pnlCardHolder.PerformLayout();
            this.pnlCardNumber.ResumeLayout(false);
            this.pnlCardNumber.PerformLayout();
            this.pnlCurrency.ResumeLayout(false);
            this.pnlCurrency.PerformLayout();
            this.pnlClient.ResumeLayout(false);
            this.pnlClient.PerformLayout();
            this.pnlStatus.ResumeLayout(false);
            this.pnlStatus.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            this.pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDetails;
        private System.Windows.Forms.Panel pnlFields;
        private System.Windows.Forms.Panel pnlStatus;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.Panel pnlCurrency;
        private System.Windows.Forms.ComboBox cmbCurrency;
        private System.Windows.Forms.Label lblCurrency;
        private System.Windows.Forms.Panel pnlClient;
        private System.Windows.Forms.ComboBox cmbClient;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.Panel pnlCardHolder;
        private System.Windows.Forms.TextBox tbCardHolder;
        private System.Windows.Forms.Label lblCardHolder;
        private System.Windows.Forms.Panel pnlCardNumber;
        private System.Windows.Forms.TextBox tbCardNumber;
        private System.Windows.Forms.Label lblCardNumber;
        private System.Windows.Forms.Panel pnlExpYear;
        private System.Windows.Forms.Label lblExpYear;
        private System.Windows.Forms.Panel pnlExpMonth;
        private System.Windows.Forms.Label lblExpMonth;
        private System.Windows.Forms.NumericUpDown udExpYear;
        private System.Windows.Forms.NumericUpDown udExpMonth;
        private System.Windows.Forms.Panel pnlLimit;
        private System.Windows.Forms.NumericUpDown udLimit;
        private System.Windows.Forms.Label lblLimit;
        private Zuby.ADGV.AdvancedDataGridView dgvItems;
        private System.Windows.Forms.Panel pnlVendor;
        private System.Windows.Forms.TextBox tbVendor;
        private System.Windows.Forms.Label lblVendor;
        private System.Windows.Forms.Panel pnlPin;
        private System.Windows.Forms.TextBox tbPin;
        private System.Windows.Forms.Label lblPin;
        private System.Windows.Forms.Panel pnlCvc;
        private System.Windows.Forms.TextBox tbCvc;
        private System.Windows.Forms.Label lblCvc;
        private System.Windows.Forms.ComboBox cmbCardStatus;
        private System.Windows.Forms.Panel pnlComment;
        private System.Windows.Forms.TextBox tbComment;
        private System.Windows.Forms.Label lblComment;
    }
}
