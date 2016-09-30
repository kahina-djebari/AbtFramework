using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace AbtFramework
{
    public class AgiHRServiceCenter : PageModel
    {
        [FindsBy(How=How.LinkText,Using ="HR Service Center")]
        private IWebElement HRServiceLink;

        public bool IsAt()
        {
            wait.Until(e => e.Title.Equals("HR Service Center"));
            if (HRServiceLink.Displayed)
            {
                Console.WriteLine("HR Service Center Link Opened Succesfully");
                return true;
            }

            return false;
        }
    }
}