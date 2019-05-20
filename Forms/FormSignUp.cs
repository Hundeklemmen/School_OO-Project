using OO_Bank.Classes;
using OO_Bank.Forms;
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

namespace OO_Bank.User_Controls {
    public partial class FormSignUp : Form {

        bool fullNameClicked = false;
        bool passwordClicked = false;
        bool emailClicked = false;
        bool mobileClicked = false;
        bool goingToShake = false;
        bool signSuccess;

        public FormSignUp() {
            InitializeComponent();
        }

        //Hvis der trykkes på exit, så exit
        private void LblExit_MouseClick(object sender, MouseEventArgs e) {
            this.Hide();
        }

        //Hvis der klikkes på tekstboks for fulde navn fjernes teksten så der er plads til at skrive
        private void TxtFullNameInput_MouseClick(object sender, MouseEventArgs e) {
            if (!fullNameClicked) {
                TextBox box = sender as TextBox;
                box.Text = String.Empty;
                fullNameClicked = true;
            }
        }

        //Hvis der klikkes på tekstboks for password fjernes teksten så der er plads til at skrive
        private void TxtPasswordInput_MouseClick(object sender, MouseEventArgs e) {
            if (!passwordClicked) {
                TextBox box = sender as TextBox;
                box.Text = String.Empty;
                passwordClicked = true;
            }
        }

        //Hvis der klikkes på tekstboks for email fjernes teksten så der er plads til at skrive
        private void TxtEmailInput_MouseClick(object sender, MouseEventArgs e) {
            if (!emailClicked) {
                TextBox box = sender as TextBox;
                box.Text = String.Empty;
                emailClicked = true;
            }
        }

        //Hvis der klikkes på tekstboks for mobil nummer fjernes teksten så der er plads til at skrive
        private void TxtMobileInput_MouseClick(object sender, MouseEventArgs e) {
            if (!mobileClicked) {
                TextBox box = sender as TextBox;
                box.Text = String.Empty;
                mobileClicked = true;
            }
        }

        //Hvis teksten for fulde navn ændres
        private void TxtFullNameInput_TextChanged(object sender, EventArgs e) {
            fullNameClicked = true;
            pnlFullName.BackColor = Color.FromArgb(114, 137, 218); //Sæt farven tilbage til normal
        }

        //Hvis teksten for password ændres
        private void TxtPasswordInput_TextChanged(object sender, EventArgs e) {
            passwordClicked = true;
            txtPasswordInput.MaxLength = 20;
            txtPasswordInput.PasswordChar = '*'; //Sæt password char = *, for at maskere kodeord
            pnlPassword.BackColor = Color.FromArgb(114, 137, 218); //Sæt farven tilbage til normal
        }

        //Hvis teksten for email ændres
        private void TxtEmailInput_TextChanged(object sender, EventArgs e) {
            emailClicked = true;
            pnlEmail.BackColor = Color.FromArgb(114, 137, 218); //Sæt farven tilbage til normal
        }

        //Hvis teksten for mobil nummer ændres
        private void TxtMobileInput_TextChanged(object sender, EventArgs e) {
            mobileClicked = true;
            pnlMobile.BackColor = Color.FromArgb(114, 137, 218); //Sæt farven tilbage til normal
        }

        //Variable som bruges til at rykke rundt på formen
        private bool mouseDown; //Holdes venstre-klik nede eller ej
        private Point lastLocation; //Hvor var formen sidst
        //Hvis der trykkes ned på musen sættes bool mouseDown til sand og fortæller lokation til Point variablen
        private void LblSignUp_MouseDown(object sender, MouseEventArgs e) {
            mouseDown = true;
            lastLocation = e.Location;
        }
        //Hvis der gives slip på musen stopper det
        private void LblSignUp_MouseUp(object sender, MouseEventArgs e) {
            mouseDown = false;
        }
        //Når musen rykkes opdateres lokationen
        private void LblSignUp_MouseMove(object sender, MouseEventArgs e) {
            if (mouseDown) {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
                this.Update();
            }

        }

        //Hvis man forlader tekstboksen for fulde navn
        private void TxtFullNameInput_Leave(object sender, EventArgs e) {
            if (txtFullNameInput.Text.Length == 0) {
                txtFullNameInput.Text = "Full name"; //Sæt tekstboksen = Full Name
                fullNameClicked = false;
            }
        }

