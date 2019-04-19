using OO_Bank.User_Controls;
using OO_Bank.User_Controls.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
    }
}
