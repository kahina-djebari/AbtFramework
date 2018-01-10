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

        public IWebElement GetCreateBankAccountLink()
        {
            string xpath = "//button[@title='Create']";
            return SeleniumDriver.GetElementByXpath(xpath);
        }

        public IWebElement GetBankNameInput()
        {
            string xpath = "//span[contains(text(),'Bank Name')]/parent::td//following-sibling::td/span/input";
            return SeleniumDriver.GetElementByXpath(xpath);
        }

        public IWebElement GetBranchNameInput()
        {
            string xpath = "//span[contains(text(),'Branch Name')]/parent::td//following-sibling::td/span/input";
            return SeleniumDriver.GetElementByXpath(xpath);
        }

        public IWebElement GetPaymentsLink()
        {
            string xpath = "//span[text()='Payments : Entry']/parent::td/parent::tr/following-sibling::tr[1]//child::td/a[text()='Payments']";
            return SeleniumDriver.GetElementByXpath(xpath);
        }

        public IWebElement GetInvoicesLink()
        {
            string xpath = "//span[text()='Invoices : Entry']/parent::td/parent::tr/following-sibling::tr[2]//child::td/a[text()='Invoices']";
            return SeleniumDriver.GetElementByXpath(xpath);
        }
    }
}
