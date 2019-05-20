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

        public FormLogIn() {
            InitializeComponent();
        }

        //Lukker formen hvis der trykkes på exit
        private void LblExit_Click(object sender, EventArgs e) {
            this.Hide();
        }

        //Hvis der klikkes på tekstboks for account id fjernes teksten så der er plads til at skrive
        private void TxtAccountIDInput_MouseClick(object sender, MouseEventArgs e) {
            if (!accountIDClicked) {
                TextBox box = sender as TextBox;
                box.Text = String.Empty;
                accountIDClicked = true;
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

        //Hvis tekstboks for password bliver ændret så sæt det visne tegn lig med * for at bevare password
        private void TxtPasswordInput_TextChanged_1(object sender, EventArgs e) {
            txtPasswordInput.MaxLength = 20; //Maks længde = 20
            txtPasswordInput.PasswordChar = '*';
            pnlPassword.BackColor = Color.FromArgb(114, 137, 218); //Sæt farven tilbage til normal
        }

        //Hvis tekstboks for account id bliver ændret
        private void TxtAccountID_TextChanged(object sender, EventArgs e) {
            pnlAccountID.BackColor = Color.FromArgb(114, 137, 218); //Sæt farven tilbage til normal
        }

        //Variable som bruges til at rykke rundt på formen
        private bool mouseDown; //Holdes venstre-klik nede eller ej
        private Point lastLocation; //Hvor var formen sidst
        //Hvis der trykkes ned på musen sættes bool mouseDown til sand og fortæller lokation til Point variablen
        private void LblLogIn_MouseDown(object sender, MouseEventArgs e) {
            mouseDown = true;
            lastLocation = e.Location;
        }
        //Hvis der gives slip på musen stopper det
        private void LblLogIn_MouseUp(object sender, MouseEventArgs e) {
            mouseDown = false;
        }
        //Når musen rykkes opdateres lokationen
        private void LblLogIn_MouseMove(object sender, MouseEventArgs e) {
            if (mouseDown) {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
                this.Update();
            }
        }

        //Hvis man forlader tekstboksen for account id
        private void TxtAccountID_Leave(object sender, EventArgs e) {
            if(txtAccountIDInput.Text.Length == 0) { //Hvis der intet er i tekstfeltet, erstat det med "Account ID", så brugeren ved hvad der skal skrives
                txtAccountIDInput.Text = "Account ID"; 
                accountIDClicked = false; //Sæt bool = false, så der igen kan klikkes på den for at fjerne teksten
            }
        }

        //Hvis man forlader tekstboksen for password
        private void TxtPasswordInput_Leave(object sender, EventArgs e) {
            if (txtPasswordInput.Text.Length == 0) { //Hvis der intet er i tekstfeltet, erstat det med "Password", så brugeren ved hvad der skal skrives
                txtPasswordInput.Text = "Password";
                txtPasswordInput.PasswordChar = '\0'; //Fjerner password character så der kan stå Password uden det bliver til *
                passwordClicked = false;  //Sæt bool = false, så der igen kan klikkes på den for at fjerne teksten
            }
        }

        //Klik event til login knappen.
        private void BtnLogInConfirm_Click(object sender, EventArgs e) {

            //Parser vores txtAccountIDInput til en int samt sætter den som en variable
            long AccountID = Convert.ToInt64(txtAccountIDInput.Text);
            //Hasher vores txtPasswordInput til MD5 (Mindste sikkerhedskrav til hvis man skal gemme et password)
            String Password = Utils.CalculateMD5Hash(txtPasswordInput.Text);

            logSuccess = true;
            //Hvis account id ikke passer med længden eller der bare står Account ID
            if (txtAccountIDInput.Text.Length != 6 || txtAccountIDInput.Text == "Account ID") {
                pnlAccountID.BackColor = Color.FromArgb(255, 0, 0); //Sæt panel farven for account id = rød
                goingToShake = true; //Sørger for at formen ryster hvis fejl
            }
            //Hvis password er mindre end 8 eller der bare står "Password"
            if (txtPasswordInput.Text.Length < 8 || txtPasswordInput.Text == "Password") {
                pnlPassword.BackColor = Color.FromArgb(255, 0, 0); //Sæt panel farven for password = rød
                goingToShake = true; //Sørger for at formen ryster hvis fejl
            }
            //Hvis formen skal ryste
            if (goingToShake) {
                Utils.Shake(this); //Ryst formen
                goingToShake = false; //Reset bool
                logSuccess = false; //Reset bool
                return;
            }
            //Hvis alle input møder kravene
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