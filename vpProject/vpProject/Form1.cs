using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vpProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
        }

        private void Trends_Click(object sender, EventArgs e)
        {
            Trends obj = new Trends();
            obj.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            showGraphs obj = new showGraphs();
            obj.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
