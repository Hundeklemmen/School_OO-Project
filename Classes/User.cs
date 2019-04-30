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
    public class User {

        public long ID { get; set; }
        public String Name { get; set; }
        public String Password { get; set; }
        public String Email { get; set; }
        public String Mobile { get; set; }
        public Boolean Suspended { get; set; }
        public Boolean Admin { get; set; }
        public List<Account> Accounts { get; set; }

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
            JArray tempAccounts = new JArray();
            foreach (Account acc in Accounts) {
                tempAccounts.Add(acc.GetAsJson());
            }
            tempUserObj.Add("Accounts", tempAccounts);

            return tempUserObj;
        }

        public void Save() {
            String userPath = Settings.UsersPath + "/" + this.ID + ".json";
            using (StreamWriter file = File.CreateText(@userPath)) {
                JsonSerializer serializer = new JsonSerializer();
                //Serialize object directly into file stream
                serializer.Serialize(file, this.GetAsJson());
            }
        }
    }
}