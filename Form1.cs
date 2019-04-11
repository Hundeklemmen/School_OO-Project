using OO_Bank.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OO_Bank {
    public partial class Form1 : Form {

        /*
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
        
        File:
            - Saving as .JSON
        
            
            
        */

        public Form1() {
            //Kalder vores function som ville lave alle vores filer.
            generateFiles();
            InitializeComponent();
        }

        public static String desktopPath, OOProjekt, usersPath;

        public void generateFiles() {
            //Vores skrivebord
            desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            //Specificere vores OO projekt fil placering
            OOProjekt = desktopPath + "/OOProjekt";
            
            //Hvis vores projekt mappe ikke findes, så opretter vi den
            if (!Directory.Exists(@OOProjekt)) {
                //Hvis vores projekt mappe ikke findes
                Directory.CreateDirectory(@OOProjekt);
            }

            usersPath = OOProjekt + "/users";
            if (!Directory.Exists(@usersPath)) {
                Directory.CreateDirectory(@usersPath);
            }

        }

        bool formMove;
        int formMoveX;
        int formMoveY;

        private void Form1_Load(object sender, EventArgs e) {
            //User user = new User("{ID: 'ID test', Name: 'Name test', Password: 'Password test', Email: 'Email test', Suspended: false, Accounts: ['test']}");
            //User user2 = new User("").get("ID HER");
            User user = Utils.getUserByID(1232132321);
            user.save();
            //Makes sure first page is Overview
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
        }

        private void PnlLogo_MouseDown(object sender, MouseEventArgs e) {
            formMove = true;
            formMoveX = e.X;
            formMoveY = e.Y;
        }

        private void PnlLogo_MouseUp(object sender, MouseEventArgs e) {
            formMove = false;
        }

        private void PnlLogo_MouseMove(object sender, MouseEventArgs e) {
            if (formMove) {
                this.SetDesktopLocation(MousePosition.X - formMoveX, MousePosition.Y - formMoveY);
            }
        }

        private void BtnExit_Click(object sender, EventArgs e) {
            DialogResult result = MessageBox.Show("Do you want to exit the application?", "Exit application", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes) {
                Application.Exit();
            }
        }

        private void BtnOverview_Click(object sender, EventArgs e) {
            //Moves current page bar to current button
            pnlCurrentPage.Height = btnOverview.Height;
            pnlCurrentPage.Top = btnOverview.Top;
            //Sets Overview visible, rest invisible
            overviewUC1.Visible = true;
            expenses_and_BudgetUC1.Visible = false;
            pay_and_TransferUC1.Visible = false;
            my_AccountUC1.Visible = false;
        }

        private void BtnExpenseBudget_Click(object sender, EventArgs e) {
            //Moves current page bar to current button
            pnlCurrentPage.Height = btnExpenseBudget.Height;
            pnlCurrentPage.Top = btnExpenseBudget.Top;
            //Sets Expense and Budget visible, rest invisible
            overviewUC1.Visible = false;
            expenses_and_BudgetUC1.Visible = true;
            pay_and_TransferUC1.Visible = false;
            my_AccountUC1.Visible = false;
        }

        private void BtnPayTransfer_Click(object sender, EventArgs e) {
            //Moves current page bar to current button
            pnlCurrentPage.Height = btnPayTransfer.Height;
            pnlCurrentPage.Top = btnPayTransfer.Top;
            //Sets Pay and Transfer visible, rest invisible
            overviewUC1.Visible = false;
            expenses_and_BudgetUC1.Visible = false;
            pay_and_TransferUC1.Visible = true;
            my_AccountUC1.Visible = false;
        }

        private void BtnAccount_Click(object sender, EventArgs e) {
            //Moves current page bar to current button
            pnlCurrentPage.Height = btnAccount.Height;
            pnlCurrentPage.Top = btnAccount.Top;
            //Sets My Account visible, rest invisible
            overviewUC1.Visible = false;
            expenses_and_BudgetUC1.Visible = false;
            pay_and_TransferUC1.Visible = false;
            my_AccountUC1.Visible = true;
        }
    }
}