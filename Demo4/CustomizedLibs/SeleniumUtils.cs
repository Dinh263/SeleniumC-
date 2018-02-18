using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo4.CustomizedLibs;

namespace Demo4.CustomizedLibs
{
    class SeleniumUtils
    {
        public static void takeScreenshoot(IWebDriver driver)
        {
            string screenshotPath =  ApplicationSetUp.getCurrentApplicatonPath() + "Screenshots/";
            ITakesScreenshot screenshotDriver = driver as ITakesScreenshot;
            Screenshot screenshot = screenshotDriver.GetScreenshot();
            string fp = screenshotPath + DateTime.Now.ToString("dd_MM_yyyy_hh_mm_ss") + ".png";
            screenshot.SaveAsFile(fp, ScreenshotImageFormat.Png);

        }
    }
}
