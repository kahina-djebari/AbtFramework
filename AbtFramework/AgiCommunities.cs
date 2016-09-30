using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace AbtFramework
{
    public class AgiCommunities : PageModel
    {
        [FindsBy(How=How.LinkText,Using ="Communities")]
        private IWebElement Communities;

        public bool IsAt()
        {
            wait.Until(e => e.Title.Equals("Communities"));
            if (Communities.Displayed)
            {
                Console.WriteLine("Communities Link Opened Succesfully");
                return true;
            }

            return false;
        }
    }
}