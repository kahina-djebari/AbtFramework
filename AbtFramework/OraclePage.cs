using AbtFramework.Utils_Classes;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AbtFramework
{
    public class OraclePage : PageModel
    {
        [FindsBy(How=How.TagName,Using ="h1")]
        private IList<IWebElement> infoText;

        public void goTo()
        {
            AbtDriver.TopNavigation.ToolsDropdown.OracleLink();
            wait.PollingInterval = TimeSpan.FromSeconds(1);
            wait.Until(DriverExtentions.WaitforWindowsTobe2);
            Driver.seleniumdriver.Close();
            Driver.seleniumdriver.SwitchTo().Window(Driver.seleniumdriver.WindowHandles.Last());
        }

        public bool isAt()
        {
            Console.WriteLine("Oracle Web Page Loaded in: " + LoadTime);
            IWebElement header = infoText.SingleOrDefault(e => e.Text.Equals("More Information Requested"));
            if (header!=null){

                return true;
            }

            return false;
        }
    }
}