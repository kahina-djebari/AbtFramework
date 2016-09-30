using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace AbtFramework
{
    public class Agi_ExpertiseCenter : PageModel
    {
        [FindsBy(How=How.LinkText,Using ="Expertise Centers")]
        private IWebElement ExpertiseCenterLink;

        public bool IsAt()
        {
            wait.Until(e => e.Title.Equals("Expertise Centers - Home"));
            if (ExpertiseCenterLink.Displayed)
            {
                Console.WriteLine("Expertise Centers Link Opened Succesfully");
                return true;
            }

            return false;
        }
    }
}