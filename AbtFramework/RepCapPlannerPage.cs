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
        [FindsBy(How=How.LinkText,Using = "RepCap Planner")]
        private IWebElement RepCapLink;

        [FindsBy(How = How.TagName, Using = "h2")]
        private IList<IWebElement> headers;

        public void goTo()
        {
            RepCapLink.Click();
            wait.PollingInterval = TimeSpan.FromSeconds(1);
            wait.Until(DriverExtentions.WaitforWindowsTobe2);
            Driver.seleniumdriver.Close();
            Driver.seleniumdriver.SwitchTo().Window(Driver.seleniumdriver.WindowHandles.Last());
        }

        public bool isAt()
        {
            if(headers.ElementWithTextExists("New to the Rep Cap Planner?"))
            {
                return true;
            }

            return false;
        }
    }
}