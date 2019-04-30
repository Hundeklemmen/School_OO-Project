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
    public partial class OverviewUC : UserControl {

        public static User user;
        public static Account account;

        public OverviewUC() {
            InitializeComponent();
            Settings.overviewUC = this;
        }

        private void CmbChooseAccount_SelectedIndexChanged(object sender, EventArgs e) {
            Object selectedItem = cmbChooseAccount.SelectedItem;
            if (selectedItem.ToString().Equals("Create account")) {
                CreateAccount(null);
                return;
            }
            foreach (Account acc in user.Accounts) {
                if (acc.Name.Equals(selectedItem.ToString())) {
                    account = acc;
                    UpdateAccount();
                    return;
                }
            }
        }

        public void CreateAccount(String customMSG) {
            FormTextInput customText;
            if (customMSG != null) {
                customText = new FormTextInput(customMSG);
            } else {
                customText = new FormTextInput("Name of account: ");
            }
            if (customText.DialogResult == DialogResult.OK) {
                //Tjek om brugeren allerede har en account med det navn.
                Boolean exists = false;
                foreach (Account acc in user.Accounts) {
                    if (acc.Name.ToLower().Equals(customText.Message.ToLower())) {
                        exists = true;
                    }
                }
                if (exists == false) {
                    if (!string.IsNullOrWhiteSpace(customText.Message)) {
                        if (customText.Message.Length < 20) {
                            Account newAccount = new Account(Utils.GenerateAccountNumber(), customText.Message, 0.0m, user.ID, null);
                            Settings.CurrentUser.Accounts.Add(newAccount);
                            user = Settings.CurrentUser;
                            user.Save();
                            UpdateList();
                            cmbChooseAccount.SelectedIndex = cmbChooseAccount.Items.IndexOf(newAccount.Name);
                            account = newAccount;
                            UpdateAccount();
                        } else {
                            CreateAccount("Your account name is too long!\nPlease try again!");
                        }
                    } else {
                        CreateAccount("Your account name can't\nonly contain whitespaces!\nPlease try again!");
                    }
                } else {
                    //"\n" står for "\" = break og "n" = new line.
                    CreateAccount("You already have a account\nwith that name!\nPlease try again!");
                }
            } else if (customText.DialogResult == DialogResult.Cancel) {

            }
        }

        public void UpdateList() {
            try {
                if (cmbChooseAccount != null) {
                    cmbChooseAccount.Items.Clear();
                    user = Settings.CurrentUser;
                    if (user.Accounts.Count != 0) {
                        foreach (Account acc in user.Accounts) {
                            cmbChooseAccount.Items.Add(acc.Name);
                        }
                        account = user.Accounts.First();
                        cmbChooseAccount.SelectedIndex = cmbChooseAccount.Items.IndexOf(account.Name);
                    }
                    cmbChooseAccount.Items.Add("Create account");
                }
            } catch (NullReferenceException) {
                
            }
        }

        //Her opdatere vi Account, så vores form viser det korrekte information.
        public void UpdateAccount() {
            lblAccountName.Text = "Account Name: " + account.Name;
            lblAccountNumber.Text = "Account Number: " + account.Number;
            lblBalance.Text = "Balance: " + String.Format("{0:n}", account.balance) + " DKK";

            //Her tjekker vi om accounten har et Kredit kort
            if(account.Card != null) {
                //Hvis der er et kort
                ((Label)hasCard1.Controls["lblCard"]).Text = "Card Number: " + System.Text.RegularExpressions.Regex.Replace(account.Card.Number.ToString(), ".{4}", "$0 ");
                ((Label)hasCard1.Controls["lblExpireDate"]).Text = "Expire Date: " + account.Card.ExpireDate.ToString("MM/dd/yyyy");
                ((Label)hasCard1.Controls["lblSecurityNumber"]).Text = "Security Number: " + account.Card.SecurityNumber;
                //Vis hasCard User Control og fjern noCard user control
                hasCard1.Visible = true;
                noCard1.Visible = false;
            } else {
                //Hvis der ikke er et kort, så viser vi en UserControl som indeholder en knap som gør brugeren kan oprette en form.
                hasCard1.Visible = false;
                noCard1.Visible = true;
            }
        }

        private void OverviewUC_Load(object sender, EventArgs e) {
            UpdateList();
        }
    }
}
