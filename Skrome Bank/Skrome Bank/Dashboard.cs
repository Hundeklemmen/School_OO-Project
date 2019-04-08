using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skrome_Bank {
    public partial class Dashboard : UserControl {
        public Dashboard() {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e) {
            Sign_up formSignUp = new Sign_up();
            formSignUp.ShowDialog();
        }

        private void btnLogIn_Click(object sender, EventArgs e) {
            Log_in formLogIn = new Log_in();
            formLogIn.ShowDialog();
        }
    }
}
