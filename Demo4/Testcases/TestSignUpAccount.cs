using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo4.Pages;
using Demo4.CustomizedLibs;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
namespace Demo4.Testcases
{
    [TestFixture]
    public class TestSignUpAccount
    {
        IWebDriver driver;
        
        IndexPage indexP;
        SignUpPage signupP;

        [SetUp]
        public void openURL()
        {
            if (BrowserSetUp.getBrowserName().ToLower().StartsWith("fire"))
            {
                Dictionary<string, string> dictffprofile = BrowserSetUp.getFireFoxProfile();
                if (dictffprofile.Count != 0)
                {
                    FirefoxOptions ffoptions = new FirefoxOptions();
                    foreach(var item in dictffprofile)
                    {
                        if(item.Value.ToString().Equals("true") || item.Value.ToString().Equals("false"))
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
        }
        [Test]
        public void TestLoginAccount()
        {
            /*
            indexP = new IndexPage(driver);
            signupP = indexP.GoToSignUpPage();
            signupP.SignUpAnAccount("user205@gmail.com", "123456789", "123456789");
            */
        }
    }
}
