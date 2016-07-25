using AbtFramework.Utils_Classes;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AbtFramework
{
    public class AbtKnowledgePage : PageModel
    {
       
        [FindsBy(How = How.TagName, Using = "h1")]
        private IList<IWebElement> abtKnowledgeText;

        public void goTo()
        {
            AbtDriver.TopNavigation.ToolsDropdown.AbtKnowledgeLink();
            wait.PollingInterval = TimeSpan.FromSeconds(1);
            wait.Until(DriverExtentions.WaitforWindowsTobe2);
            Driver.seleniumdriver.Close();
            Driver.seleniumdriver.SwitchTo().Window(Driver.seleniumdriver.WindowHandles.Last());
            //continueBtn.Click();
        }

        public bool isAt()
        {
            if(abtKnowledgeText.ElementWithTextExists("What's new in AbtKnowledge:"))
            {
                return true;
            }
            return false;
        }
    }
}