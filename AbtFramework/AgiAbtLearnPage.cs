using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace AbtFramework
{
    public class AgiAbtLearnPage : PageModel
    {
        [FindsBy(How=How.LinkText,Using = "AbtLearn")]
        private IWebElement AbtLearnLink;

        public bool IsAt()
        {
            wait.Until(e => e.Title.Equals("AbtLearn"));
            if (AbtLearnLink.Displayed)
            {
                Console.WriteLine("AbtLearn Link Opened Succesfully");
                return true;
            }

            return false;
        }
    }
}