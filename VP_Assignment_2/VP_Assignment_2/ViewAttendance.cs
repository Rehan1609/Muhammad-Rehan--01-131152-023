using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace VP_Assignment_2
{
    public partial class ViewAttendance : Form
    {
        public ViewAttendance()
        {
            InitializeComponent();
        }
        static filePath passPath = new filePath();
        static string attendanceFile = passPath.attendancePath;
        private void button1_Click(object sender, EventArgs e)
        {
            string semester = textBox1.Text;
            string pres_absnt, name, sem;
            string line;
            StreamReader file = new StreamReader(attendanceFile);
            while ((line = file.ReadLine()) != null)
            {
                sem = line;
                name = file.ReadLine();
                pres_absnt = file.ReadLine();

                if (sem == semester)
                {
                    viewList.Text = "Attendance of semester : " + semester;
                    showAttendance.Show();
                    showAttendance.Text += (name + "\t" + pres_absnt + " ");
                }
                else
                {
                    viewList.Hide();
                    viewList.Text = "No Record Found for semester " + semester;
                }
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Application.Restart();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
