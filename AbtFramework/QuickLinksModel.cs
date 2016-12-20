using AbtFramework.Utils_Classes;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Linq;

namespace AbtFramework
{
    public class QuickLinksModel : PageModel
    {

        
       
        [FindsBy(How=How.Id,Using ="quicklinks")]
        private IWebElement quicklinksBar;

        [FindsBy(How=How.LinkText,Using ="Staff Directory")]
        private IWebElement staffDirectoryLink;

       

        [FindsBy(How=How.LinkText,Using ="Forms Library")]
        private IWebElement formsLinks;

        [FindsBy(How=How.LinkText,Using ="Customize")]
        private IWebElement customizeLink;

        [FindsBy(How = How.Id, Using = "ulQLnk")]
        public IWebElement QuickLinks;

        public IWebElement oracleLink { get { return QuickLinks.FindElements(By.TagName("a")).Single(e => e.Text.Equals("Oracle")); } }

        public void OpenStaffDirectory()
        {
            staffDirectoryLink.Click();
        }

        private void ClickLink(IWebElement element, Func<IWebDriver, bool> func)
        {
            wait.Timeout = TimeSpan.FromSeconds(30);
            wait.IgnoreExceptionTypes(typeof(StaleElementReferenceException));


            wait.Until((Func<IWebDriver, bool>)((e) =>
            {
                if (func((IWebDriver)SeleniumDriver.Instance))
                {
                    action.MoveToElement(quicklinksBar).Perform();
                    if (element.Displayed && element.Enabled)
                    {
                        element.Click();
                    }
                }

                else
                {
                    return true;
                }

                return false;

            }));
        }

        public string OpenOracle()
        {
            finder = new PopupWindowFinder(SeleniumDriver.Instance);
            string WinHandle= finder.Click(oracleLink);
            StartTimer();

            return WinHandle;
        }




    }
}