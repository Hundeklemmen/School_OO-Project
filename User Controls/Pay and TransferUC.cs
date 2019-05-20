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
using OO_Bank.Forms;
using System.IO;
using OO_Bank.Forms.Custom_Messages;

namespace OO_Bank.User_Controls {
    public partial class Pay_and_TransferUC : UserControl {
        public Pay_and_TransferUC() {
            InitializeComponent();
        }

        //Sæt user = current user
        public User user = Settings.CurrentUser;

        //Når pay and transfer loader
        private void Pay_and_TransferUC_Load(object sender, EventArgs e) {
            try {
                UpdateLists();
                Settings.PayAndTransfer = this;
            } catch (NullReferenceException) {

            }
        }

        //Bruger til at opdatere combobox listerne
        public void UpdateLists() {
            try {
                //Opdater cmbFromAccount listen.
                if (cmbFromAccount != null) {
                    cmbFromAccount.Items.Clear();
                    if (user.Accounts.Count != 0) {
                        foreach (Account acc in user.Accounts) {
                            cmbFromAccount.Items.Add(acc.Name);
                        }
                        Account account = user.Accounts.First();
                        cmbFromAccount.SelectedIndex = cmbFromAccount.Items.IndexOf(account.Name);
                        lblFromOwn.Text = Utils.BalanceFormatted(account.balance);
                    }
                }
                //Opdater cmbToAccount listen.
                if (cmbToAccount != null) {
                    cmbToAccount.Items.Clear();
                    user = Settings.CurrentUser;
                    if (user.Accounts.Count != 0) {
                        foreach (Account acc in user.Accounts) {
                            cmbToAccount.Items.Add(acc.Name);
                        }
                        Account account = user.Accounts.First();
                        cmbToAccount.SelectedIndex = cmbToAccount.Items.IndexOf(account.Name);
                        lblToOwn.Text = Utils.BalanceFormatted(account.balance);
                    }
                }
                //Opdater cmbFromOther listen.
                if (cmbFromOther != null) {
                    cmbFromOther.Items.Clear();
                    if (user.Accounts.Count != 0) {
                        foreach (Account acc in user.Accounts) {
                            cmbFromOther.Items.Add(acc.Name);
                        }
                        Account account = user.Accounts.First();
                        cmbFromOther.SelectedIndex = cmbFromAccount.Items.IndexOf(account.Name);
                        lblFromOther.Text = Utils.BalanceFormatted(account.balance);
                    }
                }


            } catch (NullReferenceException) {

            }
        }

        //Hvis valgte combobox for konto som skal sende penge til egen anden konto ændres
        private void CmbFromAccount_SelectedIndexChanged(object sender, EventArgs e) {
            Object selectedItem = cmbFromAccount.SelectedItem;
            foreach (Account acc in user.Accounts) {
                if (acc.Name.Equals(selectedItem.ToString())) {
                    lblFromOwn.Text = Utils.BalanceFormatted(acc.balance);
                    return;
                }
            }
        }

        //Hvis valgte combobox for konto som skal modtage penge fra egen anden konto ændres
        private void CmbToAccount_SelectedIndexChanged(object sender, EventArgs e) {
            Object selectedItem = cmbToAccount.SelectedItem;
            foreach (Account acc in user.Accounts) {
                if (acc.Name.Equals(selectedItem)) {
                    lblToOwn.Text = Utils.BalanceFormatted(acc.balance);
                    return;
                }
            }
        }

        //Hvis valgte combobox for konto som skal sende penge til andre mennesker ændres
        private void CmbFromOther_SelectedIndexChanged(object sender, EventArgs e) {
            Object selectedItem = cmbFromOther.SelectedItem;
            foreach (Account acc in user.Accounts) {
                if (acc.Name.Equals(selectedItem)) {
                    lblFromOther.Text = Utils.BalanceFormatted(acc.balance);
                    return;
                }
            }
        }

