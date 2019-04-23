using OO_Bank.Classes;
using OO_Bank.Exceptions;
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

namespace OO_Bank.User_Controls.Forms {
    public partial class FormLogIn : Form {

        bool accountIDClicked = false;
        bool passwordClicked = false;
        bool goingToShake = false;
        bool logSuccess;
        private bool mouseDown;
        private Point lastLocation;

        public FormLogIn() {
            InitializeComponent();
        }

        private void LblExit_Click(object sender, EventArgs e) {
            this.Hide();
        }

        private void TxtAccountIDInput_MouseClick(object sender, MouseEventArgs e) {
            if (!accountIDClicked) {
                TextBox box = sender as TextBox;
                box.Text = String.Empty;
                accountIDClicked = true;
            }
        }

        private void TxtPasswordInput_MouseClick(object sender, MouseEventArgs e) {
            if (!passwordClicked) {
                TextBox box = sender as TextBox;
                box.Text = String.Empty;
                passwordClicked = true;
            }
        }

        private void TxtPasswordInput_TextChanged_1(object sender, EventArgs e) {
            txtPasswordInput.MaxLength = 20;
            txtPasswordInput.PasswordChar = '*';
            pnlPassword.BackColor = Color.FromArgb(114, 137, 218);
        }

        private void TxtAccountID_TextChanged(object sender, EventArgs e) {
            pnlAccountID.BackColor = Color.FromArgb(114, 137, 218);
        }

        private void LblLogIn_MouseDown(object sender, MouseEventArgs e) {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void LblLogIn_MouseUp(object sender, MouseEventArgs e) {
            mouseDown = false;
        }

        private void LblLogIn_MouseMove(object sender, MouseEventArgs e) {
            if (mouseDown) {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
                this.Update();
            }
        }

        private void TxtAccountID_Leave(object sender, EventArgs e) {
            if(txtAccountIDInput.Text.Length == 0) {
                txtAccountIDInput.Text = "Account ID";
                accountIDClicked = false;
            }
        }

        private void TxtPasswordInput_Leave(object sender, EventArgs e) {
            if (txtPasswordInput.Text.Length == 0) {
                txtPasswordInput.Text = "Password";
                txtPasswordInput.PasswordChar = '\0';
                passwordClicked = false;
            }
        }

        private void BtnLogInConfirm_Click(object sender, EventArgs e) {
            long AccountID = Convert.ToInt64(txtAccountIDInput.Text);
            String Password = txtPasswordInput.Text;
            logSuccess = true;

            if (txtAccountIDInput.Text.Length != 6 || txtAccountIDInput.Text == "Account ID") {
                pnlAccountID.BackColor = Color.FromArgb(255, 0, 0);
                goingToShake = true;
            }
            if (txtPasswordInput.Text.Length < 8 || txtPasswordInput.Text == "Password") {
                pnlPassword.BackColor = Color.FromArgb(255, 0, 0);
                goingToShake = true;
            }
            if (goingToShake) {
                Utils.Shake(this);
                goingToShake = false;
                logSuccess = false;
                return;
            }
            if (logSuccess) {
                try {
                    User user = Utils.GetUserByID(AccountID);
                    if (user.Password.Equals(Password)) {
                        //Hvis brugeren findes OG at hans password er korrekt.
                        Settings.CurrentUser = user;
                        var t = new Thread(() => Application.Run(new FormMain()));
                        t.Start();
                        Application.OpenForms["FormLogIn"].Close();
                        Application.OpenForms["FormLogSign"].Close();
                    } else {
                        //Brugeren findes MEN password er forkert.
                        pnlPassword.BackColor = Color.FromArgb(255, 0, 0);
                        Utils.Shake(this);
                        MessageBox.Show("Password incorrect!");
                    }
                } catch (UserException) {
                    //Hvis brugeren ikke findes!
                    MessageBox.Show("User non-existant: " + AccountID);
                }
            }
        }
    }
}