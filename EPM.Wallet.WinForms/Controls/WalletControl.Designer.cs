namespace EPM.Wallet.WinForms.Controls
{
    partial class WalletControl
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
            this.pnlWorkArea = new System.Windows.Forms.Panel();
            this.btnBanks = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClientAccounts = new System.Windows.Forms.Button();
            this.btnClients = new System.Windows.Forms.Button();
            this.btnBankAccounts = new System.Windows.Forms.Button();
            this.bntCards = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlWorkArea
            // 
            this.pnlWorkArea.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlWorkArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlWorkArea.Location = new System.Drawing.Point(0, 32);
            this.pnlWorkArea.Name = "pnlWorkArea";
            this.pnlWorkArea.Size = new System.Drawing.Size(562, 434);
            this.pnlWorkArea.TabIndex = 0;
            // 
            // btnBanks
            // 
            this.btnBanks.Location = new System.Drawing.Point(3, 3);
            this.btnBanks.Name = "btnBanks";
            this.btnBanks.Size = new System.Drawing.Size(75, 23);
            this.btnBanks.TabIndex = 2;
            this.btnBanks.Text = "Banks";
            this.btnBanks.UseVisualStyleBackColor = true;
            this.btnBanks.Click += new System.EventHandler(this.btnBanks_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bntCards);
            this.panel1.Controls.Add(this.btnClientAccounts);
            this.panel1.Controls.Add(this.btnClients);
            this.panel1.Controls.Add(this.btnBankAccounts);
            this.panel1.Controls.Add(this.btnBanks);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(562, 32);
            this.panel1.TabIndex = 3;
            // 
            // btnClientAccounts
            // 
            this.btnClientAccounts.Location = new System.Drawing.Point(262, 3);
            this.btnClientAccounts.Name = "btnClientAccounts";
            this.btnClientAccounts.Size = new System.Drawing.Size(92, 23);
            this.btnClientAccounts.TabIndex = 5;
            this.btnClientAccounts.Text = "Client Accounts";
            this.btnClientAccounts.UseVisualStyleBackColor = true;
            this.btnClientAccounts.Click += new System.EventHandler(this.btnClientAccounts_Click);
            // 
            // btnClients
            // 
            this.btnClients.Location = new System.Drawing.Point(181, 3);
            this.btnClients.Name = "btnClients";
            this.btnClients.Size = new System.Drawing.Size(75, 23);
            this.btnClients.TabIndex = 4;
            this.btnClients.Text = "Clients";
            this.btnClients.UseVisualStyleBackColor = true;
            this.btnClients.Click += new System.EventHandler(this.btnClients_Click);
            // 
            // btnBankAccounts
            // 
            this.btnBankAccounts.Location = new System.Drawing.Point(84, 3);
            this.btnBankAccounts.Name = "btnBankAccounts";
            this.btnBankAccounts.Size = new System.Drawing.Size(91, 23);
            this.btnBankAccounts.TabIndex = 3;
            this.btnBankAccounts.Text = "BankAccounts";
            this.btnBankAccounts.UseVisualStyleBackColor = true;
            this.btnBankAccounts.Click += new System.EventHandler(this.btnBankAccounts_Click);
            // 
            // bntCards
            // 
            this.bntCards.Location = new System.Drawing.Point(361, 3);
            this.bntCards.Name = "bntCards";
            this.bntCards.Size = new System.Drawing.Size(75, 23);
            this.bntCards.TabIndex = 6;
            this.bntCards.Text = "Cards";
            this.bntCards.UseVisualStyleBackColor = true;
            this.bntCards.Click += new System.EventHandler(this.bntCards_Click);
            // 
            // WalletControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlWorkArea);
            this.Controls.Add(this.panel1);
            this.Name = "WalletControl";
            this.Size = new System.Drawing.Size(562, 466);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlWorkArea;
        private System.Windows.Forms.Button btnBanks;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBankAccounts;
        private System.Windows.Forms.Button btnClients;
        private System.Windows.Forms.Button btnClientAccounts;
        private System.Windows.Forms.Button bntCards;
    }
}
