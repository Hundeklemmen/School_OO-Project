using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OO_Bank.Forms.Custom_Messages {
    public partial class FormMessage : Form {
        public FormMessage(string message) {
            InitializeComponent();
            //Sætter den brugerdefinerede besked til at stå på formen
            lblCustomMessage.Text = message;
            //Viser formen
            ShowDialog();
        }

        //Lukker formen hvis der trykkes "Ok"
        private void BtnOk_Click(object sender, EventArgs e) {
            this.Hide();
        }

        //Variable som bruges til at rykke rundt på formen
        private bool mouseDown; //Holdes venstre-klik nede eller ej
        private Point lastLocation; //Hvor var formen sidst
        //Hvis der trykkes ned på musen sættes bool mouseDown til sand og fortæller lokation til Point variablen
        private void FormMove_MouseDown(object sender, MouseEventArgs e) {
            mouseDown = true;
            lastLocation = e.Location;
        }
        //Hvis der gives slip på musen stopper det
        private void FormMove_MouseUp(object sender, MouseEventArgs e) {
            mouseDown = false;
        }
        //Når musen rykkes opdateres lokationen
        private void FormMove_MouseMove(object sender, MouseEventArgs e) {
            if (mouseDown) {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
                this.Update();
            }
        }

        //Lukker formen hvis der trykkes på "X"
        private void LblExit_Click(object sender, EventArgs e) {
            this.Hide();
        }
    }
}