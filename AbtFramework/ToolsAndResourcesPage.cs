using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;

namespace AbtFramework
{
    public class ToolsAndResourcesPage : PageModel
    {
        [FindsBy(How=How.Id,Using = "WebPartCaptionWPQ4")]
        private IWebElement LibrariesHeader;

        public void goTo()
        {
            
            AbtDriver.TopNavigation.ToolsLink();
        }

        public bool isAt()
        {
            
                if (LibrariesHeader.Enabled)
                {
                   
                    return true;
                }
                        
            return false;
        }
    }
}