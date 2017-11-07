using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using AbtFramework.Utils_Classes.SeleniumUtils;

namespace AbtFramework
{
    public class Office365LoginPage : PageModel
    {
        [FindsBy(How=How.Id,Using = "cred_userid_inputtext")]
        private IWebElement userInput;
        [FindsBy(How=How.Id,Using = "aad_account_tile_link")]
        private IWebElement WorkAccount;

        public IWebElement UserInput
        {
            get
            {
                return userInput;
            }

            set
            {
                userInput = value;
            }
        }

        public void Go()
        {
            StartTimer();
            SeleniumDriver.DriverInstance.Navigate().GoToUrl("https://abtassoc.sharepoint.com/");
        }

        public void Login(string userName)
        {
            wait.Until(e => userInput.Displayed);
            userInput.SendKeys(userName);
            action.SendKeys(Keys.Tab).Perform();
            wait.Until(e => WorkAccount.Displayed);
            WorkAccount.Click();
            StartTimer();

        }
    }
}