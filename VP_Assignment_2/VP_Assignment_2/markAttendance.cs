using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VP_Assignment_2
{
    public partial class markAttendance : Form
    {
        public markAttendance()
        {
            InitializeComponent();
        }
        filePath passPath = new filePath();
        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Label labels = new System.Windows.Forms.Label();
            string getFileData = passPath.mainPath;
            string storeAttendance = passPath.attendancePath;
            string semester = readSemester.Text;
            //Code to be pasted for names
            string id, name, sem, gpa, uni, dept;
            string line;
            string att = "";  //attendance variable
            StreamReader file = new StreamReader(getFileData);
            StreamWriter write = File.AppendText(storeAttendance);
            while ((line = file.ReadLine()) != null)
            {
                id = line;
                name = file.ReadLine();
                uni = file.ReadLine();
                dept = file.ReadLine();
                sem = file.ReadLine();
                gpa = file.ReadLine();

                if (sem == semester)
                {
                    int[] x = new int[1000];
                    for (int i = 0; i < x.Length; i++)  // input equals to name count. jitny naam utni input k liy.
                    {
                        x[i] = name.Count();    //name count.
                        textBox1.Text = name;
                        
                    }
                }
                label7.Text = "Students of " + semester + " semester";
            }
        }
    }
}