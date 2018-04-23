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
    public partial class twitterTrends : Form
    {
        public twitterTrends()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void showtrends_Click(object sender, EventArgs e)
        {
            trendsList.Show();
            suspicious.Show();
        }

        private void suspicious_Click(object sender, EventArgs e)
        {
            showtrends.Hide();
            suspiciousTrends.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
