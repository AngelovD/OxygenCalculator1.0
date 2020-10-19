using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace OxygenCalculator
{
    public partial class DeleteApparatus : Form
    {

        bool language;

        static string MySqlConnectionText = "datasource=127.0.0.1;port=3306;username=root;password=;database=OxygenCalculatorDB";
        static MySqlConnection databaseConnection = new MySqlConnection(MySqlConnectionText);

        List<Apparatus> apparatuses;
        public DeleteApparatus(bool language)
        {
            apparatuses = new List<Apparatus>();
            this.language = language;
            InitializeComponent();
            FillLanguage();
            fillList();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                string[] chosenApparatusID = ApparatusBox.SelectedItem.ToString().Split(' ');
                int id;
                id = Convert.ToInt32(chosenApparatusID[0]);
                string queryText = "DELETE FROM `apparatus` WHERE id=" + id;
                MySqlCommand commandDatabase = new MySqlCommand(queryText, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                databaseConnection.Open();
                commandDatabase.ExecuteNonQuery();
                databaseConnection.Close();
            }
            catch(Exception ex)
            {
                ApparatusBox.Items.Add("At delete" + ex);
            }
            ApparatusBox.Items.Clear();
            fillList();
        }

        private void FillLanguage()
        {
            if (language)
            {
                TitleLabel.Text = "Апарати";
                Delete.Text = "Изтрий";
            }
            else
            {
                TitleLabel.Text = "Apparatuses";
                Delete.Text = "Delete";
            }
        }
        private void fillList()
        {

            string queryTextApparatus = "SELECT * FROM Apparatus";
            MySqlCommand commandDatabaseApparatus = new MySqlCommand(queryTextApparatus, databaseConnection);
            commandDatabaseApparatus.CommandTimeout = 60;

            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = commandDatabaseApparatus.ExecuteReader();
                while (myReader.Read())
                {
                    apparatuses.Add(new Apparatus(myReader.GetInt16(0), myReader.GetString(1), myReader.GetString(2), myReader.GetFloat(3), myReader.GetFloat(4), myReader.GetFloat(5), myReader.GetInt16(6), myReader.GetFloat(7)));
                    ApparatusBox.Items.Add(myReader.GetInt16(0) + " - " + myReader.GetString(1));
                }
                databaseConnection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                ApparatusBox.Items.Add(e.Message + "At fill");
            }
            if (!apparatuses.Any())
            {
                ApparatusBox.Items.Add("Моля създайте апарат");
            }
        }
    }
}
