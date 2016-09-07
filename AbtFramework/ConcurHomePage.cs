using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;

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

        public void Go()
        {
            StartTimer();
            Driver.seleniumdriver.Navigate().GoToUrl("https://abtassociates.okta.com/home/concur/0oa7nf05pdDTmrMJZ0x7/615");
            wait.Until(e => warning.Displayed);
            warning.Click();
          

        }

        public bool isUserLoggedIn()
        {

            if (isAt())
            {
                userProfile.Click();
                // if (username.Text.Equals(SSOCrendentials.CurrentUser))
                if (username.Text.Equals("David Acuna"))
                {
                    Console.WriteLine("User: David succesfully logged in with Okta");
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
                Console.WriteLine("Concur Prod Home Page Took: " + LoadTime + " to load with Okta");
                Console.WriteLine("</br>");
                return true;
            }

            return false;
        }
    }
}