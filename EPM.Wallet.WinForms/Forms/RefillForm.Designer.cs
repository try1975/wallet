namespace EPM.Wallet.WinForms.Forms
{
    partial class RefillForm
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
            this.pnlFields = new System.Windows.Forms.Panel();
            this.gbTransactionIn = new System.Windows.Forms.GroupBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tbNoteIn = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.tbFromToIn = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.tbAmountIn = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.tbBeneficiaryAccountName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.gbTransactionOut = new System.Windows.Forms.GroupBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.tbNoteOut = new System.Windows.Forms.TextBox();
            this.lblNote = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbFromToOut = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tbCurrencyId = new System.Windows.Forms.TextBox();
            this.tbAmountCurrencyOut = new System.Windows.Forms.TextBox();
            this.lblAmountInCurrency = new System.Windows.Forms.Label();
            this.pnlAmountOut = new System.Windows.Forms.Panel();
            this.tbAmountOut = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlValueDate = new System.Windows.Forms.Panel();
            this.tbValueDate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlAccountName = new System.Windows.Forms.Panel();
            this.tbAccountName = new System.Windows.Forms.TextBox();
            this.lblAccount = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.pnlFields.SuspendLayout();
            this.gbTransactionIn.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel11.SuspendLayout();
            this.gbTransactionOut.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.pnlAmountOut.SuspendLayout();
            this.pnlValueDate.SuspendLayout();
            this.pnlAccountName.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFields
            // 
            this.pnlFields.Controls.Add(this.gbTransactionIn);
            this.pnlFields.Controls.Add(this.gbTransactionOut);
            this.pnlFields.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFields.Location = new System.Drawing.Point(0, 0);
            this.pnlFields.Name = "pnlFields";
            this.pnlFields.Size = new System.Drawing.Size(535, 479);
            this.pnlFields.TabIndex = 4;
            // 
            // gbTransactionIn
            // 
            this.gbTransactionIn.Controls.Add(this.panel5);
            this.gbTransactionIn.Controls.Add(this.panel7);
            this.gbTransactionIn.Controls.Add(this.panel9);
            this.gbTransactionIn.Controls.Add(this.panel11);
            this.gbTransactionIn.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbTransactionIn.Location = new System.Drawing.Point(0, 236);
            this.gbTransactionIn.Name = "gbTransactionIn";
            this.gbTransactionIn.Size = new System.Drawing.Size(535, 236);
            this.gbTransactionIn.TabIndex = 14;
            this.gbTransactionIn.TabStop = false;
            this.gbTransactionIn.Text = "Transaction In";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.tbNoteIn);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(3, 118);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(529, 34);
            this.panel5.TabIndex = 18;
            // 
            // tbNoteIn
            // 
            this.tbNoteIn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNoteIn.Location = new System.Drawing.Point(97, 6);
            this.tbNoteIn.Name = "tbNoteIn";
            this.tbNoteIn.Size = new System.Drawing.Size(416, 20);
            this.tbNoteIn.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Note";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.tbFromToIn);
            this.panel7.Controls.Add(this.label5);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(3, 84);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(529, 34);
            this.panel7.TabIndex = 17;
            // 
            // tbFromToIn
            // 
            this.tbFromToIn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFromToIn.Location = new System.Drawing.Point(97, 6);
            this.tbFromToIn.Name = "tbFromToIn";
            this.tbFromToIn.Size = new System.Drawing.Size(416, 20);
            this.tbFromToIn.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "FromTo";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.tbAmountIn);
            this.panel9.Controls.Add(this.label7);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(3, 50);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(529, 34);
            this.panel9.TabIndex = 15;
            // 
            // tbAmountIn
            // 
            this.tbAmountIn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAmountIn.Location = new System.Drawing.Point(97, 6);
            this.tbAmountIn.Name = "tbAmountIn";
            this.tbAmountIn.Size = new System.Drawing.Size(416, 20);
            this.tbAmountIn.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Amount";
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.tbBeneficiaryAccountName);
            this.panel11.Controls.Add(this.label9);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel11.Location = new System.Drawing.Point(3, 16);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(529, 34);
            this.panel11.TabIndex = 13;
            // 
            // tbBeneficiaryAccountName
            // 
            this.tbBeneficiaryAccountName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbBeneficiaryAccountName.Location = new System.Drawing.Point(97, 8);
            this.tbBeneficiaryAccountName.Name = "tbBeneficiaryAccountName";
            this.tbBeneficiaryAccountName.ReadOnly = true;
            this.tbBeneficiaryAccountName.Size = new System.Drawing.Size(416, 20);
            this.tbBeneficiaryAccountName.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Account";
            // 
            // gbTransactionOut
            // 
            this.gbTransactionOut.Controls.Add(this.panel6);
            this.gbTransactionOut.Controls.Add(this.panel3);
            this.gbTransactionOut.Controls.Add(this.panel4);
            this.gbTransactionOut.Controls.Add(this.pnlAmountOut);
            this.gbTransactionOut.Controls.Add(this.pnlValueDate);
            this.gbTransactionOut.Controls.Add(this.pnlAccountName);
            this.gbTransactionOut.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbTransactionOut.Location = new System.Drawing.Point(0, 0);
            this.gbTransactionOut.Name = "gbTransactionOut";
            this.gbTransactionOut.Size = new System.Drawing.Size(535, 236);
            this.gbTransactionOut.TabIndex = 13;
            this.gbTransactionOut.TabStop = false;
            this.gbTransactionOut.Text = "Transaction Out";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.tbNoteOut);
            this.panel6.Controls.Add(this.lblNote);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(3, 186);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(529, 34);
            this.panel6.TabIndex = 12;
            // 
            // tbNoteOut
            // 
            this.tbNoteOut.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNoteOut.Location = new System.Drawing.Point(97, 6);
            this.tbNoteOut.Name = "tbNoteOut";
            this.tbNoteOut.Size = new System.Drawing.Size(416, 20);
            this.tbNoteOut.TabIndex = 2;
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
            this.panel3.Controls.Add(this.tbFromToOut);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 152);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(529, 34);
            this.panel3.TabIndex = 11;
            // 
            // tbFromToOut
            // 
            this.tbFromToOut.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFromToOut.Location = new System.Drawing.Point(97, 6);
            this.tbFromToOut.Name = "tbFromToOut";
            this.tbFromToOut.Size = new System.Drawing.Size(416, 20);
            this.tbFromToOut.TabIndex = 2;
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
            this.panel4.Controls.Add(this.tbAmountCurrencyOut);
            this.panel4.Controls.Add(this.lblAmountInCurrency);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(3, 118);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(529, 34);
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
            // tbAmountCurrencyOut
            // 
            this.tbAmountCurrencyOut.Location = new System.Drawing.Point(97, 5);
            this.tbAmountCurrencyOut.Name = "tbAmountCurrencyOut";
            this.tbAmountCurrencyOut.ReadOnly = true;
            this.tbAmountCurrencyOut.Size = new System.Drawing.Size(139, 20);
            this.tbAmountCurrencyOut.TabIndex = 2;
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
            // pnlAmountOut
            // 
            this.pnlAmountOut.Controls.Add(this.tbAmountOut);
            this.pnlAmountOut.Controls.Add(this.label2);
            this.pnlAmountOut.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAmountOut.Location = new System.Drawing.Point(3, 84);
            this.pnlAmountOut.Name = "pnlAmountOut";
            this.pnlAmountOut.Size = new System.Drawing.Size(529, 34);
            this.pnlAmountOut.TabIndex = 7;
            // 
            // tbAmountOut
            // 
            this.tbAmountOut.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAmountOut.Location = new System.Drawing.Point(97, 6);
            this.tbAmountOut.Name = "tbAmountOut";
            this.tbAmountOut.Size = new System.Drawing.Size(416, 20);
            this.tbAmountOut.TabIndex = 2;
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
            this.pnlValueDate.Location = new System.Drawing.Point(3, 50);
            this.pnlValueDate.Name = "pnlValueDate";
            this.pnlValueDate.Size = new System.Drawing.Size(529, 34);
            this.pnlValueDate.TabIndex = 6;
            // 
            // tbValueDate
            // 
            this.tbValueDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbValueDate.Location = new System.Drawing.Point(97, 6);
            this.tbValueDate.Name = "tbValueDate";
            this.tbValueDate.Size = new System.Drawing.Size(416, 20);
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
            this.pnlAccountName.Location = new System.Drawing.Point(3, 16);
            this.pnlAccountName.Name = "pnlAccountName";
            this.pnlAccountName.Size = new System.Drawing.Size(529, 34);
            this.pnlAccountName.TabIndex = 4;
            // 
            // tbAccountName
            // 
            this.tbAccountName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAccountName.Location = new System.Drawing.Point(97, 8);
            this.tbAccountName.Name = "tbAccountName";
            this.tbAccountName.ReadOnly = true;
            this.tbAccountName.Size = new System.Drawing.Size(416, 20);
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
            // panel2
            // 
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnOk);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 479);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(535, 65);
            this.panel2.TabIndex = 3;
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
            // RefillForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(535, 544);
            this.Controls.Add(this.pnlFields);
            this.Controls.Add(this.panel2);
            this.Name = "RefillForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "RefillForm";
            this.Load += new System.EventHandler(this.RefillForm_Load);
            this.pnlFields.ResumeLayout(false);
            this.gbTransactionIn.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.gbTransactionOut.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.pnlAmountOut.ResumeLayout(false);
            this.pnlAmountOut.PerformLayout();
            this.pnlValueDate.ResumeLayout(false);
            this.pnlValueDate.PerformLayout();
            this.pnlAccountName.ResumeLayout(false);
            this.pnlAccountName.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFields;
        private System.Windows.Forms.GroupBox gbTransactionIn;
        private System.Windows.Forms.GroupBox gbTransactionOut;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox tbNoteOut;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox tbFromToOut;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox tbCurrencyId;
        private System.Windows.Forms.TextBox tbAmountCurrencyOut;
        private System.Windows.Forms.Label lblAmountInCurrency;
        private System.Windows.Forms.Panel pnlAmountOut;
        private System.Windows.Forms.TextBox tbAmountOut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlValueDate;
        private System.Windows.Forms.TextBox tbValueDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlAccountName;
        private System.Windows.Forms.TextBox tbAccountName;
        private System.Windows.Forms.Label lblAccount;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox tbNoteIn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox tbFromToIn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox tbAmountIn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.TextBox tbBeneficiaryAccountName;
        private System.Windows.Forms.Label label9;
    }
}