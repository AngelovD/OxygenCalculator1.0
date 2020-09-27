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
    public partial class Form1 : Form
    {
        static string MySqlConnectionText = "datasource=127.0.0.1;port=3306;username=root;password=;database=OxygenCalculatorDB";
        static MySqlConnection databaseConnection = new MySqlConnection(MySqlConnectionText);

        List<Worker> workers;
        List<Segment> segments;
        List<Apparatus> apparatuses;
        Worker worker;
        public Form1()
        {
            InitializeComponent();
            ChooseWorkerLabel.Hide();
            workers = new List<Worker>();
            segments = new List<Segment>();
            apparatuses = new List<Apparatus>();
            FillLists();
        }




        private void CreateWorkerB_Click(object sender, EventArgs e)
        {

            WorkerForm workerForm = new WorkerForm(this);
            workerForm.Show();

        }

        private void ChooseWorkerB_Click(object sender, EventArgs e)
        {

            try
            {
                string[] chosenWorkerID = WorkerListBox.SelectedItem.ToString().Split(' ');
                int id;
                id = Convert.ToInt32(chosenWorkerID[0]);
                for (int i = 0; i < workers.Count; i++)
                {
                    if (workers[i].getID() == id)
                    {
                        worker = workers[i];
                        break;

                    }
                }
            }
            catch(Exception ex){
                WorkerListBox.Items.Add(ex.Message +" at Choose");
            }

            
        }

        private void UpdateWorkerB_Click(object sender, EventArgs e)
        {
            try
            {
                ChooseWorkerLabel.Hide();
                WorkerForm workerForm = new WorkerForm(this, worker);
                workerForm.Show();
            }
            catch (Exception ex)
            {
                ChooseWorkerLabel.Show();
                Console.WriteLine(ex.Message);
            }
        }

        private void DeleteWorkerB_Click(object sender, EventArgs e)
        {
            string[] workerID = WorkerListBox.SelectedItem.ToString().Split(' ');
            
            int id;
            try
            {
                id = Convert.ToInt32(workerID[0]);
                string queryText = "DELETE FROM `workers` WHERE id=" + id;
                MySqlCommand commandDatabase = new MySqlCommand(queryText, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                databaseConnection.Open();
                commandDatabase.ExecuteNonQuery();
                databaseConnection.Close();
            }catch(Exception ex){
                WorkerListBox.Items.Add(ex.Message);
            }
            FillLists();

        }

        private void CreateApparatusB_Click(object sender, EventArgs e)
        {
            ApparatusForm apparatusForm = new ApparatusForm();
            apparatusForm.Show();
        }

        private void UpdateApparatusB_Click(object sender, EventArgs e)
        {

        }

        private void DeleteApparatusB_Click(object sender, EventArgs e)
        {

        }

        private void CreateSegmentB_Click(object sender, EventArgs e)
        {
            SegmentForm segmentForm = new SegmentForm(this);
            segmentForm.Show();
        }

        private void UpdateSegmentB_Click(object sender, EventArgs e)
        {

        }

        private void DeleteSegmentB_Click(object sender, EventArgs e)
        {

        }

        private void AddLuggageB_Click(object sender, EventArgs e)
        {

        }

        private void RemoveLuggageB_Click(object sender, EventArgs e)
        {

        }

        private void AddBreakB_Click(object sender, EventArgs e)
        {

        }

        private void DeleteBreakB_Click(object sender, EventArgs e)
        {

        }

        private void ChoosePathB_Click(object sender, EventArgs e)
        {

        }

        private void CalculateB_Click(object sender, EventArgs e)
        {
            try
            {
                ChooseWorkerLabel.Hide();
                double speed = worker.getSpeed();
                int lenght = 0;
                double time;
                for (int i = 0; i < segments.Count; i++)
                {
                    lenght += segments[i].getLenght() * 2;
                }
                time = lenght / speed;
                TimeForEntryB.Text += " " + time / 2;
                TimeForExitB.Text += " " + time / 2;
                TimeForPathB.Text += " " + Math.Pow(time,2);

            }catch(Exception ex)
            {
                ChooseWorkerLabel.Show();
                Console.WriteLine(ex.Message);
            }
        }

        private void AlternativePathsB_Click(object sender, EventArgs e)
        {

        }

        private void OxygenOnEntryB_Click(object sender, EventArgs e)
        {

        }

        private void OxygenOnExitB_Click(object sender, EventArgs e)
        {

        }

        private void OxygenForEntryB_Click(object sender, EventArgs e)
        {

        }

        private void OxygenForExitB_Click(object sender, EventArgs e)
        {

        }

        private void PathLengthB_Click(object sender, EventArgs e)
        {

        }

        private void TimeForEntryB_Click(object sender, EventArgs e)
        {

        }

        private void TimeForExitB_Click(object sender, EventArgs e)
        {

        }

        private void TimeForPathB_Click(object sender, EventArgs e)
        {

        }

        private void RemainingTimeB_Click(object sender, EventArgs e)
        {

        }

        private void SaveResultsB_Click(object sender, EventArgs e)
        {

        }

        private void ChangeValuesB_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        public void FillLists()
        {
            //Wroker query
            string queryTextWorker = "SELECT * FROM Workers";
            MySqlCommand commandDatabaseWorker = new MySqlCommand(queryTextWorker, databaseConnection);
            commandDatabaseWorker.CommandTimeout = 60;

            //Segment query
            string queryTextSegment = "SELECT * FROM Segments";
            MySqlCommand commandDatabaseSegment = new MySqlCommand(queryTextSegment, databaseConnection);
            commandDatabaseSegment.CommandTimeout = 60;

            //Apparatus query
            string queryTextApparatus = "SELECT * FROM Apparatus";
            MySqlCommand commandDatabaseApparatus = new MySqlCommand(queryTextApparatus, databaseConnection);
            commandDatabaseApparatus.CommandTimeout = 60;

            WorkerListBox.Items.Clear();
            SegmentListBox.Items.Clear();

            //Worker connection and fill
            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = commandDatabaseWorker.ExecuteReader();
                while (myReader.Read())
                {
                    workers.Add(new Worker(myReader.GetInt16(0),myReader.GetString(1),myReader.GetFloat(2),myReader.GetFloat(3),myReader.GetFloat(4),myReader.GetFloat(5),myReader.GetFloat(6),myReader.GetInt16(7)));
                    WorkerListBox.Items.Add(myReader.GetInt16(0) + " - " + myReader.GetString(1));
                }
                databaseConnection.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                WorkerListBox.Items.Add(e.Message);
            }

            //Segment connection and fill
            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = commandDatabaseSegment.ExecuteReader();
                while (myReader.Read())
                {
                    segments.Add(new Segment(myReader.GetInt16(0), myReader.GetString(1),myReader.GetInt16(2), myReader.GetFloat(3), myReader.GetFloat(4), myReader.GetFloat(5), myReader.GetInt16(6), myReader.GetInt16(7), myReader.GetInt16(8)));
                    SegmentListBox.Items.Add(myReader.GetInt16(0) + " - " + myReader.GetString(1));
                }
                databaseConnection.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                SegmentListBox.Items.Add(e.Message);
            }

            //Apparatus connection and fill
            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = commandDatabaseApparatus.ExecuteReader();
                while (myReader.Read())
                {
                    apparatuses.Add(new Apparatus(myReader.GetInt16(0), myReader.GetString(1), myReader.GetString(2), myReader.GetFloat(3), myReader.GetFloat(4), myReader.GetFloat(5), myReader.GetInt16(6), myReader.GetFloat(7)));
                }
                databaseConnection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                WorkerListBox.Items.Add(e.Message);
            }

        }

    }
}