        //Hvis brugeren bekræfter
        private void BtnConfirm1_Click(object sender, EventArgs e) {
            FormYesNo ConfirmForm = new FormYesNo("Confirm transaction");
            if (ConfirmForm.DialogResult == DialogResult.Yes) {
                //Gennemfør transaktionen

                String FromAccount = cmbFromAccount.Text;
                String ToAccount = cmbToAccount.Text;
                String amount = txtAmountOwn.Text;

                //Tjekker om alt er i orden
                if (decimal.TryParse(amount, out decimal amountParsed)) {
                    if (amountParsed > 0) {

                        Account fromAccount = null;
                        foreach (Account acc in Settings.CurrentUser.Accounts) {
                            if (acc.Name.ToString().Equals(FromAccount)) {
                                fromAccount = acc;
                                break;
                            }
                        }

                        Account toAccount = null;
                        foreach (Account acc in Settings.CurrentUser.Accounts) {
                            if (acc.Name.ToString().Equals(ToAccount)) {
                                toAccount = acc;
                                break;
                            }
                        }

                        if (toAccount != null && fromAccount != null) {
                            Transaction TAction = new Transaction(fromAccount, toAccount, amountParsed, DateTime.Now);
                            if (TAction.CanTransfer() == true) {
                                TAction.Transfer();
                                Settings.CurrentUser.Save();
                                UpdateLists();
                                cmbFromAccount.SelectedIndex = cmbFromAccount.Items.IndexOf(fromAccount.Name);
                                cmbToAccount.SelectedIndex = cmbToAccount.Items.IndexOf(toAccount.Name);
                                //Hvis transaktionen går igennem
                                new FormMessage("Transaction has been completed");
                            } else {
                                //Hvis brugeren ikke har nok penge
                                new FormMessage("Insufficient funding");
                                Utils.Shake(Settings.FormMain);
                            }
                        } else {
                            //Hvis kontoen ikke findes
                            new FormMessage("Account not found");
                            Utils.Shake(Settings.FormMain);
                        }
                    } else {
                        //Hvis man prøver at sende mindre end 0
                        new FormMessage("Du kan ikke sende et beløb under 0!");
                        Utils.Shake(Settings.FormMain);
                    }
                } else {
                    //Hvis man prøver at sende andet end tal
                    new FormMessage("Dit beløb kan kun indeholde et tal!");
                    Utils.Shake(Settings.FormMain);
                }

            }
        }

        //Hvis brugeren bekræfter
        private void BtnConfirm2_Click(object sender, EventArgs e) {
            FormYesNo ConfirmForm = new FormYesNo("Confirm transaction");
            if (ConfirmForm.DialogResult == DialogResult.Yes) {
                //Gennemfør transaktionen

                String FromAccount = cmbFromOther.Text;
                int ToOtherAccount = int.Parse(txtRecipient.Text);
                String amount = txtAmountOther.Text;

                //TJekker om alt er i orden
                if (decimal.TryParse(amount, out decimal amountParsed)) {
                    if (amountParsed > 0) {

                        Account fromAccount = null;
                        foreach (Account acc in Settings.CurrentUser.Accounts) {
                            if (acc.Name.ToString().Equals(FromAccount)) {
                                fromAccount = acc;
                                break;
                            }
                        }

                        //Loop igennem alle brugere for at se om der er en account i et user object
                        Account toAccount = null;

                        foreach (string path in Directory.GetFiles(Settings.UsersPath)) {
                            User _tempUser = Utils.GetUserByPath(path);
                            Boolean breakUL = false;
                            foreach (Account _tempAccount in _tempUser.Accounts) {
                                if (_tempAccount.Number == ToOtherAccount) {
                                    toAccount = _tempAccount;

                                    breakUL = true;
                                    break;
                                }
                            }
                            if (breakUL == true) {
                                break;
                            }
                        }

                        if (toAccount != null && fromAccount != null) {
                            Transaction TAction = new Transaction(fromAccount, toAccount, amountParsed, DateTime.Now);
                            if (TAction.CanTransfer() == true) {
                                TAction.Transfer();
                                Settings.CurrentUser.Save();
                                UpdateLists();
                                cmbFromAccount.SelectedIndex = cmbFromAccount.Items.IndexOf(fromAccount.Name);
                                cmbToAccount.SelectedIndex = cmbToAccount.Items.IndexOf(toAccount.Name);
                                //Hvis transaktionen går i gennem
                                new FormMessage("Transaction has been completed");
                            } else {
                                //Hvis kontoen ikke har nok penge
                                new FormMessage("Insufficient funding");
                                Utils.Shake(Settings.FormMain);
                            }
                        } else {
                            //Hvis kontoen ikke kan findes
                            new FormMessage("Account not found");
                            Utils.Shake(Settings.FormMain);
                        }
                    } else {
                        //Hvis brugeren sender beløb under 0
                        new FormMessage("Du kan ikke sende et beløb under 0!");
                        Utils.Shake(Settings.FormMain);
                    }
                } else {
                    //Hvis bruger sender andet end tal
                    new FormMessage("Dit beløb kan kun indeholde et tal!");
                    Utils.Shake(Settings.FormMain);
                }
            }
        }
    }
}