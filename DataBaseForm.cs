using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace OxygenCalculator
{
    public partial class DataBaseForm : Form
    {
        private bool language = true;

        public DataBaseForm()
        {
            InitializeComponent();
            LanguageB.Text = "English";
            
            FillLanguagesBG();
        }

        private void FillLanguagesBG()
        {
            DatabaseNotFoundLabel.Text = "Не е намерена База данни";
            LinkLabel.Text = "Ако нямате база моя изтеглете и инсталирайте XAMPP от дадения линк:";
            linkLabel1.Text = "Изтегли XAMPP";
            RunLabel.Text = "След като инсталирате XAMPP моля вкючете XAMPP control panel и изберете Start бутоните до Apache и MySQL";
        }

        private void FillLanguagesEN()
        {
            DatabaseNotFoundLabel.Text = "Database not found";
            LinkLabel.Text = "If you don't have a database please download it here:";
            linkLabel1.Text = "Download XAMPP";
            RunLabel.Text = "After installing XAMPP please run the XAMPP control panel and choose the Start buttons next to Apache and MySQL";
        }

            private void DataBaseForm_Load(object sender, EventArgs e)
        {

        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void LanguageB_Click(object sender, EventArgs e)
        {
            if (language)
            {
                FillLanguagesEN();
                language = false;
                LanguageB.Text = "Български";
            }
            else
            {
                FillLanguagesBG();
                language = true;
                LanguageB.Text = "English";
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.apachefriends.org/download.html");
        }
    }
}
