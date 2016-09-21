using AbtFramework.Utils_Classes;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Linq;

namespace AbtFramework
{
    public class AtlasPage : PageModel
    {
        public void goTo()
        {

            
            wait.PollingInterval = TimeSpan.FromSeconds(1);
            wait.Until(DriverExtentions.WaitforWindowsTobe2);
            SeleniumDriver.FiringDriver.Close();
            SeleniumDriver.FiringDriver.SwitchTo().Window(SeleniumDriver.FiringDriver.WindowHandles.Last());

        }

        public bool IsUserLoggedIn()
        {
            return false;
        }
    }
}