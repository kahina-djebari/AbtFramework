using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace AbtFramework
{
    public class AgiOfficeServices : PageModel
    {
        [FindsBy(How=How.LinkText,Using ="Office Services Service Center")]
        private IWebElement OfficeServicesLink;

        public bool IsAt()
        {
            wait.Until(e => e.Title.Equals("Office Services Service Center"));
            if (OfficeServicesLink.Displayed)
            {
                Console.WriteLine("Office Services Link Opened Succesfully");
                return true;
            }

            return false;
        }
    }
}