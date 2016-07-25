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
          
            AbtDriver.TopNavigation.ToolsDropdown.IsmsLink();
        
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