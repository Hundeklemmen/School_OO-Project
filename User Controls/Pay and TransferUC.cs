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

namespace OO_Bank.User_Controls {
    public partial class Pay_and_TransferUC : UserControl {
        public Pay_and_TransferUC() {
            InitializeComponent();
        }

        public User user = Settings.CurrentUser;

        private void Pay_and_TransferUC_Load(object sender, EventArgs e) {
            try {
                UpdateLists();
            } catch (NullReferenceException) {

            }
        }

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

        private void CmbFromAccount_SelectedIndexChanged(object sender, EventArgs e) {
            Object selectedItem = cmbFromAccount.SelectedItem;
            foreach (Account acc in user.Accounts) {
                if (acc.Name.Equals(selectedItem.ToString())) {
                    lblFromOwn.Text = Utils.BalanceFormatted(acc.balance);
                    return;
                }
            }
        }

        private void CmbToAccount_SelectedIndexChanged(object sender, EventArgs e) {
            Object selectedItem = cmbToAccount.SelectedItem;
            foreach (Account acc in user.Accounts) {
                if (acc.Name.Equals(selectedItem.ToString())) {
                    lblToOwn.Text = Utils.BalanceFormatted(acc.balance);
                    return;
                }
            }
        }

        private void CmbFromOther_SelectedIndexChanged(object sender, EventArgs e) {
            Object selectedItem = cmbFromOther.SelectedItem;
            foreach (Account acc in user.Accounts) {
                if (acc.Name.Equals(selectedItem.ToString())) {
                    lblFromOther.Text = Utils.BalanceFormatted(acc.balance);
                    return;
                }
            }
        }

        private void BtnConfirm1_Click(object sender, EventArgs e) {
            FormYesNo ConfirmForm = new FormYesNo("Confirm transaction");
            if (ConfirmForm.DialogResult == DialogResult.Yes) {
                //Gennemfør transaktionen

                String FromAccount = cmbFromAccount.Text;
                String ToAccount = cmbToAccount.Text;
                String amount = txtAmountOwn.Text;

                decimal amountParsed = decimal.Parse(amount);

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
                        MessageBox.Show("Transaction has been completed");
                    } else {
                        MessageBox.Show("Insufficient funding");
                    }
                } else {
                    MessageBox.Show("Account not found");
                }

            }
        }

        private void BtnConfirm2_Click(object sender, EventArgs e) {
            FormYesNo ConfirmForm = new FormYesNo("Confirm transaction");
            if (ConfirmForm.DialogResult == DialogResult.Yes) {
                //Gennemfør transaktionen

                String FromAccount = cmbFromOther.Text;
                int ToOtherAccount = int.Parse(txtAmountOther.Text);
                String amount = txtAmountOther.Text;

                decimal amountParsed = decimal.Parse(amount);

                Account fromAccount = null;
                foreach (Account acc in Settings.CurrentUser.Accounts) {
                    if (acc.Name.ToString().Equals(FromAccount)) {
                        fromAccount = acc;
                        break;
                    }
                }

                //Loop igennem alle brugere for at se om der er en account i et user object
                Account toAccount = null;
                foreach(string path in Directory.GetFiles(Settings.UsersPath)) {
                    MessageBox.Show(path);
                    User _tempUser = Utils.GetUserByPath(path);
                    Boolean breakUL = false;
                    foreach(Account _tempAccount in _tempUser.Accounts) {
                        if(_tempAccount.Number == ToOtherAccount) { 
                            toAccount = _tempAccount;
                            breakUL = true;
                            break;
                        }
                    }
                    if(breakUL == true) {
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
                        MessageBox.Show("Transaction has been completed");
                    } else {
                        MessageBox.Show("Insufficient funding");
                    }
                } else {
                    MessageBox.Show("Account not found");
                }
            }
        }

        /*
                String amount = customText.Input1;
                String Account = customText.Input2;
                decimal amountParsed = decimal.Parse(amount);

                Account toAccount = null;
                foreach(Account acc in Settings.CurrentUser.Accounts){
                    if (acc.Number.ToString().Equals(Account)) {
                        toAccount = acc;
                    }
                }
                if(toAccount != null) {
                    Transaction TAction = new Transaction(account, toAccount, amountParsed, DateTime.Now);
                    if(TAction.CanTransfer() == true) {
                        TAction.Transfer();
                        this.UpdateAccount();
                    } else {
                        MessageBox.Show("Account doesn't contain enough money!");
                    }
                } else {
                    MessageBox.Show("Account not found");
                }
                */
    }
}