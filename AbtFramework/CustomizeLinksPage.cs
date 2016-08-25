using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace AbtFramework
{
    public class CustomizeLinksPage : PageModel
    {
        [FindsBy(How=How.LinkText,Using ="Personal Links")]
        private IWebElement header;

        public bool isAt()
        {
            wait.Until(e => header.Displayed);
            return true;
        }
    }
}