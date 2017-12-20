using AbtFramework.Utils_Classes.SeleniumUtils;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbtFramework.PageObjects.Oracle
{
    public class TimeCardPO
    {

        public IWebElement GetTimeCardToBeApproved()
        {
            string xpath = "//span[text()='Subject']/parent::th/parent::tr/following-sibling::tr[1]/child::td[1]/child::a";
            return SeleniumDriver.GetElementByXpath(xpath);
        }

        public IWebElement GetButtonApproveTimeCard()
        {
            string xpath = "//a[@title='Orders']/ancestor::table[2]/following-sibling::div/child::div[3]/child::div[1]/child::div[2]/descendant::button[@title='Approve']";
            return SeleniumDriver.GetElementByXpath(xpath);
        }

        public IWebElement GetNonCatalogRequest()
        {
            string xpath = "//a[@title='Non-Catalog Request']";
            return SeleniumDriver.GetElementByXpath(xpath);
        }

        public IWebElement GetTimeEntry()
        {
            string xpath = "//a[text()='Time Entry']";
            return SeleniumDriver.GetElementByXpath(xpath);
        }

        public IWebElement GetCreateTimeCards()
        {
            string xpath = "//a[text()='Create Timecard']";
            return SeleniumDriver.GetElementByXpath(xpath);
        }

        public IWebElement GetProjectTimeCardInput()
        {
            string xpath = "//span[contains(text(),'Project')]/ancestor::tr[2]/following-sibling::tr[1]/child::td[1]/descendant::input";
            return SeleniumDriver.GetElementByXpath(xpath);
        }

        public IWebElement GetTasktTimeCardInput()
        {
            string xpath = "//span[contains(text(),'Task')]/ancestor::tr[2]/following-sibling::tr[1]/child::td[2]/descendant::input";
            return SeleniumDriver.GetElementByXpath(xpath);
        }

        public IWebElement GetTypeTimeCardInput()
        {
            string xpath = "//span[contains(text(),'Task')]/ancestor::tr[2]/following-sibling::tr[1]/child::td[3]/descendant::input";
            return SeleniumDriver.GetElementByXpath(xpath);
        }

        public List<IWebElement> GetTimeInputList()
        {
            string xpath = "//span[contains(text(),'Task')]/ancestor::tr[2]/following-sibling::tr[1]//child::input[@title = 'Hrs']";
            return SeleniumDriver.GetListElementByXpath(xpath);
        }

        public IWebElement GetReviewThenSavebutton()
        {
            string xpath = "//h1[contains(text(),'Time Entry')]/ancestor::div[1]/following-sibling::div[1]/descendant::button[@title='Review, then Save']";
            return SeleniumDriver.GetElementByXpath(xpath);
        }

        public IWebElement GetReturnToTimeEntryButtonTimeCard()
        {
            string xpath = "//h1[contains(text(),'Confirmation:')]/ancestor::div[1]/following-sibling::div[1]/descendant::button[@title='Return to Time Entry']";
            return SeleniumDriver.GetElementByXpath(xpath);
        }

        public IWebElement GetTimecardBeginSubmit()
        {
            string xpath = "//h1[contains(text(),'Time Entry:')]/ancestor::div[1]/following-sibling::div[1]/descendant::button[@title='Begin Submit Process']";
            return SeleniumDriver.GetElementByXpath(xpath);
        }

        public IWebElement GetTimecardSubmit()
        {
            string xpath = "//h1[contains(text(),'Review:')]/ancestor::div[1]/following-sibling::div[1]/descendant::button[@title='Submit']";
            return SeleniumDriver.GetElementByXpath(xpath);
        }

        public IWebElement GetCompleteSaveTimeCardProcess()
        {
            string xpath = "//h1[contains(text(),'Review')]/ancestor::div[1]/following-sibling::div[1]/descendant::button[@title='Save'][text()='Complete Save Process']";
            return SeleniumDriver.GetElementByXpath(xpath);
        }
    }
}
