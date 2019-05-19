using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OO_Bank.Classes {

    //Account = Konto (Bank konto og ikke bruger)
    public class Account {
        public int Number;
        public String Name;
        public decimal balance;
        public long OwnerId; //Bruges så vi kan sporer tilbage hvem der ejer kontoen.
        public Card Card;

        //Her laver vi vores Account objekt
        public Account(int accountNumber, String accountName, decimal balance, long accountOwnerId, Card accountCard) {
            this.Number = accountNumber;
            this.Name = accountName;
            this.balance = balance;
            this.OwnerId = accountOwnerId;
            this.Card = accountCard;
        }

        //Tilføj penge:
        public void AddMoney(decimal Amount) {
            this.balance += Amount;
        }
        //Fjern penge:
        public void RemoveMoney(decimal Amount) {
            this.balance -= Amount;
        }

        //Få det som JSON, dette bruges til når vi skal gemme kontoen i en json fil.
        public JObject GetAsJson() {
            JObject tmpAccount = new JObject {
                { "Number", this.Number },
                { "Name", this.Name },
                { "balance", this.balance },
                { "OwnerId", this.OwnerId },
            };
            //Tjekker om kontoen har et kort
            if(this.Card != null) {
                //Hvis den har
                tmpAccount.Add("Card", this.Card.GetAsJson()); //Ligesom alle vores andre objekter, så har den "GetAsJson()" så vi kan gemme det i en fil.
            }
            return tmpAccount;
        }
    }
}
