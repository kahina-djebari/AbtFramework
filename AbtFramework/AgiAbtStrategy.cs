using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace AbtFramework
{
    public class AgiAbtStrategy : PageModel
    {
        [FindsBy(How=How.LinkText,Using ="Company Strategy")]
        private IWebElement StrategyLink;

        public bool IsAt()
        {
            wait.Until(e => e.Title.Equals("Company Strategy"));
            if (StrategyLink.Displayed)
            {
                Console.WriteLine("Abt Strategy Link Opened Correctly");
                return true;
            }

            return false;
        }
    }
}