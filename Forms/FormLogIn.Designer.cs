namespace OO_Bank.User_Controls.Forms {
    partial class FormLogIn {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogIn));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogInConfirm = new System.Windows.Forms.Button();
            this.lblExit = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pnlPassword = new System.Windows.Forms.Panel();
            this.txtPasswordInput = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlAccountID = new System.Windows.Forms.Panel();
            this.txtAccountIDInput = new System.Windows.Forms.TextBox();
            this.lblLogIn = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnLogInConfirm);
            this.panel1.Controls.Add(this.lblExit);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pnlPassword);
            this.panel1.Controls.Add(this.txtPasswordInput);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pnlAccountID);
            this.panel1.Controls.Add(this.txtAccountIDInput);
            this.panel1.Controls.Add(this.lblLogIn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 320);
            this.panel1.TabIndex = 29;
            // 
            // btnLogInConfirm
            // 
            this.btnLogInConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.btnLogInConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogInConfirm.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.btnLogInConfirm.FlatAppearance.BorderSize = 3;
            this.btnLogInConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogInConfirm.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogInConfirm.ForeColor = System.Drawing.Color.White;
            this.btnLogInConfirm.Location = new System.Drawing.Point(105, 219);
            this.btnLogInConfirm.Name = "btnLogInConfirm";
            this.btnLogInConfirm.Size = new System.Drawing.Size(142, 67);
            this.btnLogInConfirm.TabIndex = 28;
            this.btnLogInConfirm.Text = "Log in";
            this.btnLogInConfirm.UseVisualStyleBackColor = false;
            this.btnLogInConfirm.Click += new System.EventHandler(this.BtnLogInConfirm_Click);
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.lblExit.Location = new System.Drawing.Point(314, 6);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(32, 31);
            this.lblExit.TabIndex = 24;
            this.lblExit.Text = "X";
            this.lblExit.Click += new System.EventHandler(this.LblExit_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(27, 160);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // pnlPassword
            // 
            this.pnlPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.pnlPassword.ForeColor = System.Drawing.Color.White;
            this.pnlPassword.Location = new System.Drawing.Point(68, 189);
            this.pnlPassword.Name = "pnlPassword";
            this.pnlPassword.Size = new System.Drawing.Size(250, 5);
            this.pnlPassword.TabIndex = 22;
            // 
            // txtPasswordInput
            // 
            this.txtPasswordInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.txtPasswordInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPasswordInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.txtPasswordInput.ForeColor = System.Drawing.Color.Gray;
            this.txtPasswordInput.Location = new System.Drawing.Point(68, 160);
            this.txtPasswordInput.Name = "txtPasswordInput";
            this.txtPasswordInput.Size = new System.Drawing.Size(250, 31);
            this.txtPasswordInput.TabIndex = 21;
            this.txtPasswordInput.Text = "Password";
            this.txtPasswordInput.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TxtPasswordInput_MouseClick);
            this.txtPasswordInput.TextChanged += new System.EventHandler(this.TxtPasswordInput_TextChanged_1);
            this.txtPasswordInput.Leave += new System.EventHandler(this.TxtPasswordInput_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(27, 107);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // pnlAccountID
            // 
            this.pnlAccountID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.pnlAccountID.ForeColor = System.Drawing.Color.White;
            this.pnlAccountID.Location = new System.Drawing.Point(68, 136);
            this.pnlAccountID.Name = "pnlAccountID";
            this.pnlAccountID.Size = new System.Drawing.Size(250, 5);
            this.pnlAccountID.TabIndex = 19;
            // 
            // txtAccountIDInput
            // 
            this.txtAccountIDInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.txtAccountIDInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAccountIDInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.txtAccountIDInput.ForeColor = System.Drawing.Color.Gray;
            this.txtAccountIDInput.Location = new System.Drawing.Point(68, 107);
            this.txtAccountIDInput.Name = "txtAccountIDInput";
            this.txtAccountIDInput.Size = new System.Drawing.Size(250, 31);
            this.txtAccountIDInput.TabIndex = 17;
            this.txtAccountIDInput.Text = "Account ID";
            this.txtAccountIDInput.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TxtAccountIDInput_MouseClick);
            this.txtAccountIDInput.TextChanged += new System.EventHandler(this.TxtAccountID_TextChanged);
            this.txtAccountIDInput.Leave += new System.EventHandler(this.TxtAccountID_Leave);
            // 
            // lblLogIn
            // 
            this.lblLogIn.AutoSize = true;
            this.lblLogIn.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.lblLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.lblLogIn.Location = new System.Drawing.Point(95, 20);
            this.lblLogIn.Name = "lblLogIn";
            this.lblLogIn.Size = new System.Drawing.Size(155, 55);
            this.lblLogIn.TabIndex = 18;
            this.lblLogIn.Text = "Log in";
            this.lblLogIn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LblLogIn_MouseDown);
            this.lblLogIn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LblLogIn_MouseMove);
            this.lblLogIn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LblLogIn_MouseUp);
            // 
            // FormLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(350, 320);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormLogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log_in";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLogInConfirm;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel pnlPassword;
        private System.Windows.Forms.TextBox txtPasswordInput;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlAccountID;
        private System.Windows.Forms.TextBox txtAccountIDInput;
        private System.Windows.Forms.Label lblLogIn;
    }
}