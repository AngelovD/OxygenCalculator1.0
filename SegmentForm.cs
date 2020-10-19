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
    public partial class SegmentForm : Form
    {
        private Form1 mainForm = null;
        static string MySqlConnectionText = "datasource=127.0.0.1;port=3306;username=root;password=;database=OxygenCalculatorDB";
        static MySqlConnection databaseConnection = new MySqlConnection(MySqlConnectionText);
        public SegmentForm()
        {
            InitializeComponent();
        }

        public SegmentForm(Form callingForm)
        {
            mainForm = callingForm as Form1;
            InitializeComponent();
        }


        private void SaveB_Click(object sender, EventArgs e)
        {

            if (checkSegment() != null)
            {
                Segment segment = checkSegment();
                string queryText = "INSERT INTO `segments`( `Name`, `Lenght`, `EntrySpeed`, `ExitSpeed`, `EntryOxygen`, `ExitOxygen`, `Height`, `WetFloor`, `Obstacles`) VALUES ('" +
                    segment.getName()+"'," +
                    segment.getLenght() + "," +
                    segment.getEntrySpeed() + "," +
                    segment.getExitSpeed() + "," +
                    segment.getEntryOxygen() + "," +
                    segment.getExitOxygen() + "," +
                    segment.getHeight() + "," +
                    segment.getWetFloor() + "," +
                    segment.getObstacles() +");";
                MySqlCommand commandDatabase = new MySqlCommand(queryText, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                try
                {
                    databaseConnection.Open();
                    commandDatabase.ExecuteNonQuery();
                    databaseConnection.Close();
                    NameBox.Text = "";
                    LenghtBox.Text = "";
                    EntryBox.Text = "";
                    ExitBox.Text = "";
                    EntryOxygenBox.Text = "";
                    ExitOxygenBox.Text = "";
                    HeightBox.Text = "";
                    ObstaclesBox.Text = "";
                }
                catch(Exception ex)
                {
                    NameBox.Text = ex.Message;
                }
            }

                mainForm.FillLists();
        }

        private void NameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private Segment checkSegment()
        {
            bool result = true;
            Segment segment = null;
            string name = NameBox.Text;
            int lenght;
            double entrySpeed;
            double exitSpeed;
            double entryOxygen;
            double exitOxygen;
            double height;
            int wetFloor;
            int Obstacles;

            if (name.Length > 30)
            {
                result = false;
            }

            try
            {
                height = Convert.ToDouble(HeightBox.Text);
                lenght = Convert.ToInt32(LenghtBox.Text);
                entrySpeed = Convert.ToDouble(EntryBox.Text);
                exitSpeed = Convert.ToDouble(ExitBox.Text);
                entryOxygen = Convert.ToDouble(EntryOxygenBox.Text);
                exitOxygen = Convert.ToDouble(ExitOxygenBox.Text);
                Obstacles = Convert.ToInt32(ObstaclesBox.Text);
                if (FloorB.Checked)
                {
                    wetFloor = 1;
                }
                else
                {
                    wetFloor = 0;
                }
                segment = new Segment(name, lenght, entrySpeed, exitSpeed,entryOxygen, exitOxygen, height, wetFloor, Obstacles);
            }catch(Exception e)
            {
                NameBox.Text = e.Message;
                result = false;
            }
            if (!result)
            {
                NameBox.Text = "Моля попълнете всички полета";
            }
                return segment;
        }

        private void SegmentForm_Load(object sender, EventArgs e)
        {

        }
    }
}
