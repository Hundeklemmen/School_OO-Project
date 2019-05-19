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

        //Generer filer til programmet, så det virker korrekt.
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

            //Sætter vores path til bruger mappen
            Settings.UsersPath = Settings.OOProject + "/users";
            //Tjekker om den findes
            if (!Directory.Exists(@Settings.UsersPath)) {
                //Hvis ikke, så laver vi den nye mappe
                Directory.CreateDirectory(@Settings.UsersPath);
            }

            //Sætter vores path til transactions mappen
            Settings.TransactionsPath = Settings.OOProject + "/transactions";
            //Tjekker om den findes
            if (!Directory.Exists(@Settings.TransactionsPath)) {
                //Hvis ikke, så laver vi den nye mappe
                Directory.CreateDirectory(@Settings.TransactionsPath);
            }

            
            //Account info bruges til at gemme personens account, hvis han inde i my account trykker gem info.
            //Sætter vores path til account info mappen
            Settings.AccountInfoPath = Settings.OOProject + "/Account Info";
            //Tjekker om den findes
            if (!Directory.Exists(@Settings.AccountInfoPath)) {
                //Hvis ikke, så laver vi den nye mappe
                Directory.CreateDirectory(@Settings.AccountInfoPath);
            }

        }

    }
    //Settings class som er public og static, så alle vores andre classes kan tilgå vores indstillinger eller globale variabler.
    public static class Settings {
        //Vores nuværende logged ind bruger.
        public static User CurrentUser { get; set; }

        //Skrivebords path
        public static String DesktopPath { get; set; }

        //Vores projekt mappe path
        public static String OOProject { get; set; }

        //Vores bruger mappe path
        public static String UsersPath { get; set; }

        //Vores transactions mappe path
        public static String TransactionsPath { get; set; }

        //Vores account info mappe path
        public static String AccountInfoPath { get; set; }

        //Vores overview UC, så vi kan tilgå den fra flere steder og opdater den.
        public static OverviewUC OverviewUC { get; set; }

        //Vores Pay and Transfer UC, så vi kan tilgå den fra flere steder og opdater den.
        public static Pay_and_TransferUC PayAndTransfer { get; set; }

    }
}
