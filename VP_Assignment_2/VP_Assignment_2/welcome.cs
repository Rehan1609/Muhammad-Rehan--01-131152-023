using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VP_Assignment_2
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        createProfile create = new createProfile();
        searchProfile search = new searchProfile();
        deleteRecord del = new deleteRecord();
        topThree top = new topThree();
        markAttendance mark = new markAttendance();
        private void label1_Click(object sender, EventArgs e)
        {
            create.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            create.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            top.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            top.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            search.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            search.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            del.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            del.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            mark.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            mark.Show();
        }
    }
}
