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
    public partial class LanguageForm : Form
    {
        public LanguageForm()
        {
            InitializeComponent();
        }

        private void BG_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(true);
            form1.Show();
            this.Hide();
        }

        private void EN_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(false);
            form1.Show();
            this.Hide();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
