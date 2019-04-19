using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO_Bank.Classes {
    public class Card {
        /*
        - Card:
            - Card Number
            - Expiry date
            - The 3 security numbers on the back
            - Card holder
            - Account Number
        */
        public long Number { get; set; }
        public DateTime ExpireDate { get; set; }
        public int SecurityNumber { get; set; }
        public long Owner { get; set; }
        public long AccountNumber { get; set; }

        public Card(long Number, DateTime ExpireDate, int SecurityNumber, long Owner, long AccountNumber) {
            this.Number = Number;
            this.ExpireDate = ExpireDate;
            this.SecurityNumber = SecurityNumber;
            this.Owner = Owner;
            this.AccountNumber = AccountNumber;
        }
    }
}
