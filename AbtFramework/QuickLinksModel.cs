using AbtFramework.Utils_Classes;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;

namespace AbtFramework
{
    public class QuickLinksModel : PageModel
    {

        [FindsBy(How=How.LinkText,Using ="Oracle")]
        private IWebElement oracleLink;

        [FindsBy(How=How.Id,Using ="quicklinks")]
        private IWebElement quicklinksBar;

        public void OracleLink()
        {
            Actions action = new Actions(Driver.seleniumdriver);
            action.MoveToElement(quicklinksBar).Perform();
            wait.Timeout = TimeSpan.FromSeconds(30);
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            wait.Until(DriverExtentions.WaitforQuicklinks);
            
              oracleLink.Click();
        }
    }
}