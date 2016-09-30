using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace AbtFramework
{
    public class AgiAnnouncements : PageModel
    {
        [FindsBy(How=How.LinkText,Using ="Happenings")]
        private IWebElement Hapenings;

        public bool IsAt()
        {
            wait.Until(e => e.Title.Equals("Announcements - All items"));
            if (Hapenings.Displayed)
            {
                Console.WriteLine("Announcements Link Opened Succesfully");
                return true;
            }

            return false;
        }
    }
}