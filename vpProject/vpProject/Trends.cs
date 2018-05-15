using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vpProject
{
    public partial class twitterTrends : Form
    {
        public twitterTrends()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //public static void DownloadString(string address)
        //{
        //    WebClient client = new WebClient();
        //    string reply = client.DownloadString(address);

        //    MessageBox.Show(reply);
        //}

        private void showtrends_Click(object sender, EventArgs e)
        {
            //trendsList.Show();
            //suspicious.Show();
            WebClient web = new WebClient();
            Stream stream = web.OpenRead("https://trends24.in/");
            using (StreamReader reader = new StreamReader(stream))
              {
                    String text = reader.ReadToEnd();

                    richTextBox1.Text = "" + stream;
                }
           // ________________________________________________
            
        }

        private void suspicious_Click(object sender, EventArgs e)
        {
            showtrends.Hide();
            suspiciousTrends.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SelectionForm obj = new SelectionForm();
            this.Hide();
            obj.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
