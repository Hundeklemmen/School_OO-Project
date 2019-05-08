namespace OO_Bank.Forms {
    partial class FormYesNo {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormYesNo));
            this.lblCustomMessage = new System.Windows.Forms.Label();
            this.pnlBorder = new System.Windows.Forms.Panel();
            this.btnNo = new System.Windows.Forms.Button();
            this.btnYes = new System.Windows.Forms.Button();
            this.lblExit = new System.Windows.Forms.Label();
            this.pnlBorder.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCustomMessage
            // 
            this.lblCustomMessage.AutoSize = true;
            this.lblCustomMessage.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.lblCustomMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.lblCustomMessage.Location = new System.Drawing.Point(38, 19);
            this.lblCustomMessage.Name = "lblCustomMessage";
            this.lblCustomMessage.Size = new System.Drawing.Size(225, 31);
            this.lblCustomMessage.TabIndex = 5;
            this.lblCustomMessage.Text = "Custom Message";
            this.lblCustomMessage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveForm_MouseDown);
            this.lblCustomMessage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MoveForm_MouseMove);
            this.lblCustomMessage.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MoveForm_MouseUp);
            // 
            // pnlBorder
            // 
            this.pnlBorder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBorder.Controls.Add(this.btnNo);
            this.pnlBorder.Controls.Add(this.btnYes);
            this.pnlBorder.Controls.Add(this.lblExit);
            this.pnlBorder.Controls.Add(this.lblCustomMessage);
            this.pnlBorder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBorder.Location = new System.Drawing.Point(0, 0);
            this.pnlBorder.Name = "pnlBorder";
            this.pnlBorder.Size = new System.Drawing.Size(529, 332);
            this.pnlBorder.TabIndex = 6;
            this.pnlBorder.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveForm_MouseDown);
            this.pnlBorder.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MoveForm_MouseMove);
            this.pnlBorder.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MoveForm_MouseUp);
            // 
            // btnNo
            // 
            this.btnNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.btnNo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.btnNo.FlatAppearance.BorderSize = 3;
            this.btnNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNo.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNo.ForeColor = System.Drawing.Color.White;
            this.btnNo.Location = new System.Drawing.Point(335, 231);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(142, 67);
            this.btnNo.TabIndex = 30;
            this.btnNo.Text = "No";
            this.btnNo.UseVisualStyleBackColor = false;
            this.btnNo.Click += new System.EventHandler(this.BtnNo_Click);
            // 
            // btnYes
            // 
            this.btnYes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.btnYes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnYes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.btnYes.FlatAppearance.BorderSize = 3;
            this.btnYes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYes.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYes.ForeColor = System.Drawing.Color.White;
            this.btnYes.Location = new System.Drawing.Point(44, 231);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(142, 67);
            this.btnYes.TabIndex = 29;
            this.btnYes.Text = "Yes";
            this.btnYes.UseVisualStyleBackColor = false;
            this.btnYes.Click += new System.EventHandler(this.BtnYes_Click);
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.lblExit.Location = new System.Drawing.Point(494, 2);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(32, 31);
            this.lblExit.TabIndex = 25;
            this.lblExit.Text = "X";
            this.lblExit.Click += new System.EventHandler(this.LblExit_Click);
            // 
            // FormYesNo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(529, 332);
            this.Controls.Add(this.pnlBorder);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormYesNo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormCreationSuccess";
            this.pnlBorder.ResumeLayout(false);
            this.pnlBorder.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCustomMessage;
        private System.Windows.Forms.Panel pnlBorder;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.Button btnNo;
        private System.Windows.Forms.Button btnYes;
    }
}