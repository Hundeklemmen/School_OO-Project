namespace OO_Bank.User_Controls {
    partial class My_AccountUC {
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
            this.lblID = new System.Windows.Forms.Label();
            this.lblMyAccount = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblMobile = new System.Windows.Forms.Label();
            this.lblOverallBalance = new System.Windows.Forms.Label();
            this.btnDeleteAccount = new System.Windows.Forms.Button();
            this.lblClickToUpdate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.lblID.Location = new System.Drawing.Point(32, 115);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(48, 33);
            this.lblID.TabIndex = 3;
            this.lblID.Text = "ID:";
            // 
            // lblMyAccount
            // 
            this.lblMyAccount.AutoSize = true;
            this.lblMyAccount.Font = new System.Drawing.Font("Century Gothic", 32F, System.Drawing.FontStyle.Underline);
            this.lblMyAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.lblMyAccount.Location = new System.Drawing.Point(29, 25);
            this.lblMyAccount.Name = "lblMyAccount";
            this.lblMyAccount.Size = new System.Drawing.Size(278, 52);
            this.lblMyAccount.TabIndex = 4;
            this.lblMyAccount.Text = "My Account";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblName.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.lblName.Location = new System.Drawing.Point(180, 294);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(104, 33);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Name:";
            this.lblName.Click += new System.EventHandler(this.LblName_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPassword.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.lblPassword.Location = new System.Drawing.Point(139, 343);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(251, 33);
            this.lblPassword.TabIndex = 6;
            this.lblPassword.Text = "Password: Hashed";
            this.lblPassword.Click += new System.EventHandler(this.LblPassword_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblEmail.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.lblEmail.Location = new System.Drawing.Point(192, 392);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(92, 33);
            this.lblEmail.TabIndex = 7;
            this.lblEmail.Text = "Email:";
            this.lblEmail.Click += new System.EventHandler(this.LblEmail_Click);
            // 
            // lblMobile
            // 
            this.lblMobile.AutoSize = true;
            this.lblMobile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMobile.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMobile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.lblMobile.Location = new System.Drawing.Point(171, 440);
            this.lblMobile.Name = "lblMobile";
            this.lblMobile.Size = new System.Drawing.Size(113, 33);
            this.lblMobile.TabIndex = 8;
            this.lblMobile.Text = "Mobile:";
            this.lblMobile.Click += new System.EventHandler(this.LblMobile_Click);
            // 
            // lblOverallBalance
            // 
            this.lblOverallBalance.AutoSize = true;
            this.lblOverallBalance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblOverallBalance.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOverallBalance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.lblOverallBalance.Location = new System.Drawing.Point(32, 158);
            this.lblOverallBalance.Name = "lblOverallBalance";
            this.lblOverallBalance.Size = new System.Drawing.Size(234, 33);
            this.lblOverallBalance.TabIndex = 9;
            this.lblOverallBalance.Text = "Overall Balance:";
            // 
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.btnDeleteAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteAccount.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.btnDeleteAccount.FlatAppearance.BorderSize = 3;
            this.btnDeleteAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteAccount.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAccount.ForeColor = System.Drawing.Color.White;
            this.btnDeleteAccount.Location = new System.Drawing.Point(38, 503);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Size = new System.Drawing.Size(246, 113);
            this.btnDeleteAccount.TabIndex = 29;
            this.btnDeleteAccount.Text = "Delete account";
            this.btnDeleteAccount.UseVisualStyleBackColor = false;
            this.btnDeleteAccount.Click += new System.EventHandler(this.BtnDeleteAccount_Click);
            // 
            // lblClickToUpdate
            // 
            this.lblClickToUpdate.AutoSize = true;
            this.lblClickToUpdate.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClickToUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.lblClickToUpdate.Location = new System.Drawing.Point(32, 241);
            this.lblClickToUpdate.Name = "lblClickToUpdate";
            this.lblClickToUpdate.Size = new System.Drawing.Size(561, 33);
            this.lblClickToUpdate.TabIndex = 30;
            this.lblClickToUpdate.Text = "Click The Desired Information To Update It";
            // 
            // My_AccountUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.lblClickToUpdate);
            this.Controls.Add(this.btnDeleteAccount);
            this.Controls.Add(this.lblOverallBalance);
            this.Controls.Add(this.lblMobile);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblMyAccount);
            this.Controls.Add(this.lblID);
            this.Name = "My_AccountUC";
            this.Size = new System.Drawing.Size(900, 650);
            this.Load += new System.EventHandler(this.My_AccountUC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblMyAccount;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblMobile;
        private System.Windows.Forms.Label lblOverallBalance;
        private System.Windows.Forms.Button btnDeleteAccount;
        private System.Windows.Forms.Label lblClickToUpdate;
    }
}
