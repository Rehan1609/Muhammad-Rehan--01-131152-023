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
    public partial class topThree : Form
    {
        public topThree()
        {
            InitializeComponent();
        }
        filePath passPath = new filePath();
        private void button1_Click(object sender, EventArgs e)
        {
            string Path = passPath.mainPath;
            string searchID, name, sem, uni, dept, gpa;
            string line = "";
            int i = 0;
            float max1, max2, max3;
            StreamReader file = new StreamReader(Path);
            float[] array = new float[100];
            while ((line = file.ReadLine()) != null)
            {
                searchID = line;
                name = file.ReadLine();
                uni = file.ReadLine();
                dept = file.ReadLine();
                sem = file.ReadLine();
                gpa = file.ReadLine();

                // Console.WriteLine(gpa);

                //for(int i=0;)
                array[i] = float.Parse(gpa);
                //Console.WriteLine(array[0]);
                i++;

            }
            max1 = array.Max();
            for (int j = 0; j < array.Length; j++)
            {
                if (array[j] == max1)
                {
                    array[j] = 0;
                    break;
                }
            }
            max2 = array.Max();
            for (int j = 0; j < array.Length; j++)
            {
                if (array[j] == max2)
                {
                    array[j] = 0;
                    break;
                }
            }
            max3 = array.Max();
            for (int j = 0; j < array.Length; j++)
            {
                if (array[j] == max3)
                {
                    array[j] = 0;
                    break;
                }
            }
            showMsg.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            showMsg.Text = "Top three CGPA's";
            label4.Text = "First:     " + max1.ToString();
            label5.Text = "Second:  " + max2.ToString();
            label6.Text = "Third:     " + max3.ToString();
            file.Close();
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