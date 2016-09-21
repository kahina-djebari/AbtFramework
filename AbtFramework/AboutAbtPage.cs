using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;

namespace AbtFramework
{
    public class AboutAbtPage : PageModel
    {
        [FindsBy(How=How.ClassName,Using = "PageHeader")]
        private IWebElement aboutHeader;
        private LeftNavigation _leftNavigation;

        [FindsBy(How=How.Id,Using = "MSOZoneCell_WebPartWPQ2")]
        private IWebElement documentList;

        public LeftNavigation LeftNavigation {
            get
            {
                _leftNavigation = PageGenerator.GetPage<LeftNavigation>();
                _leftNavigation.wait = new WebDriverWait(SeleniumDriver.FiringDriver, TimeSpan.FromSeconds(15));
                _leftNavigation.action = new Actions(SeleniumDriver.FiringDriver);
                return _leftNavigation;
            }
        }

        public bool isAt()
        {
           
            if (aboutHeader.Text.Equals("ABOUT ABT"))
            {
                return true;
            }

            return false;
            
        }

        public bool DocumentOpensProperly()
        {
            var document= documentList.FindElements(By.TagName("a"))[0];

            document.Click();

            return true;
        }
    }
}