using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace AbtFramework
{
    public class AgiNewsArchive : PageModel
    {
        [FindsBy(How=How.LinkText,Using ="News Archive")]
        private IWebElement NewsArchiveLink;

        public bool IsAt()
        {
            wait.Until(e => e.Title.Equals("News Archive"));
            if (NewsArchiveLink.Displayed)
            {
                Console.WriteLine("News Archive Link Opened Succesfully");
                return true;
            }

            return false;
        }
    }
}