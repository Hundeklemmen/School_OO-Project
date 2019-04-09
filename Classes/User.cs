using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OO_Bank.Classes {
    class User {

        public String ID { get; set; }
        public String Name { get; set; }
        public String Password { get; set; }
        public String Email { get; set; }
        public Boolean Suspended { get; set; }
        public List<Account> Accounts { get; set; }

        public User(String json) {
            JObject obj = JObject.Parse(@json);
            ID = (String)obj["ID"];
            Name = (String)obj["Name"];
            Password = (String)obj["Password"];
            Email = (String)obj["Email"];
            Suspended = (Boolean)obj["Suspended"];

            JArray accs = (JArray)obj["Accounts"];

            Accounts = new List<Account>();
            foreach (String acc in accs) {
                Accounts.Add(new Account(acc, this));
            }
        }

        public JObject getAsJson() {
            JObject tempUserObj = new JObject();
            tempUserObj.Add("ID", this.ID);
            tempUserObj.Add("Name", this.Name);
            tempUserObj.Add("Password", this.Password);
            tempUserObj.Add("Email", this.Email);
            tempUserObj.Add("Suspended", this.Suspended);
            JArray tempAccounts = new JArray();
            foreach (Account acc in Accounts) {
                tempAccounts.Add(acc.getAsJson());
            }
            tempUserObj.Add("Accounts", tempAccounts);

            return tempUserObj;
        }

        public void save() {
            String userPath = Form1.usersPath + "/" + this.ID + ".json";
            using (StreamWriter file = File.CreateText(@userPath)) {
                JsonSerializer serializer = new JsonSerializer();
                //Serialize object directly into file stream
                serializer.Serialize(file, this.getAsJson());
            }
        }
    }
}