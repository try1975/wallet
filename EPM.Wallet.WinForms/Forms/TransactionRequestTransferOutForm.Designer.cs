namespace EPM.Wallet.WinForms.Forms
{
    partial class TransactionRequestTransferOutForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.pnlFields = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.tbNote = new System.Windows.Forms.TextBox();
            this.lblNote = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbFromTo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tbCurrencyId = new System.Windows.Forms.TextBox();
            this.tbAmountInCurrency = new System.Windows.Forms.TextBox();
            this.lblAmountInCurrency = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbAmount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlValueDate = new System.Windows.Forms.Panel();
            this.tbValueDate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlAccountName = new System.Windows.Forms.Panel();
            this.tbAccountName = new System.Windows.Forms.TextBox();
            this.lblAccount = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.pnlFields.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlValueDate.SuspendLayout();
            this.pnlAccountName.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnOk);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 342);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(524, 65);
            this.panel2.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(342, 21);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(77, 27);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(254, 21);
            this.btnOk.Margin = new System.Windows.Forms.Padding(2);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(77, 27);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // pnlFields
            // 
            this.pnlFields.Controls.Add(this.panel6);
            this.pnlFields.Controls.Add(this.panel3);
            this.pnlFields.Controls.Add(this.panel4);
            this.pnlFields.Controls.Add(this.panel1);
            this.pnlFields.Controls.Add(this.pnlValueDate);
            this.pnlFields.Controls.Add(this.pnlAccountName);
            this.pnlFields.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFields.Location = new System.Drawing.Point(0, 0);
            this.pnlFields.Name = "pnlFields";
            this.pnlFields.Size = new System.Drawing.Size(524, 342);
            this.pnlFields.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.tbNote);
            this.panel6.Controls.Add(this.lblNote);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 170);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(524, 34);
            this.panel6.TabIndex = 12;
            // 
            // tbNote
            // 
            this.tbNote.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNote.Location = new System.Drawing.Point(97, 6);
            this.tbNote.Name = "tbNote";
            this.tbNote.Size = new System.Drawing.Size(411, 20);
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
            this.panel3.Location = new System.Drawing.Point(0, 136);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(524, 34);
            this.panel3.TabIndex = 11;
            // 
            // tbFromTo
            // 
            this.tbFromTo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFromTo.Location = new System.Drawing.Point(97, 6);
            this.tbFromTo.Name = "tbFromTo";
            this.tbFromTo.Size = new System.Drawing.Size(411, 20);
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
            // panel4
            // 
            this.panel4.Controls.Add(this.tbCurrencyId);
            this.panel4.Controls.Add(this.tbAmountInCurrency);
            this.panel4.Controls.Add(this.lblAmountInCurrency);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 102);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(524, 34);
            this.panel4.TabIndex = 9;
            // 
            // tbCurrencyId
            // 
            this.tbCurrencyId.Location = new System.Drawing.Point(254, 5);
            this.tbCurrencyId.Name = "tbCurrencyId";
            this.tbCurrencyId.ReadOnly = true;
            this.tbCurrencyId.Size = new System.Drawing.Size(139, 20);
            this.tbCurrencyId.TabIndex = 3;
            // 
            // tbAmountInCurrency
            // 
            this.tbAmountInCurrency.Location = new System.Drawing.Point(97, 5);
            this.tbAmountInCurrency.Name = "tbAmountInCurrency";
            this.tbAmountInCurrency.ReadOnly = true;
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
            // panel1
            // 
            this.panel1.Controls.Add(this.tbAmount);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(524, 34);
            this.panel1.TabIndex = 7;
            // 
            // tbAmount
            // 
            this.tbAmount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAmount.Location = new System.Drawing.Point(97, 6);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(411, 20);
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
            // pnlValueDate
            // 
            this.pnlValueDate.Controls.Add(this.tbValueDate);
            this.pnlValueDate.Controls.Add(this.label1);
            this.pnlValueDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlValueDate.Location = new System.Drawing.Point(0, 34);
            this.pnlValueDate.Name = "pnlValueDate";
            this.pnlValueDate.Size = new System.Drawing.Size(524, 34);
            this.pnlValueDate.TabIndex = 6;
            // 
            // tbValueDate
            // 
            this.tbValueDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbValueDate.Location = new System.Drawing.Point(97, 6);
            this.tbValueDate.Name = "tbValueDate";
            this.tbValueDate.Size = new System.Drawing.Size(411, 20);
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
            // pnlAccountName
            // 
            this.pnlAccountName.Controls.Add(this.tbAccountName);
            this.pnlAccountName.Controls.Add(this.lblAccount);
            this.pnlAccountName.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAccountName.Location = new System.Drawing.Point(0, 0);
            this.pnlAccountName.Name = "pnlAccountName";
            this.pnlAccountName.Size = new System.Drawing.Size(524, 34);
            this.pnlAccountName.TabIndex = 4;
            // 
            // tbAccountName
            // 
            this.tbAccountName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAccountName.Location = new System.Drawing.Point(97, 8);
            this.tbAccountName.Name = "tbAccountName";
            this.tbAccountName.ReadOnly = true;
            this.tbAccountName.Size = new System.Drawing.Size(411, 20);
            this.tbAccountName.TabIndex = 3;
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
            // TransactionRequestTransferOutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 407);
            this.Controls.Add(this.pnlFields);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TransactionRequestTransferOutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Transaction by Request";
            this.Load += new System.EventHandler(this.TransactionRequestTransferOutForm_Load);
            this.panel2.ResumeLayout(false);
            this.pnlFields.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlValueDate.ResumeLayout(false);
            this.pnlValueDate.PerformLayout();
            this.pnlAccountName.ResumeLayout(false);
            this.pnlAccountName.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Panel pnlFields;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox tbNote;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox tbFromTo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox tbAmountInCurrency;
        private System.Windows.Forms.Label lblAmountInCurrency;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlValueDate;
        private System.Windows.Forms.TextBox tbValueDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlAccountName;
        private System.Windows.Forms.Label lblAccount;
        private System.Windows.Forms.TextBox tbAccountName;
        private System.Windows.Forms.TextBox tbCurrencyId;
    }
}