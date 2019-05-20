using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using OO_Bank.Exceptions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OO_Bank.Classes {

    //User = Brugeren med alle kontoer.
    public class User {

        public long ID; //ID på brugeren
        public String Name; //Navnet på brugeren
        public String Password; //Kodeordet for brugeren
        public String Email; //Email for brugeren
        public String Mobile; //Mobil nummer på brugeren
        public Boolean Suspended; //Er brugeren suspenderet eller ej
        public Boolean Admin; //Er brugeren en admin-konto eller ej
        public List<Account> Accounts; //Brugerens kontoer

        public User(long ID, String Name, String Password, String Email, String Mobile, Boolean Suspended, Boolean Admin, List<Account> Accounts) {
            this.ID = ID;
            this.Name = Name;
            this.Password = Password;
            this.Email = Email;
            this.Mobile = Mobile;
            this.Suspended = Suspended;
            this.Admin = Admin;
            this.Accounts = Accounts;
        }

        //Få det som JSON, dette bruges til når vi skal gemme kontoen i en json fil.
        public JObject GetAsJson() {
            JObject tempUserObj = new JObject {
                { "ID", this.ID },
                { "Name", this.Name },
                { "Password", this.Password },
                { "Email", this.Email },
                { "Mobile", this.Mobile },
                { "Suspended", this.Suspended },
                { "Admin", this.Admin }
            };
            //Lav et nyt Json Array:
            JArray tempAccounts = new JArray();
            //Loop alle accounts:
            foreach (Account acc in Accounts) {
                //Tilføj account til vores json array
                tempAccounts.Add(acc.GetAsJson());
            }
            //Tilføjer vores accounts json array til vores user json objekt.
            tempUserObj.Add("Accounts", tempAccounts);

            return tempUserObj;
        }

        //Her gemmer vi vores bruger i en json fil.
        public void Save() {
            String userPath = Settings.UsersPath + "/" + this.ID + ".json";
            using (StreamWriter file = File.CreateText(@userPath)) {
                JsonSerializer serializer = new JsonSerializer();
                //Serializerer objektet direkte ind i fil
                serializer.Serialize(file, this.GetAsJson());
            }
        }
    }
}