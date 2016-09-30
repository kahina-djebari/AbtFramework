using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace AbtFramework
{
    public class AgiEAC : PageModel
    {
        [FindsBy(How=How.LinkText,Using = "Employee Advisory Council (EAC)")]
        private IWebElement EACLink;

        public bool IsAt()
        {
            wait.Until(e => e.Title.Equals("Employee Advisory Council (EAC)"));
            if (EACLink.Displayed)
            {
                Console.WriteLine("Employee Advisory Council(EAC) Link Opened Succesfully");
                return true;
            }

            return false;
        }
    }
}