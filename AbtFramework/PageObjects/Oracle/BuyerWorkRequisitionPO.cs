using AbtFramework.Utils_Classes.SeleniumUtils;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbtFramework.PageObjects.Oracle
{
     public class AbtUSPOBuyerPO
    {
        public IWebElement GetRequisitionsBuyerWorkCenter()
        {
            string xpath = "//span[text()='Buyer Work Center']/parent::td/parent::tr/following-sibling::tr[1]//a[text()='Requisitions']";
            return SeleniumDriver.GetElementByXpath(xpath);
        }

        public IWebElement GetRequisitionsRequisitions()
        {
            string xpath = "//span[text()='Requisitions']/parent::td/parent::tr/following-sibling::tr[2]//a[text()='Requisitions']";
            return SeleniumDriver.GetElementByXpath(xpath);
        }

        public IWebElement GetRequisitionToBeAdded()
        {
            string xpath = "//input[@title='Select'][@value='0']";
            return SeleniumDriver.GetElementByXpath(xpath);
        }

        public IWebElement GetAddRequisitionButton()
        {
            string xpath = "//a[contains(text(),'Select None')]/ancestor::tr[2]/preceding-sibling::tr[1]/descendant::button[@title='Add to Document Builder']";
            return SeleniumDriver.GetElementByXpath(xpath);
        }

        public IWebElement GetCreateButton()
        {
            string xpath = "//button[@title='Create']";
            return SeleniumDriver.GetElementByXpath(xpath);
        }


    }
}
