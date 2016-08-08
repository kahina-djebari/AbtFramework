using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace AbtFramework
{
    public class WebExPage : PageModel
    {
        [FindsBy(How=How.Id,Using = "wcc-lnk-loginLink")]
        private IWebElement loginbtn;

        public void goTo()
        {
            Driver.seleniumdriver.Navigate().GoToUrl("https://abtassociates.webex.com/mw3100/mywebex/default.do?siteurl=abtassociates");

        }

        public void Login()
        {
            Driver.seleniumdriver.SwitchTo().Frame("header");
            loginbtn.Click();
        }
    }
}