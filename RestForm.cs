using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OxygenCalculator
{
    public partial class RestForm : Form
    {
        List<Segment> segments;
        bool language;
        int id;
        private Form1 mainForm = null;

        public RestForm(Form callingForm, List<Segment> segments, bool language)
        {
            this.segments = segments;
            this.language = language;
            InitializeComponent();
            fillLanguage();
            fillList();
            this.mainForm = callingForm as Form1;
        }

        private void fillList()
        {
            for (int i = 0; i < segments.Count; i++)
            {
                SegmentListBox.Items.Add(i + " - " + segments[i].getName());
            }
        }

        private void fillLanguage()
        {
            if (language)
            {
                TimeLabel.Text = "Почивка:";
                SelectB.Text = "Избери участък";
                AddB.Text = "Добави";
                RemoveB.Text = "Премахни";
                TitleLabel.Text = "Почивка";
            }
            else
            {
                TimeLabel.Text = "Rest:";
                SelectB.Text = "Choose segment";
                AddB.Text = "Add";
                RemoveB.Text = "Remove";
                TitleLabel.Text = "Rest";
            }
        }

        private void SelectB_Click(object sender, EventArgs e)
        {
            try
            {
                string[] chosenSegmentID = SegmentListBox.SelectedItem.ToString().Split(' ');
                this.id = Convert.ToInt32(chosenSegmentID[0]);
                TimeBox.Text = segments[id].getObstacles().ToString();
            }
            catch (Exception ex)
            {
                SegmentListBox.Items.Add("At Choose" + ex);
            }
        }

        private void AddB_Click(object sender, EventArgs e)
        {
            int TimeA;
            try
            {
                TimeA = Convert.ToInt32(TimeBox.Text);
                this.segments[id].setObstacles(TimeA);
                mainForm.fillSegments(segments);
                TimeBox.Text = "";
            }
            catch (Exception ex)
            {
                TimeBox.Text = ex.ToString();
            }
        }

        private void RemoveB_Click(object sender, EventArgs e)
        {
            try
            {
                this.segments[id].setObstacles(0);
                mainForm.fillSegments(segments);
                TimeBox.Text = "";
            }
            catch (Exception ex)
            {
                TimeBox.Text = ex.ToString();
            }
        }
    }
}
