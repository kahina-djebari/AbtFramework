﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AbtFramework
{
    public class OutlookWebPage : PageModel
    {

        [FindsBy(How=How.TagName,Using ="span")]
        private IList<IWebElement> spans;

        public void goTo()
        {
          
            AbtDriver.TopNavigation.ToolsDropdown.OutlookLink();
            Driver.seleniumdriver.Close();
            Driver.seleniumdriver.SwitchTo().Window(Driver.seleniumdriver.WindowHandles.Last());
        }

        public bool isAt()
        {
            IWebElement script = (IWebElement)((IJavaScriptExecutor)Driver.seleniumdriver).ExecuteScript("document.getElementsByClassName('_n_m1 ms-font-xxl')[0];");
            if (script.Text=="Inbox")
            {
                return true;
            }

            return false;
        }
    }
}