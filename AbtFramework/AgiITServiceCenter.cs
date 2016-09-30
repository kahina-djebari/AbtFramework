using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace AbtFramework
{
    public class AgiITServiceCenter : PageModel
    {
        [FindsBy(How=How.LinkText,Using ="IT Service Center")]
        private IWebElement ITServiceLink;

        public bool IsAt()
        {
            wait.Until(e => e.Title.Equals("IT Service Center"));
            if (ITServiceLink.Displayed)
            {
                Console.WriteLine("IT Service Center Link Opened Succesfully");
                return true;
            }


            return false;
        }
    }
}