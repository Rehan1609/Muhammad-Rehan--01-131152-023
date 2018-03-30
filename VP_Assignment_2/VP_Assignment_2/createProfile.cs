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
    public partial class createProfile : Form
    {
        public createProfile()
        {
            InitializeComponent();
        }
        static filePath passPath = new filePath(); 
        StreamReader file = new StreamReader(passPath.mainPath);
        string studentID,getName, university, department;
        int smstr;
        float getCGPA;
        string line = "";
        private void createBtn_Click(object sender, EventArgs e)
        {
            string Path = passPath.mainPath;
            while (File.Exists(Path) != true)
            {
                error.Text = ("File does not exists (Create file by entereing path (e.g, d:/name.txt)): ");
                StreamWriter makefile = new StreamWriter(Path);
                makefile.Close();
            }
            studentID = id.Text;
            if (studentID != line)
            {
                file.Close();
                getName = name.Text;
                university = uni.Text;
                department = dept.Text;
                smstr = int.Parse(sem.Text);
                if (smstr > 0 && smstr <= 12)
                {
                    getCGPA = float.Parse(cgpa.Text);
                    if (getCGPA > 0 && getCGPA <= 4)
                    {
                        StreamWriter write = File.AppendText(Path);
                        write.WriteLine(studentID);
                        write.WriteLine(getName.Trim());
                        write.WriteLine(university.Trim());
                        write.WriteLine(department);
                        write.WriteLine(smstr);
                        write.WriteLine(getCGPA);
                        write.Flush();
                        error.Text = ("Your data has been successfully inserted in ");
                        write.Close();
                    }
                    else
                    {
                        error.Text = "Wrong CGPA entered! Correct it please";
                    }
                }
                else
                {
                    error.Text = "Wrong CGPA entered! Correct it please";
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

        private void name_TextChanged(object sender, EventArgs e)
        {
            string line="";
            while ((line = file.ReadLine()) != null)
            {
                if (id.Text == line)
                {
                    studentID = id.Text;
                    error.Text = ("Enter unique id please : ");
                }
            }
        }
    }
}