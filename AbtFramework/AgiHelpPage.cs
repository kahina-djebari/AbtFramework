using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace AbtFramework
{
    public class AgiHelpPage : PageModel
    {
        [FindsBy(How=How.LinkText,Using ="AGI Help")]
        private IWebElement AgiHelp;

        public bool IsAt()
        {
            wait.Until(e => e.Title.Equals("AGI Help"));
            if (AgiHelp.Displayed)
            {
                Console.WriteLine("AGI Help Link Opened Succesfully");
                return true;
            }

            return false;
        }
    }
}