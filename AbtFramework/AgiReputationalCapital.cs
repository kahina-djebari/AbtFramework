using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace AbtFramework
{
    public class AgiReputationalCapital : PageModel
    {
        [FindsBy(How=How.LinkText,Using ="Reputational Capital Service Center")]
        private IWebElement ReputationalLink;

        public bool IsAt()
        {

            wait.Until(e => e.Title.Equals("Reputational Capital Service Center"));

            if (ReputationalLink.Displayed)
            {
                Console.WriteLine("Reputational Capital Link Opened Succesfully");
                return true;
            }

            return false;
        }
    }
}