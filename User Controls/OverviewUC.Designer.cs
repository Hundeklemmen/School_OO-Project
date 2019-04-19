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
            this.lblLoggedInOverview = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblLoggedInOverview
            // 
            this.lblLoggedInOverview.AutoSize = true;
            this.lblLoggedInOverview.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoggedInOverview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.lblLoggedInOverview.Location = new System.Drawing.Point(3, 0);
            this.lblLoggedInOverview.Name = "lblLoggedInOverview";
            this.lblLoggedInOverview.Size = new System.Drawing.Size(299, 73);
            this.lblLoggedInOverview.TabIndex = 3;
            this.lblLoggedInOverview.Text = "Overview";
            // 
            // OverviewUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.lblLoggedInOverview);
            this.Name = "OverviewUC";
            this.Size = new System.Drawing.Size(900, 650);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLoggedInOverview;
    }
}
