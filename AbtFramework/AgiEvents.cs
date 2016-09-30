using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace AbtFramework
{
    public class AgiEvents : PageModel
    {
        [FindsBy(How=How.LinkText,Using = "AbtEvents")]
        private IWebElement abtEventsLink;

        public bool IsAt()
        {
            wait.Until(e => e.Title.Equals("AbtEvents - Calendar"));
            if (abtEventsLink.Displayed)
            {

                Console.WriteLine("Events Link Opened Succesfully");
                return true;
            }

            return false;
        }
    }
}