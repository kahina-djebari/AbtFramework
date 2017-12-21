using AbtFramework.Utils_Classes.SeleniumUtils;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbtFramework.PageObjects.Oracle
{
    public class iProcurementRequesterPO
    {
        public IWebElement GetItemDescription()
        {
            string xpath = "//span[contains(text(),'Item Description')]/parent::td/following-sibling::td[2]/child::textarea";
            return SeleniumDriver.GetElementByXpath(xpath);
        }

        public IWebElement GetQuantity()
        {
            string xpath = "//span[contains(text(),'Quantity')]/parent::td/following-sibling::td[2]/child::input";
            return SeleniumDriver.GetElementByXpath(xpath);
        }

        public IWebElement GetUnitOfMeasure()
        {
            string xpath = "//span[contains(text(),'Unit of Measure')]/parent::td/following-sibling::td[2]/child::span/child::input";
            return SeleniumDriver.GetElementByXpath(xpath);
        }

        public IWebElement GetUnitPrice()
        {
            string xpath = "//span[contains(text(),'Unit Price')]/parent::td/following-sibling::td[2]/child::input";
            return SeleniumDriver.GetElementByXpath(xpath);
        }

        public IWebElement GetSupplierName()
        {
            string xpath = "//span[contains(text(),'Supplier Name')]/parent::td/following-sibling::td[2]/child::span/child::input";
            return SeleniumDriver.GetElementByXpath(xpath);
        }

        public IWebElement GetContactName()
        {
            string xpath = "//span[contains(text(),'Contact Name')]/parent::td/following-sibling::td[2]/child::input";
            return SeleniumDriver.GetElementByXpath(xpath);
        }

        public IWebElement GetPhone()
        {
            string xpath = "//span[contains(text(),'Phone')]/parent::td/following-sibling::td[2]/child::input";
            return SeleniumDriver.GetElementByXpath(xpath);
        }

        public IWebElement GetAddToCart()
        {

            string xpath = "//h1[text()='Non-Catalog Request']/parent::div//descendant::button[text()='Add to Cart']";
            return SeleniumDriver.GetElementByXpath(xpath);

            //string xpath = "//button[text()='Add to Cart']";
            //return SeleniumDriver.GetListElementByXpath(xpath)[0];

        }

        public IWebElement GetViewCartAndCheckout()
        {
            string xpath = "//button[@title='Proceeds to the Shopping Cart page.'][contains(text(),'View Cart and Checkout')]";
            return SeleniumDriver.GetElementByXpath(xpath);
        }

        public IWebElement GetCheckout()
        {

            string xpath = "//h1[text()='Shopping Cart']/parent::div//descendant::button[text()='Checkout']";
            return SeleniumDriver.GetElementByXpath(xpath);

            //string xpath = "//button[text()='Checkout']";
            //return SeleniumDriver.GetListElementByXpath(xpath)[0];

        }


        public IWebElement GetProject()
        {
            string xpath = "//span[text()='Project']/parent::td/following-sibling::td[2]/child::span/child::input";
            return SeleniumDriver.GetElementByXpath(xpath);
        }

        public IWebElement GetExpenditureType()
        {
            string xpath = "//span[text()='Expenditure Type']/parent::td/following-sibling::td[2]/child::span/child::input";
            return SeleniumDriver.GetElementByXpath(xpath);
        }

        public IWebElement GetTask()
        {
            string xpath = "//span[text()='Task']/parent::td/following-sibling::td[2]/child::span/child::input";
            return SeleniumDriver.GetElementByXpath(xpath);
        }

        public IWebElement GetExpenditureItemDate()
        {
            string xpath = "//span[text()='Expenditure Item Date']/parent::td/following-sibling::td[2]/child::input";
            return SeleniumDriver.GetElementByXpath(xpath);
        }


        public IWebElement GetNextButtons()
        {
            string xpath = "//button[@title='Next']";
            return SeleniumDriver.GetListElementByXpath(xpath)[0];
        }

        public IWebElement GetManageApprovals()
        {
            string xpath = "//button[@title='Manage Approvals']";
            return SeleniumDriver.GetElementByXpath(xpath);
        }

        public IWebElement GetNewApproverText()
        {
            string xpath = "//span[contains(text(),'Approver')]/parent::td/following-sibling::td[2]/child::span/child::input";
            return SeleniumDriver.GetElementByXpath(xpath);
        }

        public IWebElement GetApproverLocation()
        {
            string xpath = "//span[contains(text(),'Add to Location')]/parent::td/following-sibling::td[2]/child::select";
            return SeleniumDriver.GetElementByXpath(xpath);
        }

        public IWebElement GetApprovalNextButton()
        {
            string xpath = "//h1[text()='Checkout: Approvals and Notes']/ancestor::div[2]/following-sibling::div/child::table/descendant::button[@title='Next']";
            return SeleniumDriver.GetElementByXpath(xpath);
        }

        public IWebElement GetContinueShoppingButton()
        {
            string xpath = "//button[text() = 'Continue Shopping']";
            return SeleniumDriver.GetElementByXpath(xpath);
        }
    }
}
