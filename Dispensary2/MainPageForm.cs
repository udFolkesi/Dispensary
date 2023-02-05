using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Dispensary2
{
    public partial class MainPageForm : Form
    {
        public MainPageForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StatisticsForm statisticsForm = new StatisticsForm();
            statisticsForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ViewingForm tables = new ViewingForm();
            tables.Show();
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            AuthorizationForm authorization = new AuthorizationForm();
            authorization.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EditingForm editingForm = new EditingForm();
            editingForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //ReportsForm reportsForm = new ReportsForm();
            //reportsForm.Show();
        }
    }
}
