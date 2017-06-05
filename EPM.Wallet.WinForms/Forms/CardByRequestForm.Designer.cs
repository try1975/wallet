namespace EPM.Wallet.WinForms.Forms
{
    partial class CardByRequestForm
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
            this.gbMessage = new System.Windows.Forms.GroupBox();
            this.tbMessage = new System.Windows.Forms.TextBox();
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.pnlFields.SuspendLayout();
            this.gbMessage.SuspendLayout();
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
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFields
            // 
            this.pnlFields.Controls.Add(this.gbMessage);
            this.pnlFields.Controls.Add(this.pnlLimit);
            this.pnlFields.Controls.Add(this.pnlExpYear);
            this.pnlFields.Controls.Add(this.pnlExpMonth);
            this.pnlFields.Controls.Add(this.pnlCardHolder);
            this.pnlFields.Controls.Add(this.pnlCardNumber);
            this.pnlFields.Controls.Add(this.pnlCurrency);
            this.pnlFields.Controls.Add(this.pnlClient);
            this.pnlFields.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFields.Location = new System.Drawing.Point(0, 0);
            this.pnlFields.Name = "pnlFields";
            this.pnlFields.Size = new System.Drawing.Size(560, 402);
            this.pnlFields.TabIndex = 4;
            // 
            // gbMessage
            // 
            this.gbMessage.Controls.Add(this.tbMessage);
            this.gbMessage.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbMessage.Location = new System.Drawing.Point(0, 231);
            this.gbMessage.Name = "gbMessage";
            this.gbMessage.Size = new System.Drawing.Size(560, 100);
            this.gbMessage.TabIndex = 19;
            this.gbMessage.TabStop = false;
            this.gbMessage.Text = "Message";
            // 
            // tbMessage
            // 
            this.tbMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbMessage.Location = new System.Drawing.Point(3, 16);
            this.tbMessage.Multiline = true;
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbMessage.Size = new System.Drawing.Size(554, 81);
            this.tbMessage.TabIndex = 0;
            // 
            // pnlLimit
            // 
            this.pnlLimit.Controls.Add(this.udLimit);
            this.pnlLimit.Controls.Add(this.lblLimit);
            this.pnlLimit.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLimit.Location = new System.Drawing.Point(0, 198);
            this.pnlLimit.Name = "pnlLimit";
            this.pnlLimit.Size = new System.Drawing.Size(560, 33);
            this.pnlLimit.TabIndex = 18;
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
            this.pnlExpYear.Location = new System.Drawing.Point(0, 165);
            this.pnlExpYear.Name = "pnlExpYear";
            this.pnlExpYear.Size = new System.Drawing.Size(560, 33);
            this.pnlExpYear.TabIndex = 17;
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
            this.pnlExpMonth.Location = new System.Drawing.Point(0, 132);
            this.pnlExpMonth.Name = "pnlExpMonth";
            this.pnlExpMonth.Size = new System.Drawing.Size(560, 33);
            this.pnlExpMonth.TabIndex = 16;
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
            this.pnlCardHolder.Location = new System.Drawing.Point(0, 99);
            this.pnlCardHolder.Name = "pnlCardHolder";
            this.pnlCardHolder.Size = new System.Drawing.Size(560, 33);
            this.pnlCardHolder.TabIndex = 15;
            // 
            // tbCardHolder
            // 
            this.tbCardHolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCardHolder.Enabled = false;
            this.tbCardHolder.Location = new System.Drawing.Point(97, 6);
            this.tbCardHolder.Name = "tbCardHolder";
            this.tbCardHolder.Size = new System.Drawing.Size(447, 20);
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
            this.pnlCardNumber.Location = new System.Drawing.Point(0, 66);
            this.pnlCardNumber.Name = "pnlCardNumber";
            this.pnlCardNumber.Size = new System.Drawing.Size(560, 33);
            this.pnlCardNumber.TabIndex = 14;
            // 
            // tbCardNumber
            // 
            this.tbCardNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCardNumber.Enabled = false;
            this.tbCardNumber.Location = new System.Drawing.Point(97, 6);
            this.tbCardNumber.Name = "tbCardNumber";
            this.tbCardNumber.Size = new System.Drawing.Size(447, 20);
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
            this.pnlCurrency.Location = new System.Drawing.Point(0, 33);
            this.pnlCurrency.Name = "pnlCurrency";
            this.pnlCurrency.Size = new System.Drawing.Size(560, 33);
            this.pnlCurrency.TabIndex = 13;
            // 
            // cmbCurrency
            // 
            this.cmbCurrency.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbCurrency.FormattingEnabled = true;
            this.cmbCurrency.Location = new System.Drawing.Point(97, 6);
            this.cmbCurrency.Name = "cmbCurrency";
            this.cmbCurrency.Size = new System.Drawing.Size(447, 21);
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
            this.pnlClient.Location = new System.Drawing.Point(0, 0);
            this.pnlClient.Name = "pnlClient";
            this.pnlClient.Size = new System.Drawing.Size(560, 33);
            this.pnlClient.TabIndex = 12;
            // 
            // cmbClient
            // 
            this.cmbClient.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbClient.FormattingEnabled = true;
            this.cmbClient.Location = new System.Drawing.Point(97, 6);
            this.cmbClient.Name = "cmbClient";
            this.cmbClient.Size = new System.Drawing.Size(447, 21);
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
            // panel2
            // 
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnOk);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 402);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(560, 65);
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
            // CardByRequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 467);
            this.Controls.Add(this.pnlFields);
            this.Controls.Add(this.panel2);
            this.Name = "CardByRequestForm";
            this.Text = "CardByRequestForm";
            this.pnlFields.ResumeLayout(false);
            this.gbMessage.ResumeLayout(false);
            this.gbMessage.PerformLayout();
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
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFields;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Panel pnlLimit;
        private System.Windows.Forms.NumericUpDown udLimit;
        private System.Windows.Forms.Label lblLimit;
        private System.Windows.Forms.Panel pnlExpYear;
        private System.Windows.Forms.NumericUpDown udExpYear;
        private System.Windows.Forms.Label lblExpYear;
        private System.Windows.Forms.Panel pnlExpMonth;
        private System.Windows.Forms.NumericUpDown udExpMonth;
        private System.Windows.Forms.Label lblExpMonth;
        private System.Windows.Forms.Panel pnlCardHolder;
        private System.Windows.Forms.TextBox tbCardHolder;
        private System.Windows.Forms.Label lblCardHolder;
        private System.Windows.Forms.Panel pnlCardNumber;
        private System.Windows.Forms.TextBox tbCardNumber;
        private System.Windows.Forms.Label lblCardNumber;
        private System.Windows.Forms.Panel pnlCurrency;
        private System.Windows.Forms.ComboBox cmbCurrency;
        private System.Windows.Forms.Label lblCurrency;
        private System.Windows.Forms.Panel pnlClient;
        private System.Windows.Forms.ComboBox cmbClient;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.GroupBox gbMessage;
        private System.Windows.Forms.TextBox tbMessage;
    }
}