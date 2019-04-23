using OO_Bank.Classes;
using OO_Bank.Exceptions;
using OO_Bank.User_Controls;
using OO_Bank.User_Controls.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OO_Bank {
    public partial class FormLogSign : Form {

        private bool mouseDown;
        private Point lastLocation;

        public FormLogSign() {
            InitializeComponent();
        }

        private void LblWelcome_MouseDown(object sender, MouseEventArgs e) {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void LblWelcome_MouseUp(object sender, MouseEventArgs e) {
            mouseDown = false;
        }

        private void LblWelcome_MouseMove(object sender, MouseEventArgs e) {
            if (mouseDown) {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
                this.Update();
            }
        }

        private void BtnLogIn_Click(object sender, EventArgs e) {
            FormLogIn formLogIn = new FormLogIn();
            formLogIn.ShowDialog();
        }

        private void BtnSignUp_Click(object sender, EventArgs e) {
            FormSignUp formSignUp = new FormSignUp();
            formSignUp.ShowDialog();
        }

        private void LblExit_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        //For testing the main form, without having to log in or sign up all the time.
        private void BtnTesting_Click(object sender, EventArgs e) {
                try {
                    User user = Utils.GetUserByID(111111);
                    Settings.CurrentUser = user;
                    var t = new Thread(() => Application.Run(new FormMain()));
                    t.Start();
                    Application.OpenForms["FormLogSign"].Close();
                } catch (UserException) {
                //If user 111111 (test account) doesn't exist, create new 111111
                MessageBox.Show("Test user 111111 doesn't exist, creating new test user.");
                List<Account> accounts = new List<Account>();
                Card testCard = new Card(9352192417248172, DateTime.Now, 421, 111111, 133125312);
                accounts.Add(new Account(133125312, "Macd penge", 20.0m, 111111, testCard));
                accounts.Add(new Account(172571252, "Opsparing", 2582858.2952m, 111111, null));
                accounts.Add(new Account(112522152, "mienkraft", 0.0m, 111111, null));
                User user = new User(111111, "Skrome", "12345678", "skrome@gmail.com", "12345678", false, true, accounts);
                user.Save();
                Settings.CurrentUser = user;
                var t = new Thread(() => Application.Run(new FormMain()));
                t.Start();
                Application.OpenForms["FormLogSign"].Close();
            }
        }
    }
}
