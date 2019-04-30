using OO_Bank.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO_Bank.Classes {
    class Transaction {
        Account From;
        Account To;
        decimal Amount;
        DateTime Time;

        public Transaction(Account From, Account To, decimal Amount, DateTime Time) {
            this.From = From;
            this.To = To;
            this.Amount = Amount;
            this.Time = Time;
        }

        public String GetFormatted() {
            String FromName = "Someone";
            try {
                FromName = Utils.GetUserByID(From.OwnerId).Name;
            } catch (UserException e) {
                //Idk? Nyby, lav en custom alert box til hvis der opstår en fejl?
            }
            String ToName = "Someone";
            try {
                ToName = Utils.GetUserByID(To.OwnerId).Name;
            } catch (UserException e) {
                //Idk? Nyby, lav en custom alert box til hvis der opstår en fejl?
            }
            return FromName + " sended $" + Amount + " to " + ToName;
        }

    }
}
