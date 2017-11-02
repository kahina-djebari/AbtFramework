using AbtFramework.Utils_Classes;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Linq;
using AbtFramework.SeleniumUtils;

namespace AbtFramework
{
    public class AtlasPage : PageModel
    {
        public void goTo()
        {

            
            wait.PollingInterval = TimeSpan.FromSeconds(1);
            wait.Until(DriverExtentions.WaitforWindowsTobe2);
            SeleniumDriver.DriverInstance.Close();
            SeleniumDriver.DriverInstance.SwitchTo().Window(SeleniumDriver.DriverInstance.WindowHandles.Last());

        }

        public bool IsUserLoggedIn()
        {
            return false;
        }
    }
}