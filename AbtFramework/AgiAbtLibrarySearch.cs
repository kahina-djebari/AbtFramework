using OpenQA.Selenium.Support.UI;
using System;
using AbtFramework.Utils_Classes.SeleniumUtils;
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
            SeleniumDriver.Instance.Navigate().GoToUrl("https://abtassoc.sharepoint.com/Pages/Updates-to-the-Abt-Library-Search.aspx");
        }

        public string GoToRightFind()
        {
            finder = new PopupWindowFinder(SeleniumDriver.Instance);
            string RightFindWinHandle = finder.Click(RightFindLink);
            StartTimer();
            return RightFindWinHandle;

        }
    }
}