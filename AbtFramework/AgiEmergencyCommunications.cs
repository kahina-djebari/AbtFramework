using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace AbtFramework
{
    public class AgiEmergencyCommunications : PageModel
    {
        [FindsBy(How=How.LinkText,Using ="Emergency Communications")]
        private IWebElement EmergencyLink;

        public bool isAt()
        {
            wait.Until(e => e.Title.Equals("Emergency Communications"));
            if (EmergencyLink.Displayed)
            {
                Console.WriteLine("Emergency Communications Link Opened Succesfully");
                return true;
            }


            return false;
        }
    }
}