using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo4.Pages
{
    class SignUpPage:BasePage
    {
        [FindsBy(How = How.Name, Using = "email")]
        IWebElement emailSignUp;

        [FindsBy(How = How.Name, Using = "password")]
        IWebElement passwordSignUp;

        [FindsBy(How = How.Name, Using = "confirmPassword")]
        IWebElement confirmPasswordSignUp;

        [FindsBy(How = How.XPath, Using = "*//div[text()='Sign Up']")]
        IWebElement btnSignUp;



        public SignUpPage(IWebDriver driver) : base(driver)
        {

        }

        public void SignUpAnAccount(string email, string password, string confirmpassword)
        {
            EnterTextOnElement(emailSignUp, email);
            EnterTextOnElement(passwordSignUp, password);
            EnterTextOnElement(confirmPasswordSignUp, confirmpassword);
            ClickElement(btnSignUp);
        }
    }
}
