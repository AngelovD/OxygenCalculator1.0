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
        Dictionary<int,Apparatus> apparatuses;
        
        Worker worker;
        public Form1()
        {
            InitializeComponent();
            ChooseWorkerLabel.Hide();
            workers = new List<Worker>();
            segments = new List<Segment>();
            apparatuses = new Dictionary<int, Apparatus>();
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
                WorkerListBox.Items.Add(ex.Message + " At update");
            }
        }

        private void DeleteWorkerB_Click(object sender, EventArgs e)
        {
            string[] workerID = WorkerListBox.SelectedItem.ToString().Split(' ');
            
            try
            {
                int id = Convert.ToInt32(workerID[0]);
                workers.Clear();
                string queryText = "DELETE FROM `workers` WHERE id=" + id;
                MySqlCommand commandDatabase = new MySqlCommand(queryText, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                databaseConnection.Open();
                commandDatabase.ExecuteNonQuery();
                databaseConnection.Close();
            }catch(Exception ex){
                WorkerListBox.Items.Add(ex.Message + " At delete");
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
            string[] segmentID = SegmentListBox.SelectedItem.ToString().Split(' ');

            try
            {
                int id = Convert.ToInt32(segmentID[0]);
                segments.Clear();
                string queryText = "DELETE FROM `segments` WHERE id=" + id;
                MySqlCommand commandDatabase = new MySqlCommand(queryText, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                databaseConnection.Open();
                commandDatabase.ExecuteNonQuery();
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                SegmentListBox.Items.Add(ex.Message + " At delete");
            }
            FillLists();
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
            TimeForEntryB.Text = "Време за влизане:";
            TimeForExitB.Text = "Време за излизане:";
            TimeForPathB.Text = "Време за изминаване на пътя:";
            PathLengthB.Text = "Дължина на трасето:";
            OxygenForEntryB.Text = "Кислород за влизане:";
            OxygenOnEntryB.Text = "Наличен кислород при влизане:";
            OxygenForExitB.Text = "Кислород за излизане:";
            OxygenOnExitB.Text = "Наличен кислород при излизане:";
            RemainingTimeB.Text = "Оставащо време при умерена работа:";
            int lenght = 0;
            double tireA = 1;
            double timeIn = 0;
            double timeOut = 0;
            double time = 0;
            double oxygenIn = 0;
            double oxygenOut = 0;
            try
            {
                ChooseWorkerLabel.Hide();
                Apparatus apparatus;
                apparatuses.TryGetValue(worker.getApparatus(), out apparatus);

                double speed = worker.getSpeed();
                double tireRate = worker.getTireRate();
                double oxygenC = worker.getOxygenConsumption();

                for (int i = 0; i < segments.Count; i++)
                {
                    lenght += segments[i].getLenght();
                    int segmentTireCount = segments[i].getLenght() / 100;
                    if (segments[i].getLenght() % 100 > 50)
                    {
                        segmentTireCount++;
                    }
                    while (segmentTireCount >= 0)
                    {
                        double oxygenConsumptionIn = oxygenC * segments[i].getEntryOxygen() * tireA;
                        double speedIn = speed * segments[i].getEntrySpeed() * tireA;
                        if (tireA < 0.4)
                        {
                            timeIn += 15;
                            time += 15;
                            oxygenIn += 15 * oxygenC;
                            tireA += 0.3;
                        }
                        timeIn += 100 / speedIn;
                        time += 100 / speedIn;
                        oxygenIn += (100 / speedIn) * oxygenConsumptionIn;
                        tireA -= tireRate;
                        segmentTireCount--;
                    }
                }
                for (int i = 0; i < segments.Count; i++)
                {
                    int segmentTireCount = segments[i].getLenght() / 100;
                    if (segments[i].getLenght() % 100 > 50)
                    {
                        segmentTireCount++;
                    }
                    while (segmentTireCount >= 0)
                    {
                        double oxygenConsumptionOut = oxygenC * segments[i].getExitOxygen() * tireA;
                        double speedOut = speed * segments[i].getExitSpeed() * tireA;
                        if (tireA < 0.4)
                        {
                            timeOut += 15;
                            time += 15;
                            oxygenOut += 15 * oxygenC;
                            tireA += 0.3;
                        }
                        timeOut += 100 / speedOut;
                        time += 100 / speedOut;
                        oxygenOut += (100 / speedOut) * oxygenConsumptionOut;
                        tireA -= tireRate;
                        segmentTireCount--;
                    }
                }
                double oxygenAmmount = (apparatus.getVolume() * apparatus.getPressure() * 10);
                double oxygenLeft = oxygenAmmount - (oxygenIn + oxygenOut);
                TimeForEntryB.Text += " " + Math.Round(timeIn, 3, MidpointRounding.AwayFromZero).ToString() + " min";
                TimeForExitB.Text += " " + Math.Round(timeOut, 3, MidpointRounding.AwayFromZero).ToString() + " min";
                TimeForPathB.Text += " " + Math.Round(time, 3, MidpointRounding.AwayFromZero).ToString() + " min";
                PathLengthB.Text += " " + lenght + " m";
                OxygenForEntryB.Text += " " + Math.Round(oxygenIn, 3, MidpointRounding.AwayFromZero).ToString() + " l";
                OxygenOnEntryB.Text += " " + Math.Round(oxygenAmmount, 3, MidpointRounding.AwayFromZero).ToString() + " l";
                OxygenForExitB.Text += " " + Math.Round(oxygenOut, 3, MidpointRounding.AwayFromZero).ToString() + " l";
                
                if (oxygenLeft > 0)
                {
                    OxygenOnExitB.Text += " " + Math.Round(oxygenLeft, 3, MidpointRounding.AwayFromZero).ToString() + " l";
                    RemainingTimeB.Text += " " + Math.Round(oxygenLeft/worker.getOxygenConsumption(), 3, MidpointRounding.AwayFromZero).ToString() + " min";
                }
                else
                {
                    OxygenOnExitB.Text = " Не достатъчен кислород";
                    RemainingTimeB.Text = " Не достатъчен кислород";
                }

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

            workers = new List<Worker>();
            segments = new List<Segment>();
            apparatuses = new Dictionary<int, Apparatus>();

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
                WorkerListBox.Items.Add(" At Select W");
            }

            //Segment connection and fill
            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = commandDatabaseSegment.ExecuteReader();
                while (myReader.Read())
                {
                    segments.Add(new Segment(myReader.GetInt16(0), myReader.GetString(1),myReader.GetInt16(2), myReader.GetFloat(3), myReader.GetFloat(4), myReader.GetFloat(5), myReader.GetFloat(6), myReader.GetFloat(7), myReader.GetInt16(8), myReader.GetInt16(9), myReader.GetInt16(10)));
                    SegmentListBox.Items.Add(myReader.GetInt16(0) + " - " + myReader.GetString(1));
                }
                databaseConnection.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                SegmentListBox.Items.Add("At Select S");
            }

            //Apparatus connection and fill
            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = commandDatabaseApparatus.ExecuteReader();
                while (myReader.Read())
                {
                    apparatuses.Add(myReader.GetInt16(0),new Apparatus(myReader.GetInt16(0), myReader.GetString(1), myReader.GetString(2), myReader.GetFloat(3), myReader.GetFloat(4), myReader.GetFloat(5), myReader.GetInt16(6), myReader.GetFloat(7)));
                }
                databaseConnection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + "At select A");
                SegmentListBox.Items.Add("At Select A");
            }

        }


    }
}
