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
            this.tbMessageBody = new System.Windows.Forms.TextBox();
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
            this.tbCurrencyId = new System.Windows.Forms.TextBox();
            this.lblCurrency = new System.Windows.Forms.Label();
            this.pnlClient = new System.Windows.Forms.Panel();
            this.tbClientId = new System.Windows.Forms.TextBox();
            this.lblClient = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
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
            this.pnlComment.SuspendLayout();
            this.pnlVendor.SuspendLayout();
            this.pnlPin.SuspendLayout();
            this.pnlCvc.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFields
            // 
            this.pnlFields.Controls.Add(this.gbMessage);
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
            this.pnlFields.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFields.Location = new System.Drawing.Point(0, 0);
            this.pnlFields.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlFields.Name = "pnlFields";
            this.pnlFields.Size = new System.Drawing.Size(840, 729);
            this.pnlFields.TabIndex = 4;
            // 
            // gbMessage
            // 
            this.gbMessage.Controls.Add(this.tbMessageBody);
            this.gbMessage.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbMessage.Location = new System.Drawing.Point(0, 561);
            this.gbMessage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbMessage.Name = "gbMessage";
            this.gbMessage.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbMessage.Size = new System.Drawing.Size(840, 154);
            this.gbMessage.TabIndex = 19;
            this.gbMessage.TabStop = false;
            this.gbMessage.Text = "Enter message text if necessary";
            // 
            // tbMessageBody
            // 
            this.tbMessageBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbMessageBody.Location = new System.Drawing.Point(4, 24);
            this.tbMessageBody.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbMessageBody.Multiline = true;
            this.tbMessageBody.Name = "tbMessageBody";
            this.tbMessageBody.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbMessageBody.Size = new System.Drawing.Size(832, 125);
            this.tbMessageBody.TabIndex = 0;
            // 
            // pnlLimit
            // 
            this.pnlLimit.Controls.Add(this.udLimit);
            this.pnlLimit.Controls.Add(this.lblLimit);
            this.pnlLimit.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLimit.Location = new System.Drawing.Point(0, 306);
            this.pnlLimit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlLimit.Name = "pnlLimit";
            this.pnlLimit.Size = new System.Drawing.Size(840, 51);
            this.pnlLimit.TabIndex = 18;
            // 
            // udLimit
            // 
            this.udLimit.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.udLimit.Location = new System.Drawing.Point(146, 11);
            this.udLimit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
            this.udLimit.Size = new System.Drawing.Size(180, 26);
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
            this.lblLimit.Location = new System.Drawing.Point(10, 14);
            this.lblLimit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLimit.Name = "lblLimit";
            this.lblLimit.Size = new System.Drawing.Size(42, 20);
            this.lblLimit.TabIndex = 0;
            this.lblLimit.Text = "Limit";
            // 
            // pnlExpYear
            // 
            this.pnlExpYear.Controls.Add(this.udExpYear);
            this.pnlExpYear.Controls.Add(this.lblExpYear);
            this.pnlExpYear.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlExpYear.Location = new System.Drawing.Point(0, 255);
            this.pnlExpYear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlExpYear.Name = "pnlExpYear";
            this.pnlExpYear.Size = new System.Drawing.Size(840, 51);
            this.pnlExpYear.TabIndex = 17;
            // 
            // udExpYear
            // 
            this.udExpYear.Location = new System.Drawing.Point(146, 11);
            this.udExpYear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
            this.udExpYear.Size = new System.Drawing.Size(180, 26);
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
            this.lblExpYear.Location = new System.Drawing.Point(10, 14);
            this.lblExpYear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExpYear.Name = "lblExpYear";
            this.lblExpYear.Size = new System.Drawing.Size(70, 20);
            this.lblExpYear.TabIndex = 0;
            this.lblExpYear.Text = "ExpYear";
            // 
            // pnlExpMonth
            // 
            this.pnlExpMonth.Controls.Add(this.udExpMonth);
            this.pnlExpMonth.Controls.Add(this.lblExpMonth);
            this.pnlExpMonth.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlExpMonth.Location = new System.Drawing.Point(0, 204);
            this.pnlExpMonth.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlExpMonth.Name = "pnlExpMonth";
            this.pnlExpMonth.Size = new System.Drawing.Size(840, 51);
            this.pnlExpMonth.TabIndex = 16;
            // 
            // udExpMonth
            // 
            this.udExpMonth.Location = new System.Drawing.Point(146, 11);
            this.udExpMonth.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
            this.udExpMonth.Size = new System.Drawing.Size(180, 26);
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
            this.lblExpMonth.Location = new System.Drawing.Point(10, 14);
            this.lblExpMonth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExpMonth.Name = "lblExpMonth";
            this.lblExpMonth.Size = new System.Drawing.Size(81, 20);
            this.lblExpMonth.TabIndex = 0;
            this.lblExpMonth.Text = "ExpMonth";
            // 
            // pnlCardHolder
            // 
            this.pnlCardHolder.Controls.Add(this.tbCardHolder);
            this.pnlCardHolder.Controls.Add(this.lblCardHolder);
            this.pnlCardHolder.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCardHolder.Location = new System.Drawing.Point(0, 153);
            this.pnlCardHolder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlCardHolder.Name = "pnlCardHolder";
            this.pnlCardHolder.Size = new System.Drawing.Size(840, 51);
            this.pnlCardHolder.TabIndex = 15;
            // 
            // tbCardHolder
            // 
            this.tbCardHolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCardHolder.Location = new System.Drawing.Point(146, 9);
            this.tbCardHolder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbCardHolder.Name = "tbCardHolder";
            this.tbCardHolder.Size = new System.Drawing.Size(668, 26);
            this.tbCardHolder.TabIndex = 3;
            // 
            // lblCardHolder
            // 
            this.lblCardHolder.AutoSize = true;
            this.lblCardHolder.Location = new System.Drawing.Point(10, 14);
            this.lblCardHolder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCardHolder.Name = "lblCardHolder";
            this.lblCardHolder.Size = new System.Drawing.Size(94, 20);
            this.lblCardHolder.TabIndex = 0;
            this.lblCardHolder.Text = "Card Holder";
            // 
            // pnlCardNumber
            // 
            this.pnlCardNumber.Controls.Add(this.tbCardNumber);
            this.pnlCardNumber.Controls.Add(this.lblCardNumber);
            this.pnlCardNumber.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCardNumber.Location = new System.Drawing.Point(0, 102);
            this.pnlCardNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlCardNumber.Name = "pnlCardNumber";
            this.pnlCardNumber.Size = new System.Drawing.Size(840, 51);
            this.pnlCardNumber.TabIndex = 14;
            // 
            // tbCardNumber
            // 
            this.tbCardNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCardNumber.Location = new System.Drawing.Point(146, 9);
            this.tbCardNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbCardNumber.Name = "tbCardNumber";
            this.tbCardNumber.Size = new System.Drawing.Size(668, 26);
            this.tbCardNumber.TabIndex = 3;
            // 
            // lblCardNumber
            // 
            this.lblCardNumber.AutoSize = true;
            this.lblCardNumber.Location = new System.Drawing.Point(10, 14);
            this.lblCardNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCardNumber.Name = "lblCardNumber";
            this.lblCardNumber.Size = new System.Drawing.Size(103, 20);
            this.lblCardNumber.TabIndex = 0;
            this.lblCardNumber.Text = "Card Number";
            // 
            // pnlCurrency
            // 
            this.pnlCurrency.Controls.Add(this.tbCurrencyId);
            this.pnlCurrency.Controls.Add(this.lblCurrency);
            this.pnlCurrency.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCurrency.Location = new System.Drawing.Point(0, 51);
            this.pnlCurrency.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlCurrency.Name = "pnlCurrency";
            this.pnlCurrency.Size = new System.Drawing.Size(840, 51);
            this.pnlCurrency.TabIndex = 13;
            // 
            // tbCurrencyId
            // 
            this.tbCurrencyId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCurrencyId.Enabled = false;
            this.tbCurrencyId.Location = new System.Drawing.Point(146, 11);
            this.tbCurrencyId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbCurrencyId.Name = "tbCurrencyId";
            this.tbCurrencyId.Size = new System.Drawing.Size(668, 26);
            this.tbCurrencyId.TabIndex = 4;
            // 
            // lblCurrency
            // 
            this.lblCurrency.AutoSize = true;
            this.lblCurrency.Location = new System.Drawing.Point(10, 14);
            this.lblCurrency.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCurrency.Name = "lblCurrency";
            this.lblCurrency.Size = new System.Drawing.Size(72, 20);
            this.lblCurrency.TabIndex = 0;
            this.lblCurrency.Text = "Currency";
            // 
            // pnlClient
            // 
            this.pnlClient.Controls.Add(this.tbClientId);
            this.pnlClient.Controls.Add(this.lblClient);
            this.pnlClient.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlClient.Location = new System.Drawing.Point(0, 0);
            this.pnlClient.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlClient.Name = "pnlClient";
            this.pnlClient.Size = new System.Drawing.Size(840, 51);
            this.pnlClient.TabIndex = 12;
            // 
            // tbClientId
            // 
            this.tbClientId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbClientId.Enabled = false;
            this.tbClientId.Location = new System.Drawing.Point(146, 15);
            this.tbClientId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbClientId.Name = "tbClientId";
            this.tbClientId.Size = new System.Drawing.Size(668, 26);
            this.tbClientId.TabIndex = 4;
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Location = new System.Drawing.Point(10, 14);
            this.lblClient.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(49, 20);
            this.lblClient.TabIndex = 0;
            this.lblClient.Text = "Client";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnOk);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 729);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(840, 100);
            this.panel2.TabIndex = 3;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(513, 32);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(116, 42);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(381, 32);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(116, 42);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // pnlComment
            // 
            this.pnlComment.Controls.Add(this.tbComment);
            this.pnlComment.Controls.Add(this.lblComment);
            this.pnlComment.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlComment.Location = new System.Drawing.Point(0, 510);
            this.pnlComment.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlComment.Name = "pnlComment";
            this.pnlComment.Size = new System.Drawing.Size(840, 51);
            this.pnlComment.TabIndex = 23;
            // 
            // tbComment
            // 
            this.tbComment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbComment.Enabled = false;
            this.tbComment.Location = new System.Drawing.Point(146, 9);
            this.tbComment.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbComment.Name = "tbComment";
            this.tbComment.Size = new System.Drawing.Size(668, 26);
            this.tbComment.TabIndex = 3;
            // 
            // lblComment
            // 
            this.lblComment.AutoSize = true;
            this.lblComment.Location = new System.Drawing.Point(10, 14);
            this.lblComment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(78, 20);
            this.lblComment.TabIndex = 0;
            this.lblComment.Text = "Comment";
            // 
            // pnlVendor
            // 
            this.pnlVendor.Controls.Add(this.tbVendor);
            this.pnlVendor.Controls.Add(this.lblVendor);
            this.pnlVendor.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlVendor.Location = new System.Drawing.Point(0, 459);
            this.pnlVendor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlVendor.Name = "pnlVendor";
            this.pnlVendor.Size = new System.Drawing.Size(840, 51);
            this.pnlVendor.TabIndex = 22;
            // 
            // tbVendor
            // 
            this.tbVendor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbVendor.Enabled = false;
            this.tbVendor.Location = new System.Drawing.Point(146, 9);
            this.tbVendor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbVendor.Name = "tbVendor";
            this.tbVendor.Size = new System.Drawing.Size(668, 26);
            this.tbVendor.TabIndex = 3;
            // 
            // lblVendor
            // 
            this.lblVendor.AutoSize = true;
            this.lblVendor.Location = new System.Drawing.Point(10, 14);
            this.lblVendor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVendor.Name = "lblVendor";
            this.lblVendor.Size = new System.Drawing.Size(61, 20);
            this.lblVendor.TabIndex = 0;
            this.lblVendor.Text = "Vendor";
            // 
            // pnlPin
            // 
            this.pnlPin.Controls.Add(this.tbPin);
            this.pnlPin.Controls.Add(this.lblPin);
            this.pnlPin.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPin.Location = new System.Drawing.Point(0, 408);
            this.pnlPin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlPin.Name = "pnlPin";
            this.pnlPin.Size = new System.Drawing.Size(840, 51);
            this.pnlPin.TabIndex = 21;
            // 
            // tbPin
            // 
            this.tbPin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPin.Enabled = false;
            this.tbPin.Location = new System.Drawing.Point(146, 9);
            this.tbPin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbPin.Name = "tbPin";
            this.tbPin.Size = new System.Drawing.Size(668, 26);
            this.tbPin.TabIndex = 3;
            // 
            // lblPin
            // 
            this.lblPin.AutoSize = true;
            this.lblPin.Location = new System.Drawing.Point(10, 14);
            this.lblPin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPin.Name = "lblPin";
            this.lblPin.Size = new System.Drawing.Size(31, 20);
            this.lblPin.TabIndex = 0;
            this.lblPin.Text = "Pin";
            // 
            // pnlCvc
            // 
            this.pnlCvc.Controls.Add(this.tbCvc);
            this.pnlCvc.Controls.Add(this.lblCvc);
            this.pnlCvc.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCvc.Location = new System.Drawing.Point(0, 357);
            this.pnlCvc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlCvc.Name = "pnlCvc";
            this.pnlCvc.Size = new System.Drawing.Size(840, 51);
            this.pnlCvc.TabIndex = 20;
            // 
            // tbCvc
            // 
            this.tbCvc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCvc.Enabled = false;
            this.tbCvc.Location = new System.Drawing.Point(146, 9);
            this.tbCvc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbCvc.Name = "tbCvc";
            this.tbCvc.Size = new System.Drawing.Size(668, 26);
            this.tbCvc.TabIndex = 3;
            // 
            // lblCvc
            // 
            this.lblCvc.AutoSize = true;
            this.lblCvc.Location = new System.Drawing.Point(10, 14);
            this.lblCvc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCvc.Name = "lblCvc";
            this.lblCvc.Size = new System.Drawing.Size(35, 20);
            this.lblCvc.TabIndex = 0;
            this.lblCvc.Text = "Cvc";
            // 
            // CardByRequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 829);
            this.Controls.Add(this.pnlFields);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
            this.pnlComment.ResumeLayout(false);
            this.pnlComment.PerformLayout();
            this.pnlVendor.ResumeLayout(false);
            this.pnlVendor.PerformLayout();
            this.pnlPin.ResumeLayout(false);
            this.pnlPin.PerformLayout();
            this.pnlCvc.ResumeLayout(false);
            this.pnlCvc.PerformLayout();
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
        private System.Windows.Forms.Label lblCurrency;
        private System.Windows.Forms.Panel pnlClient;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.GroupBox gbMessage;
        private System.Windows.Forms.TextBox tbMessageBody;
        private System.Windows.Forms.TextBox tbCurrencyId;
        private System.Windows.Forms.TextBox tbClientId;
        private System.Windows.Forms.Panel pnlComment;
        private System.Windows.Forms.TextBox tbComment;
        private System.Windows.Forms.Label lblComment;
        private System.Windows.Forms.Panel pnlVendor;
        private System.Windows.Forms.TextBox tbVendor;
        private System.Windows.Forms.Label lblVendor;
        private System.Windows.Forms.Panel pnlPin;
        private System.Windows.Forms.TextBox tbPin;
        private System.Windows.Forms.Label lblPin;
        private System.Windows.Forms.Panel pnlCvc;
        private System.Windows.Forms.TextBox tbCvc;
        private System.Windows.Forms.Label lblCvc;
    }
}