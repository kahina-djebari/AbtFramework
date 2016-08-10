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
        [FindsBy(How=How.Id,Using ="PageLayoutRN")]
        private IWebElement headerInfo;

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
            IWebElement header = getHeader();
                
            if (header!=null){

                return true;
            }

            return false;
        }

        private IWebElement getHeader()
        {
           return  headerInfo.FindElements(By.TagName("h1")).Single(e => e.Text.Equals("Oracle Applications Home Page"));
        }
    }
}