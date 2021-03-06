﻿namespace EPM.Wallet.WinForms.Controls
{
    partial class ClientAccountControl
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
            this.pnlBeneficiaryAddress = new System.Windows.Forms.Panel();
            this.tbBeneficiaryAddress = new System.Windows.Forms.TextBox();
            this.lblBeneficiaryAddress = new System.Windows.Forms.Label();
            this.pnlBeneficiaryName = new System.Windows.Forms.Panel();
            this.tbBeneficiaryName = new System.Windows.Forms.TextBox();
            this.lblBeneficiaryName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbComment = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbBankAccount = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlClientAccountStatus = new System.Windows.Forms.Panel();
            this.cmbClientAccountStatus = new System.Windows.Forms.ComboBox();
            this.lblClientAccountStatus = new System.Windows.Forms.Label();
            this.pnlCurrency = new System.Windows.Forms.Panel();
            this.cmbCurrency = new System.Windows.Forms.ComboBox();
            this.lblCurrency = new System.Windows.Forms.Label();
            this.pnlClient = new System.Windows.Forms.Panel();
            this.cmbClient = new System.Windows.Forms.ComboBox();
            this.lblClient = new System.Windows.Forms.Label();
            this.pnlClientAccountName = new System.Windows.Forms.Panel();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.pnlId = new System.Windows.Forms.Panel();
            this.lblId = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.dgvItems = new Zuby.ADGV.AdvancedDataGridView();
            this.pnlReference = new System.Windows.Forms.Panel();
            this.tbReference = new System.Windows.Forms.TextBox();
            this.lblReference = new System.Windows.Forms.Label();
            this.pnlDetails.SuspendLayout();
            this.pnlFields.SuspendLayout();
            this.pnlBeneficiaryAddress.SuspendLayout();
            this.pnlBeneficiaryName.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlClientAccountStatus.SuspendLayout();
            this.pnlCurrency.SuspendLayout();
            this.pnlClient.SuspendLayout();
            this.pnlClientAccountName.SuspendLayout();
            this.pnlId.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            this.pnlReference.SuspendLayout();
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
            this.pnlDetails.TabIndex = 6;
            // 
            // pnlFields
            // 
            this.pnlFields.Controls.Add(this.pnlReference);
            this.pnlFields.Controls.Add(this.pnlBeneficiaryAddress);
            this.pnlFields.Controls.Add(this.pnlBeneficiaryName);
            this.pnlFields.Controls.Add(this.panel2);
            this.pnlFields.Controls.Add(this.panel1);
            this.pnlFields.Controls.Add(this.pnlClientAccountStatus);
            this.pnlFields.Controls.Add(this.pnlCurrency);
            this.pnlFields.Controls.Add(this.pnlClient);
            this.pnlFields.Controls.Add(this.pnlClientAccountName);
            this.pnlFields.Controls.Add(this.pnlId);
            this.pnlFields.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFields.Location = new System.Drawing.Point(0, 41);
            this.pnlFields.Name = "pnlFields";
            this.pnlFields.Size = new System.Drawing.Size(396, 509);
            this.pnlFields.TabIndex = 1;
            // 
            // pnlBeneficiaryAddress
            // 
            this.pnlBeneficiaryAddress.Controls.Add(this.tbBeneficiaryAddress);
            this.pnlBeneficiaryAddress.Controls.Add(this.lblBeneficiaryAddress);
            this.pnlBeneficiaryAddress.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBeneficiaryAddress.Location = new System.Drawing.Point(0, 267);
            this.pnlBeneficiaryAddress.Name = "pnlBeneficiaryAddress";
            this.pnlBeneficiaryAddress.Size = new System.Drawing.Size(396, 34);
            this.pnlBeneficiaryAddress.TabIndex = 12;
            // 
            // tbBeneficiaryAddress
            // 
            this.tbBeneficiaryAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbBeneficiaryAddress.Enabled = false;
            this.tbBeneficiaryAddress.Location = new System.Drawing.Point(97, 5);
            this.tbBeneficiaryAddress.Name = "tbBeneficiaryAddress";
            this.tbBeneficiaryAddress.Size = new System.Drawing.Size(283, 20);
            this.tbBeneficiaryAddress.TabIndex = 1;
            // 
            // lblBeneficiaryAddress
            // 
            this.lblBeneficiaryAddress.AutoSize = true;
            this.lblBeneficiaryAddress.Location = new System.Drawing.Point(7, 8);
            this.lblBeneficiaryAddress.Name = "lblBeneficiaryAddress";
            this.lblBeneficiaryAddress.Size = new System.Drawing.Size(100, 13);
            this.lblBeneficiaryAddress.TabIndex = 0;
            this.lblBeneficiaryAddress.Text = "Beneficiary Address";
            // 
            // pnlBeneficiaryName
            // 
            this.pnlBeneficiaryName.Controls.Add(this.tbBeneficiaryName);
            this.pnlBeneficiaryName.Controls.Add(this.lblBeneficiaryName);
            this.pnlBeneficiaryName.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBeneficiaryName.Location = new System.Drawing.Point(0, 233);
            this.pnlBeneficiaryName.Name = "pnlBeneficiaryName";
            this.pnlBeneficiaryName.Size = new System.Drawing.Size(396, 34);
            this.pnlBeneficiaryName.TabIndex = 11;
            // 
            // tbBeneficiaryName
            // 
            this.tbBeneficiaryName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbBeneficiaryName.Enabled = false;
            this.tbBeneficiaryName.Location = new System.Drawing.Point(97, 5);
            this.tbBeneficiaryName.Name = "tbBeneficiaryName";
            this.tbBeneficiaryName.Size = new System.Drawing.Size(283, 20);
            this.tbBeneficiaryName.TabIndex = 1;
            // 
            // lblBeneficiaryName
            // 
            this.lblBeneficiaryName.AutoSize = true;
            this.lblBeneficiaryName.Location = new System.Drawing.Point(7, 8);
            this.lblBeneficiaryName.Name = "lblBeneficiaryName";
            this.lblBeneficiaryName.Size = new System.Drawing.Size(90, 13);
            this.lblBeneficiaryName.TabIndex = 0;
            this.lblBeneficiaryName.Text = "Beneficiary Name";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tbComment);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 199);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(396, 34);
            this.panel2.TabIndex = 10;
            // 
            // tbComment
            // 
            this.tbComment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbComment.Enabled = false;
            this.tbComment.Location = new System.Drawing.Point(97, 5);
            this.tbComment.Name = "tbComment";
            this.tbComment.Size = new System.Drawing.Size(283, 20);
            this.tbComment.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Comment";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbBankAccount);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 166);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(396, 33);
            this.panel1.TabIndex = 9;
            // 
            // cmbBankAccount
            // 
            this.cmbBankAccount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbBankAccount.FormattingEnabled = true;
            this.cmbBankAccount.Location = new System.Drawing.Point(97, 6);
            this.cmbBankAccount.Name = "cmbBankAccount";
            this.cmbBankAccount.Size = new System.Drawing.Size(283, 21);
            this.cmbBankAccount.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bank Account";
            // 
            // pnlClientAccountStatus
            // 
            this.pnlClientAccountStatus.Controls.Add(this.cmbClientAccountStatus);
            this.pnlClientAccountStatus.Controls.Add(this.lblClientAccountStatus);
            this.pnlClientAccountStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlClientAccountStatus.Location = new System.Drawing.Point(0, 133);
            this.pnlClientAccountStatus.Name = "pnlClientAccountStatus";
            this.pnlClientAccountStatus.Size = new System.Drawing.Size(396, 33);
            this.pnlClientAccountStatus.TabIndex = 8;
            // 
            // cmbClientAccountStatus
            // 
            this.cmbClientAccountStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbClientAccountStatus.FormattingEnabled = true;
            this.cmbClientAccountStatus.Location = new System.Drawing.Point(97, 6);
            this.cmbClientAccountStatus.Name = "cmbClientAccountStatus";
            this.cmbClientAccountStatus.Size = new System.Drawing.Size(283, 21);
            this.cmbClientAccountStatus.TabIndex = 1;
            // 
            // lblClientAccountStatus
            // 
            this.lblClientAccountStatus.AutoSize = true;
            this.lblClientAccountStatus.Location = new System.Drawing.Point(7, 9);
            this.lblClientAccountStatus.Name = "lblClientAccountStatus";
            this.lblClientAccountStatus.Size = new System.Drawing.Size(37, 13);
            this.lblClientAccountStatus.TabIndex = 0;
            this.lblClientAccountStatus.Text = "Status";
            // 
            // pnlCurrency
            // 
            this.pnlCurrency.Controls.Add(this.cmbCurrency);
            this.pnlCurrency.Controls.Add(this.lblCurrency);
            this.pnlCurrency.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCurrency.Location = new System.Drawing.Point(0, 100);
            this.pnlCurrency.Name = "pnlCurrency";
            this.pnlCurrency.Size = new System.Drawing.Size(396, 33);
            this.pnlCurrency.TabIndex = 7;
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
            this.pnlClient.Location = new System.Drawing.Point(0, 67);
            this.pnlClient.Name = "pnlClient";
            this.pnlClient.Size = new System.Drawing.Size(396, 33);
            this.pnlClient.TabIndex = 6;
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
            // pnlClientAccountName
            // 
            this.pnlClientAccountName.Controls.Add(this.tbName);
            this.pnlClientAccountName.Controls.Add(this.lblName);
            this.pnlClientAccountName.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlClientAccountName.Location = new System.Drawing.Point(0, 33);
            this.pnlClientAccountName.Name = "pnlClientAccountName";
            this.pnlClientAccountName.Size = new System.Drawing.Size(396, 34);
            this.pnlClientAccountName.TabIndex = 4;
            // 
            // tbName
            // 
            this.tbName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbName.Enabled = false;
            this.tbName.Location = new System.Drawing.Point(97, 5);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(283, 20);
            this.tbName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(7, 8);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // pnlId
            // 
            this.pnlId.Controls.Add(this.lblId);
            this.pnlId.Controls.Add(this.tbId);
            this.pnlId.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlId.Location = new System.Drawing.Point(0, 0);
            this.pnlId.Name = "pnlId";
            this.pnlId.Size = new System.Drawing.Size(396, 33);
            this.pnlId.TabIndex = 3;
            this.pnlId.Visible = false;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(7, 9);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(16, 13);
            this.lblId.TabIndex = 3;
            this.lblId.Text = "Id";
            // 
            // tbId
            // 
            this.tbId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbId.Enabled = false;
            this.tbId.Location = new System.Drawing.Point(97, 6);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(283, 20);
            this.tbId.TabIndex = 2;
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
            this.splitter1.TabIndex = 8;
            this.splitter1.TabStop = false;
            // 
            // pnlGrid
            // 
            this.pnlGrid.Controls.Add(this.dgvItems);
            this.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrid.Location = new System.Drawing.Point(0, 0);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(271, 550);
            this.pnlGrid.TabIndex = 9;
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
            // pnlReference
            // 
            this.pnlReference.Controls.Add(this.tbReference);
            this.pnlReference.Controls.Add(this.lblReference);
            this.pnlReference.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlReference.Location = new System.Drawing.Point(0, 301);
            this.pnlReference.Name = "pnlReference";
            this.pnlReference.Size = new System.Drawing.Size(396, 34);
            this.pnlReference.TabIndex = 13;
            // 
            // tbReference
            // 
            this.tbReference.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbReference.Enabled = false;
            this.tbReference.Location = new System.Drawing.Point(97, 5);
            this.tbReference.Name = "tbReference";
            this.tbReference.Size = new System.Drawing.Size(283, 20);
            this.tbReference.TabIndex = 1;
            // 
            // lblReference
            // 
            this.lblReference.AutoSize = true;
            this.lblReference.Location = new System.Drawing.Point(7, 8);
            this.lblReference.Name = "lblReference";
            this.lblReference.Size = new System.Drawing.Size(57, 13);
            this.lblReference.TabIndex = 0;
            this.lblReference.Text = "Reference";
            // 
            // ClientAccountControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlGrid);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.pnlDetails);
            this.Name = "ClientAccountControl";
            this.Size = new System.Drawing.Size(670, 550);
            this.pnlDetails.ResumeLayout(false);
            this.pnlFields.ResumeLayout(false);
            this.pnlBeneficiaryAddress.ResumeLayout(false);
            this.pnlBeneficiaryAddress.PerformLayout();
            this.pnlBeneficiaryName.ResumeLayout(false);
            this.pnlBeneficiaryName.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlClientAccountStatus.ResumeLayout(false);
            this.pnlClientAccountStatus.PerformLayout();
            this.pnlCurrency.ResumeLayout(false);
            this.pnlCurrency.PerformLayout();
            this.pnlClient.ResumeLayout(false);
            this.pnlClient.PerformLayout();
            this.pnlClientAccountName.ResumeLayout(false);
            this.pnlClientAccountName.PerformLayout();
            this.pnlId.ResumeLayout(false);
            this.pnlId.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            this.pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            this.pnlReference.ResumeLayout(false);
            this.pnlReference.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDetails;
        private System.Windows.Forms.Panel pnlFields;
        private System.Windows.Forms.Panel pnlClientAccountName;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel pnlId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox tbId;
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
        private System.Windows.Forms.Panel pnlClientAccountStatus;
        private System.Windows.Forms.ComboBox cmbClientAccountStatus;
        private System.Windows.Forms.Label lblClientAccountStatus;
        private Zuby.ADGV.AdvancedDataGridView dgvItems;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbBankAccount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbComment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlBeneficiaryAddress;
        private System.Windows.Forms.TextBox tbBeneficiaryAddress;
        private System.Windows.Forms.Label lblBeneficiaryAddress;
        private System.Windows.Forms.Panel pnlBeneficiaryName;
        private System.Windows.Forms.TextBox tbBeneficiaryName;
        private System.Windows.Forms.Label lblBeneficiaryName;
        private System.Windows.Forms.Panel pnlReference;
        private System.Windows.Forms.TextBox tbReference;
        private System.Windows.Forms.Label lblReference;
    }
}
