using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using AbtFramework.Utils_Classes;

namespace AbtFramework
{
    public class WebExPage : PageModel
    {
        [FindsBy(How=How.Id,Using = "wcc-lnk-loginLink")]
        private IWebElement loginbtn;
        [FindsBy(How=How.CssSelector,Using = "#screen2_h1")]
        private IWebElement userFirstName;
        [FindsBy(How=How.LinkText,Using = "Start Meeting")]
        private IWebElement StartMeeting;

        public void goTo()
        {
            Driver.seleniumdriver.Navigate().GoToUrl("https://abtassociates.webex.com/mw3100/mywebex/default.do?siteurl=abtassociates");

        }

        public void Login()
        {
            Driver.seleniumdriver.SwitchTo().Frame("header");
            loginbtn.Click();
        }

        public void Go(WebEnvironment link)
        {
            switch (link)
            {
                case WebEnvironment.TestEnvironment:
                   GoToUrl("https://abtassoc-test.webex.com");
                    Console.WriteLine("WebEx Test HomePage Loaded in: "+LoadTime);
                    break;
                case WebEnvironment.ProductionEnvironment:
                    GoToUrl("https://abtassociates.webex.com");
                    Console.WriteLine("WebEx Production HomePage Loaded in: " + LoadTime);
                    break;
                default:
                    break;
            }

        }

        private void GoToUrl(string url)
        {
            StartTimer();
            Driver.seleniumdriver.Navigate().GoToUrl(url);
            wait.Until(e =>StartMeeting.Displayed);
            StopTimer();

        }

        public bool isUserLoggedIn()
        {
            if (isAt())
            {
               
                if (userFirstName.Text.Split(',')[1].Substring(1,5).Equals(SSOCrendentials.CurrentUser.Split(' ')[0]))
                {
                    return true;
                }
            }

            return false;
        }

        private bool isAt()
        {
            wait.Until(e => StartMeeting.Displayed);
            return true;

        }
    }
}