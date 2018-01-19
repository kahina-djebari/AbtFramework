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

        public IWebElement GetCountryNameInput()
        {
            string xpath = "//span[contains(text(),'Country')]/parent::td//following-sibling::td/span/input";
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

        public IWebElement GetContinueBtn()
        {
            string xpath = "//button[@title='Continue']";
            return SeleniumDriver.GetElementByXpath(xpath);
        }

        public IWebElement GetSearchBranchIcon()
        {
            string xpath = "//span[contains(text(),'Branch Name')]/parent::td//following-sibling::td/span/a/img";
            return SeleniumDriver.GetElementByXpath(xpath);
        }

        public IWebElement GetBankAccountOwnerInput()
        {
            string xpath = "//span[contains(text(),'Bank Account Owner')]/parent::td/following-sibling::td//descendant::span/input";
            return SeleniumDriver.GetElementByXpath(xpath);
        }

        public IWebElement GetPayablesCheckBox()
        {
            string xpath = "//span[text()='Payables']/preceding-sibling::input";
            return SeleniumDriver.GetElementByXpath(xpath);
        }
    }
}
