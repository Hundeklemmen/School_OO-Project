using Newtonsoft.Json.Linq;
using OO_Bank.Exceptions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO_Bank.Classes {
    class Transaction {
        public Account From;
        public Account To;
        public decimal Amount;
        public DateTime Time;

        public Transaction(Account From, Account To, decimal Amount, DateTime Time) {
            this.From = From;
            this.To = To;
            this.Amount = Amount;
            this.Time = Time;
        }


        public void Transfer() {
            From.RemoveMoney(this.Amount);
            To.AddMoney(this.Amount);
            this.Save();
        }

        public Boolean CanTransfer() {
            if (From.balance - this.Amount >= 0) {
                return true;
            } else {
                return false;
            }
        }

        public String GetFormatted() {
            String FromName = "Someone";
            try {
                FromName = Utils.GetUserByID(From.OwnerId).Name;
            } catch (UserException) {
                //Idk? Nyby, lav en custom alert box til hvis der opstår en fejl?
            }
            String ToName = "Someone";
            try {
                ToName = Utils.GetUserByID(To.OwnerId).Name;
            } catch (UserException) {
                //Idk? Nyby, lav en custom alert box til hvis der opstår en fejl?
            }
            return FromName + " sent $" + Amount + " to " + ToName;
        }

        public String GetFormattedAsSender() {
            String ToName = "Someone";
            try {
                ToName = Utils.GetUserByID(To.OwnerId).Name;
            } catch (UserException) {
                //Idk? Nyby, lav en custom alert box til hvis der opstår en fejl?
            }
            return "[" + this.Time.ToString("MM/dd/yyyy HH:mm") + "] " + "You have sent $" + Amount + " to " + ToName;
        }
        public String GetFormattedAsReciever() {
            String FromName = "Someone";
            try {
                FromName = Utils.GetUserByID(From.OwnerId).Name;
            } catch (UserException) {
                //Idk? Nyby, lav en custom alert box til hvis der opstår en fejl?
            }
            return "[" + this.Time.ToString("MM/dd/yyyy HH:mm") + "] " + FromName + " have sent you $" + Amount;
        }


        public void Save() {
            String FromPath = Settings.TransactionsPath + "/" + From.Number + ".txt";
            String ToPath = Settings.TransactionsPath + "/" + To.Number + ".txt";

            using (StreamWriter sw = File.AppendText(@FromPath)) {
                sw.WriteLine(this.GetFormattedAsSender());
            }
            using (StreamWriter sw = File.AppendText(ToPath)) {
                sw.WriteLine(this.GetFormattedAsReciever());
            }

            Utils.GetUserByID(From.OwnerId).Save();
            Utils.GetUserByID(To.OwnerId).Save();
        }

    }
}
