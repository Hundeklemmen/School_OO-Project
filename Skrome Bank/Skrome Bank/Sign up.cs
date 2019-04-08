using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skrome_Bank {
    public partial class Sign_up : Form {
        public Sign_up() {
            InitializeComponent();
        }

        bool formMove;
        int formMoveX;
        int formMoveY;

        //When mouse is holding down on the panel, set move to true and grab X and Y
        private void pnlSignUp_MouseDown(object sender, MouseEventArgs e) {
            formMove = true;
            formMoveX = e.X;
            formMoveY = e.Y;
        }

        //When mouse is released, set move to false
        private void pnlSignUp_MouseUp(object sender, MouseEventArgs e) {
            formMove = false;
        }

        //If move form is set to true, set the location to new mouse location
        private void pnlSignUp_MouseMove(object sender, MouseEventArgs e) {
            if (formMove) {
                this.SetDesktopLocation(MousePosition.X - formMoveX, MousePosition.Y - formMoveY);
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e) {

        }

        private void lblExit_Click(object sender, EventArgs e) {
            this.Hide();
        }
    }
}
