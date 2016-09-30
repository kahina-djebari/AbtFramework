using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace AbtFramework
{
    public class AgiCTCPage : PageModel
    {
        [FindsBy(How=How.LinkText,Using ="CTC Service Center")]
        private IWebElement ctcLink;

        public bool IsAt()
        {
            wait.Until(e => e.Title.Equals("CTC Service Center"));

            if (ctcLink.Displayed)
            {
                Console.WriteLine("Client Technology Center Link Opened Succesfully");
                return true;
            }

            return false;
        }
    }
}