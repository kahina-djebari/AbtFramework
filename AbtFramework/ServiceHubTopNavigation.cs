using System;
using AbtFramework.Utils_Classes;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;

namespace AbtFramework
{
    public class ServiceHubTopNavigation : PageModel
    {
        [FindsBy(How=How.LinkText,Using ="HR Service Center")]
        internal IWebElement HRServiceCenter;
        [FindsBy(How=How.LinkText,Using ="Home")]
        private IWebElement homeLink;
        [FindsBy(How = How.LinkText, Using = "IT Service Center")]
        private IWebElement ITServiceCenter;
        [FindsBy(How = How.LinkText, Using = "Office Services")]
        private IWebElement OfficeServiceCenter;
 

        public void Go(ServiceHubTopNavLinks link)
        {
            switch (link)
            {
                case ServiceHubTopNavLinks.Home:
                    homeLink.Click();
                    break;
                case ServiceHubTopNavLinks.HR_Service_Center:
                    HRServiceCenter.Click();
                    break;
                case ServiceHubTopNavLinks.IT_Service_Center:
                    ITServiceCenter.Click();
                    break;
                case ServiceHubTopNavLinks.Office_Services:
                    OfficeServiceCenter.Click();
                    break;
                default:
                    break;
            }
        }
    }
}