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
        List<string> list = new List<string>();
        private void button1_Click(object sender, EventArgs e)
        {
            label3.Visible = false;
            readData.Visible = false;
            label4.Visible = false;
            saveAtt.Visible = false;
            label5.Visible = false;
            readSemester.Visible = false;
            label5.Visible = false;
            listBox1.Visible = true;
            button1.Visible = false;
            markAtt.Visible = true;
            label6.Visible = true;
            change.Visible = true;
            inputAttendance.Visible = true;
            //Code to be pasted for names
            string path = readData.Text;
            string anotherFile = saveAtt.Text;
            string semester = readSemester.Text;
            label7.Text = "Students of " + semester + " semester";
        }

        private void markAtt_Click(object sender, EventArgs e)
        {
            
            //string id, name, sem, gpa, uni, dept;
            //string line;
            //string att = "";  //attendance variable
            //StreamReader file = new StreamReader(path);
            //StreamWriter write = File.AppendText(anotherFile);
            //while ((line = file.ReadLine()) != null)
            //{
            //    id = line;
            //    name = file.ReadLine();
            //    uni = file.ReadLine();
            //    dept = file.ReadLine();
            //    sem = file.ReadLine();
            //    gpa = file.ReadLine();

            //    if (sem == semester)
            //    {
            //        int[] x = new int[1000];
            //        for (int i = 0; i < x.Length; i++)  // input equals to name count. jitny naam utni input k liy.
            //        {
            //            x[i] = name.Count();    //name count.
            //            list.Add(name); //CHECK
            //            listBox1.DataSource = list;
            //            change.Text = name; //name change
            //            att = inputAttendance.Text;
            //            if (att.Equals("P") || att.Equals("p") || att.Equals("A") || att.Equals("a"))
            //            {
            //                write.WriteLine(sem);
            //                write.WriteLine(name);
            //                write.WriteLine(att);
            //                write.Flush();
            //                break;
            //            }
            //        }
            //    }
            //    showMsg.Text = "Attendance Marked!";
            //}
        }
    }
}