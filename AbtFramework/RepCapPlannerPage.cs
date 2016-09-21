using AbtFramework.Utils_Classes;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AbtFramework
{
    public class RepCapPlannerPage : PageModel
    {
        

        [FindsBy(How = How.TagName, Using = "h2")]
        private IList<IWebElement> headers;
        [FindsBy(How=How.CssSelector,Using = "body > div > div.navbar.navbar-fixed-top > div > div > div > ul > li:nth-child(4)")]
        private IWebElement UserFirstName; // this element shows at the top right corner on the page as Hello, FirstName, will have to get a substring

        public void goTo()
        {
           
            wait.PollingInterval = TimeSpan.FromSeconds(1);
            wait.Until(DriverExtentions.WaitforWindowsTobe2);
            SeleniumDriver.FiringDriver.Close();
            SeleniumDriver.FiringDriver.SwitchTo().Window(SeleniumDriver.FiringDriver.WindowHandles.Last());
        }

        public bool isAt()
        {
            if(headers.ElementWithTextExists("New to the Rep Cap Planner?"))
            {
                StopTimer();
                Console.WriteLine("Reputational Capital Planner Prod Page Toook: " + LoadTime + " to load");
                return true;
            }

            return false;
        }

        public void Go()
        {
            StartTimer();
            SeleniumDriver.FiringDriver.Navigate().GoToUrl("http://repcapplanner.corp.abtassoc.com/");

            
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