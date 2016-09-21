using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using AbtFramework.Utils_Classes;

namespace AbtFramework
{
    public class ConcurHomePage : PageModel
    {
        [FindsBy(How=How.ClassName,Using = "icon-logotype")]
        private IWebElement Logo;
        [FindsBy(How=How.CssSelector,Using = "#cnqr-profile-popup > div.cnqr-avatarred-div > div:nth-child(2) > div")]
        private IWebElement username;
        [FindsBy(How = How.Id, Using = "cnqr-profile-menu-link")]
        private IWebElement userProfile;
        [FindsBy(How=How.Id,Using = "popupdialogBtn_0")]
        private IWebElement warning;
        private static string SSOProvider = "Simieo";
        private static string portalenvironment="Production";

        public void Go()
        {
            StartTimer();
            SeleniumDriver.FiringDriver.Navigate().GoToUrl("https://abtassociates.okta.com/home/concur/0oa7nf05pdDTmrMJZ0x7/615");
            wait.Until(e => warning.Displayed);
            warning.Click();
            SSOProvider = "Okta";
            portalenvironment = "Test";

        }

        public bool isUserLoggedIn()
        {

            if (isAt())
            {
                userProfile.Click();

                if (username.Text.Equals("Sofiane Oumsalem"))
                {
                    Console.WriteLine("User: Sofiane Oumsalem succesfully logged in with "+SSOProvider);
                    return true;
                }

                
            }
            return false;
        }

        private bool isAt()
        {

            wait.Until(ExpectedConditions.PresenceOfAllElementsLocatedBy(By.TagName("body")));
            if (Logo.Displayed)
            {
                StopTimer();
                Console.WriteLine("Concur ("+portalenvironment+") Home Page Took: " + LoadTime + " to load using "+SSOProvider);
                Console.WriteLine("</br>");
                return true;
            }

            return false;
        }

    
    }
}