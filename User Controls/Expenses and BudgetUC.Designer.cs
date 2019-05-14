namespace OO_Bank.User_Controls {
    partial class Expenses_and_BudgetUC {
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
            this.lblExpensesAndBudget = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblExpensesAndBudget
            // 
            this.lblExpensesAndBudget.AutoSize = true;
            this.lblExpensesAndBudget.Font = new System.Drawing.Font("Century Gothic", 32.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpensesAndBudget.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.lblExpensesAndBudget.Location = new System.Drawing.Point(32, 30);
            this.lblExpensesAndBudget.Name = "lblExpensesAndBudget";
            this.lblExpensesAndBudget.Size = new System.Drawing.Size(471, 52);
            this.lblExpensesAndBudget.TabIndex = 4;
            this.lblExpensesAndBudget.Text = "Expenses and Budget";
            // 
            // Expenses_and_BudgetUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.lblExpensesAndBudget);
            this.Name = "Expenses_and_BudgetUC";
            this.Size = new System.Drawing.Size(900, 650);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblExpensesAndBudget;
    }
}
