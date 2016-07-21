using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace AbtFramework
{
    public class AtlasPage : PageModel
    {
        public void goTo()
        {
            
            AbtDriver.TopNavigation.ToolsDropdown.AtlasLink();
          
        }
    }
}