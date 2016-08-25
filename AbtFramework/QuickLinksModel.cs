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

        [FindsBy(How=How.LinkText,Using ="Oracle")]
        private IWebElement oracleLink;

        [FindsBy(How=How.Id,Using ="quicklinks")]
        private IWebElement quicklinksBar;

        [FindsBy(How=How.LinkText,Using ="Staff Directory")]
        private IWebElement staffDirectoryLink;

        [FindsBy(How=How.LinkText,Using ="Forms Library")]
        private IWebElement formsLinks;

        [FindsBy(How=How.LinkText,Using ="Customize")]
        private IWebElement customizeLink;

        public void GoTo(quickLinks links)
        {
            switch (links)
            {
                case quickLinks.Oracle:
                    ClickLink(oracleLink,a=>Driver.seleniumdriver.WindowHandles.Count<2);
                    Driver.Close();
                    Driver.seleniumdriver.SwitchTo().Window(Driver.seleniumdriver.WindowHandles.Last());
                    break;

                case quickLinks.Staff_Directory:
                    ClickLink(staffDirectoryLink,a=>!Driver.seleniumdriver.Title.Equals("Search People"));
                    break;

                case quickLinks.FormsLibrary:
                    ClickLink(formsLinks,a=>!Driver.seleniumdriver.Title.Equals("AbtForms - All Documents"));
                    break;

                case quickLinks.Customize:
                    ClickLink(customizeLink, a => Driver.seleniumdriver.WindowHandles.Count < 2);
                    Driver.Close();
                    Driver.seleniumdriver.SwitchTo().Window(Driver.seleniumdriver.WindowHandles.Last());
                    break;
            }
        }

        private void ClickLink(IWebElement element, Func<IWebDriver, bool> func)
        {
            wait.Timeout = TimeSpan.FromSeconds(30);
            wait.IgnoreExceptionTypes(typeof(StaleElementReferenceException));


            wait.Until((e) =>
            {
                if (func(Driver.seleniumdriver))
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

            });
        }

       

       
    }
}