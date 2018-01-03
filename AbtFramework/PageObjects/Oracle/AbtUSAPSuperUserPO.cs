using AbtFramework.Utils_Classes.SeleniumUtils;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbtFramework.PageObjects.Oracle
{
    class AbtUSAPSuperUserPO
    {
        public IWebElement GetQuickInvoicesLink()
        {
            string xpath = "//span[text()='Invoices : Entry']/parent::td/parent::tr/following-sibling::tr[3]//child::td/a[text()='Quick Invoices']";
            return SeleniumDriver.GetElementByXpath(xpath);
        }
    }
}
