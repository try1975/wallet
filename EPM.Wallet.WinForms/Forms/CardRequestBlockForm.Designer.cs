namespace EPM.Wallet.WinForms.Forms
{
    partial class CardRequestBlockForm
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
            this.gbMessage = new System.Windows.Forms.GroupBox();
            this.tbMessageBody = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.gbMessage.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbMessage
            // 
            this.gbMessage.Controls.Add(this.tbMessageBody);
            this.gbMessage.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbMessage.Location = new System.Drawing.Point(0, 0);
            this.gbMessage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbMessage.Name = "gbMessage";
            this.gbMessage.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbMessage.Size = new System.Drawing.Size(669, 154);
            this.gbMessage.TabIndex = 22;
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
            this.tbMessageBody.Size = new System.Drawing.Size(661, 125);
            this.tbMessageBody.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnOk);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 342);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(669, 100);
            this.panel2.TabIndex = 21;
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
            // CardRequestBlockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 442);
            this.Controls.Add(this.gbMessage);
            this.Controls.Add(this.panel2);
            this.Name = "CardRequestBlockForm";
            this.Text = "CardRequestBlockForm";
            this.gbMessage.ResumeLayout(false);
            this.gbMessage.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbMessage;
        private System.Windows.Forms.TextBox tbMessageBody;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
    }
}