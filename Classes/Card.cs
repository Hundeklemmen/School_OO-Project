using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO_Bank.Classes {

    //Card = En konto's kredit kort.
    public class Card {

        public long Number; //Kort nummer
        public DateTime ExpireDate; //Udløbsdato
        public int SecurityNumber; //De tre numre bagpå
        public long Owner; //Kort ejeren
        public long AccountNumber; //Konto nummer

        //Her laver vi vores Kort objekt.
        public Card(long Number, DateTime ExpireDate, int SecurityNumber, long Owner, long AccountNumber) {
            this.Number = Number;
            this.ExpireDate = ExpireDate;
            this.SecurityNumber = SecurityNumber;
            this.Owner = Owner;
            this.AccountNumber = AccountNumber;
        }

        //Få det som JSON, dette bruges til når vi skal gemme kortet i en json fil.
        public JObject GetAsJson() {
            JObject tmpCard = new JObject {
                { "Number", this.Number },
                { "ExpireDate", this.ExpireDate },
                { "SecurityNumber", this.SecurityNumber },
                { "Owner", this.Owner },
                { "AccountNumber", this.AccountNumber }
            };
            return tmpCard;
        }
    }
}
