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
    public partial class WorkerForm : Form
    {
        private Form1 mainForm = null;
        static string MySqlConnectionText = "datasource=127.0.0.1;port=3306;username=root;password=;database=OxygenCalculatorDB";
        static MySqlConnection databaseConnection = new MySqlConnection(MySqlConnectionText);
        List<Apparatus> apparatuses;

        bool language;

        public WorkerForm()
        {
            InitializeComponent();
            apparatuses = new List<Apparatus>();
            fillList();

        }

        public WorkerForm(Form callingForm, bool language)
        {
            mainForm = callingForm as Form1;
            InitializeComponent();
            apparatuses = new List<Apparatus>();
            fillList();
            this.language = language;
            fillLanguage();
        }

        private void fillLanguage()
        {
            if (language)
            {
                TitleLabel.Text = "Създай спасител";
                label1.Text = "Име";
                label2.Text = "Ръст";
                label3.Text = "Тегло";
                label4.Text = "Консумация на кислород";
                label5.Text = "Скорост";
                label6.Text = "Умора за 100 метра";
                label7.Text = "Изберете апарат";
                SaveB.Text = "Запази";

            }
            else
            {
                TitleLabel.Text = "Create worker";
                label1.Text = "Name";
                label2.Text = "Height";
                label3.Text = "Weight";
                label4.Text = "Oxygen consumption";
                label5.Text = "Speed";
                label6.Text = "Tire rate for 100m";
                label7.Text = "Choose apparatus";
                SaveB.Text = "Save";
            }
        }


        private void SaveB_Click(object sender, EventArgs e)
        {

            if (checkWorker() != null)
            {
                Worker worker = checkWorker();
                string queryText = "INSERT INTO `workers`( `Name`, `Height`, `Weight`, `OxygenConsumption`, `Speed`, `TireRate`, `Apparatus`) VALUES ('" +
                    worker.getName()+"'," +
                    worker.getHeight() + "," +
                    worker.getWeight() + "," +
                    worker.getOxygenConsumption() + "," +
                    worker.getSpeed() + "," +
                    worker.getTireRate() + "," +
                    worker.getApparatus() + ");";
                MySqlCommand commandDatabase = new MySqlCommand(queryText, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                try
                {
                    databaseConnection.Open();
                    commandDatabase.ExecuteNonQuery();
                    databaseConnection.Close();
                    NameBox.Text = "";
                    HeightBox.Text = "";
                    WeightBox.Text = "";
                    OxygenBox.Text = "";
                    SpeedBox.Text = "";
                    TireBox.Text = "";
                }
                catch (Exception ex)
                {
                    ApparatusBox.Items.Add(ex.Message);
                }
                mainForm.FillLists();
            }
            else
            {
                ApparatusBox.Items.Add("Моля попълнете всички полета");
            }

        }

        private Worker checkWorker()
        {
            Worker worker = null;
            bool result = true;
            string name = NameBox.Text;
            double height;
            double weight;
            double oxygenConsumption;
            double speed;
            double tireRate;
            if (name.Length > 50)
            {
                result = false;
            }

            try
            {
                height = Convert.ToDouble(HeightBox.Text);
                weight = Convert.ToDouble(WeightBox.Text);
                oxygenConsumption = Convert.ToDouble(OxygenBox.Text);
                speed = Convert.ToDouble(SpeedBox.Text);
                tireRate = Convert.ToDouble(TireBox.Text);
                if (!apparatuses.Any())
                {
                    if (language)
                    {
                        ApparatusBox.Items.Add("Моля създайте апарат");
                    }
                    else
                    {
                        ApparatusBox.Items.Add("Please create an apparatus");
                    }
                }
                else
                {
                    string[] apparatusID = ApparatusBox.SelectedItem.ToString().Split(' ');
                    int apparatus = Convert.ToInt32(apparatusID[0]);
                    worker = new Worker(name, height, weight, oxygenConsumption, speed, tireRate,apparatus);
                    return worker;
                }
                
            }
            catch(Exception e)
            {
                ApparatusBox.Items.Add(e.Message + "At check");
                result = false;
            }

            if (!result)
            {
                NameBox.Text = "Моля попълнете всички полета";
            }

            return worker;
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

        private void NameBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
