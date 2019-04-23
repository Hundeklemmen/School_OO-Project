namespace OO_Bank.User_Controls.Overview {
    partial class HasCard {
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
            this.lblCard = new System.Windows.Forms.Label();
            this.lblExpireDate = new System.Windows.Forms.Label();
            this.lblSecurityNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCard
            // 
            this.lblCard.AutoSize = true;
            this.lblCard.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.lblCard.Location = new System.Drawing.Point(-6, 11);
            this.lblCard.Name = "lblCard";
            this.lblCard.Size = new System.Drawing.Size(79, 30);
            this.lblCard.TabIndex = 6;
            this.lblCard.Text = "Card:";
            // 
            // lblExpireDate
            // 
            this.lblExpireDate.AutoSize = true;
            this.lblExpireDate.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpireDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.lblExpireDate.Location = new System.Drawing.Point(-5, 51);
            this.lblExpireDate.Name = "lblExpireDate";
            this.lblExpireDate.Size = new System.Drawing.Size(155, 30);
            this.lblExpireDate.TabIndex = 7;
            this.lblExpireDate.Text = "Expire Date:";
            // 
            // lblSecurityNumber
            // 
            this.lblSecurityNumber.AutoSize = true;
            this.lblSecurityNumber.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecurityNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.lblSecurityNumber.Location = new System.Drawing.Point(-6, 91);
            this.lblSecurityNumber.Name = "lblSecurityNumber";
            this.lblSecurityNumber.Size = new System.Drawing.Size(216, 30);
            this.lblSecurityNumber.TabIndex = 8;
            this.lblSecurityNumber.Text = "Security Number:";
            // 
            // HasCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.lblSecurityNumber);
            this.Controls.Add(this.lblExpireDate);
            this.Controls.Add(this.lblCard);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MaximumSize = new System.Drawing.Size(405, 302);
            this.MinimumSize = new System.Drawing.Size(405, 302);
            this.Name = "HasCard";
            this.Size = new System.Drawing.Size(405, 302);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCard;
        private System.Windows.Forms.Label lblExpireDate;
        private System.Windows.Forms.Label lblSecurityNumber;
    }
}
