using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;

namespace AbtFramework
{
    public class TopNavigation : PageModel
    {
        [FindsBy(How=How.LinkText,Using ="Tools & Resources")]
        private IWebElement ToolsAndResources;
        
       
        private ToolsDropdown _toolsDropdown;

        public ToolsDropdown ToolsDropdown { get {
                _toolsDropdown = PageGenerator.GetPage<ToolsDropdown>();
                _toolsDropdown.wait = new WebDriverWait(Driver.seleniumdriver, TimeSpan.FromSeconds(15));
                _toolsDropdown.action = new Actions(Driver.seleniumdriver);
                return _toolsDropdown;
            } }

        public void ToolsLink()
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