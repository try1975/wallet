﻿using Zuby.ADGV;

namespace EPM.Wallet.WinForms.Controls
{
    partial class TransferOutInfoControl
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
            this.panel7 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.tbNote = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.tbOwnerName = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.tbBic = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.tbBankAddress = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.tbIban = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.tbBankName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tbValueDate = new System.Windows.Forms.TextBox();
            this.pnlClientAccountName = new System.Windows.Forms.Panel();
            this.tbAccount = new System.Windows.Forms.TextBox();
            this.lblAccount = new System.Windows.Forms.Label();
            this.pnlCurrency = new System.Windows.Forms.Panel();
            this.tbAmountOut = new System.Windows.Forms.TextBox();
            this.tbCurrencyId = new System.Windows.Forms.TextBox();
            this.lblCurrency = new System.Windows.Forms.Label();
            this.pnlClient = new System.Windows.Forms.Panel();
            this.tbClientName = new System.Windows.Forms.TextBox();
            this.tbAccountCurrency = new System.Windows.Forms.TextBox();
            this.tbClientId = new System.Windows.Forms.TextBox();
            this.lblClient = new System.Windows.Forms.Label();
            this.pnlClientAccountStatus = new System.Windows.Forms.Panel();
            this.cmbRequestStatus = new System.Windows.Forms.ComboBox();
            this.lblClientAccountStatus = new System.Windows.Forms.Label();
            this.pnlId = new System.Windows.Forms.Panel();
            this.lblId = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnPending = new System.Windows.Forms.Button();
            this.btnProcessed = new System.Windows.Forms.Button();
            this.btnReject = new System.Windows.Forms.Button();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.dgvItems = new Zuby.ADGV.AdvancedDataGridView();
            this.pnlDetails.SuspendLayout();
            this.pnlFields.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlClientAccountName.SuspendLayout();
            this.pnlCurrency.SuspendLayout();
            this.pnlClient.SuspendLayout();
            this.pnlClientAccountStatus.SuspendLayout();
            this.pnlId.SuspendLayout();
            this.panel8.SuspendLayout();
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
            this.pnlDetails.TabIndex = 7;
            // 
            // pnlFields
            // 
            this.pnlFields.Controls.Add(this.panel7);
            this.pnlFields.Controls.Add(this.panel6);
            this.pnlFields.Controls.Add(this.panel5);
            this.pnlFields.Controls.Add(this.panel4);
            this.pnlFields.Controls.Add(this.panel3);
            this.pnlFields.Controls.Add(this.panel2);
            this.pnlFields.Controls.Add(this.panel1);
            this.pnlFields.Controls.Add(this.pnlClientAccountName);
            this.pnlFields.Controls.Add(this.pnlCurrency);
            this.pnlFields.Controls.Add(this.pnlClient);
            this.pnlFields.Controls.Add(this.pnlClientAccountStatus);
            this.pnlFields.Controls.Add(this.pnlId);
            this.pnlFields.Controls.Add(this.panel8);
            this.pnlFields.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFields.Location = new System.Drawing.Point(0, 41);
            this.pnlFields.Name = "pnlFields";
            this.pnlFields.Size = new System.Drawing.Size(396, 509);
            this.pnlFields.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.label7);
            this.panel7.Controls.Add(this.tbNote);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 405);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(396, 33);
            this.panel7.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Note";
            // 
            // tbNote
            // 
            this.tbNote.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNote.Location = new System.Drawing.Point(97, 6);
            this.tbNote.Name = "tbNote";
            this.tbNote.Size = new System.Drawing.Size(283, 20);
            this.tbNote.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.tbOwnerName);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 372);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(396, 33);
            this.panel6.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "OwnerName";
            // 
            // tbOwnerName
            // 
            this.tbOwnerName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbOwnerName.Location = new System.Drawing.Point(97, 6);
            this.tbOwnerName.Name = "tbOwnerName";
            this.tbOwnerName.Size = new System.Drawing.Size(283, 20);
            this.tbOwnerName.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.tbBic);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 339);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(396, 33);
            this.panel5.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Bic";
            // 
            // tbBic
            // 
            this.tbBic.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbBic.Location = new System.Drawing.Point(97, 6);
            this.tbBic.Name = "tbBic";
            this.tbBic.Size = new System.Drawing.Size(283, 20);
            this.tbBic.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.tbBankAddress);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 306);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(396, 33);
            this.panel4.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "BankAddress";
            // 
            // tbBankAddress
            // 
            this.tbBankAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbBankAddress.Location = new System.Drawing.Point(97, 6);
            this.tbBankAddress.Name = "tbBankAddress";
            this.tbBankAddress.Size = new System.Drawing.Size(283, 20);
            this.tbBankAddress.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.tbIban);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 273);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(396, 33);
            this.panel3.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Iban";
            // 
            // tbIban
            // 
            this.tbIban.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbIban.Location = new System.Drawing.Point(97, 6);
            this.tbIban.Name = "tbIban";
            this.tbIban.Size = new System.Drawing.Size(283, 20);
            this.tbIban.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.tbBankName);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 240);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(396, 33);
            this.panel2.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "BankName";
            // 
            // tbBankName
            // 
            this.tbBankName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbBankName.Location = new System.Drawing.Point(97, 6);
            this.tbBankName.Name = "tbBankName";
            this.tbBankName.Size = new System.Drawing.Size(283, 20);
            this.tbBankName.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbValueDate);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 207);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(396, 33);
            this.panel1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Value date";
            // 
            // tbValueDate
            // 
            this.tbValueDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbValueDate.Location = new System.Drawing.Point(97, 6);
            this.tbValueDate.Name = "tbValueDate";
            this.tbValueDate.Size = new System.Drawing.Size(283, 20);
            this.tbValueDate.TabIndex = 2;
            // 
            // pnlClientAccountName
            // 
            this.pnlClientAccountName.Controls.Add(this.tbAccount);
            this.pnlClientAccountName.Controls.Add(this.lblAccount);
            this.pnlClientAccountName.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlClientAccountName.Location = new System.Drawing.Point(0, 173);
            this.pnlClientAccountName.Name = "pnlClientAccountName";
            this.pnlClientAccountName.Size = new System.Drawing.Size(396, 34);
            this.pnlClientAccountName.TabIndex = 4;
            this.pnlClientAccountName.Visible = false;
            // 
            // tbAccount
            // 
            this.tbAccount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAccount.Location = new System.Drawing.Point(97, 8);
            this.tbAccount.Name = "tbAccount";
            this.tbAccount.Size = new System.Drawing.Size(283, 20);
            this.tbAccount.TabIndex = 1;
            // 
            // lblAccount
            // 
            this.lblAccount.AutoSize = true;
            this.lblAccount.Location = new System.Drawing.Point(7, 8);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(47, 13);
            this.lblAccount.TabIndex = 0;
            this.lblAccount.Text = "Account";
            // 
            // pnlCurrency
            // 
            this.pnlCurrency.Controls.Add(this.tbAmountOut);
            this.pnlCurrency.Controls.Add(this.tbCurrencyId);
            this.pnlCurrency.Controls.Add(this.lblCurrency);
            this.pnlCurrency.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCurrency.Location = new System.Drawing.Point(0, 140);
            this.pnlCurrency.Name = "pnlCurrency";
            this.pnlCurrency.Size = new System.Drawing.Size(396, 33);
            this.pnlCurrency.TabIndex = 7;
            // 
            // tbAmountOut
            // 
            this.tbAmountOut.Location = new System.Drawing.Point(97, 7);
            this.tbAmountOut.Name = "tbAmountOut";
            this.tbAmountOut.Size = new System.Drawing.Size(191, 20);
            this.tbAmountOut.TabIndex = 2;
            // 
            // tbCurrencyId
            // 
            this.tbCurrencyId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCurrencyId.Location = new System.Drawing.Point(294, 7);
            this.tbCurrencyId.Name = "tbCurrencyId";
            this.tbCurrencyId.Size = new System.Drawing.Size(86, 20);
            this.tbCurrencyId.TabIndex = 1;
            // 
            // lblCurrency
            // 
            this.lblCurrency.AutoSize = true;
            this.lblCurrency.Location = new System.Drawing.Point(7, 9);
            this.lblCurrency.Name = "lblCurrency";
            this.lblCurrency.Size = new System.Drawing.Size(43, 13);
            this.lblCurrency.TabIndex = 0;
            this.lblCurrency.Text = "Amount";
            // 
            // pnlClient
            // 
            this.pnlClient.Controls.Add(this.tbClientName);
            this.pnlClient.Controls.Add(this.tbAccountCurrency);
            this.pnlClient.Controls.Add(this.tbClientId);
            this.pnlClient.Controls.Add(this.lblClient);
            this.pnlClient.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlClient.Location = new System.Drawing.Point(0, 107);
            this.pnlClient.Name = "pnlClient";
            this.pnlClient.Size = new System.Drawing.Size(396, 33);
            this.pnlClient.TabIndex = 6;
            // 
            // tbClientName
            // 
            this.tbClientName.Location = new System.Drawing.Point(164, 7);
            this.tbClientName.Name = "tbClientName";
            this.tbClientName.Size = new System.Drawing.Size(120, 20);
            this.tbClientName.TabIndex = 3;
            // 
            // tbAccountCurrency
            // 
            this.tbAccountCurrency.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAccountCurrency.Location = new System.Drawing.Point(294, 7);
            this.tbAccountCurrency.Name = "tbAccountCurrency";
            this.tbAccountCurrency.Size = new System.Drawing.Size(86, 20);
            this.tbAccountCurrency.TabIndex = 2;
            // 
            // tbClientId
            // 
            this.tbClientId.Location = new System.Drawing.Point(97, 7);
            this.tbClientId.Name = "tbClientId";
            this.tbClientId.Size = new System.Drawing.Size(61, 20);
            this.tbClientId.TabIndex = 1;
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
            // pnlClientAccountStatus
            // 
            this.pnlClientAccountStatus.Controls.Add(this.cmbRequestStatus);
            this.pnlClientAccountStatus.Controls.Add(this.lblClientAccountStatus);
            this.pnlClientAccountStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlClientAccountStatus.Location = new System.Drawing.Point(0, 74);
            this.pnlClientAccountStatus.Name = "pnlClientAccountStatus";
            this.pnlClientAccountStatus.Size = new System.Drawing.Size(396, 33);
            this.pnlClientAccountStatus.TabIndex = 8;
            // 
            // cmbRequestStatus
            // 
            this.cmbRequestStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbRequestStatus.FormattingEnabled = true;
            this.cmbRequestStatus.Location = new System.Drawing.Point(97, 6);
            this.cmbRequestStatus.Name = "cmbRequestStatus";
            this.cmbRequestStatus.Size = new System.Drawing.Size(283, 21);
            this.cmbRequestStatus.TabIndex = 1;
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
            // pnlId
            // 
            this.pnlId.Controls.Add(this.lblId);
            this.pnlId.Controls.Add(this.tbId);
            this.pnlId.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlId.Location = new System.Drawing.Point(0, 41);
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
            // panel8
            // 
            this.panel8.Controls.Add(this.btnPending);
            this.panel8.Controls.Add(this.btnProcessed);
            this.panel8.Controls.Add(this.btnReject);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(396, 41);
            this.panel8.TabIndex = 16;
            // 
            // btnPending
            // 
            this.btnPending.Location = new System.Drawing.Point(162, 6);
            this.btnPending.Margin = new System.Windows.Forms.Padding(2);
            this.btnPending.Name = "btnPending";
            this.btnPending.Size = new System.Drawing.Size(75, 22);
            this.btnPending.TabIndex = 11;
            this.btnPending.Text = "Pending";
            this.btnPending.UseVisualStyleBackColor = true;
            // 
            // btnProcessed
            // 
            this.btnProcessed.Location = new System.Drawing.Point(81, 5);
            this.btnProcessed.Margin = new System.Windows.Forms.Padding(2);
            this.btnProcessed.Name = "btnProcessed";
            this.btnProcessed.Size = new System.Drawing.Size(77, 23);
            this.btnProcessed.TabIndex = 10;
            this.btnProcessed.Text = "Processed";
            this.btnProcessed.UseVisualStyleBackColor = true;
            // 
            // btnReject
            // 
            this.btnReject.Location = new System.Drawing.Point(15, 5);
            this.btnReject.Margin = new System.Windows.Forms.Padding(2);
            this.btnReject.Name = "btnReject";
            this.btnReject.Size = new System.Drawing.Size(62, 23);
            this.btnReject.TabIndex = 9;
            this.btnReject.Text = "Reject";
            this.btnReject.UseVisualStyleBackColor = true;
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.btnCancel);
            this.pnlButtons.Controls.Add(this.btnSave);
            this.pnlButtons.Controls.Add(this.btnEdit);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlButtons.Location = new System.Drawing.Point(0, 0);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(396, 41);
            this.pnlButtons.TabIndex = 2;
            this.pnlButtons.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(213, 12);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(148, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(59, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Visible = false;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(78, 12);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(61, 23);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Visible = false;
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter1.Location = new System.Drawing.Point(271, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 550);
            this.splitter1.TabIndex = 9;
            this.splitter1.TabStop = false;
            // 
            // pnlGrid
            // 
            this.pnlGrid.Controls.Add(this.dgvItems);
            this.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrid.Location = new System.Drawing.Point(0, 0);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(271, 550);
            this.pnlGrid.TabIndex = 10;
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
            this.dgvItems.TabIndex = 0;
            // 
            // TransferOutInfoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlGrid);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.pnlDetails);
            this.Name = "TransferOutInfoControl";
            this.Size = new System.Drawing.Size(670, 550);
            this.pnlDetails.ResumeLayout(false);
            this.pnlFields.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlClientAccountName.ResumeLayout(false);
            this.pnlClientAccountName.PerformLayout();
            this.pnlCurrency.ResumeLayout(false);
            this.pnlCurrency.PerformLayout();
            this.pnlClient.ResumeLayout(false);
            this.pnlClient.PerformLayout();
            this.pnlClientAccountStatus.ResumeLayout(false);
            this.pnlClientAccountStatus.PerformLayout();
            this.pnlId.ResumeLayout(false);
            this.pnlId.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.pnlButtons.ResumeLayout(false);
            this.pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDetails;
        private System.Windows.Forms.Panel pnlFields;
        private System.Windows.Forms.Panel pnlClientAccountStatus;
        private System.Windows.Forms.ComboBox cmbRequestStatus;
        private System.Windows.Forms.Label lblClientAccountStatus;
        private System.Windows.Forms.Panel pnlCurrency;
        private System.Windows.Forms.Label lblCurrency;
        private System.Windows.Forms.Panel pnlClient;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.Panel pnlClientAccountName;
        private System.Windows.Forms.TextBox tbAccount;
        private System.Windows.Forms.Label lblAccount;
        private System.Windows.Forms.Panel pnlId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.TextBox tbClientId;
        private System.Windows.Forms.TextBox tbCurrencyId;
        private System.Windows.Forms.TextBox tbAmountOut;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbValueDate;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbOwnerName;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbBic;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbBankAddress;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbIban;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbBankName;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbNote;
        private AdvancedDataGridView dgvItems;
        private System.Windows.Forms.Button btnProcessed;
        private System.Windows.Forms.Button btnReject;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btnPending;
        private System.Windows.Forms.TextBox tbAccountCurrency;
        private System.Windows.Forms.TextBox tbClientName;
    }
}
