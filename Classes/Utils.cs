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
        public static User getUserByID(int ID) {
            String userPath = Form1.usersPath + "/" + ID + ".json";
            if (File.Exists(userPath)) {
                String userJSON = File.ReadAllText(userPath);
                return new User(userJSON);
            }
            else {
                throw new UserException("User not found!");
            }
        }
        public static int generateID() {
            return int.Parse(DateTime.Now.ToFileTime().ToString().Remove(0, 8));
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

        public static void Shake(Form form) {
            var original = form.Location;
            var rnd = new Random(1337);
            const int shake_amplitude = 10;
            for (int i = 0; i < 10; i++) {
                form.Location = new Point(original.X + rnd.Next(-shake_amplitude, shake_amplitude), original.Y + rnd.Next(-shake_amplitude, shake_amplitude));
                System.Threading.Thread.Sleep(20);
            }
            form.Location = original;
        }
    }
}
