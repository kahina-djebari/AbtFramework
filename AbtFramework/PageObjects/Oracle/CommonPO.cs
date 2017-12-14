using AbtFramework.Utils_Classes.SeleniumUtils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbtFramework.PageObjects.Oracle
{
    public class CommonPO
    {
        //this should not be done
        [FindsBy(How = How.CssSelector, Using = "#PageLayoutRN > div > div:nth-child(5) > div > div.x63 > table > tbody > tr > td > h1")]
        public static IWebElement OracleWelcome => OracleWelcome;

        public IWebElement GetSelectHomePageLinkFolder(string linkFolderName)
        {
            string xpath = "//a[text() = '" + linkFolderName + "']";
            return SeleniumDriver.GetElementByXpath(xpath);
        }

        public IWebElement GetHomeBtn()
        {
            string xpath = "//*[@id='WF_SS_NOTIF_PAGE']/table[1]/tbody/tr[2]/td/table/tbody/tr[2]/td[2]/table/tbody/tr/td[1]/a";
            return SeleniumDriver.GetElementByXpath(xpath);
        }

        public IWebElement GetHeaderInfo()
        {
            string id = "PageLayoutRN";
            return SeleniumDriver.GetElementByID(id);
        }

        public IWebElement GetHomeMenuTable()
        {
            string xpath = "//h2[text()='Navigator']/ancestor::tr[2]/following-sibling::tr[2]/descendant::div[1]/child::div[2]/descendant::tr[1]/child::td[1]";
            return SeleniumDriver.GetElementByXpath(xpath);
        }

        public IWebElement GetUserBrowsingOptions()
        {
            string xpath = "//h2[text()='Navigator']/ancestor::tr[2]/following-sibling::tr[2]/descendant::div[1]/child::div[2]/descendant::tr[1]/child::td[2]";
            return SeleniumDriver.GetElementByXpath(xpath);
        }

        public IWebElement GetSubmitButton_uixr()
        {
            string xpath = "SubmitButton_uixr";
            return SeleniumDriver.GetElementByID(xpath);
        }

        public IWebElement GetEntriesNavigationLink()
        {
            string xpath = "//span[text()='View : Histories']/parent::td/parent::tr/following-sibling::tr[4]/child::td[3]/a[text()='Entries']";
            return SeleniumDriver.GetElementByXpath(xpath);
        }

        public IWebElement GetSalaryNavigationLink()
        {
            string xpath = "//span[text()='View : Histories']/parent::td/parent::tr/following-sibling::tr[3]/child::td[3]/a[text()='Salary']";
            return SeleniumDriver.GetElementByXpath(xpath);
        }

        public IWebElement GetSalaryBNavigationLink()
        {
            string xpath = "//span[text()='View : Histories']/parent::td/parent::tr/following-sibling::tr[4]/child::td[3]/a[text()='Salary']";
            return SeleniumDriver.GetElementByXpath(xpath);
        }

        public IWebElement GetValuesNavigationLink()
        {
            string xpath = "//span[text()='Flexfield : Descriptive']/parent::td/parent::tr/following-sibling::tr[2]/child::td[3]/a[text()='Values']";
            return SeleniumDriver.GetElementByXpath(xpath);
        }

        public IWebElement GetAbsenceNavigationLink()
        {
            string xpath = "//span[text()='View : Histories']/parent::td/parent::tr/following-sibling::tr[2]/child::td[3]/a[text()='Absence']";
            return SeleniumDriver.GetElementByXpath(xpath);
        }

        public IWebElement GetDescriptionPayrollNavigationLink()
        {
            string xpath = "//span[text()='Payroll']/parent::td/parent::tr/following-sibling::tr[1]/child::td[3]/a[text()='Description']";
            return SeleniumDriver.GetElementByXpath(xpath);
        }

        public IWebElement GetDescriptionGradeNavigationLink()
        {
            string xpath = "//span[text()='Work Structures : Grade']/parent::td/parent::tr/following-sibling::tr[1]/child::td[3]/a[text()='Description']";
            return SeleniumDriver.GetElementByXpath(xpath);
        }

        public IWebElement GetDescriptionJobNavigationLink()
        {
            string xpath = "//span[text()='Work Structures : Job']/parent::td/parent::tr/following-sibling::tr[1]/child::td[3]/a[text()='Description']";
            return SeleniumDriver.GetElementByXpath(xpath);
        }

        public IWebElement GetDescriptionOrganizationNavigationLink()
        {
            string xpath = "//span[text()='Work Structures : Organization']/parent::td/parent::tr/following-sibling::tr[1]/child::td[3]/a[text()='Description']";
            return SeleniumDriver.GetElementByXpath(xpath);
        }

        public IWebElement GetDescriptionPositionNavigationLink()
        {
            string xpath = "//span[text()='Work Structures : Position']/parent::td/parent::tr/following-sibling::tr[1]/child::td[3]/a[text()='Description']";
            return SeleniumDriver.GetElementByXpath(xpath);
        }

        public IWebElement GetUpdateBtn()
        {
            string xpath = "//button[@title='Update']";
            return SeleniumDriver.GetElementByXpath(xpath);
        }

        public IWebElement GetAddBtn()
        {
            string xpath = "//button[@title='Add']";
            return SeleniumDriver.GetElementByXpath(xpath);
        }

        public IWebElement GetGoBtn()
        {
            string xpath = "//button[text()='Go']";
            return SeleniumDriver.GetElementByXpath(xpath);
        }

        public IWebElement GetGoHomeBtn()
        {
            string xpath = "//button[@title='Home']";
            return SeleniumDriver.GetElementByXpath(xpath);
        }

        public IWebElement GetNameSearchInputField()
        {
            string xpath = "//input[@title='Search Criteria']";
            return SeleniumDriver.GetElementByXpath(xpath);
        }

        public IWebElement GetSelectNameInputCheckBox()
        {
            string xpath = "//input[@title='Select']";
            return SeleniumDriver.GetElementByXpath(xpath);
        }


        public IWebElement GetDoActionIcon()
        {
            string xpath = "//img[@title='Action']";
            return SeleniumDriver.GetElementByXpath(xpath);
        }



    }
}
