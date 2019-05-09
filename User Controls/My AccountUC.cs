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
using System.Threading;
using OO_Bank.Forms;
using System.IO;

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
                if (inputBox.Message.Length == 0 || inputBox.Message == "Full name") {

                } else {
                    Settings.CurrentUser.Name = inputBox.Message;
                    Settings.CurrentUser.Save();
                    UpdateInfo();
                }
            }
        }

        private void LblPassword_Click(object sender, EventArgs e) {
            ChangePassword("Enter new password: ");
        }
        private void ChangePassword(String title) {
            FormTextInput inputBox = new FormTextInput(title);
            if (inputBox.DialogResult == DialogResult.OK) {
                if (inputBox.Message.Length < 8 || inputBox.Message == "Password") {
                    inputBox.Hide(); 
                    ChangePassword("Enter new password: Please try again");
                } else {
                    Settings.CurrentUser.Password = Utils.CalculateMD5Hash(inputBox.Message);
                    Settings.CurrentUser.Save();
                    UpdateInfo();
                    _ = new FormMessage("Your password has been changed!");
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
                if (inputBox.Message.Length != 8 || inputBox.Message == "Mobile" || !inputBox.Message.All(char.IsDigit)) {

                } else {
                    Settings.CurrentUser.Mobile = inputBox.Message;
                    Settings.CurrentUser.Save();
                    UpdateInfo();

                }
            }
        }

        private void BtnDeleteAccount_Click(object sender, EventArgs e) {
            FormYesNo ConfirmDelete = new FormYesNo("Confirm deletion of account");
            if (ConfirmDelete.DialogResult == DialogResult.Yes) {
                FormMessage InfoMessage = new FormMessage("You've successfully deleted your account!");
                File.Delete(Settings.UsersPath + "/" + Settings.CurrentUser.ID + ".json");
                var t = new Thread(() => Application.Run(new FormLogSign()));
                t.Start();
                Application.OpenForms["FormMain"].Close();
            }
        }

        private void BtnCollectAccInfo_Click(object sender, EventArgs e) {
            FormYesNo confirmCollection = new FormYesNo("Would you like to save all\naccount information?");
            if(confirmCollection.DialogResult == DialogResult.Yes) {
                try {
                    //Checking if file exists..
                    if(File.Exists(@Settings.AccountInfoPath + "/Account info for ID " + Settings.CurrentUser.ID + ".json")) {
                        //Delete if it does so we can "overwrite" it.
                        File.Delete(@Settings.AccountInfoPath + "/Account info for ID " + Settings.CurrentUser.ID + ".json");
                    }
                    File.Copy(@Settings.UsersPath + "/" + Settings.CurrentUser.ID + ".json", @Settings.AccountInfoPath + "/Account info for ID " + Settings.CurrentUser.ID + ".json");
                    new FormMessage("File has been saved in the\nOOProject file");
                } catch (Exception) {
                    new FormMessage("Something went wrong whilst\ntrying to save the file");
                }
            }
        }
    }
}