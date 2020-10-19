using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace OxygenCalculator
{
    static class Program
    {

        private static bool works = true;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            //Create Database if it doesn't exist
            CreateDB();

            //Create Tables if they don't exist
            CreateTables();

            if (works)
            {
                Application.Run(new LanguageForm());
            }
            else
            {
                Application.Run(new DataBaseForm());
            }

        }
        private static void CreateDB()
        {
            string MySqlConnectionText = "datasource=127.0.0.1;port=3306;username=root;password=;database=";
            MySqlConnection databaseConnection = new MySqlConnection(MySqlConnectionText);
            string queryText = "CREATE DATABASE IF NOT EXISTS OxygenCalculatorDB;";
            MySqlCommand commandDatabase = new MySqlCommand(queryText, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            try
            {
                databaseConnection.Open();
                commandDatabase.ExecuteNonQuery();
                databaseConnection.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                works = false;
            }

        }

        private static void CreateTables()
        {
            string MySqlConnectionText = "datasource=127.0.0.1;port=3306;username=root;password=;database=OxygenCalculatorDB";
            MySqlConnection databaseConnection = new MySqlConnection(MySqlConnectionText);
            string queryText = "CREATE TABLE IF NOT EXISTS Apparatus (Id SMALLINT(3) UNSIGNED AUTO_INCREMENT PRIMARY KEY, Name VARCHAR(30) NOT NULL,Description Text, Weight FLOAT(4,2) UNSIGNED NOT NULL, Volume FLOAT(4,2) UNSIGNED NOT NULL, Pressure FLOAT(5,2) UNSIGNED NOT NULL,WorkTime INT(3) UNSIGNED, Reserve FLOAT(5,2) UNSIGNED NOT NULL);" +
                "CREATE TABLE IF NOT EXISTS Workers(Id SMALLINT(3) UNSIGNED AUTO_INCREMENT PRIMARY KEY, Name VARCHAR(50) NOT NULL, Height FLOAT(3,2) UNSIGNED NOT NULL, Weight FLOAT(5,2) UNSIGNED NOT NULL, OxygenConsumption FLOAT(4,2) UNSIGNED NOT NULL, Speed FLOAT(4,2) UNSIGNED NOT NULL, TireRate FLOAT(4,3) UNSIGNED NOT NULL,Apparatus SMALLINT(3) UNSIGNED,FOREIGN KEY (Apparatus) REFERENCES Apparatus(Id));" +
                "CREATE TABLE IF NOT EXISTS Segments(Id SMALLINT(3) UNSIGNED AUTO_INCREMENT PRIMARY KEY, Name VARCHAR(30) NOT NULL,Lenght INT(4) UNSIGNED NOT NULL, EntrySpeed FLOAT(3,2) UNSIGNED NOT NULL,ExitSpeed FLOAT(3,2) UNSIGNED NOT NULL, EntryOxygen FLOAT(3,2) UNSIGNED NOT NULL, ExitOxygen FLOAT(3,2) UNSIGNED NOT NULL, Height FLOAT(4,2) UNSIGNED NOT NULL,Temperature INT(2) UNSIGNED NOT NULL, WetFloor TINYINT(1) UNSIGNED NOT NULL, Obstacles SMALLINT(2) UNSIGNED NOT NULL)";
            MySqlCommand commandDatabase = new MySqlCommand(queryText, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            try
            {
                databaseConnection.Open();
                commandDatabase.ExecuteNonQuery();
                databaseConnection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                works = false;
            }
        }
    }
}
