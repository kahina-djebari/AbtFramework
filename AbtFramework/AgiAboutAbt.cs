using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace AbtFramework
{
    public class AgiAboutAbt : PageModel
    {
        [FindsBy(How=How.LinkText,Using ="About Abt")]
        private IWebElement AboutAbtLink;

        public bool IsAt()
        {
            wait.Until(e => e.Title.Equals("About Abt"));
            if (AboutAbtLink.Displayed)
            {
                Console.WriteLine("About Abt Link Opened Succesfully");
                return true;

            }

            return false;
        }
    }
}