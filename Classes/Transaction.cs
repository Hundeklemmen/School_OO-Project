using Newtonsoft.Json.Linq;
using OO_Bank.Exceptions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO_Bank.Classes {

    //Transaction = Når der sker en overførsel mellem 2 kontoer
    class Transaction {
        public Account From;
        public Account To;
        public decimal Amount;
        public DateTime Time;

        //Her laver vi vores transaction objekt 
        public Transaction(Account From, Account To, decimal Amount, DateTime Time) {
            this.From = From;
            this.To = To;
            this.Amount = Amount;
            this.Time = Time;
        }

        //Fjerner og tilføjer pengene til de 2 kontoer
        public void Transfer() {
            From.RemoveMoney(this.Amount);
            To.AddMoney(this.Amount);
            this.Save();
        }

        //Tjekker om "fra" kontoen har nok penge
        public Boolean CanTransfer() {
            if (From.balance - this.Amount >= 0) {
                return true;
            } else {
                return false;
            }
        }

        //Denne bruges når vi skal gemme transactionen i læsebar form.
        public String GetFormattedAsSender() {
            String ToName = "Someone";
            try {
                ToName = Utils.GetUserByID(To.OwnerId).Name;
            } catch (UserException) {
                //Idk? Nyby, lav en custom alert box til hvis der opstår en fejl?
            }
            return "[" + this.Time.ToString("MM/dd/yyyy HH:mm") + "] " + "You have sent " + Utils.BalanceFormatted(Amount) + " to " + ToName;
        }
        public String GetFormattedAsReciever() {
            String FromName = "Someone";
            try {
                FromName = Utils.GetUserByID(From.OwnerId).Name;
            } catch (UserException) {
                //Idk? Nyby, lav en custom alert box til hvis der opstår en fejl?
            }
            return "[" + this.Time.ToString("MM/dd/yyyy HH:mm") + "] " + FromName + " have sent you " + Utils.BalanceFormatted(Amount);
        }


        //Når vi gemmer transaktionen i en konto's transcations fil.
        //Denne fil loades når man skifter konto inde i OverviewUC
        public void Save() {
            String FromPath = Settings.TransactionsPath + "/" + From.Number + ".txt";
            String ToPath = Settings.TransactionsPath + "/" + To.Number + ".txt";

            using (StreamWriter sw = File.AppendText(@FromPath)) {
                sw.WriteLine(this.GetFormattedAsSender());
            }
            using (StreamWriter sw = File.AppendText(ToPath)) {
                sw.WriteLine(this.GetFormattedAsReciever());
            }

            //Gem fra brugeren:
            Utils.GetUserByID(From.OwnerId).Save();

            //Her opdatere vi bruger objektet før vi gemmer det:
            User toUser = Utils.GetUserByID(To.OwnerId);
            foreach(var item in ForEachHelper.WithIndex(toUser.Accounts)) {
                Account _acc = item.Value;
                if(_acc.Number == To.Number) {
                    toUser.Accounts[item.Index] = To;
                }
            }
            toUser.Save();
        }

    }
}
