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
    public partial class Form1 : Form {

        bool formMove;
        int formMoveX;
        int formMoveY;

        public Form1() {
            InitializeComponent();
            //Makes sure first page is Dashboard
            dashboard1.BringToFront();
        }


        private void btnDashboard_Click(object sender, EventArgs e) {
            //Moves current page bar to current button
            pnlCurrentPage.Height = btnDashboard.Height;
            pnlCurrentPage.Top = btnDashboard.Top;
            //Sets Dashboard visible, rest invisible
            dashboard1.Visible = true;
            account1.Visible = false;
            settings1.Visible = false;
            admin1.Visible = false;
        }

        private void btnAccount_Click(object sender, EventArgs e) {
            //Moves current page bar to current button
            pnlCurrentPage.Height = btnAccount.Height;
            pnlCurrentPage.Height = btnAccount.Height;
            //Sets Account visible, rest invisible
            pnlCurrentPage.Top = btnAccount.Top;
            dashboard1.Visible = false;
            account1.Visible = true;
            settings1.Visible = false;
            admin1.Visible = false;
        }

        private void btnSettings_Click(object sender, EventArgs e) {
            //Moves current page bar to current button
            pnlCurrentPage.Height = btnSettings.Height;
            pnlCurrentPage.Top = btnSettings.Top;
            //Sets Settings visible, rest invisible
            dashboard1.Visible = false;
            account1.Visible = false;
            settings1.Visible = true;
            admin1.Visible = false;
        }

        private void btnAdmin_Click(object sender, EventArgs e) {
            //Moves current page bar to current button
            pnlCurrentPage.Height = btnAdmin.Height;
            pnlCurrentPage.Top = btnAdmin.Top;
            //Sets Admin visible, rest invisible
            dashboard1.Visible = false;
            account1.Visible = false;
            settings1.Visible = false;
            admin1.Visible = true;
        }

        //When mouse is holding down on the panel, set move to true and grab X and Y
        private void pnlTop_MouseDown(object sender, MouseEventArgs e) {
            formMove = true;
            formMoveX = e.X;
            formMoveY = e.Y;
        }
        //When mouse is released, set move to false
        private void pnlTop_MouseUp(object sender, MouseEventArgs e) {
            formMove = false;
        }
        //If move form is set to true, set the location to new mouse location
        private void pnlTop_MouseMove(object sender, MouseEventArgs e) {
            if (formMove) {
                this.SetDesktopLocation(MousePosition.X - formMoveX, MousePosition.Y - formMoveY);
            }
        }

        //When click on Exit, ask if you want to exit
        private void lblExit_MouseClick(object sender, MouseEventArgs e) {
            DialogResult result = MessageBox.Show("Do you want to exit the application?", "Exit application", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes) {
                Application.Exit();
            }
        }
    }
}
