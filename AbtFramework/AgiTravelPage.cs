using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace AbtFramework
{
    public class AgiTravelPage : PageModel
    {
        [FindsBy(How=How.LinkText,Using ="Travel Service Center")]
        private IWebElement TravelService;

        public bool IsAt()
        {
            wait.Until(e => e.Title.Equals("Travel Service Center"));

            if (TravelService.Displayed)
            {
                Console.WriteLine("Travel Link Opened Succesfully");
                return true;

            }
            return false;
        }
    }
}