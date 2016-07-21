using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace AbtFramework
{
    public class ReputationalCapDBPage : PageModel
    {
        [FindsBy(How=How.LinkText,Using = "Reputational Capital Database")]
        private IWebElement repCapDBPageLink;

        public void goTo()
        {
            repCapDBPageLink.Click();

        }
    }
}