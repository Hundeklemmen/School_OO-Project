using Newtonsoft.Json.Linq;
using OO_Bank.Exceptions;
using OO_Bank.User_Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OO_Bank.Classes {
    class Utils {

        public static Random random = new Random();
        public static long LongRandom(long min, long max, Random rand) {
            byte[] buf = new byte[8];
            rand.NextBytes(buf);
            long longRand = BitConverter.ToInt64(buf, 0);
            return (Math.Abs(longRand % (max - min)) + min);
        }

        public static long GenerateCardNumber() {
            long randomNumber = LongRandom(100000000000, 1000000000000, random);
            string randomString = "9352" + randomNumber.ToString();
            randomNumber = Convert.ToInt64(randomString);
            return randomNumber;
            /*
            String date = DateTime.Now.ToFileTime().ToString();
            date = date.Remove(0, (date.Length - 12));
            string stringCard = "9352" + date.ToString();
            long cardNumber = Convert.ToInt64(stringCard);
            return cardNumber;
            */
        }

        public static int GenerateSecurityNumber() {
            int randomNumber = random.Next(100, 1000);
            return randomNumber;
            /*
            String date = DateTime.Now.ToFileTime().ToString();
            date = date.Remove(0, (date.Length - 3));
            int securityNumber = int.Parse(date);
            return securityNumber;
            */
        }

        public static String BalanceFormatted(decimal balance) {
            return String.Format("{0:n}", balance) + " DKK";
        }

        public static long GenerateID() {
            long randomNumber = LongRandom(100000, 1000000, random);
            return randomNumber;
            /*
            int tries = 0;
            Retry:
            String date = DateTime.Now.ToFileTime().ToString();
            date = date.Remove(0, (date.Length - 6));
            if (tries == 10000) {
                MessageBox.Show("No more IDs, please contact an administrator");
                goto Retry;
            } else if (int.Parse(date) < 100000) {
                tries++;
                goto Retry;
            }
            else if (File.Exists(Settings.UsersPath + "/" + date + ".json")) {
                tries++;
                goto Retry;
            }
            else {
                long Id = Convert.ToInt64(date);
                return Id;
            }
            */
        }

        public static int GenerateAccountNumber() {
            int randomNumber = random.Next(100000000, 1000000000);
            return randomNumber;
        }

        public static User GetUserByID(long ID) {
            String userPath = Settings.UsersPath + "/" + ID + ".json";
            if (File.Exists(userPath)) {
                String userJSON = File.ReadAllText(userPath);
                return UserFromJson(userJSON);
            } else {
                throw new UserException("User not found!");
            }
        }

        public static User GetUserByPath(String userPath) {
            if (File.Exists(userPath)) {
                String userJSON = File.ReadAllText(userPath);
                return UserFromJson(userJSON);
            } else {
                throw new UserException("User not found!");
            }
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
                String accountName = (String)acc["Name"];
                decimal accountBalance = (decimal)acc["balance"];
                long accountOwnerID = ID;

                //public Card(long Number, DateTime ExpireDate, int SecurityNumber, long Owner, long AccountNumber) {
                Card accountCard = null;
                if (acc.ContainsKey("Card") == true) {
                    JObject tmpCard = (JObject)acc["Card"];
                    long CardNumber = (long)tmpCard["Number"];
                    DateTime CardExpireDate = (DateTime)tmpCard["ExpireDate"];
                    int CardSecurityNumber = (int)tmpCard["SecurityNumber"];
                    long CardOwner = (long)tmpCard["Owner"];
                    long CardAccountNumber = (long)tmpCard["AccountNumber"];
                    accountCard = new Card(CardNumber, CardExpireDate, CardSecurityNumber, CardOwner, CardAccountNumber);
                }
                Accounts.Add(new Account(accountNumber, accountName, accountBalance, accountOwnerID, accountCard));
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
        public static void Shake(UserControl form) {
            var original = form.Location;
            var rnd = new Random(1337);
            const int shake_amp = 10;
            for (int i = 0; i < 10; i++) {
                form.Location = new Point(original.X + rnd.Next(-shake_amp, shake_amp), original.Y + rnd.Next(-shake_amp, shake_amp));
                System.Threading.Thread.Sleep(20);
            }
            form.Location = original;
        }


        public static string CalculateMD5Hash(string input) {
            // step 1, calculate MD5 hash from input
            MD5 md5 = MD5.Create();
            byte[] inputBytes = Encoding.ASCII.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputBytes);

            // step 2, convert byte array to hex string
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++) {
                sb.Append(hash[i].ToString("X2"));
            }
            return sb.ToString();
        }
    }
    public static class ForEachHelper {
        public sealed class Item<T> {
            public int Index { get; set; }
            public T Value { get; set; }
            public bool IsLast { get; set; }
        }

        public static IEnumerable<Item<T>> WithIndex<T>(IEnumerable<T> enumerable) {
            Item<T> item = null;
            foreach (T value in enumerable) {
                Item<T> next = new Item<T>
                {
                    Index = 0,
                    Value = value,
                    IsLast = false
                };
                if (item != null) {
                    next.Index = item.Index + 1;
                    yield return item;
                }
                item = next;
            }
            if (item != null) {
                item.IsLast = true;
                yield return item;
            }
        }
    }
}
