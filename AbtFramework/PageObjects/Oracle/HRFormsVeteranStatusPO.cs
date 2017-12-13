using AbtFramework.Utils_Classes.SeleniumUtils;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbtFramework.PageObjects.Oracle
{
    public class HRFormsVeteranStatusPO
    {
        public IWebElement GetSearchVeteranStatusBtn()
        {
            string xpath = "//span[contains(text(),'Choose Your Veteran Status')]/parent::td/following-sibling::td[2]/child::span/child::a";
            return SeleniumDriver.GetElementByXpath(xpath);
        }

        public IWebElement GetSearchVeteranStatusInputBox()
        {
            string xpath = "//input[@title='Search Term']";
            return SeleniumDriver.GetElementByXpath(xpath);
        }

       
    }
}
