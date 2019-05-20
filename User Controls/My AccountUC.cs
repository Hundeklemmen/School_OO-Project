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

        //Bruges til at opdatere user info
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
            lblOverallBalance.Text = "Overall Balance: " + Utils.BalanceFormatted(OverallSaldo);
        }

        //Hvis der klikkes på navn for at ændre det
        private void LblName_Click(object sender, EventArgs e) {
            FormTextInput inputBox = new FormTextInput("Enter new name: ");
            if(inputBox.DialogResult == DialogResult.OK) {
                if (inputBox.Message.Length == 0 || inputBox.Message == "Full name") {
                    Utils.Shake(Settings.FormMain);
                } else {
                    //Sæt og gem nye navn
                    Settings.CurrentUser.Name = inputBox.Message;
                    Settings.CurrentUser.Save();
                    UpdateInfo();
                    new FormMessage("Your name has been changed!");
                }
            }
        }

        //Hvis der klikkes på password for at ændre det
        private void LblPassword_Click(object sender, EventArgs e) {
            ChangePassword("Enter new password: ");
        }
        private void ChangePassword(String title) {
            FormTextInput inputBox = new FormTextInput(title);
            if (inputBox.DialogResult == DialogResult.OK) {
                //Tjekker for krav
                if (inputBox.Message.Length < 8 || inputBox.Message == "Password") {
                    inputBox.Hide(); 
                    ChangePassword("Enter new password: Please try again");
                } else {
                    //Sæt og gem nye password
                    Settings.CurrentUser.Password = Utils.CalculateMD5Hash(inputBox.Message);
                    Settings.CurrentUser.Save();
                    UpdateInfo();
                    new FormMessage("Your password has been changed!");
                }
            }
        }

        //Hvis der klikkes på email for at ændre det
        private void LblEmail_Click(object sender, EventArgs e) {
            FormTextInput inputBox = new FormTextInput("Enter new email: ");
            if (inputBox.DialogResult == DialogResult.OK) {
                //Tjekker for krav
                if (!Utils.IsValidEmail(inputBox.Message)) {
                    Utils.Shake(Settings.FormMain);
                } else {
                    //Sæt og gem nye email
                    Settings.CurrentUser.Email = inputBox.Message;
                    Settings.CurrentUser.Save();
                    UpdateInfo();
                    new FormMessage("Your Email has been changed!");
                }
            }
        }

        //Hvis der klikkes på mobil nummer for at ændre det
        private void LblMobile_Click(object sender, EventArgs e) {
            FormTextInput inputBox = new FormTextInput("Enter new mobile: ");
            if (inputBox.DialogResult == DialogResult.OK) {
                //Tjekker for krav
                if (inputBox.Message.Length != 8 || inputBox.Message == "Mobile" || !inputBox.Message.All(char.IsDigit)) {
                    Utils.Shake(Settings.FormMain);
                } else {
                    //Sæt og gem nye mobil nummer
                    Settings.CurrentUser.Mobile = inputBox.Message;
                    Settings.CurrentUser.Save();
                    UpdateInfo();

                }
            }
        }

        //Hvis bruger vil fjerne konto
        private void BtnDeleteAccount_Click(object sender, EventArgs e) {
            //Bekræft
            FormYesNo ConfirmDelete = new FormYesNo("Confirm deletion of account");
            if (ConfirmDelete.DialogResult == DialogResult.Yes) {
                //Fjern konto
                FormMessage InfoMessage = new FormMessage("You've successfully deleted your account!");
                File.Delete(Settings.UsersPath + "/" + Settings.CurrentUser.ID + ".json");
                //Start ny start form
                var t = new Thread(() => Application.Run(new FormLogSign()));
                t.Start();
                Application.OpenForms["FormMain"].Close();
            }
        }

        //Hvis bruger vil have alt konto info
        private void BtnCollectAccInfo_Click(object sender, EventArgs e) {
            FormYesNo confirmCollection = new FormYesNo("Would you like to save all\naccount information?");
            if(confirmCollection.DialogResult == DialogResult.Yes) {
                try {
                    //Tjekker om fil eksisterer
                    if(File.Exists(@Settings.AccountInfoPath + "/Account info for ID " + Settings.CurrentUser.ID + ".json")) {
                        //Fjerner fil så vi kan erstatte den
                        File.Delete(@Settings.AccountInfoPath + "/Account info for ID " + Settings.CurrentUser.ID + ".json");
                    }
                    //Kopierer fil på personen
                    File.Copy(@Settings.UsersPath + "/" + Settings.CurrentUser.ID + ".json", @Settings.AccountInfoPath + "/Account info for ID " + Settings.CurrentUser.ID + ".json");
                    new FormMessage("File has been saved in the\nOOProject file");
                //Hvis noget går galt
                } catch (Exception) {
                    new FormMessage("Something went wrong whilst\ntrying to save the file");
                    Utils.Shake(Settings.FormMain);
                }
            }
        }
    }
}