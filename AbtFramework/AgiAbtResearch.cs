using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace AbtFramework
{
    public class AgiAbtResearch : PageModel
    {
        [FindsBy(How=How.LinkText,Using ="Abt Research Library")]
        private IWebElement AbtResearchLink;

        public bool IsAt()
        {
            wait.Until(e => e.Title.Equals("Abt Research Library"));

            if (AbtResearchLink.Displayed)
            {
                Console.WriteLine("Abt Research Library Link Opened Succesfully");
                return true;
            }

            return false;
        }
    }
}