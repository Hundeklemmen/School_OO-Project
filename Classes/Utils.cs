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

        //Genererer tilfældigt tal
        public static Random random = new Random();
        public static long LongRandom(long min, long max, Random rand) {
            byte[] buf = new byte[8];
            rand.NextBytes(buf);
            long longRand = BitConverter.ToInt64(buf, 0);
            return (Math.Abs(longRand % (max - min)) + min);
        }

        //Genererer et kort nummer som der altid starter med 9352 efterfulgt af 12 tal
        public static long GenerateCardNumber() {
            long randomNumber = LongRandom(100000000000, 1000000000000, random);
            string randomString = "9352" + randomNumber.ToString();
            randomNumber = Convert.ToInt64(randomString);
            return randomNumber;
        }

        //Genererer de tre numre bag på kortet
        public static int GenerateSecurityNumber() {
            int randomNumber = random.Next(100, 1000);
            return randomNumber;
        }

        //Formatterer saldoen til at være let læseligt i DKK
        public static String BalanceFormatted(decimal balance) {
            return String.Format("{0:n}", balance) + " DKK";
        }

        //Genererer et ID
        public static long GenerateID() {
            long randomNumber = LongRandom(100000, 1000000, random);
            return randomNumber;
        }

        //Genererer et konto nummer
        public static int GenerateAccountNumber() {
            int randomNumber = random.Next(100000000, 1000000000);
            return randomNumber;
        }

        //Får en bruger fra personens ID
        public static User GetUserByID(long ID) {
            String userPath = Settings.UsersPath + "/" + ID + ".json";
            if (File.Exists(userPath)) {
                String userJSON = File.ReadAllText(userPath);
                return UserFromJson(userJSON); //Konventere JSON formatten om til vores Bruger Objekt (User class)
            } else {
                throw new UserException("User not found!"); //Hvis brugen ikke findes, så kaster vi vores egen Exception kaldet UserEkseption.
            }
        }
        
        //Få en bruger fra en path
        public static User GetUserByPath(String userPath) {
            if (File.Exists(userPath)) {
                String userJSON = File.ReadAllText(userPath);
                return UserFromJson(userJSON); //Konventere JSON formatten om til vores Bruger Objekt (User class)
            } else {
                throw new UserException("User not found!"); //Hvis brugen ikke findes, så kaster vi vores egen Exception kaldet UserEkseption.
            }
        }

        //Tjekker om indtastet email er gyldig
        public static bool IsValidEmail(string email) {
            try {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch {
                return false;
            }
        }
        
        //Her konventere vi en JSON string om til vores user objekt.
        public static User UserFromJson(String json) {
            //Starter med at parse det:
            JObject obj = JObject.Parse(@json);
            //Her begyndet vi at sætte de forskellige user variable
            long ID = (long)obj["ID"];
            String Name = (String)obj["Name"];
            String Password = (String)obj["Password"];
            String Email = (String)obj["Email"];
            String Mobile = (String)obj["Mobile"];
            Boolean Suspended = (Boolean)obj["Suspended"];
            Boolean Admin = (Boolean)obj["Admin"];
            //Vores Account liste bliver gemt som en JSON array.
            JArray accs = (JArray)obj["Accounts"];
            //Her laver vi en ny liste med kontoer, som vi kan adde til.
            List<Account> Accounts = new List<Account>();
            //Eftersom det ligenu er en json object i et json array, så skal vi loop igennem det for at kunne lave det om til de forskellige objekter
            foreach (JObject acc in accs) {
                //Her sætter vi konto variablerne
                int accountNumber = (int)acc["Number"];
                String accountName = (String)acc["Name"];
                decimal accountBalance = (decimal)acc["balance"];
                long accountOwnerID = ID;
                Card accountCard = null;

                //Tjekker om kontoen indeholder et kort:
                if (acc.ContainsKey("Card") == true) {
                    //Hvis den indeholder et kort, så sætter vi de forskellige variabler.
                    JObject tmpCard = (JObject)acc["Card"];
                    long CardNumber = (long)tmpCard["Number"];
                    DateTime CardExpireDate = (DateTime)tmpCard["ExpireDate"];
                    int CardSecurityNumber = (int)tmpCard["SecurityNumber"];
                    long CardOwner = (long)tmpCard["Owner"];
                    long CardAccountNumber = (long)tmpCard["AccountNumber"];
                    //Her laver vi vores kort objekt
                    accountCard = new Card(CardNumber, CardExpireDate, CardSecurityNumber, CardOwner, CardAccountNumber);
                }
                //Her laver vi et nyt konto objekt og tilføjer den til vores Accounts liste.
                Accounts.Add(new Account(accountNumber, accountName, accountBalance, accountOwnerID, accountCard));
            }
            //Her laver vi et bruger objekt og returner det.
            return new User(ID, Name, Password, Email, Mobile, Suspended, Admin, Accounts);
        }

        //Ryster formen, bruges hvis der opstår fejl
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
            //Step 1, udregn MD5 hash fra input
            MD5 md5 = MD5.Create();
            byte[] inputBytes = Encoding.ASCII.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputBytes);

            //Step 2, konverter byte array til hex string
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++) {
                sb.Append(hash[i].ToString("X2"));
            }
            return sb.ToString();
        }
    }

    //En hjælper til foreach
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