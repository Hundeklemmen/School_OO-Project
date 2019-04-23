namespace OO_Bank.User_Controls.Overview {
    partial class NoCard {
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
            this.btnRegisterCreditCard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRegisterCreditCard
            // 
            this.btnRegisterCreditCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.btnRegisterCreditCard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegisterCreditCard.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.btnRegisterCreditCard.FlatAppearance.BorderSize = 3;
            this.btnRegisterCreditCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegisterCreditCard.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisterCreditCard.ForeColor = System.Drawing.Color.White;
            this.btnRegisterCreditCard.Location = new System.Drawing.Point(54, 77);
            this.btnRegisterCreditCard.Name = "btnRegisterCreditCard";
            this.btnRegisterCreditCard.Size = new System.Drawing.Size(292, 127);
            this.btnRegisterCreditCard.TabIndex = 5;
            this.btnRegisterCreditCard.Text = "Register credit card";
            this.btnRegisterCreditCard.UseVisualStyleBackColor = false;
            this.btnRegisterCreditCard.Click += new System.EventHandler(this.BtnRegisterCreditCard_Click);
            // 
            // NoCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.btnRegisterCreditCard);
            this.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximumSize = new System.Drawing.Size(405, 302);
            this.MinimumSize = new System.Drawing.Size(405, 302);
            this.Name = "NoCard";
            this.Size = new System.Drawing.Size(405, 302);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegisterCreditCard;
    }
}
