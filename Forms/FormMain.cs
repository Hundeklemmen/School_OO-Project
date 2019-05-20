using OO_Bank.Classes;
using OO_Bank.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OO_Bank {
    public partial class FormMain : Form {
        /*
        Get/Set our user with Settings.CurrentUser = (User object here)
        Todo:
        -Check if card number already exist

        Plans:
        User:
            - Can check balance
            - Deposit and withdraw
            - Request new credit card or new pin
            - Settings:
                - Change password
                - Create account for kids
                - Create savings account

        Accounts:
            - Account Number
            - Account Nickname
            - Account Owner ID
            - Card:
                - Card Number
                - Expiry date
                - The 3 security numbers on the back
                - Card holder
                - Expire date
                - Account Number

        Admins:
            - Create new accounts
            - Modify all accounts
                - Disable/Suspend
                - Change information
        
        File:
            - Saving as .JSON
            - Load

        Overview:
            - View your account / cards
                - See balance

        Expenses and Budget:
            - See what you've spent money on

        Pay and Transfer:
            - Pay bills
            - Transfer to others

        My Account:
            - View details of your account
            - Change details (Settings)
        */

        public FormMain() {
            InitializeComponent();

        }

        //Variable som bruges til at rykke rundt på formen
        private bool mouseDown; //Holdes venstre-klik nede eller ej
        private Point lastLocation; //Hvor var formen sidst
        //Hvis der trykkes ned på musen sættes bool mouseDown til sand og fortæller lokation til Point variablen
        private void PnlLogo_MouseDown(object sender, MouseEventArgs e) {
            mouseDown = true;
            lastLocation = e.Location;
        }
        //Hvis der gives slip på musen stopper det
        private void PnlLogo_MouseUp(object sender, MouseEventArgs e) {
            mouseDown = false;
        }
        //Når musen rykkes opdateres lokationen
        private void PnlLogo_MouseMove(object sender, MouseEventArgs e) {
            if (mouseDown) {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
                this.Update();
            }
        }

        private void BtnExit_Click(object sender, EventArgs e) {
            DialogResult result = MessageBox.Show("Do you want to exit the application?", "Exit application", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes) {
                Application.Exit(); 
            }
        }

        //Moves current page bar to current button
        public void MoveBar(Button button) {
            pnlCurrentPage.Height = button.Height;
            pnlCurrentPage.Top = button.Top;
        }

        //Set user controls visible or invisible by assigning them true or false
        public void VisibleUC(bool UC1, bool UC2, bool UC3) {
            overviewUC1.Visible = UC1;
            pay_and_TransferUC1.Visible = UC2;
            my_AccountUC1.Visible = UC3;
        }

        private void BtnOverview_Click(object sender, EventArgs e) {
            MoveBar(btnOverview);
            VisibleUC(true, false, false);
        }

        private void BtnPayTransfer_Click(object sender, EventArgs e) {
            MoveBar(btnPayTransfer);
            VisibleUC(false, true, false);
        }

        private void BtnAccount_Click(object sender, EventArgs e) {
            MoveBar(btnAccount);
            VisibleUC(false, false, true);
        }

        private void BtnLogOut_Click(object sender, EventArgs e) {
            FormYesNo customMessage = new FormYesNo("Would you like to log out?");
            if (customMessage.DialogResult == DialogResult.Yes) {
                var t = new Thread(() => Application.Run(new FormLogSign()));
                t.Start();
                Application.OpenForms["FormMain"].Close();

            } else if (customMessage.DialogResult == DialogResult.No) {
                customMessage.Hide();
            }
        }
    }
}