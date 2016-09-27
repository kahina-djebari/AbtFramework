using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace AbtFramework
{
    public class EbscoMyAccountPage : PageModel
    {
        [FindsBy(How=How.Id,Using = "ctl00_ctl00_MainContentArea_MainContentArea_ScreenNameTBox")]
        private IWebElement FirstName;

        public bool IsUserLoggedIn()
        {
            
            if (FirstName.GetAttribute("value").Equals("David"))
            {
                return true;
            }


            else
            {
                return false;
            }
        }
    }
}