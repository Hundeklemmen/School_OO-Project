namespace OO_Bank.User_Controls {
    partial class Pay_and_TransferUC {
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
            this.lblPayAndTransfer = new System.Windows.Forms.Label();
            this.cmbFromAccount = new System.Windows.Forms.ComboBox();
            this.cmbToAccount = new System.Windows.Forms.ComboBox();
            this.txtAmountOwn = new System.Windows.Forms.TextBox();
            this.pnlAmountOwn = new System.Windows.Forms.Panel();
            this.lblToOwn = new System.Windows.Forms.Label();
            this.lblFromOwn = new System.Windows.Forms.Label();
            this.lblFromOther = new System.Windows.Forms.Label();
            this.pnlAmountOther = new System.Windows.Forms.Panel();
            this.txtAmountOther = new System.Windows.Forms.TextBox();
            this.cmbFromOther = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlRecipient = new System.Windows.Forms.Panel();
            this.txtRecipient = new System.Windows.Forms.TextBox();
            this.btnConfirm1 = new System.Windows.Forms.Button();
            this.btnConfirm2 = new System.Windows.Forms.Button();
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblFrom2 = new System.Windows.Forms.Label();
            this.lblTo2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPayAndTransfer
            // 
            this.lblPayAndTransfer.AutoSize = true;
            this.lblPayAndTransfer.Font = new System.Drawing.Font("Century Gothic", 32.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayAndTransfer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.lblPayAndTransfer.Location = new System.Drawing.Point(23, 23);
            this.lblPayAndTransfer.Name = "lblPayAndTransfer";
            this.lblPayAndTransfer.Size = new System.Drawing.Size(366, 52);
            this.lblPayAndTransfer.TabIndex = 4;
            this.lblPayAndTransfer.Text = "Pay and Transfer";
            // 
            // cmbFromAccount
            // 
            this.cmbFromAccount.BackColor = System.Drawing.Color.White;
            this.cmbFromAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbFromAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFromAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbFromAccount.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFromAccount.FormattingEnabled = true;
            this.cmbFromAccount.Items.AddRange(new object[] {
            "From"});
            this.cmbFromAccount.Location = new System.Drawing.Point(47, 243);
            this.cmbFromAccount.Name = "cmbFromAccount";
            this.cmbFromAccount.Size = new System.Drawing.Size(161, 29);
            this.cmbFromAccount.TabIndex = 5;
            this.cmbFromAccount.TabStop = false;
            this.cmbFromAccount.SelectedIndexChanged += new System.EventHandler(this.CmbFromAccount_SelectedIndexChanged);
            // 
            // cmbToAccount
            // 
            this.cmbToAccount.BackColor = System.Drawing.Color.White;
            this.cmbToAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbToAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbToAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbToAccount.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbToAccount.FormattingEnabled = true;
            this.cmbToAccount.Items.AddRange(new object[] {
            "To"});
            this.cmbToAccount.Location = new System.Drawing.Point(243, 243);
            this.cmbToAccount.Name = "cmbToAccount";
            this.cmbToAccount.Size = new System.Drawing.Size(161, 29);
            this.cmbToAccount.TabIndex = 6;
            this.cmbToAccount.TabStop = false;
            this.cmbToAccount.SelectedIndexChanged += new System.EventHandler(this.CmbToAccount_SelectedIndexChanged);
            // 
            // txtAmountOwn
            // 
            this.txtAmountOwn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.txtAmountOwn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAmountOwn.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmountOwn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.txtAmountOwn.Location = new System.Drawing.Point(47, 320);
            this.txtAmountOwn.Name = "txtAmountOwn";
            this.txtAmountOwn.Size = new System.Drawing.Size(357, 41);
            this.txtAmountOwn.TabIndex = 7;
            // 
            // pnlAmountOwn
            // 
            this.pnlAmountOwn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.pnlAmountOwn.ForeColor = System.Drawing.Color.White;
            this.pnlAmountOwn.Location = new System.Drawing.Point(47, 369);
            this.pnlAmountOwn.Name = "pnlAmountOwn";
            this.pnlAmountOwn.Size = new System.Drawing.Size(357, 10);
            this.pnlAmountOwn.TabIndex = 8;
            // 
            // lblToOwn
            // 
            this.lblToOwn.AutoSize = true;
            this.lblToOwn.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToOwn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.lblToOwn.Location = new System.Drawing.Point(239, 280);
            this.lblToOwn.Name = "lblToOwn";
            this.lblToOwn.Size = new System.Drawing.Size(124, 24);
            this.lblToOwn.TabIndex = 9;
            this.lblToOwn.Text = "To Balance";
            // 
            // lblFromOwn
            // 
            this.lblFromOwn.AutoSize = true;
            this.lblFromOwn.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFromOwn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.lblFromOwn.Location = new System.Drawing.Point(43, 280);
            this.lblFromOwn.Name = "lblFromOwn";
            this.lblFromOwn.Size = new System.Drawing.Size(153, 24);
            this.lblFromOwn.TabIndex = 10;
            this.lblFromOwn.Text = "From Balance";
            // 
            // lblFromOther
            // 
            this.lblFromOther.AutoSize = true;
            this.lblFromOther.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFromOther.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.lblFromOther.Location = new System.Drawing.Point(494, 280);
            this.lblFromOther.Name = "lblFromOther";
            this.lblFromOther.Size = new System.Drawing.Size(153, 24);
            this.lblFromOther.TabIndex = 15;
            this.lblFromOther.Text = "From Balance";
            // 
            // pnlAmountOther
            // 
            this.pnlAmountOther.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.pnlAmountOther.ForeColor = System.Drawing.Color.White;
            this.pnlAmountOther.Location = new System.Drawing.Point(498, 369);
            this.pnlAmountOther.Name = "pnlAmountOther";
            this.pnlAmountOther.Size = new System.Drawing.Size(357, 10);
            this.pnlAmountOther.TabIndex = 14;
            // 
            // txtAmountOther
            // 
            this.txtAmountOther.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.txtAmountOther.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAmountOther.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmountOther.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.txtAmountOther.Location = new System.Drawing.Point(498, 320);
            this.txtAmountOther.Name = "txtAmountOther";
            this.txtAmountOther.Size = new System.Drawing.Size(357, 41);
            this.txtAmountOther.TabIndex = 13;
            // 
            // cmbFromOther
            // 
            this.cmbFromOther.BackColor = System.Drawing.Color.White;
            this.cmbFromOther.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbFromOther.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFromOther.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbFromOther.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFromOther.FormattingEnabled = true;
            this.cmbFromOther.Items.AddRange(new object[] {
            "From"});
            this.cmbFromOther.Location = new System.Drawing.Point(498, 243);
            this.cmbFromOther.Name = "cmbFromOther";
            this.cmbFromOther.Size = new System.Drawing.Size(161, 29);
            this.cmbFromOther.TabIndex = 11;
            this.cmbFromOther.TabStop = false;
            this.cmbFromOther.SelectedIndexChanged += new System.EventHandler(this.CmbFromOther_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.label3.Location = new System.Drawing.Point(41, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(238, 33);
            this.label3.TabIndex = 17;
            this.label3.Text = "To own accounts";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.label4.Location = new System.Drawing.Point(492, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(265, 33);
            this.label4.TabIndex = 18;
            this.label4.Text = "To others\' accounts";
            // 
            // pnlRecipient
            // 
            this.pnlRecipient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.pnlRecipient.ForeColor = System.Drawing.Color.White;
            this.pnlRecipient.Location = new System.Drawing.Point(680, 290);
            this.pnlRecipient.Name = "pnlRecipient";
            this.pnlRecipient.Size = new System.Drawing.Size(175, 10);
            this.pnlRecipient.TabIndex = 20;
            // 
            // txtRecipient
            // 
            this.txtRecipient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.txtRecipient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRecipient.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecipient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.txtRecipient.Location = new System.Drawing.Point(680, 243);
            this.txtRecipient.Name = "txtRecipient";
            this.txtRecipient.Size = new System.Drawing.Size(175, 41);
            this.txtRecipient.TabIndex = 19;
            this.txtRecipient.Text = "Acc Number";
            // 
            // btnConfirm1
            // 
            this.btnConfirm1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.btnConfirm1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirm1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.btnConfirm1.FlatAppearance.BorderSize = 3;
            this.btnConfirm1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm1.ForeColor = System.Drawing.Color.White;
            this.btnConfirm1.Location = new System.Drawing.Point(47, 395);
            this.btnConfirm1.Name = "btnConfirm1";
            this.btnConfirm1.Size = new System.Drawing.Size(357, 57);
            this.btnConfirm1.TabIndex = 30;
            this.btnConfirm1.Text = "Confirm";
            this.btnConfirm1.UseVisualStyleBackColor = false;
            this.btnConfirm1.Click += new System.EventHandler(this.BtnConfirm1_Click);
            // 
            // btnConfirm2
            // 
            this.btnConfirm2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.btnConfirm2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirm2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.btnConfirm2.FlatAppearance.BorderSize = 3;
            this.btnConfirm2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm2.ForeColor = System.Drawing.Color.White;
            this.btnConfirm2.Location = new System.Drawing.Point(498, 395);
            this.btnConfirm2.Name = "btnConfirm2";
            this.btnConfirm2.Size = new System.Drawing.Size(357, 57);
            this.btnConfirm2.TabIndex = 31;
            this.btnConfirm2.Text = "Confirm";
            this.btnConfirm2.UseVisualStyleBackColor = false;
            this.btnConfirm2.Click += new System.EventHandler(this.BtnConfirm2_Click);
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.lblFrom.Location = new System.Drawing.Point(41, 207);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(80, 33);
            this.lblFrom.TabIndex = 32;
            this.lblFrom.Text = "From";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.lblTo.Location = new System.Drawing.Point(237, 207);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(44, 33);
            this.lblTo.TabIndex = 33;
            this.lblTo.Text = "To";
            // 
            // lblFrom2
            // 
            this.lblFrom2.AutoSize = true;
            this.lblFrom2.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrom2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.lblFrom2.Location = new System.Drawing.Point(492, 207);
            this.lblFrom2.Name = "lblFrom2";
            this.lblFrom2.Size = new System.Drawing.Size(80, 33);
            this.lblFrom2.TabIndex = 34;
            this.lblFrom2.Text = "From";
            // 
            // lblTo2
            // 
            this.lblTo2.AutoSize = true;
            this.lblTo2.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTo2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.lblTo2.Location = new System.Drawing.Point(674, 207);
            this.lblTo2.Name = "lblTo2";
            this.lblTo2.Size = new System.Drawing.Size(44, 33);
            this.lblTo2.TabIndex = 35;
            this.lblTo2.Text = "To";
            // 
            // Pay_and_TransferUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.lblTo2);
            this.Controls.Add(this.lblFrom2);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.btnConfirm2);
            this.Controls.Add(this.btnConfirm1);
            this.Controls.Add(this.pnlRecipient);
            this.Controls.Add(this.txtRecipient);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblFromOther);
            this.Controls.Add(this.pnlAmountOther);
            this.Controls.Add(this.txtAmountOther);
            this.Controls.Add(this.cmbFromOther);
            this.Controls.Add(this.lblFromOwn);
            this.Controls.Add(this.lblToOwn);
            this.Controls.Add(this.pnlAmountOwn);
            this.Controls.Add(this.txtAmountOwn);
            this.Controls.Add(this.cmbToAccount);
            this.Controls.Add(this.cmbFromAccount);
            this.Controls.Add(this.lblPayAndTransfer);
            this.Name = "Pay_and_TransferUC";
            this.Size = new System.Drawing.Size(900, 650);
            this.Load += new System.EventHandler(this.Pay_and_TransferUC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPayAndTransfer;
        private System.Windows.Forms.ComboBox cmbFromAccount;
        private System.Windows.Forms.ComboBox cmbToAccount;
        private System.Windows.Forms.TextBox txtAmountOwn;
        private System.Windows.Forms.Panel pnlAmountOwn;
        private System.Windows.Forms.Label lblToOwn;
        private System.Windows.Forms.Label lblFromOwn;
        private System.Windows.Forms.Label lblFromOther;
        private System.Windows.Forms.Panel pnlAmountOther;
        private System.Windows.Forms.TextBox txtAmountOther;
        private System.Windows.Forms.ComboBox cmbFromOther;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlRecipient;
        private System.Windows.Forms.TextBox txtRecipient;
        private System.Windows.Forms.Button btnConfirm1;
        private System.Windows.Forms.Button btnConfirm2;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblFrom2;
        private System.Windows.Forms.Label lblTo2;
    }
}
