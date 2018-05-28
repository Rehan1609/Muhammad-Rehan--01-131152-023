using Spring.Social.Twitter.Api;
using Spring.Social.Twitter.Api.Impl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Spring.Social.Twitter;
using System.Net.WebSockets;
using HtmlAgilityPack;
using DynamicHtml;
using System.IO;
using System.Net;
using Supremes;
using System.Text.RegularExpressions;
using Supremes.Nodes;

namespace vpProject
{
    public partial class TwitterTrends : Form
    {
        public TwitterTrends()
        {
            InitializeComponent();
        }
        public string[] customLink = {"https://twitter.com/hashtag/ENGvPAK?src=tren","https://twitter.com/hashtag/UCLfinal?src=tren",
                                       "https://twitter.com/search?q=Lords&src=tren","https://twitter.com/search?q=England&src=tren",
                                       "https://twitter.com/hashtag/CSKvSRH?src=tren","https://twitter.com/search?q=Liverpool&src=tren",
                                       "https://twitter.com/hashtag/%D9%88%D8%B2%DB%8C%D8%B1%D8%A7%D8%B9%D8%B8%D9%85_%D8%B9%D9%85%D8%B1%D8%A7%D9%86_%D8%AE%D8%A7%D9%86?src=tren",
                                       "https://twitter.com/search?q=%22kp%20assembly%22&src=tren","https://twitter.com/search?q=%22mohammad%20abbas%22&src=tren"};
        public string url = "https://twitter.com/search?q='*?'";
        private void TwitterTrends_Load(object sender, EventArgs e)
        {
            try
            {
                trend1.Text = GrabTrends.scrapTrends(trend1.Text);
                trend2.Text = GrabTrends.scrapTrend2(trend2.Text);
                trend3.Text = GrabTrends.scrapTrend3(trend3.Text);
                trend4.Text = GrabTrends.scrapTrend4(trend4.Text);
                trend5.Text = GrabTrends.scrapTrend5(trend5.Text);
                trend6.Text = GrabTrends.scrapTrend6(trend6.Text);
                trend7.Text = GrabTrends.scrapTrend7(trend7.Text);
                trend8.Text = GrabTrends.scrapTrend8(trend8.Text);
                trend9.Text = GrabTrends.scrapTrend9(trend9.Text);
                trend10.Text = GrabTrends.scrapTrend10(trend10.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to Restore Trends!");
            }
        }

        private void webBrowser2_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            
        }

        private void trend1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            webBrowser2.Show();
            webBrowser2.Navigate(customLink[0]);
        }

        private void trend2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            webBrowser2.Show();
            webBrowser2.Navigate(customLink[1]);
        }

        private void trend3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            webBrowser2.Show();
            webBrowser2.Navigate(customLink[2]);
        }

        private void trend4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            webBrowser2.Show();
            webBrowser2.Navigate(customLink[3]);
        }

        private void trend5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            webBrowser2.Show();
            webBrowser2.Navigate(customLink[4]);
        }

        private void trend6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            webBrowser2.Show();
            webBrowser2.Navigate(customLink[5]);
        }

        private void trend7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            webBrowser2.Show();
            webBrowser2.Navigate(customLink[16]);
        }

        private void trend8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            webBrowser2.Show();
            webBrowser2.Navigate(customLink[7]);
        }

        private void trend9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            webBrowser2.Show();
            webBrowser2.Navigate(customLink[8]);
        }

        private void trend10_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            webBrowser2.Show();
            webBrowser2.Navigate(customLink[9]);
        }

        private void spamFormSwitch_Click(object sender, EventArgs e)
        {
            SpamTrends obj = new SpamTrends();
            obj.ShowDialog();
        }
    }
}

