using System;
using OO_Bank.Classes;
using OO_Bank.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OO_Bank.Forms.Custom_Messages {
    public partial class FormTextInput : Form {

        public String Message;

        public FormTextInput(string message) {
            InitializeComponent();
            lblCustomMessage.Text = message;
            ShowDialog();
        }

        private void LblExit_Click(object sender, EventArgs e) {
            this.Hide();
        }

        private void BtnConfirm_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.OK;
            this.Message = txtAccountName.Text;
        }

        private void BtnCancel_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
        }

        private bool mouseDown;
        private Point lastLocation;
        private void FormMove_MouseDown(object sender, MouseEventArgs e) {
            mouseDown = true;
            lastLocation = e.Location;
        }
        private void FormMove_MouseUp(object sender, MouseEventArgs e) {
            mouseDown = false;
        }
        private void FormMove_MouseMove(object sender, MouseEventArgs e) {
            if (mouseDown) {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
                this.Update();
            }
        }
    }
}
