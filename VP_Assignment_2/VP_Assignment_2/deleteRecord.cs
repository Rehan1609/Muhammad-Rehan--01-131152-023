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
    public partial class deleteRecord : Form
    {
        public deleteRecord()
        {
            InitializeComponent();
        }
        filePath passPath = new filePath();
        private void button1_Click(object sender, EventArgs e)
        {
            string Path = passPath.mainPath;
            string id = getID.Text;
            StreamReader file = new StreamReader(Path);
            string line;    //reading integers
            int addition = 0;
            while ((line = file.ReadLine()) != null)
            {
                addition++;
            }
            file.Close();
            file = new StreamReader(Path);
            string[] length = new string[addition]; //passing string to n lines
            for (int i = 0; i < addition; i++)
            {
                length[i] = file.ReadLine();
                if (length[i] == id.ToString()) //if condition is true
                {
                    length[i] = null;   //make it null
                    i--;                //decrement previous records
                    for (int j = 0; j < 5; j++)
                    {
                        line = file.ReadLine();
                    }
                }
            }
            file.Close();
            using (StreamWriter newfile = new StreamWriter(Path))
            {
                for (int i = 0; i < length.Length; i++)
                {
                    newfile.WriteLine(length[i]);
                }
                newfile.Close();//edited
            }
            showMsg.Text="Record has been deleted successfully";
            home.Show();
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
