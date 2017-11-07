using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using AbtFramework.Utils_Classes.SeleniumUtils;

namespace AbtFramework
{
    public class TablePageObject : PageModel
    {
        [FindsBy(How = How.ClassName, Using = "list_row")]
        private IList<IWebElement> Rows;

        public IWebElement FirstRowItem
        {
            get
            {
                return Rows[0].FindElements(By.TagName("td"))[2].FindElement(By.TagName("a"));
            }
        }
        internal string FirstIncidentDescription
        {
            get
            {

                return Rows[0].FindElements(By.TagName("td"))[3].Text;

            }
        }

        public void OpenIncident(string IncidentId)
        {
            SeleniumDriver.DriverInstance.SwitchTo().ParentFrame();
            SeleniumDriver.DriverInstance.SwitchTo().Frame("gsft_main");
            SeleniumDriver.DriverInstance.FindElement(By.LinkText(IncidentId)).Click();
        }

        public void OpenFirstRowItem()
        {
            FirstRowItem.Click();
        }

        public string GetIncidentNumberFirstRowItem()
        {
           return   FirstRowItem.GetAttribute("value");
        }
    }
}