using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace AbtFramework
{
    public class AgiInitiatives : PageModel
    {
        [FindsBy(How=How.LinkText,Using ="Initiatives & Programs")]
        private IWebElement InitiativesLink;

        public bool IsAt()
        {
            wait.Until(e => e.Title.Equals("Initiatives & Programs"));
            if (InitiativesLink.Displayed)
            {
                Console.WriteLine("Initiatives & Programs Link Opened Succesfully");
                return true;
            }

            return false;
        }
    }
}