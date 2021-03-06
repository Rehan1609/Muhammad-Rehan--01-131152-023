﻿using System;
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
        static filePath obj = new filePath();
        static string recordFile = obj.mainPath;
        static string attFile = obj.attendancePath;
        StreamReader file = new StreamReader(recordFile);      //read file Data
        StreamWriter write = File.AppendText(attFile);  //Writing attendance file
        string id, name, sem, gpa, uni, dept;
        string line="";
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = "Mark Attendance";
            string semester = readSemester.Text;
            groupBox1.Show();
            radioButton1.Show();
            radioButton2.Show();
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
                    double[] countName = new double[1000];
                    for (int i = 0; i < countName.Length; )
                    {
                        countName[i] = name.Count();   //Counting names to take inputs wrt names count 
                        write.WriteLine(semester);
                        write.WriteLine(name);
                        groupBox1.Text = name;  //Printing name on GroupBox
                        if (radioButton1.Checked == true)
                        {
                            write.WriteLine("Present");
                        }
                        else
                        {
                            write.WriteLine("Absent");
                        }
                        i++;
                        write.Flush();
                        return;
                    }
                }
                else
                {
                    showMsg.Text = "Attendance Marked for semester " + semester;
                }
            }
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}