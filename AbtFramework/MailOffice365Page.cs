using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using AbtFramework.Utils_Classes.SeleniumUtils;

namespace AbtFramework
{
    public class MailOffice365Page : PageModel
    {
        [FindsBy(How=How.Id,Using = "cred_password_inputtext")]
        private IWebElement passwordInput;
        [FindsBy(How=How.Id,Using = "login")]
        private IWebElement userInput;

        public void Go()
        {
            
            SeleniumDriver.DriverInstance.Navigate().GoToUrl("http://mail.office365.com");
        }

        public void Login(string userName)
        {
            wait.Until(e => AbtPages.Office365LoginPage.UserInput.Displayed);
            StopTimer();
            AbtPages.Office365LoginPage.UserInput.SendKeys(userName);
            passwordInput.Click();
            StartTimer();
        }
    }
}