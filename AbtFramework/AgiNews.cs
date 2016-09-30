using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace AbtFramework
{
    public class AgiNews : PageModel
    {
        [FindsBy(How=How.LinkText,Using ="News Archive")]
        private IWebElement newsLinks;

        public bool IsAt()
        {
            wait.Until(e => e.Title.Equals("News"));
            if (newsLinks.Displayed)
            {
                Console.WriteLine("News Link Opened Succesfully");
                return true;
            }

            return false;
        }

      
    }
}