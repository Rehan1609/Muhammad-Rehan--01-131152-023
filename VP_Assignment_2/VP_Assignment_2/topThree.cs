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
        private void button1_Click(object sender, EventArgs e)
        {
            string Path = path.Text;
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
            label4.Text = "" + max1;
            label5.Text = "" + max2;
            label6.Text = "" + max3;
        }
    }
}