using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace AbtFramework
{
    public class AgiCreativeServices : PageModel
    {
        [FindsBy(How=How.LinkText,Using ="Creative Services Service Center")]
        private IWebElement CreativeServLink;

        public bool IsAt()
        {
            wait.Until(e => e.Title.Equals("Creative Services Service Center"));

            if (CreativeServLink.Displayed)
            {
                Console.WriteLine("Creative Services Link Opened Succesfully");
                return true;
            }


            return false;
        }

    }
}