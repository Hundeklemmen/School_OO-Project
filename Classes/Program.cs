using OO_Bank.Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OO_Bank {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static FormLogSign formLogSign;

        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Generate our files..
            GenerateFiles();

            //Create new Log in/Sign up form and Run it
            formLogSign = new FormLogSign();
            Application.Run(formLogSign);
        }

        public static void GenerateFiles() {
            //Vores skrivebord fil sti
            Settings.DesktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            //Specificere vores OO projekt fil placering
            Settings.OOProjekt = Settings.DesktopPath + "/OOProjekt";

            //Hvis vores projekt mappe ikke findes, så opretter vi den
            if (!Directory.Exists(@Settings.OOProjekt)) {
                //Hvis vores projekt mappe ikke findes
                Directory.CreateDirectory(@Settings.OOProjekt);
            }

            Settings.UsersPath = Settings.OOProjekt + "/users";
            if (!Directory.Exists(@Settings.UsersPath)) {
                Directory.CreateDirectory(@Settings.UsersPath);
            }

        }

    }
    public static class Settings {
        public static User CurrentUser { get; set; }
        public static String DesktopPath { get; set; }
        public static String OOProjekt { get; set; }
        public static String UsersPath { get; set; }
    }
}
