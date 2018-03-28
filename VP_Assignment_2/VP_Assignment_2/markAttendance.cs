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
        static filePath passPath = new filePath();  //path class
        static string getFileData = passPath.mainPath;  //main file
        static string storeAttendance = passPath.attendancePath;    //attendance file
        StreamReader file = new StreamReader(getFileData);      //read file Data
        StreamWriter write = File.AppendText(storeAttendance);  //Writing attendance file
        string id, name, sem, gpa, uni, dept;
        string line;

        public void markingAttendance()
        {
            string semester = readSemester.Text;
            //Code to be pasted for names
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
                    int[] countName = new int[1000];
                    for (int i = 0; i < countName.Length;)
                    {
                        countName[i] = name.Count();    //Counting names to take inputs wrt names count 
                        groupBox1.Text = name;
                        i++;
                        write.Flush();
                        break;
                    }
                }
                else
                {
                    showMsg.Text = "Record not found";
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            markingAttendance();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            showMsg.Text = sem;
        }

        private void readSemester_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void present_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void absent_CheckedChanged(object sender, EventArgs e)
        {
        }
    }
}