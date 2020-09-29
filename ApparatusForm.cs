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
    public partial class ApparatusForm : Form
    {
        static string MySqlConnectionText = "datasource=127.0.0.1;port=3306;username=root;password=;database=OxygenCalculatorDB";
        static MySqlConnection databaseConnection = new MySqlConnection(MySqlConnectionText);

        public ApparatusForm()
        {
            InitializeComponent();
        }

        private void SaveB_Click(object sender, EventArgs e)
        {

            if (checkApparatus() != null)
            {
                Apparatus apparatus = checkApparatus();
                string queryText = "INSERT INTO `apparatus`( `Name`, `Description`, `Weight`, `Volume`, `Pressure`, `WorkTime`, `Reserve`) VALUES ('" +
                    apparatus.getName() + "','" +
                    apparatus.getDescription() + "'," +
                    apparatus.getWeight() + "," +
                    apparatus.getVolume() + "," +
                    apparatus.getPressure() + "," +
                    apparatus.getWorkTime() + "," +
                    apparatus.getReserve() + ");";
                MySqlCommand commandDatabase = new MySqlCommand(queryText, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                try
                {
                    databaseConnection.Open();
                    commandDatabase.ExecuteNonQuery();
                    databaseConnection.Close();
                    NameBox.Text = "";
                    DescriptionBox.Text = "";
                    WeightBox.Text = "";
                    VolumeBox.Text = "";
                    TimeBox.Text = "";
                    ReserveBox.Text = "";
                    PressureBox.Text = "";
                }
                catch (Exception ex)
                {
                    NameBox.Text=ex.Message;
                }
            }

        }

        private Apparatus checkApparatus()
        {
            bool result = true;

            Apparatus apparatus = null;
            string name = NameBox.Text;
            string description = DescriptionBox.Text;
            double weight;
            double volume;
            double pressure;
            int workTime;
            double reserve;

            if (name.Length > 30)
            {
                result = false;
            }
            try
            {
                weight = Convert.ToDouble(WeightBox.Text);
                volume = Convert.ToDouble(VolumeBox.Text);
                pressure = Convert.ToDouble(PressureBox.Text);
                workTime = Convert.ToInt32(TimeBox.Text);
                reserve = Convert.ToDouble(ReserveBox.Text);
                apparatus = new Apparatus(name, description, weight, volume, pressure, workTime, reserve);
            }
            catch(Exception e)
            {
                DescriptionBox.Text = e.Message;
                result = false;
            }

            if (!result)
            {
                NameBox.Text = "Моля попълнете всички полета";
            }

                return apparatus;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
