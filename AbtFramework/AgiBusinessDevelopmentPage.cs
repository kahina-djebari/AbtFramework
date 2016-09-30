using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace AbtFramework
{
    public class AgiBusinessDevelopmentPage : PageModel
    {
        [FindsBy(How=How.LinkText,Using = "Business Development Service Center")]
        private IWebElement BusinessLink;

        public bool IsAt()
        {
            wait.Until(e => e.Title.Equals("Business Development Service Center"));

            if (BusinessLink.Displayed)
            {
                Console.WriteLine("Business Development Link Opened Sucessfully");
                return true;
            }

            return false;
        }
    }
}