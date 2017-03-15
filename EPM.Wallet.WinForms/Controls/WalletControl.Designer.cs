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
            this.pnlBanks = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnBankAccounts = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnClientAccounts = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnClients = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.bntCards = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnMessages = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnTransferOut = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.pnlBanks.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlWorkArea
            // 
            this.pnlWorkArea.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlWorkArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlWorkArea.Location = new System.Drawing.Point(0, 32);
            this.pnlWorkArea.Name = "pnlWorkArea";
            this.pnlWorkArea.Size = new System.Drawing.Size(828, 481);
            this.pnlWorkArea.TabIndex = 0;
            // 
            // btnBanks
            // 
            this.btnBanks.Location = new System.Drawing.Point(0, 3);
            this.btnBanks.Name = "btnBanks";
            this.btnBanks.Size = new System.Drawing.Size(75, 23);
            this.btnBanks.TabIndex = 2;
            this.btnBanks.Text = "Banks";
            this.btnBanks.UseVisualStyleBackColor = true;
            this.btnBanks.Click += new System.EventHandler(this.btnBanks_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnlBanks);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(828, 32);
            this.panel1.TabIndex = 3;
            // 
            // pnlBanks
            // 
            this.pnlBanks.Controls.Add(this.btnBanks);
            this.pnlBanks.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlBanks.Location = new System.Drawing.Point(648, 0);
            this.pnlBanks.Name = "pnlBanks";
            this.pnlBanks.Size = new System.Drawing.Size(89, 32);
            this.pnlBanks.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnBankAccounts);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(551, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(97, 32);
            this.panel2.TabIndex = 10;
            // 
            // btnBankAccounts
            // 
            this.btnBankAccounts.Location = new System.Drawing.Point(0, 3);
            this.btnBankAccounts.Name = "btnBankAccounts";
            this.btnBankAccounts.Size = new System.Drawing.Size(91, 23);
            this.btnBankAccounts.TabIndex = 3;
            this.btnBankAccounts.Text = "BankAccounts";
            this.btnBankAccounts.UseVisualStyleBackColor = true;
            this.btnBankAccounts.Click += new System.EventHandler(this.btnBankAccounts_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnClientAccounts);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(452, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(99, 32);
            this.panel3.TabIndex = 10;
            // 
            // btnClientAccounts
            // 
            this.btnClientAccounts.Location = new System.Drawing.Point(0, 3);
            this.btnClientAccounts.Name = "btnClientAccounts";
            this.btnClientAccounts.Size = new System.Drawing.Size(92, 23);
            this.btnClientAccounts.TabIndex = 5;
            this.btnClientAccounts.Text = "Client Accounts";
            this.btnClientAccounts.UseVisualStyleBackColor = true;
            this.btnClientAccounts.Click += new System.EventHandler(this.btnClientAccounts_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnClients);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(363, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(89, 32);
            this.panel7.TabIndex = 12;
            // 
            // btnClients
            // 
            this.btnClients.Location = new System.Drawing.Point(0, 3);
            this.btnClients.Name = "btnClients";
            this.btnClients.Size = new System.Drawing.Size(75, 23);
            this.btnClients.TabIndex = 4;
            this.btnClients.Text = "Clients";
            this.btnClients.UseVisualStyleBackColor = true;
            this.btnClients.Click += new System.EventHandler(this.btnClients_Click);
            // 
            // panel8
            // 
            this.panel8.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel8.Location = new System.Drawing.Point(274, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(89, 32);
            this.panel8.TabIndex = 13;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.bntCards);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(185, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(89, 32);
            this.panel6.TabIndex = 11;
            this.panel6.Visible = false;
            // 
            // bntCards
            // 
            this.bntCards.Location = new System.Drawing.Point(0, 3);
            this.bntCards.Name = "bntCards";
            this.bntCards.Size = new System.Drawing.Size(75, 23);
            this.bntCards.TabIndex = 6;
            this.bntCards.Text = "Cards";
            this.bntCards.UseVisualStyleBackColor = true;
            this.bntCards.Click += new System.EventHandler(this.bntCards_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnMessages);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(96, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(89, 32);
            this.panel5.TabIndex = 10;
            // 
            // btnMessages
            // 
            this.btnMessages.Location = new System.Drawing.Point(0, 3);
            this.btnMessages.Name = "btnMessages";
            this.btnMessages.Size = new System.Drawing.Size(75, 23);
            this.btnMessages.TabIndex = 8;
            this.btnMessages.Text = "Messages";
            this.btnMessages.UseVisualStyleBackColor = true;
            this.btnMessages.Click += new System.EventHandler(this.btnMessages_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnTransferOut);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(96, 32);
            this.panel4.TabIndex = 10;
            // 
            // btnTransferOut
            // 
            this.btnTransferOut.Location = new System.Drawing.Point(3, 3);
            this.btnTransferOut.Name = "btnTransferOut";
            this.btnTransferOut.Size = new System.Drawing.Size(87, 23);
            this.btnTransferOut.TabIndex = 7;
            this.btnTransferOut.Text = "Transfer Outs";
            this.btnTransferOut.UseVisualStyleBackColor = true;
            this.btnTransferOut.Click += new System.EventHandler(this.btnRequests_Click);
            // 
            // WalletControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlWorkArea);
            this.Controls.Add(this.panel1);
            this.Name = "WalletControl";
            this.Size = new System.Drawing.Size(828, 513);
            this.panel1.ResumeLayout(false);
            this.pnlBanks.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
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
        private System.Windows.Forms.Button btnTransferOut;
        private System.Windows.Forms.Button btnMessages;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlBanks;
    }
}
