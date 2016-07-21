using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;

namespace AbtFramework
{
    public class LoginPage : PageModel
    {
       [FindsBy(How=How.Id,Using = "Email")]
        private IWebElement search;

        [FindsBy(How = How.Name, Using = "q")]
        private IWebElement button;

        public void goTo()
        {
            Driver.seleniumdriver.Navigate().GoToUrl("https://gmail.com");
        }

        public void login()
        {
            var wait = new WebDriverWait(Driver.seleniumdriver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("Email")));
            search.SendKeys("Testing Selenium");
        }
    }
}