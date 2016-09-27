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
        [FindsBy(How=How.Id,Using = "btn_join_room")]
        private IWebElement StartMeeting;

      

        public void Login()
        {
           // SeleniumDriver.seleniumdriver.SwitchTo().Frame("header");
            loginbtn.Click();
        }

        public void Go(WebEnvironment link)
        {
            switch (link)
            {
                case WebEnvironment.TestEnvironment:
                   GoToUrl("https://abtassoc-test.webex.com");
                    Console.WriteLine("WebEx Test HomePage took: "+LoadTime+" to load using okta");
                   
                    break;
                case WebEnvironment.ProductionEnvironment:
                    GoToUrl("https://abtassociates.webex.com");
                    Console.WriteLine("WebEx Production HomePage took: " + LoadTime+"to load using simieo");
                    break;
                default:
                    break;
            }

        }

        private void GoToUrl(string url)
        {
            StartTimer();
            SeleniumDriver.Instance.Navigate().GoToUrl(url);
            wait.Until(e => StartMeeting.Displayed);
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

        public bool isAt()
        {
            wait.Until(e => StartMeeting.Displayed);
            StopTimer();
            return true;

        }
    }
}