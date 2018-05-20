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
using System.IO;
using System.Net;
using Supremes;

namespace vpProject
{
    public partial class TwitterTrends : Form
    {
        public TwitterTrends()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            trendsList.Show();
            SuspiciousButton.Show();
            String consumerKey = "BvdjSAbD26aSNRDN7FbiTAsDV"; // The application's consumer key
            String consumerSecret = "N7Y93ojNZFmmkbFfVhAokF4L79PeVoOR4hEUiRa5PAvFeOfT2O"; // The application's consumer secret
            String accessToken = "3311888538-kQwVCbPsHbOOwmj3TEbgNGp9iitIoDwcUMDOPw6"; // The access token granted after OAuth authorization
            String accessTokenSecret = "p2rU9ERjtCEflCNp5LVvLrZF2Gvp1Bt7mlZBWV7Jg8viD"; // The access token secret granted after OAuth authorization
            TwitterTemplate twitterResponse = new TwitterTemplate(consumerKey, consumerSecret, accessToken, accessTokenSecret);
            string clientToken = "3311888538-kQwVCbPsHbOOwmj3TEbgNGp9iitIoDwcUMDOPw6";
            TwitterTemplate twitterClient = new TwitterTemplate(clientToken, "", "", "");
            string access_token = "";
            var post = WebRequest.Create("https://api.twitter.com/oauth2/token") as HttpWebRequest;
            post.Method = "POST";
            post.ContentType = "application/x-www-form-urlencoded";
            post.Headers[HttpRequestHeader.Authorization] = "Basic ";
            var reqbody = Encoding.UTF8.GetBytes("grant_type=client_credentials");
            post.ContentLength = reqbody.Length;
            using (var req = post.GetRequestStream())
            {
                req.Write(reqbody, 0, reqbody.Length);
            }
            try
            {
                string respbody = null;
                using (var resp = post.GetResponse().GetResponseStream()) //request will be sent.
                {
                    var respR = new StreamReader(resp);
                    respbody = respR.ReadToEnd();
                }
                //TODO use a library to parse json
                access_token = respbody.Substring(respbody.IndexOf("access_token\":\"") + "access_token\":\"".Length, respbody.IndexOf("\"}") - (respbody.IndexOf("access_token\":\"") + "access_token\":\"".Length));
            }
            catch //if credentials are not valid (403 error)
            {
                //TODO
            }
            //------------------------------------------------------------
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Home_Click(object sender, EventArgs e)
        {
            SelectionForm obj = new SelectionForm();
            this.Hide();
            obj.ShowDialog();
        }

        private void SuspiciousButton_Click(object sender, EventArgs e)
        {

        }
    }
}
