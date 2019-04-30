using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OO_Bank.Classes {
    public class Account {
        int Number;
        String NickName;
        decimal balance;
        long OwnerId;
        Card Card;

        //Test1234
        public Account(int accountNumber, String accountNickName, decimal balance, long accountOwnerId, Card accountCard) {
            this.Number = accountNumber;
            this.NickName = accountNickName;
            this.balance = balance;
            this.OwnerId = accountOwnerId;
            this.Card = accountCard;
        }

        public void AddMoney(decimal Amount) {
            this.balance =+ Amount;
        }
        public void RemoveMoney(decimal Amount) {
            this.balance =- Amount;
        }

        public JObject GetAsJson() {
            return new JObject();
        }
    }
}
