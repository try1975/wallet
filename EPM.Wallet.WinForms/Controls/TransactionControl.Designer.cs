namespace EPM.Wallet.WinForms.Controls
{
    partial class TransactionControl
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
            this.panel6 = new System.Windows.Forms.Panel();
            this.tbNote = new System.Windows.Forms.TextBox();
            this.lblNote = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbFromTo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tbBalance = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cmbCurrency = new System.Windows.Forms.ComboBox();
            this.tbAmountInCurrency = new System.Windows.Forms.TextBox();
            this.lblAmountInCurrency = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbAmount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbValueDate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlBank = new System.Windows.Forms.Panel();
            this.tbRegisterDate = new System.Windows.Forms.TextBox();
            this.lblBank = new System.Windows.Forms.Label();
            this.pnlAccountName = new System.Windows.Forms.Panel();
            this.cmbAccount = new System.Windows.Forms.ComboBox();
            this.lblAccount = new System.Windows.Forms.Label();
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
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.pnlDetails.SuspendLayout();
            this.pnlFields.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlBank.SuspendLayout();
            this.pnlAccountName.SuspendLayout();
            this.pnlId.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDetails
            // 
            this.pnlDetails.Controls.Add(this.pnlFields);
            this.pnlDetails.Controls.Add(this.pnlButtons);
            this.pnlDetails.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlDetails.Location = new System.Drawing.Point(365, 0);
            this.pnlDetails.Name = "pnlDetails";
            this.pnlDetails.Size = new System.Drawing.Size(396, 483);
            this.pnlDetails.TabIndex = 7;
            // 
            // pnlFields
            // 
            this.pnlFields.Controls.Add(this.panel6);
            this.pnlFields.Controls.Add(this.panel3);
            this.pnlFields.Controls.Add(this.panel5);
            this.pnlFields.Controls.Add(this.panel4);
            this.pnlFields.Controls.Add(this.panel2);
            this.pnlFields.Controls.Add(this.panel1);
            this.pnlFields.Controls.Add(this.pnlBank);
            this.pnlFields.Controls.Add(this.pnlAccountName);
            this.pnlFields.Controls.Add(this.pnlId);
            this.pnlFields.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFields.Location = new System.Drawing.Point(0, 41);
            this.pnlFields.Name = "pnlFields";
            this.pnlFields.Size = new System.Drawing.Size(396, 442);
            this.pnlFields.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.tbNote);
            this.panel6.Controls.Add(this.lblNote);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 271);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(396, 34);
            this.panel6.TabIndex = 12;
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
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Location = new System.Drawing.Point(7, 7);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(30, 13);
            this.lblNote.TabIndex = 0;
            this.lblNote.Text = "Note";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tbFromTo);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 237);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(396, 34);
            this.panel3.TabIndex = 11;
            // 
            // tbFromTo
            // 
            this.tbFromTo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFromTo.Location = new System.Drawing.Point(97, 6);
            this.tbFromTo.Name = "tbFromTo";
            this.tbFromTo.Size = new System.Drawing.Size(283, 20);
            this.tbFromTo.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "FromTo";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.tbBalance);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 203);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(396, 34);
            this.panel5.TabIndex = 10;
            this.panel5.Visible = false;
            // 
            // tbBalance
            // 
            this.tbBalance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbBalance.Location = new System.Drawing.Point(97, 6);
            this.tbBalance.Name = "tbBalance";
            this.tbBalance.Size = new System.Drawing.Size(283, 20);
            this.tbBalance.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Balance";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.cmbCurrency);
            this.panel4.Controls.Add(this.tbAmountInCurrency);
            this.panel4.Controls.Add(this.lblAmountInCurrency);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 169);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(396, 34);
            this.panel4.TabIndex = 9;
            // 
            // cmbCurrency
            // 
            this.cmbCurrency.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbCurrency.FormattingEnabled = true;
            this.cmbCurrency.Location = new System.Drawing.Point(262, 5);
            this.cmbCurrency.Name = "cmbCurrency";
            this.cmbCurrency.Size = new System.Drawing.Size(118, 21);
            this.cmbCurrency.TabIndex = 3;
            // 
            // tbAmountInCurrency
            // 
            this.tbAmountInCurrency.Location = new System.Drawing.Point(97, 5);
            this.tbAmountInCurrency.Name = "tbAmountInCurrency";
            this.tbAmountInCurrency.Size = new System.Drawing.Size(139, 20);
            this.tbAmountInCurrency.TabIndex = 2;
            // 
            // lblAmountInCurrency
            // 
            this.lblAmountInCurrency.AutoSize = true;
            this.lblAmountInCurrency.Location = new System.Drawing.Point(7, 7);
            this.lblAmountInCurrency.Name = "lblAmountInCurrency";
            this.lblAmountInCurrency.Size = new System.Drawing.Size(94, 13);
            this.lblAmountInCurrency.TabIndex = 0;
            this.lblAmountInCurrency.Text = "AmountInCurrency";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tbAmount);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 135);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(396, 34);
            this.panel2.TabIndex = 7;
            // 
            // tbAmount
            // 
            this.tbAmount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAmount.Location = new System.Drawing.Point(97, 6);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(283, 20);
            this.tbAmount.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Amount";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbValueDate);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 101);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(396, 34);
            this.panel1.TabIndex = 6;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ValueDate";
            // 
            // pnlBank
            // 
            this.pnlBank.Controls.Add(this.tbRegisterDate);
            this.pnlBank.Controls.Add(this.lblBank);
            this.pnlBank.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBank.Location = new System.Drawing.Point(0, 67);
            this.pnlBank.Name = "pnlBank";
            this.pnlBank.Size = new System.Drawing.Size(396, 34);
            this.pnlBank.TabIndex = 5;
            // 
            // tbRegisterDate
            // 
            this.tbRegisterDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbRegisterDate.Location = new System.Drawing.Point(97, 6);
            this.tbRegisterDate.Name = "tbRegisterDate";
            this.tbRegisterDate.Size = new System.Drawing.Size(283, 20);
            this.tbRegisterDate.TabIndex = 2;
            // 
            // lblBank
            // 
            this.lblBank.AutoSize = true;
            this.lblBank.Location = new System.Drawing.Point(7, 7);
            this.lblBank.Name = "lblBank";
            this.lblBank.Size = new System.Drawing.Size(69, 13);
            this.lblBank.TabIndex = 0;
            this.lblBank.Text = "RegisterDate";
            // 
            // pnlAccountName
            // 
            this.pnlAccountName.Controls.Add(this.cmbAccount);
            this.pnlAccountName.Controls.Add(this.lblAccount);
            this.pnlAccountName.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAccountName.Location = new System.Drawing.Point(0, 33);
            this.pnlAccountName.Name = "pnlAccountName";
            this.pnlAccountName.Size = new System.Drawing.Size(396, 34);
            this.pnlAccountName.TabIndex = 4;
            // 
            // cmbAccount
            // 
            this.cmbAccount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbAccount.FormattingEnabled = true;
            this.cmbAccount.Location = new System.Drawing.Point(97, 8);
            this.cmbAccount.Name = "cmbAccount";
            this.cmbAccount.Size = new System.Drawing.Size(283, 21);
            this.cmbAccount.TabIndex = 1;
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
            this.splitter1.Location = new System.Drawing.Point(362, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 483);
            this.splitter1.TabIndex = 9;
            this.splitter1.TabStop = false;
            // 
            // pnlGrid
            // 
            this.pnlGrid.Controls.Add(this.dgvItems);
            this.pnlGrid.Controls.Add(this.panel7);
            this.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrid.Location = new System.Drawing.Point(0, 0);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(362, 483);
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
            this.dgvItems.Location = new System.Drawing.Point(0, 41);
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.ReadOnly = true;
            this.dgvItems.Size = new System.Drawing.Size(362, 442);
            this.dgvItems.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnRefresh);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(362, 41);
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
            // TransactionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlGrid);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.pnlDetails);
            this.Name = "TransactionControl";
            this.Size = new System.Drawing.Size(761, 483);
            this.pnlDetails.ResumeLayout(false);
            this.pnlFields.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlBank.ResumeLayout(false);
            this.pnlBank.PerformLayout();
            this.pnlAccountName.ResumeLayout(false);
            this.pnlAccountName.PerformLayout();
            this.pnlId.ResumeLayout(false);
            this.pnlId.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            this.pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            this.panel7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDetails;
        private System.Windows.Forms.Panel pnlFields;
        private System.Windows.Forms.Panel pnlBank;
        private System.Windows.Forms.TextBox tbRegisterDate;
        private System.Windows.Forms.Label lblBank;
        private System.Windows.Forms.Panel pnlAccountName;
        private System.Windows.Forms.ComboBox cmbAccount;
        private System.Windows.Forms.Label lblAccount;
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
        private Zuby.ADGV.AdvancedDataGridView dgvItems;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbValueDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox tbBalance;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox tbAmountInCurrency;
        private System.Windows.Forms.Label lblAmountInCurrency;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbCurrency;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox tbFromTo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox tbNote;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnRefresh;
    }
}
