using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OO_Bank.Classes {
    public class Account {
        public int Number;
        public String Name;
        public decimal balance;
        public long OwnerId;
        public Card Card;


        public Account(int accountNumber, String accountName, decimal balance, long accountOwnerId, Card accountCard) {
            this.Number = accountNumber;
            this.Name = accountName;
            this.balance = balance;
            this.OwnerId = accountOwnerId;
            this.Card = accountCard;
        }

        public void AddMoney(decimal Amount) {
            this.balance = this.balance + Amount;
        }
        public void RemoveMoney(decimal Amount) {
            this.balance = this.balance - Amount;
        }

        public JObject GetAsJson() {
            JObject tmpAccount = new JObject {
                { "Number", this.Number },
                { "Name", this.Name },
                { "balance", this.balance },
                { "OwnerId", this.OwnerId },
            };
            if(this.Card != null) {
                tmpAccount.Add("Card", this.Card.GetAsJson());
            }

            return tmpAccount;
        }
    }
}
