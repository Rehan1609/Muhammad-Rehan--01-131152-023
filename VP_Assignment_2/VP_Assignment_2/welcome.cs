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

        private void label1_Click(object sender, EventArgs e)
        {
            createProfile create = new createProfile();
            create.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            createProfile create = new createProfile();
            this.Hide();
            create.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            topThree top = new topThree();
            this.Hide();
            top.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            topThree top = new topThree();
            this.Hide();
            top.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            searchProfile search = new searchProfile();
            this.Hide();
            search.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            searchProfile search = new searchProfile();
            this.Hide();
            search.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            deleteRecord del = new deleteRecord();
            this.Hide();
            del.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            deleteRecord del = new deleteRecord();
            this.Hide();
            del.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            markAttendance mark = new markAttendance();
            this.Hide();
            mark.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            markAttendance mark = new markAttendance();
            this.Hide();
            mark.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            ViewAttendance view = new ViewAttendance();
            this.Hide();
            view.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            ViewAttendance view = new ViewAttendance();
            this.Hide();
            view.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
