using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace AbtFramework
{
    public class NewsPage : PageModel
    {
        [FindsBy(How=How.LinkText,Using ="News Archive")]
        private IWebElement newsLinks;

        public bool isAt()
        {
            if (newsLinks.Displayed)
            {
                return true;
            }

            return false;
        }
    }
}