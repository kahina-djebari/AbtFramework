using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace AbtFramework
{
    public class RepCapPlannerPage : PageModel
    {
        [FindsBy(How=How.LinkText,Using = "RepCap Planner")]
        private IWebElement RepCapLink;

        public void goTo()
        {
            RepCapLink.Click();
        }
    }
}