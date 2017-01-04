using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace AbtFramework
{
    public class AgiEvents : PageModel
    {
        [FindsBy(How=How.LinkText,Using = "AbtEvents")]
        private IWebElement abtEventsLink;
        [FindsBy(How=How.Id,Using = "WPQ2_nav_header")]
        private IWebElement _CalendarCurrentMonth;

        public string EventCalendarCurrentMonth { get { return _CalendarCurrentMonth.Text; } }

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