        //Hvis man forlader tekstboksen for password
        private void TxtPasswordInput_Leave(object sender, EventArgs e) {
            if (txtPasswordInput.Text.Length == 0) {
                txtPasswordInput.Text = "Password"; //Sæt tekstboksen = Password
                txtPasswordInput.PasswordChar = '\0'; //Fjern password char så Password ikke bliver til ********
                passwordClicked = false;
            }
        }

        //Hvis man forlader tekstboksen for email
        private void TxtEmailInput_Leave(object sender, EventArgs e) {
            if (txtEmailInput.Text.Length == 0) {
                txtEmailInput.Text = "Email"; //Sæt tekstboksen = Email
                emailClicked = false;
            }
        }

        //Hvis man forlader tekstboksen for mobil nummer
        private void TxtMobileInput_Leave(object sender, EventArgs e) {
            if(txtMobileInput.Text.Length == 0) {
                txtMobileInput.Text = "Mobile"; //Sæt tekstboksen = Mobile
                mobileClicked = false;
            }
        }

        //Hvis der trykkes på bekræft for at sign up
        private void BtnSignUpConfirm_Click(object sender, EventArgs e) {
            //Gem al given information
            String FullName = txtFullNameInput.Text;
            String Password = Utils.CalculateMD5Hash(txtPasswordInput.Text);
            String Email = txtEmailInput.Text;
            String Mobile = txtMobileInput.Text;
            Boolean Admin = chkAdmin.Checked;
            DateTime Birth = dtpBirthdate.Value;
            long ree = Birth.ToBinary();
            //MessageBox.Show(ree + "");
            signSuccess = true;
            //Tjekker om email er valid
            if (!Utils.IsValidEmail(Email)) {
                pnlEmail.BackColor = Color.FromArgb(255, 0, 0); //Sæt panel farven for email = rød
                goingToShake = true; //Sørger for at formen ryster hvis fejl
            }
            //Tjekker om password er over 8 eller bare er "Password"
            if (txtPasswordInput.Text.Length < 8 || txtPasswordInput.Text == "Password") {
                pnlPassword.BackColor = Color.FromArgb(255, 0, 0); //Sæt panel farven for password = rød
                goingToShake = true; //Sørger for at formen ryster hvis fejl
            }
            //Tjekker om fulde navn indeholder noget som ikke er "Full Name"
            if (txtFullNameInput.Text.Length == 0 ||txtFullNameInput.Text == "Full name") {
                pnlFullName.BackColor = Color.FromArgb(255, 0, 0); //Sæt panel farven for fulde navn = rød
                goingToShake = true; //Sørger for at formen ryster hvis fejl
            }
            //Tjekker om mobil nummeret ikke er lig med 8, om der står "Mobile", eller hvis det ikke er tal
            if (txtMobileInput.Text.Length != 8 || txtMobileInput.Text == "Mobile" || !txtMobileInput.Text.All(char.IsDigit)) {
                pnlMobile.BackColor = Color.FromArgb(255, 0, 0); //Sæt panel farven for mobil nummer = rød
                goingToShake = true; //Sørger for at formen ryster hvis fejl
            }
            //Hvis formen skal ryste
            if (goingToShake) {
                Utils.Shake(this);
                goingToShake = false;
                signSuccess = false;
            }
            //Hvis sign up er en success
            if (signSuccess) {
                User user = new User(Utils.GenerateID(), FullName, Password, Email, Mobile, false, Admin, new List<Account>()); //Her laver vi et nyt user objekt til vores nye bruger
                user.Save(); //Her gemmer vi vores nye bruger i vores system så han ikke mister sin bruger
                FormYesNo customMessage = new FormYesNo("Your account was created successfully!\nYour ID is: " + user.ID + ", write this down!\nVery important - You need it to login!\n\n\nWould you like to be logged in?");
                //Hvis brugeren vil logges ind med det samme
                if (customMessage.DialogResult == DialogResult.Yes) {
                    Settings.CurrentUser = user;
                    var t = new Thread(() => Application.Run(new FormMain()));
                    t.Start();
                    //Luk Sign Up og LogSign da man nu er inde i main form
                    Application.OpenForms["FormSignUp"].Close();
                    Application.OpenForms["FormLogSign"].Close();
                //Ellers bare luk sign up
                } else if (customMessage.DialogResult == DialogResult.No) {
                    this.Hide();
                }
            }
            else {
                return;
            }
        }
    }
}