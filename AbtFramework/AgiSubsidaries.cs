using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace AbtFramework
{
    public class AgiSubsidaries : PageModel
    {
        [FindsBy(How=How.LinkText,Using ="Subsidiaries")]
        private IWebElement Subsidaries;

        public bool IsAt()
        {
            wait.Until(e => e.Title.Equals("Subsidiaries"));
            if (Subsidaries.Displayed)
            {
                Console.WriteLine("Subsidiaries Link Opened Succesfully");
                return true;
            }

            return false;
        }
    }
}