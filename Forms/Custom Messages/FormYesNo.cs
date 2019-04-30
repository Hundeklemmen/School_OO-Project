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
            lblCustomMessage.Text = Message;
            ShowDialog();
        }

        private void LblExit_Click(object sender, EventArgs e) {
            this.Hide();
        }

        public void BtnYes_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Yes;
        }

        private void BtnNo_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.No;
        }

        private bool mouseDown;
        private Point lastLocation;
        private void MoveForm_MouseDown(object sender, MouseEventArgs e) {
            mouseDown = true;
            lastLocation = e.Location;
        }
        private void MoveForm_MouseUp(object sender, MouseEventArgs e) {
            mouseDown = false;
        }
        private void MoveForm_MouseMove(object sender, MouseEventArgs e) {
            if (mouseDown) {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
                this.Update();
            }
        }
    }
}
