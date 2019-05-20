using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OO_Bank.Forms {
    public partial class FormYesNo : Form {
        public FormYesNo(String Message) {
            InitializeComponent();
            //Sætter den brugerdefinerede besked til at stå på formen
            lblCustomMessage.Text = Message;
            //Viser formen
            ShowDialog();
        }

        //Lukker formen hvis der trykkes "X"
        private void LblExit_Click(object sender, EventArgs e) {
            this.Hide();
        }

        //Hvis der trykkes Yes luk form og sæt DialogResult som Yes
        public void BtnYes_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Yes;
        }

        //Hvis der trykkes No luk form og sæt DialogResult som No
        private void BtnNo_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.No;
        }

        //Variable som bruges til at rykke rundt på formen
        private bool mouseDown; //Holdes venstre-klik nede eller ej
        private Point lastLocation; //Hvor var formen sidst
        //Hvis der trykkes ned på musen sættes bool mouseDown til sand og fortæller lokation til Point variablen
        private void MoveForm_MouseDown(object sender, MouseEventArgs e) {
            mouseDown = true;
            lastLocation = e.Location;
        }
        //Hvis der gives slip på musen stopper det
        private void MoveForm_MouseUp(object sender, MouseEventArgs e) {
            mouseDown = false;
        }
        //Når musen rykkes opdateres lokationen
        private void MoveForm_MouseMove(object sender, MouseEventArgs e) {
            if (mouseDown) {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
                this.Update();
            }
        }
    }
}