using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace AbtFramework
{
    public class TopNavigation : PageModel
    {
        [FindsBy(How=How.LinkText,Using ="Tools & Resources")]
        private IWebElement ToolsAndResources;
        
       
        private ToolsDropdown _toolsDropdown;

        internal ToolsDropdown ToolsDropdown { get { return _toolsDropdown = PageGenerator.GetPage<ToolsDropdown>(); } }

        internal void ToolsLink()
        {
            ToolsAndResources.Click();
                       
        }

        public void HoverOverTools()
        {
            Actions action = new Actions(Driver.seleniumdriver);
            action.MoveToElement(ToolsAndResources).Perform();
        }

     
    }
}