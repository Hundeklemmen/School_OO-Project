using OO_Bank.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OO_Bank.User_Controls {
    public partial class Sign_up : Form {

        bool fullNameClicked = false;
        bool passwordClicked = false;
        bool emailClicked = false;
        bool formMove;
        int formMoveX;
        int formMoveY;


        public Sign_up() {
            InitializeComponent();
        }


        private void TxtFullNameInput_MouseClick(object sender, MouseEventArgs e) {
            if (!fullNameClicked) {
                TextBox box = sender as TextBox;
                box.Text = String.Empty;
                fullNameClicked = true;
            }
        }

        private void TxtPasswordInput_MouseClick(object sender, MouseEventArgs e) {
            if (!passwordClicked) {
                TextBox box = sender as TextBox;
                box.Text = String.Empty;
                passwordClicked = true;
            }
        }

        private void LblExit_MouseClick(object sender, MouseEventArgs e) {
            this.Hide();
        }

        private void LblSignUp_MouseDown(object sender, MouseEventArgs e) {
            formMove = true;
            formMoveX = e.X;
            formMoveY = e.Y;
        }

        private void LblSignUp_MouseUp(object sender, MouseEventArgs e) {
            formMove = false;
        }

        private void LblSignUp_MouseMove(object sender, MouseEventArgs e) {
            if (formMove) {
                this.SetDesktopLocation(MousePosition.X - formMoveX, MousePosition.Y - formMoveY);
            }
        }

        private void TxtEmailInput_MouseClick(object sender, MouseEventArgs e) {
            if (!emailClicked) {
                TextBox box = sender as TextBox;
                box.Text = String.Empty;
                emailClicked = true;
            }
        }
            
        private void TxtPasswordInput_TextChanged(object sender, EventArgs e) {
            txtPasswordInput.MaxLength = 20;
            txtPasswordInput.PasswordChar = '*';
        }

        private void BtnSignUpConfirm_Click(object sender, EventArgs e) {
            String FullName = txtFullNameInput.Text;
            String Password = txtPasswordInput.Text;
            String Email = txtEmailInput.Text;

            if (!Utils.IsValidEmail(Email)) {
                pnlEmail.BackColor = Color.FromArgb(255, 0, 0);
                Utils.Shake(this);
                return;
            }
            


        }

        private void TxtEmailInput_TextChanged(object sender, EventArgs e) {
            pnlEmail.BackColor = Color.FromArgb(114, 137, 218);
        }



        private void TxtFullNameInput_Leave(object sender, EventArgs e) {
            if (txtFullNameInput.Text.Length == 0) {
                txtFullNameInput.Text = "Full name";
                fullNameClicked = false;
            }
        }

        private void TxtPasswordInput_Leave(object sender, EventArgs e) {
            if (txtPasswordInput.Text.Length == 0) {
                txtPasswordInput.Text = "Password";
                txtPasswordInput.PasswordChar = '\0';
                passwordClicked = false;
            }
        }

        private void TxtEmailInput_Leave(object sender, EventArgs e) {
            if (txtEmailInput.Text.Length == 0) {
                txtEmailInput.Text = "Email";
                emailClicked = false;
            }
        }
    }
}