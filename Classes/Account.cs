﻿using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OO_Bank.Classes {
    class Account {
        
        public Account(int accountNumber, String accountNickName, int accountOwnerID, Card accountCard) {
           // MessageBox.Show(json);
           //MessageBox.Show(user.ID);
        }

        public JObject getAsJson() {
            return new JObject();
        }
    }
}