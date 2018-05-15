using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vpProject
{
    public partial class trends : Form
    {
        public trends()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            trendsList.Show();
            SuspiciousButton.Show();
        }

        private void SuspiciousButton_Click(object sender, EventArgs e)
        {
            suspiciousList.Show();
        }

        private void Home_Click(object sender, EventArgs e)
        {
            SelectionForm obj = new SelectionForm();
            this.Hide();
            obj.ShowDialog();
        }
    }
}
