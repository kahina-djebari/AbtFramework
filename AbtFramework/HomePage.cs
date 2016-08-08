using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.DirectoryServices.AccountManagement;
using System.Linq;

namespace AbtFramework
{
    public class HomePage : PageModel
    {
        [FindsBy(How = How.LinkText, Using = "Home")]
        private IWebElement HomeLink;
        private QuickLinksModel _quicklinks;

        [FindsBy(How=How.ClassName,Using = "o365cs-me-tileview-container")]
        private IWebElement userCard;

        [FindsBy(How = How.ClassName, Using = "o365cs-me-userDisplayName")]
        private IWebElement username;

        public QuickLinksModel QuickLinks { get 
                {
                    _quicklinks = PageGenerator.GetPage<QuickLinksModel>();

                    _quicklinks.wait = new WebDriverWait(Driver.seleniumdriver, TimeSpan.FromSeconds(10));
                    return _quicklinks;
                }
            }

        public void Go()
        {
            StartTimer();
            Driver.seleniumdriver.Navigate().GoToUrl("http://agi.abtassociates.com");
            StopTimer();
            Console.WriteLine("Agi Home Page Loaded in: "+LoadTime);
        }

        public bool isUserLoggedin()
        {
            userCard.Click();

            DirectoryEntry de = new DirectoryEntry("WinNT://" + Environment.UserDomainName + "/" + Environment.UserName);
            string WindowsUser = de.Properties["fullName"].Value.ToString();

            
            if (username.Text.Equals(WindowsUser))
            {
                return true;

            }
            return false;
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