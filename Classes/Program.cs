using OO_Bank.Classes;
using OO_Bank.Forms.Custom_Messages;
using OO_Bank.User_Controls;
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
            Settings.OOProject = Settings.DesktopPath + "/OOProject";

            //Hvis vores projekt mappe ikke findes, så opretter vi den
            if (!Directory.Exists(@Settings.OOProject)) {
                //Hvis vores projekt mappe ikke findes
                Directory.CreateDirectory(@Settings.OOProject);
            }

            Settings.UsersPath = Settings.OOProject + "/users";
            if (!Directory.Exists(@Settings.UsersPath)) {
                Directory.CreateDirectory(@Settings.UsersPath);
            }

            Settings.TransactionsPath = Settings.OOProject + "/transactions";
            if (!Directory.Exists(@Settings.TransactionsPath)) {
                Directory.CreateDirectory(@Settings.TransactionsPath);
            }

            Settings.AccountInfoPath = Settings.OOProject + "/Account Info";
            if (!Directory.Exists(@Settings.AccountInfoPath)) {
                Directory.CreateDirectory(@Settings.AccountInfoPath);
            }

        }

    }
    public static class Settings {
        public static User CurrentUser { get; set; }
        public static String DesktopPath { get; set; }
        public static String OOProject { get; set; }
        public static String UsersPath { get; set; }
        public static String TransactionsPath { get; set; }
        public static String AccountInfoPath { get; set; }
        public static OverviewUC OverviewUC { get; set; }

        public static void ShowMessage(String Message) {
            FormMessage InfoMessage = new FormMessage(Message);
            InfoMessage.BringToFront();
        }
    }
}
