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
    public partial class LuggageForm : Form
    {

        List<Segment> segments;
        bool language;
        int id;
        private Form1 mainForm = null;

        public LuggageForm(Form callingForm, List<Segment> segments, bool language)
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
                LuggageLabel.Text = "Тегло:";
                SelectB.Text = "Избери участък";
                AddB.Text = "Добави";
                RemoveB.Text = "Премахни";
                TitleLabel.Text = "Багаж";
            }
            else
            {
                LuggageLabel.Text = "Weight:";
                SelectB.Text = "Choose segment";
                AddB.Text = "Add";
                RemoveB.Text = "Remove";
                TitleLabel.Text = "Luggage";
            }
        }

        private void SelectB_Click(object sender, EventArgs e)
        {
            try
            {
                string[] chosenSegmentID = SegmentListBox.SelectedItem.ToString().Split(' ');
                this.id = Convert.ToInt32(chosenSegmentID[0]);
                LuggageBox.Text = segments[id].getLuggage().ToString();
            }catch(Exception ex)
            {
                SegmentListBox.Items.Add("At Choose" + ex);
            }
        }

        private void AddB_Click(object sender, EventArgs e)
        {
            double luggageA;
            try
            {
               luggageA= Convert.ToDouble(LuggageBox.Text);
                if (segments[id].getLuggage() + luggageA > 30)
                {
                    LuggageBox.Text = "Too heavy";
                }
                else
                {
                    this.segments[id].setLuggage(luggageA);
                    mainForm.fillSegments(segments);
                    LuggageBox.Text = "";
                }
            }
            catch(Exception ex)
            {
                LuggageBox.Text = ex.ToString();
            }
            
        }

        private void RemoveB_Click(object sender, EventArgs e)
        {
            try
            {
                segments[id].setLuggage(0);
                mainForm.fillSegments(segments);
                LuggageBox.Text = "";
            }
            catch (Exception ex)
            {
                LuggageBox.Text = ex.ToString();
            }
        }
    }
}
