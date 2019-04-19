using Newtonsoft.Json.Linq;
using OO_Bank.Exceptions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OO_Bank.Classes {
    class Utils {


        public static User GetUserByID(long ID) {
            String userPath = Settings.UsersPath + "/" + ID + ".json";
            if (File.Exists(userPath)) {
                String userJSON = File.ReadAllText(userPath);
                return UserFromJson(userJSON);
            } else {
                throw new UserException("User not found!");
            }
        }

        public static long GenerateID() {
            String date = DateTime.Now.ToFileTime().ToString();
            date = date.Remove(0, (date.Length - 4));
            long Id = Convert.ToInt64(date); 
            return Id;
        }

        public static bool IsValidEmail(string email) {
            try {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch {
                return false;
            }
        }
        
        public static User UserFromJson(String json) {
            JObject obj = JObject.Parse(@json);
            long ID = (long)obj["ID"];
            String Name = (String)obj["Name"];
            String Password = (String)obj["Password"];
            String Email = (String)obj["Email"];
            String Mobile = (String)obj["Mobile"];
            Boolean Suspended = (Boolean)obj["Suspended"];
            Boolean Admin = (Boolean)obj["Admin"];

            JArray accs = (JArray)obj["Accounts"];

            List<Account> Accounts = new List<Account>();
            foreach (JObject acc in accs) {
                int accountNumber = (int)acc["Number"];
                String accountNickName = (String)acc["NickName"];
                decimal accountBalance = (decimal)acc["Balance"];
                long accountOwnerID = ID;

                //public Card(long Number, DateTime ExpireDate, int SecurityNumber, long Owner, long AccountNumber) {
                Card accountCard = null; //Lige nu indtil videre?.. fordi card ikke er done

                Accounts.Add(new Account(accountNumber, accountNickName, accountBalance, accountOwnerID, accountCard));
            }
            return new User(ID, Name, Password, Email, Mobile, Suspended, Admin, Accounts);
        }

        public static void Shake(Form form) {
            var original = form.Location;
            var rnd = new Random(1337);
            const int shake_amp = 10;
            for (int i = 0; i < 10; i++) {
                form.Location = new Point(original.X + rnd.Next(-shake_amp, shake_amp), original.Y + rnd.Next(-shake_amp, shake_amp));
                System.Threading.Thread.Sleep(20);
            }
            form.Location = original;
        }
    }
}
