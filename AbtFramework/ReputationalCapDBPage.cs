using AbtFramework.Utils_Classes;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AbtFramework
{
    public class ReputationalCapDBPage : PageModel
    {
       

        [FindsBy(How = How.TagName, Using = "h1")]
        private IList<IWebElement> headers;

        [FindsBy(How = How.Id, Using = "submitbutton")]
        private IWebElement continueBtn;

        

        public void goTo()
        {
            
            wait.PollingInterval = TimeSpan.FromSeconds(1);
            wait.Until(DriverExtentions.WaitforWindowsTobe2);
            Driver.seleniumdriver.Close();
            Driver.seleniumdriver.SwitchTo().Window(Driver.seleniumdriver.WindowHandles.Last());
            continueBtn.Click();

        }

        public bool isAt()
        {
            if(headers.ElementWithTextExists("Reputational Capital Database (RepCapDB)"))
            {
                return true;
            }

            return false;
        }
    }
}