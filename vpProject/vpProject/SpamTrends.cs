using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vpProject
{
    public partial class SpamTrends : Form
    {
        public SpamTrends()
        {
            InitializeComponent();
        }
        string spamContentFile = "SpamTrainingData.txt";
        private void SpamTrends_Load(object sender, EventArgs e)
        {
            try
            {
                using (StreamReader streamReader = new StreamReader(spamContentFile))
                {
                    var textInFile = new Regex("spam", RegexOptions.Compiled);
                    while (streamReader.Peek() > 0)
                    {
                        string line = streamReader.ReadLine();

                        if (textInFile.IsMatch(line))
                        {
                            showSpamTrends.Text += ("SPAM Trends" + line);
                        }
                    }
                }
            }
            catch (Exception)
            {
                showSpamTrends.Text = "There is no Spam Trend Found!";
            }
        }
    }
}
