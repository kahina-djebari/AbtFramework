using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace AbtFramework
{
    public class AgiDivisions : PageModel
    {
        [FindsBy(How=How.LinkText,Using ="Divisions")]
        private IWebElement DivisionLink;

        public bool IsAt()
        {
            wait.Until(e => e.Title.Equals("Divisions"));
            if (DivisionLink.Displayed)
            {
                Console.WriteLine("Divisions Link Opened Correctly");
                return true;

            }

            return false;
        }
    }
}