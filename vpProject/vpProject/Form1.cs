﻿using System;
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
    public partial class SelectionForm : Form
    {
        public SelectionForm()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            trends obj = new trends();
            obj.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            trends obj = new trends();
            obj.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            TrendsGraph graph = new TrendsGraph();
            this.Hide();
            graph.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            TrendsGraph graph = new TrendsGraph();
            this.Hide();
            graph.Show();
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click_2(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click_1(object sender, EventArgs e)
        {
            TrendsGraph graph = new TrendsGraph();
            this.Hide();
            graph.Show();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            trends obj = new trends();
            obj.Show();
        }

    }
}
