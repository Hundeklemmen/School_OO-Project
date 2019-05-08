namespace OO_Bank {
    partial class FormMain {
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.pnlSideBar = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.pnlCurrentPage = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAccount = new System.Windows.Forms.Button();
            this.btnPayTransfer = new System.Windows.Forms.Button();
            this.btnExpenseBudget = new System.Windows.Forms.Button();
            this.btnOverview = new System.Windows.Forms.Button();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.lblOOBankLogo = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.overviewUC1 = new OO_Bank.User_Controls.OverviewUC();
            this.expenses_and_BudgetUC1 = new OO_Bank.User_Controls.Expenses_and_BudgetUC();
            this.pay_and_TransferUC1 = new OO_Bank.User_Controls.Pay_and_TransferUC();
            this.my_AccountUC1 = new OO_Bank.User_Controls.My_AccountUC();
            this.pnlSideBar.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSideBar
            // 
            this.pnlSideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.pnlSideBar.Controls.Add(this.btnLogOut);
            this.pnlSideBar.Controls.Add(this.pnlCurrentPage);
            this.pnlSideBar.Controls.Add(this.btnExit);
            this.pnlSideBar.Controls.Add(this.btnAccount);
            this.pnlSideBar.Controls.Add(this.btnPayTransfer);
            this.pnlSideBar.Controls.Add(this.btnExpenseBudget);
            this.pnlSideBar.Controls.Add(this.btnOverview);
            this.pnlSideBar.Controls.Add(this.pnlLogo);
            this.pnlSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSideBar.Location = new System.Drawing.Point(0, 0);
            this.pnlSideBar.Name = "pnlSideBar";
            this.pnlSideBar.Size = new System.Drawing.Size(200, 650);
            this.pnlSideBar.TabIndex = 0;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.btnLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.btnLogOut.Location = new System.Drawing.Point(34, 543);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(128, 45);
            this.btnLogOut.TabIndex = 5;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.BtnLogOut_Click);
            // 
            // pnlCurrentPage
            // 
            this.pnlCurrentPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.pnlCurrentPage.Location = new System.Drawing.Point(0, 120);
            this.pnlCurrentPage.Name = "pnlCurrentPage";
            this.pnlCurrentPage.Size = new System.Drawing.Size(10, 100);
            this.pnlCurrentPage.TabIndex = 2;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExit.Location = new System.Drawing.Point(53, 596);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(88, 45);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // btnAccount
            // 
            this.btnAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.btnAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAccount.FlatAppearance.BorderSize = 0;
            this.btnAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccount.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccount.ForeColor = System.Drawing.Color.White;
            this.btnAccount.Location = new System.Drawing.Point(3, 438);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(194, 100);
            this.btnAccount.TabIndex = 4;
            this.btnAccount.Text = "My Account";
            this.btnAccount.UseVisualStyleBackColor = false;
            this.btnAccount.Click += new System.EventHandler(this.BtnAccount_Click);
            // 
            // btnPayTransfer
            // 
            this.btnPayTransfer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.btnPayTransfer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPayTransfer.FlatAppearance.BorderSize = 0;
            this.btnPayTransfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayTransfer.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayTransfer.ForeColor = System.Drawing.Color.White;
            this.btnPayTransfer.Location = new System.Drawing.Point(3, 332);
            this.btnPayTransfer.Name = "btnPayTransfer";
            this.btnPayTransfer.Size = new System.Drawing.Size(194, 100);
            this.btnPayTransfer.TabIndex = 3;
            this.btnPayTransfer.Text = "Pay and Transfer";
            this.btnPayTransfer.UseVisualStyleBackColor = false;
            this.btnPayTransfer.Click += new System.EventHandler(this.BtnPayTransfer_Click);
            // 
            // btnExpenseBudget
            // 
            this.btnExpenseBudget.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.btnExpenseBudget.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExpenseBudget.FlatAppearance.BorderSize = 0;
            this.btnExpenseBudget.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExpenseBudget.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpenseBudget.ForeColor = System.Drawing.Color.White;
            this.btnExpenseBudget.Location = new System.Drawing.Point(3, 226);
            this.btnExpenseBudget.Name = "btnExpenseBudget";
            this.btnExpenseBudget.Size = new System.Drawing.Size(194, 100);
            this.btnExpenseBudget.TabIndex = 2;
            this.btnExpenseBudget.Text = "Expenses and Budget";
            this.btnExpenseBudget.UseVisualStyleBackColor = false;
            this.btnExpenseBudget.Click += new System.EventHandler(this.BtnExpenseBudget_Click);
            // 
            // btnOverview
            // 
            this.btnOverview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.btnOverview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOverview.FlatAppearance.BorderSize = 0;
            this.btnOverview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOverview.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOverview.ForeColor = System.Drawing.Color.White;
            this.btnOverview.Location = new System.Drawing.Point(3, 120);
            this.btnOverview.Name = "btnOverview";
            this.btnOverview.Size = new System.Drawing.Size(194, 100);
            this.btnOverview.TabIndex = 1;
            this.btnOverview.Text = "Overview";
            this.btnOverview.UseVisualStyleBackColor = false;
            this.btnOverview.Click += new System.EventHandler(this.BtnOverview_Click);
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.pnlLogo.Controls.Add(this.lblOOBankLogo);
            this.pnlLogo.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(200, 120);
            this.pnlLogo.TabIndex = 0;
            this.pnlLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnlLogo_MouseDown);
            this.pnlLogo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PnlLogo_MouseMove);
            this.pnlLogo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PnlLogo_MouseUp);
            // 
            // lblOOBankLogo
            // 
            this.lblOOBankLogo.AutoSize = true;
            this.lblOOBankLogo.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOOBankLogo.ForeColor = System.Drawing.Color.White;
            this.lblOOBankLogo.Location = new System.Drawing.Point(52, 20);
            this.lblOOBankLogo.Name = "lblOOBankLogo";
            this.lblOOBankLogo.Size = new System.Drawing.Size(95, 76);
            this.lblOOBankLogo.TabIndex = 0;
            this.lblOOBankLogo.Text = "OO\r\nBank\r\n";
            this.lblOOBankLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblOOBankLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnlLogo_MouseDown);
            this.lblOOBankLogo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PnlLogo_MouseMove);
            this.lblOOBankLogo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PnlLogo_MouseUp);
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.overviewUC1);
            this.pnlMain.Controls.Add(this.expenses_and_BudgetUC1);
            this.pnlMain.Controls.Add(this.pay_and_TransferUC1);
            this.pnlMain.Controls.Add(this.my_AccountUC1);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(200, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(900, 650);
            this.pnlMain.TabIndex = 1;
            // 
            // overviewUC1
            // 
            this.overviewUC1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.overviewUC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.overviewUC1.Location = new System.Drawing.Point(0, 0);
            this.overviewUC1.Name = "overviewUC1";
            this.overviewUC1.Size = new System.Drawing.Size(900, 650);
            this.overviewUC1.TabIndex = 3;
            // 
            // expenses_and_BudgetUC1
            // 
            this.expenses_and_BudgetUC1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.expenses_and_BudgetUC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.expenses_and_BudgetUC1.Location = new System.Drawing.Point(0, 0);
            this.expenses_and_BudgetUC1.Name = "expenses_and_BudgetUC1";
            this.expenses_and_BudgetUC1.Size = new System.Drawing.Size(900, 650);
            this.expenses_and_BudgetUC1.TabIndex = 1;
            // 
            // pay_and_TransferUC1
            // 
            this.pay_and_TransferUC1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.pay_and_TransferUC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pay_and_TransferUC1.Location = new System.Drawing.Point(0, 0);
            this.pay_and_TransferUC1.Name = "pay_and_TransferUC1";
            this.pay_and_TransferUC1.Size = new System.Drawing.Size(900, 650);
            this.pay_and_TransferUC1.TabIndex = 2;
            // 
            // my_AccountUC1
            // 
            this.my_AccountUC1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.my_AccountUC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.my_AccountUC1.Location = new System.Drawing.Point(0, 0);
            this.my_AccountUC1.Name = "my_AccountUC1";
            this.my_AccountUC1.Size = new System.Drawing.Size(900, 650);
            this.my_AccountUC1.TabIndex = 3;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1100, 650);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlSideBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1100, 650);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1100, 650);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OO Bank";
            this.pnlSideBar.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            this.pnlLogo.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSideBar;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Button btnOverview;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAccount;
        private System.Windows.Forms.Button btnPayTransfer;
        private System.Windows.Forms.Button btnExpenseBudget;
        private System.Windows.Forms.Panel pnlCurrentPage;
        private System.Windows.Forms.Panel pnlMain;
        private User_Controls.Expenses_and_BudgetUC expenses_and_BudgetUC1;
        private User_Controls.My_AccountUC my_AccountUC1;
        private User_Controls.Pay_and_TransferUC pay_and_TransferUC1;
        private System.Windows.Forms.Label lblOOBankLogo;
        private User_Controls.OverviewUC overviewUC1;
        private System.Windows.Forms.Button btnLogOut;
    }
}

