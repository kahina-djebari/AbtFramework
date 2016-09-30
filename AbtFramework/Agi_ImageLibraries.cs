using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace AbtFramework
{
    public class Agi_ImageLibraries : PageModel
    {
        [FindsBy(How=How.LinkText,Using ="Image Library")]
        private IWebElement ImageLibraryLink;

        public bool IsAt()
        {
            wait.Until(e => e.Title.Equals("Image Library"));
            if (ImageLibraryLink.Displayed)
            {
                Console.WriteLine("Image Libraries Link Opened Succcesfully");
                return true;
            }

            return false;
        }
    }
}