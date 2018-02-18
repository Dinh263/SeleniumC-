using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Configuration;
using System.Text.RegularExpressions;

namespace Demo4.CustomizedLibs
{
    class BrowserSetUp
    {
        public static List<string> GetChromeOption()
        {
            List<string> arguments = new List<string>();            
            string profileFile = ApplicationSetUp.getCurrentApplicatonPath() + "profile/chromeprofile.txt";
            var lines = File.ReadAllLines(profileFile);
            for(var i = 0; i < lines.Length; i++)
            {
                if (!lines.ToString().StartsWith("#"))
                {
                    arguments.Add(lines[i]);
                }
                
            }
            return arguments;
        }

        public static Dictionary<string,string> getFireFoxProfile()
        {
            List<string> arguments = new List<string>();
            string profileFile = ApplicationSetUp.getCurrentApplicatonPath() + "profile/firefoxprofile.txt";
            Dictionary<string, string> dictProfile = new Dictionary<string, string>();
            var lines = File.ReadAllLines(profileFile);
            for(var i = 0; i < lines.Length; i++)
            {
                if (!Regex.IsMatch(lines[i], "^(#)"))
                {
                    string key = lines[i].Substring(0, lines[i].IndexOf("="));
                    string value = lines[i].Substring(lines[i].IndexOf("=") + 1);
                    dictProfile.Add(key, value);
                }            
            }
            return dictProfile;
        }

        public static string getBrowserName()
        {
            return ConfigurationManager.AppSettings["browsername"].ToString();
        }

        public static string getUrlApplication()
        {
            return ConfigurationManager.AppSettings["UrlApplication"].ToString();
        }
    }
}
