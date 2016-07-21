using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace AbtFramework
{
    public class IsmsPage : PageModel
    {
        [FindsBy(How=How.Id,Using = "pageTitle")]
        private IWebElement ismsHeader;

        public void goTo()
        {
            String currentWindowHandler = Driver.seleniumdriver.CurrentWindowHandle;
            AbtDriver.TopNavigation.ToolsDropdown.IsmsLink();
            var windowsHandler = Driver.seleniumdriver.WindowHandles;
            Driver.seleniumdriver.Close();
            Driver.seleniumdriver.SwitchTo().Window(Driver.GetcurrentWindowHandler(windowsHandler));
        }

        public bool isAt()
        {
            if (ismsHeader.Displayed)
            {
                return true;

            }

            return false;
        }
    }
}