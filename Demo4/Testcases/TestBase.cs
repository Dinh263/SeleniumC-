using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Demo4.CustomizedLibs;
using NUnit.Framework;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;

namespace Demo4.Testcases
{
    public class TestBase
    {
        protected IWebDriver driver;
        protected string baseUrl = BrowserSetUp.getBrowserName();

        [SetUp]
        public void SetUpBrowswer()
        {
            if (BrowserSetUp.getBrowserName().ToLower().StartsWith("fire"))
            {
                Dictionary<string, string> dictffprofile = BrowserSetUp.getFireFoxProfile();
                if (dictffprofile.Count != 0)
                {
                    FirefoxOptions ffoptions = new FirefoxOptions();
                    foreach (var item in dictffprofile)
                    {
                        if (item.Value.ToString().Equals("true") || item.Value.ToString().Equals("false"))
                        {
                            Boolean value = item.Value.ToString().Equals("true") ? true : false;
                            ffoptions.SetPreference(item.Key, value);
                        }
                        else
                        {
                            ffoptions.SetPreference(item.Key, item.Value);
                        }
                    }
                    driver = new FirefoxDriver(ffoptions);
                }
                else
                {
                    driver = new FirefoxDriver();
                }

            }
            else if (BrowserSetUp.getBrowserName().ToLower().StartsWith("chrome"))
            {
                ChromeOptions choptions = new ChromeOptions();
                choptions.AddArguments(BrowserSetUp.GetChromeOption());
                driver = new ChromeDriver(choptions);
            }

            driver.Navigate().GoToUrl(BrowserSetUp.getUrlApplication());
            driver.Manage().Window.Maximize();
            driver.Manage().Cookies.DeleteAllCookies();
        }

        [TearDown]
        public void CleanUp()
        {
            driver.Quit();
        }
    }
}
