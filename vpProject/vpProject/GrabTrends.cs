using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using System.Net;
using HtmlAgilityPack;
using System.Net.Http;
namespace vpProject
{
    public class GrabTrends
    {

        public static string scrapTrends(string showTrend)
        {
            string input = "<li title> trend</li title><li class=\"\">ENGvPAK</li title>";
            string pattern = "(<li title.*>)(.*)(<\\/li title>)";
            MatchCollection matches = Regex.Matches(input, pattern);

            if (matches.Count > 0)
            {
                foreach (Match m in matches)
                    return "" + m.Groups[2];
            }
            return "No Trends Found";
        }
        public static string scrapTrend2(string showTrend)
        {
            string input = "<li title> trend</li title><li class=\"\">UCLfinal</li title>";
            string pattern = "(<li title.*>)(.*)(<\\/li title>)";
            MatchCollection matches = Regex.Matches(input, pattern);

            if (matches.Count > 0)
            {
                foreach (Match m in matches)
                    return "" + m.Groups[2];
            }
            return "No Trends Found";
        }
        public static string scrapTrend3(string showTrend)
        {
            string input = "<li title> trend</li title><li class=\"trend\">Lords</li title>";
            string pattern = "(<li title.*>)(.*)(<\\/li title>)";
            MatchCollection matches = Regex.Matches(input, pattern);

            if (matches.Count > 0)
            {
                foreach (Match m in matches)
                    return "" + m.Groups[2];
            }
            return "No Trends Found";
        }
        public static string scrapTrend4(string showTrend)
        {
            string input = "<li title> trends</li title><li class=\"trends\">England</li title>";
            string pattern = "(<li title.*>)(.*)(<\\/li title>)";
            MatchCollection matches = Regex.Matches(input, pattern);

            if (matches.Count > 0)
            {
                foreach (Match m in matches)
                    return "" + m.Groups[2];
            }
            return "No Trends Found";
        }

        public static string scrapTrend5(string showTrend)
        {
            string input = "<li title> trends</li title><li class=\"trends\">CSKvSRH/li title>";
            string pattern = "(<li title.*>)(.*)(<\\/li title>)";
            MatchCollection matches = Regex.Matches(input, pattern);

            if (matches.Count > 0)
            {
                foreach (Match m in matches)
                    return "" + m.Groups[2];
            }
            return "No Trends Found";
        }
        public static string scrapTrend6(string showTrend)
        {
            string input = "<li title> trends</li title><li class=\"trends\">Liverpool</li title>";
            string pattern = "(<li title.*>)(.*)(<\\/li title>)";
            MatchCollection matches = Regex.Matches(input, pattern);

            if (matches.Count > 0)
            {
                foreach (Match m in matches)
                    return "" + m.Groups[2];
            }
            return "No Trends Found";
        }
        public static string scrapTrend7(string showTrend)
        {
            string input = "<li title> trends</li title><li class=\"trends\">وزیراعظم_عمران_خان</li title>";
            string pattern = "(<li title.*>)(.*)(<\\/li title>)";
            MatchCollection matches = Regex.Matches(input, pattern);

            if (matches.Count > 0)
            {
                foreach (Match m in matches)
                    return "" + m.Groups[2];
            }
            return "No Trends Found";
        }
        public static string scrapTrend8(string showTrend)
        {
            string input = "<li title> trends</li title><li class=\"trends\">KP Assembly</li title>";
            string pattern = "(<li title.*>)(.*)(<\\/li title>)";
            MatchCollection matches = Regex.Matches(input, pattern);

            if (matches.Count > 0)
            {
                foreach (Match m in matches)
                    return "" + m.Groups[2];
            }
            return "No Trends Found";
        }
        public static string scrapTrend9(string showTrend)
        {
            string input = "<li title> trends</li title><li class=\"trends\">mohammad abbas</li title>";
            string pattern = "(<li title.*>)(.*)(<\\/li title>)";
            MatchCollection matches = Regex.Matches(input, pattern);

            if (matches.Count > 0)
            {
                foreach (Match m in matches)
                    return "" + m.Groups[2];
            }
            return "No Trends Found";
        }
        //Pending
        public static string scrapTrend10(string showTrend)
        {
            string input = "<li title> trends</li title><li class=\"trends\">congratulations paksitan</li title>";
            string pattern = "(<li title.*>)(.*)(<\\/li title>)";
            MatchCollection matches = Regex.Matches(input, pattern);

            if (matches.Count > 0)
            {
                foreach (Match m in matches)
                    return "" + m.Groups[2];
            }
            return "No Trends Found";
        }
        public static Uri address { get; set; }
    }
}
