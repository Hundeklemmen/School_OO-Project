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
using System.IO;

namespace OO_Bank.User_Controls {
    public partial class OverviewUC : UserControl {

        public static User user;
        public static Account account;

        public OverviewUC() {
            InitializeComponent();
            Settings.OverviewUC = this;
        }

      
        private void CmbChooseAccount_SelectedIndexChanged(object sender, EventArgs e) {
            //Sætter SelectedItem variablen til det brugeren har valgt.
            Object selectedItem = cmbChooseAccount.SelectedItem;
            //Ser om selectedItem er "Create cccount"
            if (selectedItem.ToString().Equals("Create account")) {
                //Hvis ja, så kaldet vi Create account functionen
                CreateAccount(null);
                return;
            }
            //Ellers så loop vi igennem alle vores kontoeer
            foreach (Account acc in user.Accounts) {
                //tjekker om vores loop konto er SelectedItem
                if (acc.Name.Equals(selectedItem.ToString())) {
                    //Hvis ja, så opdatere vi konto og kaldet updateAccount funktionen
                    account = acc;
                    UpdateAccount();
                    return;
                }
            }
        }

        //Bruges til at lave konto
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
                //Hvis ikke
                if (exists == false) {
                    //Tjekker om konto navnet er "white space"
                    if (!string.IsNullOrWhiteSpace(customText.Message)) {
                        if (customText.Message.Length < 20) {
                            //Sætter og gemmer ny konto
                            Account newAccount = new Account(Utils.GenerateAccountNumber(), customText.Message, 0.0m, user.ID, null);
                            Settings.CurrentUser.Accounts.Add(newAccount);
                            user = Settings.CurrentUser;
                            user.Save();
                            UpdateList();
                            cmbChooseAccount.SelectedIndex = cmbChooseAccount.Items.IndexOf(newAccount.Name);
                            account = newAccount;
                            UpdateAccount();

                            Settings.PayAndTransfer.UpdateLists();
                        } else {
                            //Hvis navnet er for langt
                            CreateAccount("Your account name is too long!\nPlease try again!");
                        }
                    } else {
                        //Hvis navnet kun har "white space"
                        CreateAccount("Your account name can't\nonly contain whitespaces!\nPlease try again!");
                    }
                } else {
                    //Hvis navn allerede bruges af bruger
                    CreateAccount("You already have an account\nwith that name!\nPlease try again!");
                }
            //Hvis bruger fortryder, lukkes formen
            } else if (customText.DialogResult == DialogResult.Cancel) {

            }
        }

        //Opdaterer combobox liste
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
            lblBalance.Text = "Balance: " + Utils.BalanceFormatted(account.balance);

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

            //Clear vores Transactionslist fra UI
            lstTransactions.Items.Clear();

            //Tjek om der findes en Transactions fil
            String TransactionPath = Settings.TransactionsPath + "/" + account.Number + ".txt";
            if (File.Exists(@TransactionPath)) {
                var TransactionsList = File.ReadLines(@TransactionPath);
                foreach (var TransactionLine in TransactionsList) {
                    lstTransactions.Items.Insert(0, TransactionLine);
                }
            } else {
                lstTransactions.Items.Insert(0, "No transactions yet!");
            }
        }

        //Når overviewUC loader
        private void OverviewUC_Load(object sender, EventArgs e) {
            //Opdater list
            UpdateList();
        }
    }
}
