using AbtFramework.Utils_Classes.SeleniumUtils;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbtFramework.PageObjects.Oracle
{
    public class AbtUSEmployeeDirectAccessPO
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

        public IWebElement GetQuickSelect2()
        {
            string xpath = "//span[text()='Quick Select']/parent::th/parent::tr/following-sibling::tr[2]/child::td[2]/child::a/img";
            return SeleniumDriver.GetElementByXpath(xpath);
        }

        public IWebElement GetDateInput()
        {
            string xpath = "//span[contains(text(),'Enter Your Name')]/parent::td/parent::tr/following-sibling::tr/child::td[3]//child::input";
            return SeleniumDriver.GetElementByXpath(xpath);
        }

        public IWebElement GetApplyBtn()
        {
            string xpath = "//h1[text()='Voluntary Disclosure of Veterans Status']/ancestor::div[1]/following-sibling::div[1]//button[@title='Apply']";
            return SeleniumDriver.GetElementByXpath(xpath);
        }

        public IWebElement GetNextBtn()
        {
            string xpath = "//h1[text()='Extra Information']/ancestor::div[1]/following-sibling::div//descendant::button[@title='Next']";
            return SeleniumDriver.GetElementByXpath(xpath);
        }

        public IWebElement GetSubmitBtn()
        {
            string xpath = "//h1[text()='Review']/ancestor::div[1]/following-sibling::div//descendant::button[@title='Submit']";
            return SeleniumDriver.GetElementByXpath(xpath);
        }



    }
}
