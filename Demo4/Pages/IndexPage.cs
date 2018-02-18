using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo4.Pages
{
    class IndexPage:BasePage
    {
        [FindsBy(How = How.XPath, Using = "*//a[@id='NAVBAR_SIGNUP_BTN']")]
        IWebElement lnkSignUp;


        public IndexPage(IWebDriver driver) : base(driver)
        {
        }

        public SignUpPage GoToSignUpPage()
        {
            ClickElement(lnkSignUp);
            return new SignUpPage(driver);
        }
    }
}
