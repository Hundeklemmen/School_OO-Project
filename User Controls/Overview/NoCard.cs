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

namespace OO_Bank.User_Controls.Overview {
    public partial class NoCard : UserControl {
        public NoCard() {
            InitializeComponent();
        }

        private void BtnRegisterCreditCard_Click(object sender, EventArgs e) {
            long Number = Utils.GenerateCardNumber();
            DateTime ExpireDate = DateTime.Now.AddYears(3);
            int SecurityNumber = Utils.GenerateSecurityNumber();
            long Owner = OverviewUC.user.ID;
            long AccountNumber = OverviewUC.account.Number;
            
            Card card = new Card(Number, ExpireDate, SecurityNumber, Owner, AccountNumber);
            OverviewUC.account.Card = card;
            foreach (Account acc in OverviewUC.user.Accounts) {
                if(acc.Number == OverviewUC.account.Number) {
                    acc.Card = card;
                    OverviewUC.user.Save();
                    Settings.overviewUC.updateAccount();
                    return;
                }
            }
        }
    }
}
