namespace OO_Bank.User_Controls {
    partial class OverviewUC {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;


        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.lblOverview = new System.Windows.Forms.Label();
            this.cmbChooseAccount = new System.Windows.Forms.ComboBox();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblAccountNumber = new System.Windows.Forms.Label();
            this.lblAccountName = new System.Windows.Forms.Label();
            this.lstTransactions = new System.Windows.Forms.ListBox();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.pnlCard = new System.Windows.Forms.Panel();
            this.hasCard1 = new OO_Bank.User_Controls.Overview.HasCard();
            this.noCard1 = new OO_Bank.User_Controls.Overview.NoCard();
            this.pnlInfo.SuspendLayout();
            this.pnlCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblOverview
            // 
            this.lblOverview.AutoSize = true;
            this.lblOverview.Font = new System.Drawing.Font("Century Gothic", 32.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOverview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.lblOverview.Location = new System.Drawing.Point(28, 21);
            this.lblOverview.Name = "lblOverview";
            this.lblOverview.Size = new System.Drawing.Size(228, 52);
            this.lblOverview.TabIndex = 3;
            this.lblOverview.Text = "Overview";
            // 
            // cmbChooseAccount
            // 
            this.cmbChooseAccount.BackColor = System.Drawing.Color.White;
            this.cmbChooseAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbChooseAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChooseAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbChooseAccount.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbChooseAccount.FormattingEnabled = true;
            this.cmbChooseAccount.Location = new System.Drawing.Point(725, 21);
            this.cmbChooseAccount.Name = "cmbChooseAccount";
            this.cmbChooseAccount.Size = new System.Drawing.Size(161, 29);
            this.cmbChooseAccount.TabIndex = 4;
            this.cmbChooseAccount.TabStop = false;
            this.cmbChooseAccount.SelectedIndexChanged += new System.EventHandler(this.CmbChooseAccount_SelectedIndexChanged);
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.lblBalance.Location = new System.Drawing.Point(13, 94);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(119, 30);
            this.lblBalance.TabIndex = 5;
            this.lblBalance.Text = "Balance:";
            // 
            // lblAccountNumber
            // 
            this.lblAccountNumber.AutoSize = true;
            this.lblAccountNumber.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.lblAccountNumber.Location = new System.Drawing.Point(13, 53);
            this.lblAccountNumber.Name = "lblAccountNumber";
            this.lblAccountNumber.Size = new System.Drawing.Size(226, 30);
            this.lblAccountNumber.TabIndex = 6;
            this.lblAccountNumber.Text = "Account Number:";
            // 
            // lblAccountName
            // 
            this.lblAccountName.AutoSize = true;
            this.lblAccountName.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.lblAccountName.Location = new System.Drawing.Point(13, 12);
            this.lblAccountName.Name = "lblAccountName";
            this.lblAccountName.Size = new System.Drawing.Size(204, 30);
            this.lblAccountName.TabIndex = 7;
            this.lblAccountName.Text = "Account Name:";
            // 
            // lstTransactions
            // 
            this.lstTransactions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.lstTransactions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstTransactions.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstTransactions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.lstTransactions.FormattingEnabled = true;
            this.lstTransactions.ItemHeight = 17;
            this.lstTransactions.Location = new System.Drawing.Point(465, 106);
            this.lstTransactions.Name = "lstTransactions";
            this.lstTransactions.Size = new System.Drawing.Size(421, 529);
            this.lstTransactions.TabIndex = 9;
            // 
            // pnlInfo
            // 
            this.pnlInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInfo.Controls.Add(this.pnlCard);
            this.pnlInfo.Controls.Add(this.lblAccountName);
            this.pnlInfo.Controls.Add(this.lblAccountNumber);
            this.pnlInfo.Controls.Add(this.lblBalance);
            this.pnlInfo.Location = new System.Drawing.Point(15, 106);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(444, 530);
            this.pnlInfo.TabIndex = 10;
            // 
            // pnlCard
            // 
            this.pnlCard.Controls.Add(this.hasCard1);
            this.pnlCard.Controls.Add(this.noCard1);
            this.pnlCard.Location = new System.Drawing.Point(19, 208);
            this.pnlCard.Name = "pnlCard";
            this.pnlCard.Size = new System.Drawing.Size(405, 302);
            this.pnlCard.TabIndex = 8;
            // 
            // hasCard1
            // 
            this.hasCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.hasCard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hasCard1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hasCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.hasCard1.Location = new System.Drawing.Point(0, 0);
            this.hasCard1.Margin = new System.Windows.Forms.Padding(5);
            this.hasCard1.MaximumSize = new System.Drawing.Size(405, 302);
            this.hasCard1.MinimumSize = new System.Drawing.Size(405, 302);
            this.hasCard1.Name = "hasCard1";
            this.hasCard1.Size = new System.Drawing.Size(405, 302);
            this.hasCard1.TabIndex = 0;
            // 
            // noCard1
            // 
            this.noCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.noCard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.noCard1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.noCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.noCard1.Location = new System.Drawing.Point(0, 0);
            this.noCard1.Margin = new System.Windows.Forms.Padding(5);
            this.noCard1.MaximumSize = new System.Drawing.Size(405, 302);
            this.noCard1.MinimumSize = new System.Drawing.Size(405, 302);
            this.noCard1.Name = "noCard1";
            this.noCard1.Size = new System.Drawing.Size(405, 302);
            this.noCard1.TabIndex = 1;
            // 
            // OverviewUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.pnlInfo);
            this.Controls.Add(this.lstTransactions);
            this.Controls.Add(this.cmbChooseAccount);
            this.Controls.Add(this.lblOverview);
            this.Name = "OverviewUC";
            this.Size = new System.Drawing.Size(900, 650);
            this.Load += new System.EventHandler(this.OverviewUC_Load);
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            this.pnlCard.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblOverview;
        private System.Windows.Forms.ComboBox cmbChooseAccount;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblAccountNumber;
        private System.Windows.Forms.Label lblAccountName;
        private System.Windows.Forms.ListBox lstTransactions;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.Panel pnlCard;
        private Overview.NoCard noCard1;
        private Overview.HasCard hasCard1;
    }
}