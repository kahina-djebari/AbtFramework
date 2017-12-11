using AbtFramework.Utils_Classes;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using AbtFramework.Utils_Classes.SeleniumUtils;

namespace AbtFramework
{
    public class RepCapPlannerPage : PageModel
    {
        

        [FindsBy(How = How.TagName, Using = "h2")]
        private IList<IWebElement> headers;
        [FindsBy(How=How.CssSelector,Using = "body > div > div.navbar.navbar-fixed-top > div > div > div > ul > li:nth-child(4)")]
        private IWebElement UserFirstName; // this element shows at the top right corner on the page as Hello, FirstName, will have to get a substring
        [FindsBy(How=How.LinkText,Using ="Create New Plan")]
        private IWebElement CreateNewPlanLink;

        public void goTo()
        {
           
            wait.PollingInterval = TimeSpan.FromSeconds(1);
            wait.Until(DriverExtentions.WaitforWindowsTobe2);
            SeleniumDriver.Instance.Close();
            SeleniumDriver.Instance.SwitchTo().Window(SeleniumDriver.Instance.WindowHandles.Last());
        }

        public bool isAt()
        {
            wait.Until(e => e.Title.Equals("Reputational Capital Planner"));
            StopTimer();
            PrintResponseTime("Reputational Capital Planner");
            if (CreateNewPlanLink.Displayed)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        public void Go()
        {
            StartTimer();
            SeleniumDriver.Instance.Navigate().GoToUrl("http://repcapplanner.corp.abtassoc.com/");

            
        }

        public bool isUserLoggedIn()
        {
            if (isAt())
            {

                if(UserFirstName.Text.Substring(7).Equals(SSOCrendentials.CurrentUser.Split(' ')[0])){
                 
                    return true;
                }
            }

            return false;
        }
    }
}