using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace AbtFramework
{
    public class AgiAbtValues : PageModel
    {
        [FindsBy(How=How.LinkText,Using ="Abt Values")]
        private IWebElement AbtValues;

        public bool IsAt()
        {
            wait.Until(e => e.Title.Equals("Abt Values"));
            if (AbtValues.Displayed)
            {
                Console.WriteLine("Abt Values Link Opened Succesfully");
                return true;
            }

            return false;
        }
    }
}