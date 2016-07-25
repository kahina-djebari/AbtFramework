using AbtFramework.Utils_Classes;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Linq;

namespace AbtFramework
{
    public class AbtTravelPage : PageModel
    {
        [FindsBy(How=How.LinkText,Using = "AbtTravel Home")]
        private IWebElement travelHomeLink;

        public void goTo()
        {
            AbtDriver.TopNavigation.ToolsDropdown.AbtTravelLink();
            wait.PollingInterval = TimeSpan.FromSeconds(1);
            wait.Until(DriverExtentions.WaitforWindowsTobe2);
            Driver.seleniumdriver.Close();
            Driver.seleniumdriver.SwitchTo().Window(Driver.seleniumdriver.WindowHandles.Last());
        }

        public bool isAt()
        {

            if (travelHomeLink.Displayed)
            {
                return true;
            }

            return false;
        }
    }
}