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

        public FormLogSign() {
            InitializeComponent();
        }

        //Variable som bruges til at rykke rundt på formen
        private bool mouseDown; //Holdes venstre-klik nede eller ej
        private Point lastLocation; //Hvor var formen sidst
        //Hvis der trykkes ned på musen sættes bool mouseDown til sand og fortæller lokation til Point variablen
        private void LblWelcome_MouseDown(object sender, MouseEventArgs e) {
            mouseDown = true;
            lastLocation = e.Location;
        }
        //Hvis der gives slip på musen stopper det
        private void LblWelcome_MouseUp(object sender, MouseEventArgs e) {
            mouseDown = false;
        }
        //Når musen rykkes opdateres lokationen
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

        //Til at teste main-form uden at skulle log in eller sign up hele tiden
        private void BtnTesting_Click(object sender, EventArgs e) {
            try {
                User user = Utils.GetUserByID(111111);
                Settings.CurrentUser = user;
                var t = new Thread(() => Application.Run(new FormMain()));
                t.Start();
                Application.OpenForms["FormLogSign"].Close();
            } catch (UserException) {
                //Hvis bruger 111111 (test bruger) ikke eksisterer, lav ny test bruger
                MessageBox.Show("Test user 111111 doesn't exist, creating new test user.");
                //Alle test-kontoerne laves her
                List<Account> accounts = new List<Account>
                {
                    new Account(1331253125, "Mad", 2007.98m, 111111, new Card(9352192417248172, DateTime.Now, 421, 111111, 133125312)),
                    new Account(1725712525, "Opsparing", 2582858.2952m, 111111, null),
                    new Account(1125221525, "Hobby", 1272.23m, 111111, null),
                    new Account(1717281472, "SU", 0.0m, 111111, null)
                };
                User user = new User(111111, "Michael", Utils.CalculateMD5Hash("MichaelElskerKatte8716VroomVroom"), "AalborgHTX@gmail.com", "72505800", false, true, accounts);
                user.Save();
                //Gemmer brugeren i settings / Globale variabler, så resten af programmet kan tilgå den.
                Settings.CurrentUser = user;
                //Åben main bank form og luk start formen
                var t = new Thread(() => Application.Run(new FormMain()));
                t.Start();
                Application.OpenForms["FormLogSign"].Close();
            }
        }
    }
}