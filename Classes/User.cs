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
    class User {

        public int ID { get; set; }
        public String Name { get; set; }
        public String Password { get; set; }
        public String Email { get; set; }
        public Boolean Suspended { get; set; }
        public List<Account> Accounts { get; set; }

        public User(String json) {
            JObject obj = JObject.Parse(@json);
            ID = (int)obj["ID"];
            Name = (String)obj["Name"];
            Password = (String)obj["Password"];
            Email = (String)obj["Email"];
            Suspended = (Boolean)obj["Suspended"];

            JArray accs = (JArray)obj["Accounts"];

            Accounts = new List<Account>();
            foreach (JObject acc in accs) {
                //Account(int accountNumber, String accountNickName, int accountOwnerID, Card accountCard) {
                int accountNumber = (int)acc["Number"];
                String accountNickName = (String) acc["NickName"];
                int accountOwnerID = this.ID;

                Card accountCard = null; //Lige nu indtil videre?..

                Accounts.Add(new Account(accountNumber, accountNickName, accountOwnerID, accountCard));

                //Skal ændres når vi ved hvad en konto skal indeholde :) Ligenu tager den bare og laver objektet om til en string så programmet ikke brokker sig.
                // Accounts.Add(new Account(acc.ToString(Newtonsoft.Json.Formatting.None), this));
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