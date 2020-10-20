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

        bool language;

        Dictionary<int, Worker> workers;
        List<Segment> segments;
        Dictionary<int,Apparatus> apparatuses;
        
        Worker worker;
        double TireAmmount;
        public Form1(bool language)
        {
            InitializeComponent();
            ChooseWorkerLabel.Hide();
            workers = new Dictionary<int, Worker>();
            segments = new List<Segment>();
            apparatuses = new Dictionary<int, Apparatus>();
            FillLists();
            this.language = language;
            FillLanguage();
        }

        public void fillSegments(List<Segment> segments)
        {
            FillLists();
            SegmentListBox.Items.Clear();
            this.segments = segments;
            for(int i = 0; i < segments.Count; i++)
            {
                SegmentListBox.Items.Add(segments[i].getID() + " - " + segments[i].getName());
            }
        }


        private void FillLanguage()
        {
            if (language)
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
                CreateWorkerB.Text = "Създай Спасител";
                ChooseWorkerB.Text = "Избери Спасител";
                DeleteWorkerB.Text = "Изтрий Спасител";
                CreateApparatusB.Text = "Създай Апарат";
                DeleteApparatusB.Text = "Изтрий Апарат";
                CreateSegmentB.Text = "Създай Участък";
                DeleteSegmentB.Text = "Изтрий Участък";
                AddLuggageB.Text = "Добави Товар";
                RemoveLuggageB.Text = "Премахни Товар";
                AddBreakB.Text = "Добави Почивка";
                DeleteBreakB.Text = "Изтрий Почивка";
                CalculateB.Text = "Изчисли";
                SaveResultsB.Text = "Запази Резултат";
                ChangeValuesB.Text = "Промени Коефициенти";
                ChooseWorkerLabel.Text = "Моля изберете спасител";
                WorkerLabel.Text = "Спасител";
                WorkersLabel.Text = "Спасители:";
                SegmentLabel.Text = "Сегмент";
                PathLabel.Text = "Сегменти";
                TitleLabel.Text = "Изчисли Ресурси за Мисия";
            }
            else
            {
                TimeForEntryB.Text = "Time for entry:";
                TimeForExitB.Text = "Time for exit:";
                TimeForPathB.Text = "Time for path:";
                PathLengthB.Text = "Path lenght:";
                OxygenForEntryB.Text = "Oxygen for entry:";
                OxygenOnEntryB.Text = "Oxygen on entry:";
                OxygenForExitB.Text = "Oxygen for exit:";
                OxygenOnExitB.Text = "Oxygen on exit:";
                RemainingTimeB.Text = "Remaining time for work:";
                CreateWorkerB.Text = "Create Worker";
                ChooseWorkerB.Text = "Choose Worker";
                DeleteWorkerB.Text = "Delete Worker";
                CreateApparatusB.Text = "Create Apparatus";
                DeleteApparatusB.Text = "Delete Apparatus";
                CreateSegmentB.Text = "Create Segment";
                DeleteSegmentB.Text = "Delete Segment";
                AddLuggageB.Text = "Add Luggage";
                RemoveLuggageB.Text = "Remove Luggage";
                AddBreakB.Text = "Add Break";
                DeleteBreakB.Text = "Delete Break";
                CalculateB.Text = "Calculate";
                SaveResultsB.Text = "Save Result";
                ChangeValuesB.Text = "Change Constants";
                ChooseWorkerLabel.Text = "Please choose a worker";
                WorkerLabel.Text = "Rescue Worker";
                WorkersLabel.Text = "Workers:";
                SegmentLabel.Text = "Segment";
                PathLabel.Text = "Segments:";
                TitleLabel.Text = "Calculate Needed Resources for Mission";
            }
        }


        private void CreateWorkerB_Click(object sender, EventArgs e)
        {

            WorkerForm workerForm = new WorkerForm(this,language);
            workerForm.Show();

        }

        private void ChooseWorkerB_Click(object sender, EventArgs e)
        {

            try
            {
                string[] chosenWorkerID = WorkerListBox.SelectedItem.ToString().Split(' ');
                int id;
                id = Convert.ToInt32(chosenWorkerID[0]);
                this.worker = workers[id];
            }
            catch(Exception ex){
                WorkerListBox.Items.Add(ex.Message +" at Choose");
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
            ApparatusForm apparatusForm = new ApparatusForm(language);
            apparatusForm.Show();
        }

        private void DeleteApparatusB_Click(object sender, EventArgs e)
        {
            DeleteApparatus deleteApparatus = new DeleteApparatus(language);
            deleteApparatus.Show();
        }

        private void CreateSegmentB_Click(object sender, EventArgs e)
        {
            SegmentForm segmentForm = new SegmentForm(this,language);
            segmentForm.Show();
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
            LuggageForm luggageForm = new LuggageForm(this, segments, language);
            luggageForm.Show();
        }

        private void RemoveLuggageB_Click(object sender, EventArgs e)
        {
            LuggageForm luggageForm = new LuggageForm(this, segments, language);
            luggageForm.Show();

        }

        private void AddBreakB_Click(object sender, EventArgs e)
        {
            RestForm restForm = new RestForm(this, segments, language);
            restForm.Show();
        }

        private void DeleteBreakB_Click(object sender, EventArgs e)
        {
            RestForm restForm = new RestForm(this, segments, language);
            restForm.Show();
        }


        private void CalculateB_Click(object sender, EventArgs e)
        {
            FillLanguage();
            TireAmmount = 1;
            List<double> entry = Entry();
            List<double> exit = Exit();
            try {
            ChooseWorkerLabel.Hide();
            double oxygenTank = apparatuses[worker.getApparatus()].getPressure() * apparatuses[worker.getApparatus()].getVolume()*10;
            double trackOxygen = entry[1] + exit[1];
            double lenght = entry[0] + exit[0];
            double time = entry[2] + exit[2];
            if (oxygenTank > trackOxygen)
            {
                PathLengthB.Text += " " + Math.Round(lenght, 2, MidpointRounding.ToEven) + " m";
                TimeForPathB.Text += " " + Math.Round(time, 2, MidpointRounding.ToEven) + " min";
                OxygenOnEntryB.Text += " " + Math.Round(oxygenTank, 2, MidpointRounding.ToEven) + " l";
                OxygenOnExitB.Text += " " + Math.Round(oxygenTank-trackOxygen, 2, MidpointRounding.ToEven) + " l";
                OxygenForEntryB.Text += " " + Math.Round(entry[1], 2, MidpointRounding.ToEven) + " l";
                TimeForEntryB.Text += " " + Math.Round(entry[2], 2, MidpointRounding.ToEven) + " min";
                OxygenForExitB.Text += " " + Math.Round(exit[1], 2, MidpointRounding.ToEven) + " l";
                TimeForExitB.Text += " " + Math.Round(exit[2], 2, MidpointRounding.ToEven) + " min";
                double remainingTime = (oxygenTank - trackOxygen) / worker.getOxygenConsumption();
                RemainingTimeB.Text += " " + Math.Round(remainingTime, 2, MidpointRounding.ToEven) + " min";
            }
            else if(language)
            {
                ChooseWorkerLabel.Text = "Не достатъчен кислород";
            }else if (!language)
            {
                ChooseWorkerLabel.Text = "Not enough Oxygen";
            }
            }
            catch (Exception ex)
            {
                ChooseWorkerLabel.Show();
                if (language)
                {
                    ChooseWorkerLabel.Text = "Моля изберете спасител";

                }
                else
                {
                    ChooseWorkerLabel.Text = "Please choose a worker";
                }
            }

        }

        private List<double> Entry()
        {
            List<double> res = new List<double>();
            int lenght = 0;
            int sLenght;
            double oxygen = 0;
            double oxygenConsumption;
            double time = 0;
            double speed;
            try
            {
                for (int i = 0; i < segments.Count; i++)
                {
                    lenght += segments[i].getLenght();
                    sLenght = segments[i].getLenght();
                    speed = worker.getSpeed() * ((worker.getWeight() - apparatuses[worker.getApparatus()].getWeight()) / worker.getWeight());
                    speed *= segments[i].getEntrySpeed();
                    speed *= TireAmmount;
                    oxygenConsumption = worker.getOxygenConsumption() * segments[i].getEntryOxygen();
                    if (segments[i].getHeight() < worker.getHeight())
                    {
                        speed *= 0.8;
                    }

                    if (segments[i].getLuggage() > 0)
                    {
                        speed = speed * ((worker.getWeight() - segments[i].getLuggage()) / worker.getWeight());
                    }

                    if (segments[i].getObstacles() > 0)
                    {
                        time += segments[i].getObstacles();
                        oxygen += segments[i].getObstacles() * worker.getOxygenConsumption();
                        TireAmmount += segments[i].getObstacles() * 0.02;
                    }

                    int rest = sLenght % 100;

                    for (int j = 0; j < sLenght / 100; j++)
                    {
                        if (TireAmmount > 0.4)
                        {
                            oxygen += ((100 / speed) * oxygenConsumption) / TireAmmount;
                            time += 100 / speed;
                            TireAmmount -= worker.getTireRate();
                        }
                        else
                        {
                            time += 20;
                            TireAmmount += 0.4;
                            oxygen += ((100 / speed) * oxygenConsumption) / TireAmmount;
                            time += 100 / speed;
                            TireAmmount -= worker.getTireRate();
                        }
                    }
                    oxygen += ((rest / speed) * oxygenConsumption) / TireAmmount;
                    time += rest / speed;
                }
                res.Add(lenght);
                res.Add(oxygen);
                res.Add(time);
            } catch (Exception e)
            {
                ChooseWorkerLabel.Show();
                if (language) {
                    ChooseWorkerLabel.Text = "Моля изберете спасител";

                }
                else
                {
                    ChooseWorkerLabel.Text = "Please choose a worker";
                }
            }

            return res;
        }
        private List<double> Exit()
        {
            List<double> res = new List<double>();
            int lenght = 0;
            int sLenght;
            double oxygen = 0;
            double oxygenConsumption;
            double time = 0;
            double speed;
            try { 
            for (int i = 0; i < segments.Count; i++)
            {
                lenght += segments[i].getLenght();
                sLenght = segments[i].getLenght();
                speed = worker.getSpeed() * ((worker.getWeight() - apparatuses[worker.getApparatus()].getWeight()) / worker.getWeight());
                speed *= segments[i].getExitSpeed();
                speed *= TireAmmount;
                oxygenConsumption = worker.getOxygenConsumption() * segments[i].getExitOxygen();
                if (segments[i].getHeight() < worker.getHeight())
                {
                    speed *= 0.8;
                }

                if (segments[i].getLuggage() > 0)
                {
                    speed = speed * ((worker.getWeight() - segments[i].getLuggage()) / worker.getWeight());
                }

                if (segments[i].getObstacles() > 0)
                {
                    time += segments[i].getObstacles();
                    oxygen += segments[i].getObstacles() * worker.getOxygenConsumption();
                    TireAmmount += segments[i].getObstacles() * 0.02;
                }

                int rest = sLenght % 100;

                for (int j = 0; j < sLenght / 100; j++)
                {
                    if (TireAmmount > 0.4)
                    {
                        oxygen += ((100 / speed) * oxygenConsumption) / TireAmmount;
                        time += 100 / speed;
                        TireAmmount -= worker.getTireRate();
                    }
                    else
                    {
                        time += 20;
                        TireAmmount += 0.4;
                        oxygen += ((100 / speed) * oxygenConsumption) / TireAmmount;
                        time += 100 / speed;
                        TireAmmount -= worker.getTireRate();
                    }
                }
                oxygen += ((rest / speed) * oxygenConsumption) / TireAmmount;
                time += rest / speed;
            }
            res.Add(lenght);
            res.Add(oxygen);
            res.Add(time);
            }
            catch (Exception e)
            {
                ChooseWorkerLabel.Show();
                if (language)
                {
                    ChooseWorkerLabel.Text = "Моля изберете спасител";

                }
                else
                {
                    ChooseWorkerLabel.Text = "Please choose a worker";
                }
            }

            return res;
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

            workers = new Dictionary<int, Worker>();
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
                    workers.Add(myReader.GetInt16(0),new Worker(myReader.GetInt16(0),myReader.GetString(1),myReader.GetFloat(2),myReader.GetFloat(3),myReader.GetFloat(4),myReader.GetFloat(5),myReader.GetFloat(6),myReader.GetInt16(7)));
                    WorkerListBox.Items.Add(myReader.GetInt16(0) + " - " + myReader.GetString(1) + " - " + myReader.GetFloat(5) + "m/min");
                }
                databaseConnection.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                WorkerListBox.Items.Add(" At Select W");
            }

            //Segment connection and fill
            if (!segments.Any())
            {
                try
                {
                    databaseConnection.Open();
                    MySqlDataReader myReader = commandDatabaseSegment.ExecuteReader();
                    while (myReader.Read())
                    {
                        segments.Add(new Segment(myReader.GetInt16(0), myReader.GetString(1), myReader.GetInt16(2), myReader.GetFloat(3), myReader.GetFloat(4), myReader.GetFloat(5), myReader.GetFloat(6), myReader.GetFloat(7), myReader.GetInt16(8), myReader.GetInt16(9), myReader.GetInt16(10)));
                        SegmentListBox.Items.Add(myReader.GetInt16(0) + " - " + myReader.GetString(1));
                    }
                    databaseConnection.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    SegmentListBox.Items.Add("At Select S");
                }
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

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void WorkerListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void SegmentListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ChooseWorkerLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
