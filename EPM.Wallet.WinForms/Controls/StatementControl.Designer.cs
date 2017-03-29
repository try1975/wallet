namespace EPM.Wallet.WinForms.Controls
{
    partial class StatementControl
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
            this.pnlDetails = new System.Windows.Forms.Panel();
            this.pnlFields = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.linkStatement = new System.Windows.Forms.LinkLabel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnLoadPdf = new System.Windows.Forms.Button();
            this.tbLoadedFrom = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbNewBalance = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tbDebits = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tbCredits = new System.Windows.Forms.TextBox();
            this.lblAmountInCurrency = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbPreviosBalance = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.tbPeriod = new System.Windows.Forms.TextBox();
            this.lblNote = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbValueDate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.dgvItems = new Zuby.ADGV.AdvancedDataGridView();
            this.pnlDetails.SuspendLayout();
            this.pnlFields.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlAccountName.SuspendLayout();
            this.pnlId.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDetails
            // 
            this.pnlDetails.Controls.Add(this.pnlFields);
            this.pnlDetails.Controls.Add(this.pnlButtons);
            this.pnlDetails.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlDetails.Location = new System.Drawing.Point(605, 0);
            this.pnlDetails.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlDetails.Name = "pnlDetails";
            this.pnlDetails.Size = new System.Drawing.Size(594, 657);
            this.pnlDetails.TabIndex = 8;
            // 
            // pnlFields
            // 
            this.pnlFields.Controls.Add(this.panel8);
            this.pnlFields.Controls.Add(this.panel7);
            this.pnlFields.Controls.Add(this.panel3);
            this.pnlFields.Controls.Add(this.panel5);
            this.pnlFields.Controls.Add(this.panel4);
            this.pnlFields.Controls.Add(this.panel2);
            this.pnlFields.Controls.Add(this.panel6);
            this.pnlFields.Controls.Add(this.panel1);
            this.pnlFields.Controls.Add(this.pnlAccountName);
            this.pnlFields.Controls.Add(this.pnlId);
            this.pnlFields.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFields.Location = new System.Drawing.Point(0, 63);
            this.pnlFields.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlFields.Name = "pnlFields";
            this.pnlFields.Size = new System.Drawing.Size(594, 594);
            this.pnlFields.TabIndex = 1;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.linkStatement);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 467);
            this.panel8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(594, 52);
            this.panel8.TabIndex = 14;
            // 
            // linkStatement
            // 
            this.linkStatement.AutoSize = true;
            this.linkStatement.Location = new System.Drawing.Point(15, 16);
            this.linkStatement.Name = "linkStatement";
            this.linkStatement.Size = new System.Drawing.Size(80, 20);
            this.linkStatement.TabIndex = 0;
            this.linkStatement.TabStop = true;
            this.linkStatement.Text = "linkLabel1";
            this.linkStatement.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkStatement_LinkClicked);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnLoadPdf);
            this.panel7.Controls.Add(this.tbLoadedFrom);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 415);
            this.panel7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(594, 52);
            this.panel7.TabIndex = 13;
            // 
            // btnLoadPdf
            // 
            this.btnLoadPdf.Location = new System.Drawing.Point(146, 5);
            this.btnLoadPdf.Name = "btnLoadPdf";
            this.btnLoadPdf.Size = new System.Drawing.Size(139, 44);
            this.btnLoadPdf.TabIndex = 3;
            this.btnLoadPdf.Text = "btnLoadPdf";
            this.btnLoadPdf.UseVisualStyleBackColor = true;
            this.btnLoadPdf.Click += new System.EventHandler(this.btnLoadPdf_Click);
            // 
            // tbLoadedFrom
            // 
            this.tbLoadedFrom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLoadedFrom.Location = new System.Drawing.Point(292, 11);
            this.tbLoadedFrom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbLoadedFrom.Name = "tbLoadedFrom";
            this.tbLoadedFrom.Size = new System.Drawing.Size(276, 26);
            this.tbLoadedFrom.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tbNewBalance);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 363);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(594, 52);
            this.panel3.TabIndex = 11;
            // 
            // tbNewBalance
            // 
            this.tbNewBalance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNewBalance.Location = new System.Drawing.Point(146, 9);
            this.tbNewBalance.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbNewBalance.Name = "tbNewBalance";
            this.tbNewBalance.Size = new System.Drawing.Size(422, 26);
            this.tbNewBalance.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "NewBalance";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.tbDebits);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 311);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(594, 52);
            this.panel5.TabIndex = 10;
            // 
            // tbDebits
            // 
            this.tbDebits.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDebits.Location = new System.Drawing.Point(146, 9);
            this.tbDebits.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbDebits.Name = "tbDebits";
            this.tbDebits.Size = new System.Drawing.Size(422, 26);
            this.tbDebits.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 11);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Debits";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tbCredits);
            this.panel4.Controls.Add(this.lblAmountInCurrency);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 259);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(594, 52);
            this.panel4.TabIndex = 9;
            // 
            // tbCredits
            // 
            this.tbCredits.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCredits.Location = new System.Drawing.Point(146, 8);
            this.tbCredits.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbCredits.Name = "tbCredits";
            this.tbCredits.Size = new System.Drawing.Size(422, 26);
            this.tbCredits.TabIndex = 2;
            // 
            // lblAmountInCurrency
            // 
            this.lblAmountInCurrency.AutoSize = true;
            this.lblAmountInCurrency.Location = new System.Drawing.Point(10, 11);
            this.lblAmountInCurrency.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAmountInCurrency.Name = "lblAmountInCurrency";
            this.lblAmountInCurrency.Size = new System.Drawing.Size(59, 20);
            this.lblAmountInCurrency.TabIndex = 0;
            this.lblAmountInCurrency.Text = "Credits";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tbPreviosBalance);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 207);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(594, 52);
            this.panel2.TabIndex = 7;
            // 
            // tbPreviosBalance
            // 
            this.tbPreviosBalance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPreviosBalance.Location = new System.Drawing.Point(146, 9);
            this.tbPreviosBalance.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbPreviosBalance.Name = "tbPreviosBalance";
            this.tbPreviosBalance.Size = new System.Drawing.Size(422, 26);
            this.tbPreviosBalance.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "PreviosBalance";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.tbPeriod);
            this.panel6.Controls.Add(this.lblNote);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 155);
            this.panel6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(594, 52);
            this.panel6.TabIndex = 12;
            // 
            // tbPeriod
            // 
            this.tbPeriod.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPeriod.Location = new System.Drawing.Point(146, 9);
            this.tbPeriod.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbPeriod.Name = "tbPeriod";
            this.tbPeriod.Size = new System.Drawing.Size(422, 26);
            this.tbPeriod.TabIndex = 2;
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Location = new System.Drawing.Point(10, 11);
            this.lblNote.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(54, 20);
            this.lblNote.TabIndex = 0;
            this.lblNote.Text = "Period";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbValueDate);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 103);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(594, 52);
            this.panel1.TabIndex = 6;
            // 
            // tbValueDate
            // 
            this.tbValueDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbValueDate.Location = new System.Drawing.Point(146, 9);
            this.tbValueDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbValueDate.Name = "tbValueDate";
            this.tbValueDate.Size = new System.Drawing.Size(422, 26);
            this.tbValueDate.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ValueDate";
            // 
            // pnlAccountName
            // 
            this.pnlAccountName.Controls.Add(this.cmbAccount);
            this.pnlAccountName.Controls.Add(this.lblAccount);
            this.pnlAccountName.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAccountName.Location = new System.Drawing.Point(0, 51);
            this.pnlAccountName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlAccountName.Name = "pnlAccountName";
            this.pnlAccountName.Size = new System.Drawing.Size(594, 52);
            this.pnlAccountName.TabIndex = 4;
            // 
            // cmbAccount
            // 
            this.cmbAccount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbAccount.FormattingEnabled = true;
            this.cmbAccount.Location = new System.Drawing.Point(146, 12);
            this.cmbAccount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbAccount.Name = "cmbAccount";
            this.cmbAccount.Size = new System.Drawing.Size(422, 28);
            this.cmbAccount.TabIndex = 1;
            // 
            // lblAccount
            // 
            this.lblAccount.AutoSize = true;
            this.lblAccount.Location = new System.Drawing.Point(10, 12);
            this.lblAccount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(68, 20);
            this.lblAccount.TabIndex = 0;
            this.lblAccount.Text = "Account";
            // 
            // pnlId
            // 
            this.pnlId.Controls.Add(this.lblId);
            this.pnlId.Controls.Add(this.tbId);
            this.pnlId.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlId.Location = new System.Drawing.Point(0, 0);
            this.pnlId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlId.Name = "pnlId";
            this.pnlId.Size = new System.Drawing.Size(594, 51);
            this.pnlId.TabIndex = 3;
            this.pnlId.Visible = false;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(10, 14);
            this.lblId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(23, 20);
            this.lblId.TabIndex = 3;
            this.lblId.Text = "Id";
            // 
            // tbId
            // 
            this.tbId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbId.Location = new System.Drawing.Point(146, 9);
            this.tbId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(422, 26);
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
            this.pnlButtons.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(594, 63);
            this.pnlButtons.TabIndex = 2;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(441, 18);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(112, 35);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(320, 18);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 35);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(222, 18);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(88, 35);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(117, 18);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(92, 35);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(15, 18);
            this.btnAddNew.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(92, 35);
            this.btnAddNew.TabIndex = 0;
            this.btnAddNew.Text = "Add new";
            this.btnAddNew.UseVisualStyleBackColor = true;
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter1.Location = new System.Drawing.Point(601, 0);
            this.splitter1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(4, 657);
            this.splitter1.TabIndex = 10;
            this.splitter1.TabStop = false;
            // 
            // dgvItems
            // 
            this.dgvItems.AllowUserToAddRows = false;
            this.dgvItems.AllowUserToDeleteRows = false;
            this.dgvItems.AllowUserToOrderColumns = true;
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvItems.FilterAndSortEnabled = true;
            this.dgvItems.Location = new System.Drawing.Point(0, 0);
            this.dgvItems.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.ReadOnly = true;
            this.dgvItems.Size = new System.Drawing.Size(601, 657);
            this.dgvItems.TabIndex = 11;
            // 
            // StatementControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvItems);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.pnlDetails);
            this.Name = "StatementControl";
            this.Size = new System.Drawing.Size(1199, 657);
            this.pnlDetails.ResumeLayout(false);
            this.pnlFields.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlAccountName.ResumeLayout(false);
            this.pnlAccountName.PerformLayout();
            this.pnlId.ResumeLayout(false);
            this.pnlId.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDetails;
        private System.Windows.Forms.Panel pnlFields;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox tbPeriod;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox tbNewBalance;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox tbDebits;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox tbCredits;
        private System.Windows.Forms.Label lblAmountInCurrency;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbPreviosBalance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbValueDate;
        private System.Windows.Forms.Label label1;
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
        private Zuby.ADGV.AdvancedDataGridView dgvItems;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnLoadPdf;
        private System.Windows.Forms.TextBox tbLoadedFrom;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.LinkLabel linkStatement;
    }
}
