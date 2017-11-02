using OpenQA.Selenium.Support.UI;
using System;
using AbtFramework.SeleniumUtils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace AbtFramework
{
    public class AgiAbtLibrarySearch : PageModel
    {
        [FindsBy(How=How.LinkText,Using ="RightFind")]
        private IWebElement RightFindLink;

        public void Go()
        {
            SeleniumDriver.DriverInstance.Navigate().GoToUrl("https://abtassoc.sharepoint.com/Pages/Updates-to-the-Abt-Library-Search.aspx");
        }

        public string GoToRightFind()
        {
            finder = new PopupWindowFinder(SeleniumDriver.DriverInstance);
            string RightFindWinHandle = finder.Click(RightFindLink);
            StartTimer();
            return RightFindWinHandle;

        }
    }
}