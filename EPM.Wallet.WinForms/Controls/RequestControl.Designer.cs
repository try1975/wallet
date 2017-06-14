namespace EPM.Wallet.WinForms.Controls
{
    partial class RequestControl
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
            this.pnlReissueReason = new System.Windows.Forms.Panel();
            this.tbReissueReason = new System.Windows.Forms.TextBox();
            this.lblReissueReason = new System.Windows.Forms.Label();
            this.pnlReissueType = new System.Windows.Forms.Panel();
            this.tbReissueType = new System.Windows.Forms.TextBox();
            this.lblReissueType = new System.Windows.Forms.Label();
            this.pnlLimit = new System.Windows.Forms.Panel();
            this.tbLimit = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.pnlCardNumber = new System.Windows.Forms.Panel();
            this.tbCardNumber = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pnlOwnerName = new System.Windows.Forms.Panel();
            this.tbOwnerName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlBic = new System.Windows.Forms.Panel();
            this.tbBic = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlBankAddress = new System.Windows.Forms.Panel();
            this.tbBankAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlIban = new System.Windows.Forms.Panel();
            this.tbIban = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlBankName = new System.Windows.Forms.Panel();
            this.tbBankName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlBeneficiaryAccountName = new System.Windows.Forms.Panel();
            this.tbBeneficiaryAccountName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlAmountOut = new System.Windows.Forms.Panel();
            this.tbAmountOut = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pnlAmountIn = new System.Windows.Forms.Panel();
            this.tbAmountIn = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pnlCurrency = new System.Windows.Forms.Panel();
            this.tbCurrencyId = new System.Windows.Forms.TextBox();
            this.lblCurrency = new System.Windows.Forms.Label();
            this.pnlValueDate = new System.Windows.Forms.Panel();
            this.tbValueDate = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.pnlAccountName = new System.Windows.Forms.Panel();
            this.tbAccountName = new System.Windows.Forms.TextBox();
            this.lblAccountName = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnPending = new System.Windows.Forms.Button();
            this.btnProcessed = new System.Windows.Forms.Button();
            this.btnReject = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.dgvItems = new Zuby.ADGV.AdvancedDataGridView();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.pnlDetails.SuspendLayout();
            this.pnlFields.SuspendLayout();
            this.pnlReissueReason.SuspendLayout();
            this.pnlReissueType.SuspendLayout();
            this.pnlLimit.SuspendLayout();
            this.pnlCardNumber.SuspendLayout();
            this.pnlOwnerName.SuspendLayout();
            this.pnlBic.SuspendLayout();
            this.pnlBankAddress.SuspendLayout();
            this.pnlIban.SuspendLayout();
            this.pnlBankName.SuspendLayout();
            this.pnlBeneficiaryAccountName.SuspendLayout();
            this.pnlAmountOut.SuspendLayout();
            this.pnlAmountIn.SuspendLayout();
            this.pnlCurrency.SuspendLayout();
            this.pnlValueDate.SuspendLayout();
            this.pnlAccountName.SuspendLayout();
            this.panel8.SuspendLayout();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDetails
            // 
            this.pnlDetails.Controls.Add(this.pnlFields);
            this.pnlDetails.Controls.Add(this.panel8);
            this.pnlDetails.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlDetails.Location = new System.Drawing.Point(274, 0);
            this.pnlDetails.Name = "pnlDetails";
            this.pnlDetails.Size = new System.Drawing.Size(396, 578);
            this.pnlDetails.TabIndex = 5;
            // 
            // pnlFields
            // 
            this.pnlFields.Controls.Add(this.pnlReissueReason);
            this.pnlFields.Controls.Add(this.pnlReissueType);
            this.pnlFields.Controls.Add(this.pnlLimit);
            this.pnlFields.Controls.Add(this.pnlCardNumber);
            this.pnlFields.Controls.Add(this.pnlOwnerName);
            this.pnlFields.Controls.Add(this.pnlBic);
            this.pnlFields.Controls.Add(this.pnlBankAddress);
            this.pnlFields.Controls.Add(this.pnlIban);
            this.pnlFields.Controls.Add(this.pnlBankName);
            this.pnlFields.Controls.Add(this.pnlBeneficiaryAccountName);
            this.pnlFields.Controls.Add(this.pnlAmountOut);
            this.pnlFields.Controls.Add(this.pnlAmountIn);
            this.pnlFields.Controls.Add(this.pnlCurrency);
            this.pnlFields.Controls.Add(this.pnlValueDate);
            this.pnlFields.Controls.Add(this.pnlAccountName);
            this.pnlFields.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFields.Location = new System.Drawing.Point(0, 39);
            this.pnlFields.Name = "pnlFields";
            this.pnlFields.Size = new System.Drawing.Size(396, 539);
            this.pnlFields.TabIndex = 1;
            // 
            // pnlReissueReason
            // 
            this.pnlReissueReason.Controls.Add(this.tbReissueReason);
            this.pnlReissueReason.Controls.Add(this.lblReissueReason);
            this.pnlReissueReason.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlReissueReason.Location = new System.Drawing.Point(0, 504);
            this.pnlReissueReason.Name = "pnlReissueReason";
            this.pnlReissueReason.Size = new System.Drawing.Size(396, 34);
            this.pnlReissueReason.TabIndex = 22;
            // 
            // tbReissueReason
            // 
            this.tbReissueReason.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbReissueReason.Location = new System.Drawing.Point(97, 6);
            this.tbReissueReason.Name = "tbReissueReason";
            this.tbReissueReason.ReadOnly = true;
            this.tbReissueReason.Size = new System.Drawing.Size(283, 20);
            this.tbReissueReason.TabIndex = 2;
            // 
            // lblReissueReason
            // 
            this.lblReissueReason.AutoSize = true;
            this.lblReissueReason.Location = new System.Drawing.Point(7, 9);
            this.lblReissueReason.Name = "lblReissueReason";
            this.lblReissueReason.Size = new System.Drawing.Size(85, 13);
            this.lblReissueReason.TabIndex = 0;
            this.lblReissueReason.Text = "Reissue Reason";
            // 
            // pnlReissueType
            // 
            this.pnlReissueType.Controls.Add(this.tbReissueType);
            this.pnlReissueType.Controls.Add(this.lblReissueType);
            this.pnlReissueType.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlReissueType.Location = new System.Drawing.Point(0, 470);
            this.pnlReissueType.Name = "pnlReissueType";
            this.pnlReissueType.Size = new System.Drawing.Size(396, 34);
            this.pnlReissueType.TabIndex = 21;
            // 
            // tbReissueType
            // 
            this.tbReissueType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbReissueType.Location = new System.Drawing.Point(97, 6);
            this.tbReissueType.Name = "tbReissueType";
            this.tbReissueType.ReadOnly = true;
            this.tbReissueType.Size = new System.Drawing.Size(283, 20);
            this.tbReissueType.TabIndex = 2;
            // 
            // lblReissueType
            // 
            this.lblReissueType.AutoSize = true;
            this.lblReissueType.Location = new System.Drawing.Point(7, 9);
            this.lblReissueType.Name = "lblReissueType";
            this.lblReissueType.Size = new System.Drawing.Size(72, 13);
            this.lblReissueType.TabIndex = 0;
            this.lblReissueType.Text = "Reissue Type";
            // 
            // pnlLimit
            // 
            this.pnlLimit.Controls.Add(this.tbLimit);
            this.pnlLimit.Controls.Add(this.label11);
            this.pnlLimit.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLimit.Location = new System.Drawing.Point(0, 436);
            this.pnlLimit.Name = "pnlLimit";
            this.pnlLimit.Size = new System.Drawing.Size(396, 34);
            this.pnlLimit.TabIndex = 20;
            // 
            // tbLimit
            // 
            this.tbLimit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLimit.Location = new System.Drawing.Point(97, 6);
            this.tbLimit.Name = "tbLimit";
            this.tbLimit.ReadOnly = true;
            this.tbLimit.Size = new System.Drawing.Size(283, 20);
            this.tbLimit.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Limit";
            // 
            // pnlCardNumber
            // 
            this.pnlCardNumber.Controls.Add(this.tbCardNumber);
            this.pnlCardNumber.Controls.Add(this.label7);
            this.pnlCardNumber.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCardNumber.Location = new System.Drawing.Point(0, 402);
            this.pnlCardNumber.Name = "pnlCardNumber";
            this.pnlCardNumber.Size = new System.Drawing.Size(396, 34);
            this.pnlCardNumber.TabIndex = 16;
            // 
            // tbCardNumber
            // 
            this.tbCardNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCardNumber.Location = new System.Drawing.Point(97, 6);
            this.tbCardNumber.Name = "tbCardNumber";
            this.tbCardNumber.ReadOnly = true;
            this.tbCardNumber.Size = new System.Drawing.Size(283, 20);
            this.tbCardNumber.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "CardNumber";
            // 
            // pnlOwnerName
            // 
            this.pnlOwnerName.Controls.Add(this.tbOwnerName);
            this.pnlOwnerName.Controls.Add(this.label6);
            this.pnlOwnerName.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlOwnerName.Location = new System.Drawing.Point(0, 364);
            this.pnlOwnerName.Name = "pnlOwnerName";
            this.pnlOwnerName.Size = new System.Drawing.Size(396, 38);
            this.pnlOwnerName.TabIndex = 14;
            // 
            // tbOwnerName
            // 
            this.tbOwnerName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbOwnerName.Location = new System.Drawing.Point(97, 12);
            this.tbOwnerName.Name = "tbOwnerName";
            this.tbOwnerName.ReadOnly = true;
            this.tbOwnerName.Size = new System.Drawing.Size(283, 20);
            this.tbOwnerName.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "OwnerName";
            // 
            // pnlBic
            // 
            this.pnlBic.Controls.Add(this.tbBic);
            this.pnlBic.Controls.Add(this.label5);
            this.pnlBic.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBic.Location = new System.Drawing.Point(0, 326);
            this.pnlBic.Name = "pnlBic";
            this.pnlBic.Size = new System.Drawing.Size(396, 38);
            this.pnlBic.TabIndex = 13;
            // 
            // tbBic
            // 
            this.tbBic.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbBic.Location = new System.Drawing.Point(97, 12);
            this.tbBic.Name = "tbBic";
            this.tbBic.ReadOnly = true;
            this.tbBic.Size = new System.Drawing.Size(283, 20);
            this.tbBic.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Bic";
            // 
            // pnlBankAddress
            // 
            this.pnlBankAddress.Controls.Add(this.tbBankAddress);
            this.pnlBankAddress.Controls.Add(this.label4);
            this.pnlBankAddress.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBankAddress.Location = new System.Drawing.Point(0, 288);
            this.pnlBankAddress.Name = "pnlBankAddress";
            this.pnlBankAddress.Size = new System.Drawing.Size(396, 38);
            this.pnlBankAddress.TabIndex = 12;
            // 
            // tbBankAddress
            // 
            this.tbBankAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbBankAddress.Location = new System.Drawing.Point(97, 12);
            this.tbBankAddress.Name = "tbBankAddress";
            this.tbBankAddress.ReadOnly = true;
            this.tbBankAddress.Size = new System.Drawing.Size(283, 20);
            this.tbBankAddress.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "BankAddress";
            // 
            // pnlIban
            // 
            this.pnlIban.Controls.Add(this.tbIban);
            this.pnlIban.Controls.Add(this.label3);
            this.pnlIban.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlIban.Location = new System.Drawing.Point(0, 250);
            this.pnlIban.Name = "pnlIban";
            this.pnlIban.Size = new System.Drawing.Size(396, 38);
            this.pnlIban.TabIndex = 11;
            // 
            // tbIban
            // 
            this.tbIban.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbIban.Location = new System.Drawing.Point(97, 12);
            this.tbIban.Name = "tbIban";
            this.tbIban.ReadOnly = true;
            this.tbIban.Size = new System.Drawing.Size(283, 20);
            this.tbIban.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Iban";
            // 
            // pnlBankName
            // 
            this.pnlBankName.Controls.Add(this.tbBankName);
            this.pnlBankName.Controls.Add(this.label2);
            this.pnlBankName.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBankName.Location = new System.Drawing.Point(0, 212);
            this.pnlBankName.Name = "pnlBankName";
            this.pnlBankName.Size = new System.Drawing.Size(396, 38);
            this.pnlBankName.TabIndex = 10;
            // 
            // tbBankName
            // 
            this.tbBankName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbBankName.Location = new System.Drawing.Point(97, 12);
            this.tbBankName.Name = "tbBankName";
            this.tbBankName.ReadOnly = true;
            this.tbBankName.Size = new System.Drawing.Size(283, 20);
            this.tbBankName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "BankName";
            // 
            // pnlBeneficiaryAccountName
            // 
            this.pnlBeneficiaryAccountName.Controls.Add(this.tbBeneficiaryAccountName);
            this.pnlBeneficiaryAccountName.Controls.Add(this.label1);
            this.pnlBeneficiaryAccountName.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBeneficiaryAccountName.Location = new System.Drawing.Point(0, 174);
            this.pnlBeneficiaryAccountName.Name = "pnlBeneficiaryAccountName";
            this.pnlBeneficiaryAccountName.Size = new System.Drawing.Size(396, 38);
            this.pnlBeneficiaryAccountName.TabIndex = 15;
            // 
            // tbBeneficiaryAccountName
            // 
            this.tbBeneficiaryAccountName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbBeneficiaryAccountName.Location = new System.Drawing.Point(97, 12);
            this.tbBeneficiaryAccountName.Name = "tbBeneficiaryAccountName";
            this.tbBeneficiaryAccountName.ReadOnly = true;
            this.tbBeneficiaryAccountName.Size = new System.Drawing.Size(283, 20);
            this.tbBeneficiaryAccountName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Beneficiary";
            // 
            // pnlAmountOut
            // 
            this.pnlAmountOut.Controls.Add(this.tbAmountOut);
            this.pnlAmountOut.Controls.Add(this.label9);
            this.pnlAmountOut.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAmountOut.Location = new System.Drawing.Point(0, 140);
            this.pnlAmountOut.Name = "pnlAmountOut";
            this.pnlAmountOut.Size = new System.Drawing.Size(396, 34);
            this.pnlAmountOut.TabIndex = 18;
            // 
            // tbAmountOut
            // 
            this.tbAmountOut.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAmountOut.Location = new System.Drawing.Point(97, 6);
            this.tbAmountOut.Name = "tbAmountOut";
            this.tbAmountOut.ReadOnly = true;
            this.tbAmountOut.Size = new System.Drawing.Size(283, 20);
            this.tbAmountOut.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "AmountOut";
            // 
            // pnlAmountIn
            // 
            this.pnlAmountIn.Controls.Add(this.tbAmountIn);
            this.pnlAmountIn.Controls.Add(this.label8);
            this.pnlAmountIn.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAmountIn.Location = new System.Drawing.Point(0, 106);
            this.pnlAmountIn.Name = "pnlAmountIn";
            this.pnlAmountIn.Size = new System.Drawing.Size(396, 34);
            this.pnlAmountIn.TabIndex = 17;
            this.pnlAmountIn.Visible = false;
            // 
            // tbAmountIn
            // 
            this.tbAmountIn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAmountIn.Location = new System.Drawing.Point(97, 6);
            this.tbAmountIn.Name = "tbAmountIn";
            this.tbAmountIn.ReadOnly = true;
            this.tbAmountIn.Size = new System.Drawing.Size(283, 20);
            this.tbAmountIn.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "AmountIn";
            // 
            // pnlCurrency
            // 
            this.pnlCurrency.Controls.Add(this.tbCurrencyId);
            this.pnlCurrency.Controls.Add(this.lblCurrency);
            this.pnlCurrency.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCurrency.Location = new System.Drawing.Point(0, 72);
            this.pnlCurrency.Name = "pnlCurrency";
            this.pnlCurrency.Size = new System.Drawing.Size(396, 34);
            this.pnlCurrency.TabIndex = 6;
            // 
            // tbCurrencyId
            // 
            this.tbCurrencyId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCurrencyId.Location = new System.Drawing.Point(97, 6);
            this.tbCurrencyId.Name = "tbCurrencyId";
            this.tbCurrencyId.ReadOnly = true;
            this.tbCurrencyId.Size = new System.Drawing.Size(283, 20);
            this.tbCurrencyId.TabIndex = 2;
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
            // pnlValueDate
            // 
            this.pnlValueDate.Controls.Add(this.tbValueDate);
            this.pnlValueDate.Controls.Add(this.label10);
            this.pnlValueDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlValueDate.Location = new System.Drawing.Point(0, 38);
            this.pnlValueDate.Name = "pnlValueDate";
            this.pnlValueDate.Size = new System.Drawing.Size(396, 34);
            this.pnlValueDate.TabIndex = 19;
            // 
            // tbValueDate
            // 
            this.tbValueDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbValueDate.Location = new System.Drawing.Point(97, 6);
            this.tbValueDate.Name = "tbValueDate";
            this.tbValueDate.ReadOnly = true;
            this.tbValueDate.Size = new System.Drawing.Size(283, 20);
            this.tbValueDate.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 7);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "ValueDate";
            // 
            // pnlAccountName
            // 
            this.pnlAccountName.Controls.Add(this.tbAccountName);
            this.pnlAccountName.Controls.Add(this.lblAccountName);
            this.pnlAccountName.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAccountName.Location = new System.Drawing.Point(0, 0);
            this.pnlAccountName.Name = "pnlAccountName";
            this.pnlAccountName.Size = new System.Drawing.Size(396, 38);
            this.pnlAccountName.TabIndex = 4;
            // 
            // tbAccountName
            // 
            this.tbAccountName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAccountName.Location = new System.Drawing.Point(97, 12);
            this.tbAccountName.Name = "tbAccountName";
            this.tbAccountName.ReadOnly = true;
            this.tbAccountName.Size = new System.Drawing.Size(283, 20);
            this.tbAccountName.TabIndex = 1;
            // 
            // lblAccountName
            // 
            this.lblAccountName.AutoSize = true;
            this.lblAccountName.Location = new System.Drawing.Point(7, 15);
            this.lblAccountName.Name = "lblAccountName";
            this.lblAccountName.Size = new System.Drawing.Size(47, 13);
            this.lblAccountName.TabIndex = 0;
            this.lblAccountName.Text = "Account";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btnPending);
            this.panel8.Controls.Add(this.btnProcessed);
            this.panel8.Controls.Add(this.btnReject);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(396, 39);
            this.panel8.TabIndex = 17;
            // 
            // btnPending
            // 
            this.btnPending.Location = new System.Drawing.Point(178, 5);
            this.btnPending.Margin = new System.Windows.Forms.Padding(2);
            this.btnPending.Name = "btnPending";
            this.btnPending.Size = new System.Drawing.Size(77, 23);
            this.btnPending.TabIndex = 11;
            this.btnPending.Text = "Pending";
            this.btnPending.UseVisualStyleBackColor = true;
            // 
            // btnProcessed
            // 
            this.btnProcessed.Location = new System.Drawing.Point(15, 5);
            this.btnProcessed.Margin = new System.Windows.Forms.Padding(2);
            this.btnProcessed.Name = "btnProcessed";
            this.btnProcessed.Size = new System.Drawing.Size(77, 23);
            this.btnProcessed.TabIndex = 10;
            this.btnProcessed.Text = "Processed";
            this.btnProcessed.UseVisualStyleBackColor = true;
            // 
            // btnReject
            // 
            this.btnReject.Location = new System.Drawing.Point(96, 5);
            this.btnReject.Margin = new System.Windows.Forms.Padding(2);
            this.btnReject.Name = "btnReject";
            this.btnReject.Size = new System.Drawing.Size(77, 23);
            this.btnReject.TabIndex = 9;
            this.btnReject.Text = "Reject";
            this.btnReject.UseVisualStyleBackColor = true;
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter1.Location = new System.Drawing.Point(271, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 578);
            this.splitter1.TabIndex = 7;
            this.splitter1.TabStop = false;
            // 
            // pnlGrid
            // 
            this.pnlGrid.Controls.Add(this.dgvItems);
            this.pnlGrid.Controls.Add(this.panel7);
            this.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrid.Location = new System.Drawing.Point(0, 0);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(271, 578);
            this.pnlGrid.TabIndex = 11;
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
            this.dgvItems.Location = new System.Drawing.Point(0, 41);
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.ReadOnly = true;
            this.dgvItems.Size = new System.Drawing.Size(271, 537);
            this.dgvItems.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnRefresh);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(271, 41);
            this.panel7.TabIndex = 2;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(17, 12);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // RequestControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlGrid);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.pnlDetails);
            this.Name = "RequestControl";
            this.Size = new System.Drawing.Size(670, 578);
            this.pnlDetails.ResumeLayout(false);
            this.pnlFields.ResumeLayout(false);
            this.pnlReissueReason.ResumeLayout(false);
            this.pnlReissueReason.PerformLayout();
            this.pnlReissueType.ResumeLayout(false);
            this.pnlReissueType.PerformLayout();
            this.pnlLimit.ResumeLayout(false);
            this.pnlLimit.PerformLayout();
            this.pnlCardNumber.ResumeLayout(false);
            this.pnlCardNumber.PerformLayout();
            this.pnlOwnerName.ResumeLayout(false);
            this.pnlOwnerName.PerformLayout();
            this.pnlBic.ResumeLayout(false);
            this.pnlBic.PerformLayout();
            this.pnlBankAddress.ResumeLayout(false);
            this.pnlBankAddress.PerformLayout();
            this.pnlIban.ResumeLayout(false);
            this.pnlIban.PerformLayout();
            this.pnlBankName.ResumeLayout(false);
            this.pnlBankName.PerformLayout();
            this.pnlBeneficiaryAccountName.ResumeLayout(false);
            this.pnlBeneficiaryAccountName.PerformLayout();
            this.pnlAmountOut.ResumeLayout(false);
            this.pnlAmountOut.PerformLayout();
            this.pnlAmountIn.ResumeLayout(false);
            this.pnlAmountIn.PerformLayout();
            this.pnlCurrency.ResumeLayout(false);
            this.pnlCurrency.PerformLayout();
            this.pnlValueDate.ResumeLayout(false);
            this.pnlValueDate.PerformLayout();
            this.pnlAccountName.ResumeLayout(false);
            this.pnlAccountName.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            this.panel7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDetails;
        private System.Windows.Forms.Panel pnlFields;
        private System.Windows.Forms.Panel pnlCurrency;
        private System.Windows.Forms.Label lblCurrency;
        private System.Windows.Forms.Panel pnlAccountName;
        private System.Windows.Forms.TextBox tbAccountName;
        private System.Windows.Forms.Label lblAccountName;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btnPending;
        private System.Windows.Forms.Button btnProcessed;
        private System.Windows.Forms.Button btnReject;
        private System.Windows.Forms.Panel pnlBic;
        private System.Windows.Forms.TextBox tbBic;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnlBankAddress;
        private System.Windows.Forms.TextBox tbBankAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlIban;
        private System.Windows.Forms.TextBox tbIban;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlBankName;
        private System.Windows.Forms.TextBox tbBankName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlOwnerName;
        private System.Windows.Forms.TextBox tbOwnerName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbCurrencyId;
        private System.Windows.Forms.Panel pnlBeneficiaryAccountName;
        private System.Windows.Forms.TextBox tbBeneficiaryAccountName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlCardNumber;
        private System.Windows.Forms.TextBox tbCardNumber;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel pnlAmountOut;
        private System.Windows.Forms.TextBox tbAmountOut;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel pnlAmountIn;
        private System.Windows.Forms.TextBox tbAmountIn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel pnlValueDate;
        private System.Windows.Forms.TextBox tbValueDate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel pnlGrid;
        private Zuby.ADGV.AdvancedDataGridView dgvItems;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Panel pnlLimit;
        private System.Windows.Forms.TextBox tbLimit;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel pnlReissueReason;
        private System.Windows.Forms.TextBox tbReissueReason;
        private System.Windows.Forms.Label lblReissueReason;
        private System.Windows.Forms.Panel pnlReissueType;
        private System.Windows.Forms.TextBox tbReissueType;
        private System.Windows.Forms.Label lblReissueType;
    }
}
