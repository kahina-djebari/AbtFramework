using AbtFramework.Utils_Classes.SeleniumUtils;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbtFramework.PageObjects.Oracle
{
    public class WorkflowUserWebAppPO
    {
        public IWebElement GetOpenNotificationsSelect()
        {
            string xpath = "//select[@title='Provides a series of worklist views available']";
            return SeleniumDriver.GetElementByXpath(xpath);
        }

        public IWebElement GetGoNotificationsBtn()
        {
            string xpath = "//button[@title='Launches some defined function']";
            return SeleniumDriver.GetElementByXpath(xpath);
        }

        public IWebElement GetSubjectLink()
        {
            string xpath = "//a[text()='Subject']/parent::th/parent::tr/following-sibling::tr[1]/child::td[4]/a";
            return SeleniumDriver.GetElementByXpath(xpath);
        }
    }
}
