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
    public partial class Log_in : Form {
        public Log_in() {
            InitializeComponent();
        }

        bool formMove;
        int formMoveX;
        int formMoveY;

        //When mouse is holding down on the panel, set move to true and grab X and Y
        private void pnlLogIn_MouseDown(object sender, MouseEventArgs e) {
            formMove = true;
            formMoveX = e.X;
            formMoveY = e.Y;
        }
        
        //When mouse is released, set move to false
        private void pnlLogIn_MouseUp(object sender, MouseEventArgs e) {
            formMove = false;
        }

        //If move form is set to true, set the location to new mouse location
        private void pnlLogIn_MouseMove(object sender, MouseEventArgs e) {
            if (formMove) {
                this.SetDesktopLocation(MousePosition.X - formMoveX, MousePosition.Y - formMoveY);
            }

        }

        private void btnLogIn_Click(object sender, EventArgs e) {

        }

        private void lblExit_Click(object sender, EventArgs e) {
            this.Hide();
        }
    }
}
