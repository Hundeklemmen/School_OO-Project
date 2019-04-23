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
            int selectedIndex = cmbChooseAccount.SelectedIndex;
            if(selectedItem.ToString().Equals("Create account")) {

                return;
            }
            foreach (Account acc in user.Accounts) {
                if (acc.Name.Equals(selectedItem.ToString())) {
                    account = acc;
                    updateAccount();
                    return;
                }
            }
        }

        public void updateAccount() {
            lblAccountName.Text = "Account Name: " + account.Name;
            lblAccountNumber.Text = "Account Number: " + account.Number;
            lblBalance.Text = "Balance: " + String.Format("{0:n}", account.balance) + " DKK";

            if(account.Card != null) {
                //Hvis der er et kort
                ((Label)hasCard1.Controls["lblCard"]).Text = "Card Number: " + System.Text.RegularExpressions.Regex.Replace(account.Card.Number.ToString(), ".{4}", "$0 ");
                ((Label)hasCard1.Controls["lblExpireDate"]).Text = "Expire Date: " + account.Card.ExpireDate.ToString("MM/dd/yyyy");
                ((Label)hasCard1.Controls["lblSecurityNumber"]).Text = "Security Number: " + account.Card.SecurityNumber;
               //Vis hasCard User Control og fjern noCard user control
                hasCard1.Visible = true;
                noCard1.Visible = false;
            } else {
                //Hvis der ikke er et kort
                hasCard1.Visible = false;
                noCard1.Visible = true;
            }
        }

        private void OverviewUC_Load(object sender, EventArgs e) {
            try {
                if (user == null && cmbChooseAccount != null) {
                    user = Settings.CurrentUser;
                    if (user.Accounts.Count != 0) {
                        account = user.Accounts.First();
                        foreach (Account acc in user.Accounts) {
                            cmbChooseAccount.Items.Add(acc.Name);
                        }
                    }
                    cmbChooseAccount.Items.Add("Create account");
                }
            } catch (NullReferenceException) {
                
            }
        }
    }
}
