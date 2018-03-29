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
        //Variables Decalaration
        static filePath passPath = new filePath();  //path class
        static string getFileData = passPath.mainPath;  //main file
        static string storeAttendance = passPath.attendancePath;    //attendance file
        StreamReader file = new StreamReader(getFileData);      //read file Data
        StreamWriter write = File.AppendText(storeAttendance);  //Writing attendance file
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
                    int[] countName = new int[1000];
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
                        return;
                    }
                }
                else
                {
                    this.Dispose();
                    showMsg.Text = "Record not found for semester " + semester;
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
    }
}