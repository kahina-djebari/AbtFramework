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

        public void GoTo(quickLinks links)
        {
            switch (links)
            {
                case quickLinks.Oracle:
                    action.MoveToElement(quicklinksBar).Perform();
                    finder = new PopupWindowFinder(SeleniumDriver.Instance);
                    popupWindowHandle = finder.Click(oracleLink);
                    StartTimer();

                    
                        foreach(var window in SeleniumDriver.Instance.WindowHandles)
                        {
                            if (!window.Equals(popupWindowHandle))
                            {
                            SeleniumDriver.Instance.SwitchTo().Window(window);
                            SeleniumDriver.Close();
                            }
                        }
                    
                    
                    SeleniumDriver.Instance.SwitchTo().Window(popupWindowHandle);
                    SeleniumDriver.Instance.Manage().Window.Maximize();
                    break;

                case quickLinks.Staff_Directory:
                    ClickLink(staffDirectoryLink,a=>!SeleniumDriver.Instance.Title.Equals("Search People"));
                    break;

                case quickLinks.FormsLibrary:
                    ClickLink(formsLinks,a=>!SeleniumDriver.Instance.Title.Equals("AbtForms - All Documents"));
                    break;

                case quickLinks.Customize:
                    ClickLink(customizeLink, a => SeleniumDriver.Instance.WindowHandles.Count < 2);
                    SeleniumDriver.Close();
                    SeleniumDriver.Instance.SwitchTo().Window(SeleniumDriver.Instance.WindowHandles.Last());
                    break;
            }
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

       

       
    }
}