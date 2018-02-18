using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo4.Pages
{
    class BasePage
    {
        public IWebDriver driver;
        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        public void ClickElement(IWebElement element)
        {
            element.Click();
        }

        public void EnterTextOnElement(IWebElement element, string text)
        {
            element.SendKeys(text);
        }

        public void SelectDropDownListByText(IWebElement element, string text)
        {
            SelectElement ddoplist = (SelectElement)element;
            ddoplist.SelectByText(text);
        }

        public void SelectDropDownListByValue(IWebElement element, string value)
        {
            SelectElement ddoplist = (SelectElement)element;
            ddoplist.SelectByValue(value);
        }
    }
}

