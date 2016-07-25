using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace AbtFramework
{
    public class HomePage : PageModel
    {
        [FindsBy(How = How.LinkText, Using = "Home")]
        private IWebElement HomeLink;

        public void goTo()
        {
            Driver.seleniumdriver.Navigate().GoToUrl("http://agi.abtassociates.com");
        
        }

       

        public bool isAt()
        {
            
                if (HomeLink.Enabled)
                {
                    return true;
                }
           
         
            return false;
        }
    }
}