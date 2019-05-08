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
            lblCustomMessage.Text = message;
            ShowDialog();
        }
    }
}
