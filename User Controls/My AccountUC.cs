using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OO_Bank.Classes;
using OO_Bank.Forms.Custom_Messages;

namespace OO_Bank.User_Controls {
    public partial class My_AccountUC : UserControl {
        public My_AccountUC() {
            InitializeComponent();
        }

        private void My_AccountUC_Load(object sender, EventArgs e) {
            try {
                UpdateInfo();
            } catch (NullReferenceException) {
                
            }
        }

        private void UpdateInfo() {
            User user = Settings.CurrentUser;
            lblID.Text = "ID: " + user.ID;
            lblName.Text = "Name: " + user.Name;
            lblEmail.Text = "Email: " + user.Email;
            lblMobile.Text = "Mobile: " + user.Mobile;

            decimal OverallSaldo = 0.0m;
            foreach (Account account in user.Accounts) {
                OverallSaldo += account.balance;
            }
            lblOverallBalance.Text = "Overall Balance: " + String.Format("{0:c}", OverallSaldo);
        }

        private void LblName_Click(object sender, EventArgs e) {
            FormTextInput inputBox = new FormTextInput("Enter new name: ");
            if(inputBox.DialogResult == DialogResult.OK) {
                Settings.CurrentUser.Name = inputBox.Message;
                Settings.CurrentUser.Save();
                UpdateInfo();
            }
        }

        private void LblPassword_Click(object sender, EventArgs e) {
            FormTextInput inputBox = new FormTextInput("Enter new password: ");
            if (inputBox.DialogResult == DialogResult.OK) {
                if (inputBox.Message.Length < 8 || inputBox.Message == "Password") {
                    Utils.Shake();
                } else {
                    Settings.CurrentUser.Password = Utils.CalculateMD5Hash(inputBox.Message);
                    Settings.CurrentUser.Save();
                    UpdateInfo();
                    MessageBox.Show("TEST: GEMT");
                }
            }
        }

        private void LblEmail_Click(object sender, EventArgs e) {
            FormTextInput inputBox = new FormTextInput("Enter new email: ");
            if (inputBox.DialogResult == DialogResult.OK) {
                if (!Utils.IsValidEmail(inputBox.Message)) {

                } else {
                    Settings.CurrentUser.Email = inputBox.Message;
                    Settings.CurrentUser.Save();
                    UpdateInfo();
                }
            }
        }

        private void LblMobile_Click(object sender, EventArgs e) {
            FormTextInput inputBox = new FormTextInput("Enter new mobile: ");
            if (inputBox.DialogResult == DialogResult.OK) {
                Settings.CurrentUser.Mobile = inputBox.Message;
                Settings.CurrentUser.Save();
                UpdateInfo();
            }
        }

        private void BtnDeleteAccount_Click(object sender, EventArgs e) {
            
        }
    }
}
