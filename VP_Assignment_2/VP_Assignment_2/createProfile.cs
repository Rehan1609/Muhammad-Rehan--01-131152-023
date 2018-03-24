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

        private void createBtn_Click(object sender, EventArgs e)
        {
            string Path = path.Text;
            while (File.Exists(Path) != true)
            {
                error.Text = ("File does not exists (Create file by entereing path (e.g, d:/name.txt)): ");
                StreamWriter makefile = new StreamWriter(Path);
                makefile.Close();
            }
            string studentID = id.Text;
            string line = "";
            StreamReader file = new StreamReader(Path);
            while ((line = file.ReadLine()) != null)
            {
                if (studentID == line)
                {
                    error.Text = ("Enter unique id please : ");
                }
            }
            if (studentID != line)
            {
                //file.Close();
                string getName = name.Text;
                string university = uni.Text;
                string department = dept.Text;
                int smstr = int.Parse(sem.Text);
                if (smstr > 0 && smstr <= 12)
                {
                    float getCGPA = float.Parse(cgpa.Text);
                    if (getCGPA > 0 && getCGPA <= 4)
                    {
                        StreamWriter write = File.AppendText(Path);
                        write.WriteLine(studentID);
                        write.WriteLine(getName);
                        write.WriteLine(university);
                        write.WriteLine(department);
                        write.WriteLine(smstr);
                        write.WriteLine(getCGPA);
                        write.Flush();
                        error.Text = ("Data has been successfully inserted in " + Path);
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
            //welcome obj = new welcome();
            //this.Dispose();
            //obj.Show();
        }
    }
}