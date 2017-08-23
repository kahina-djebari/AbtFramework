using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;

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
            SeleniumDriver.Instance.SwitchTo().ParentFrame();
            SeleniumDriver.Instance.SwitchTo().Frame("gsft_main");
            SeleniumDriver.Instance.FindElement(By.LinkText(IncidentId)).Click();
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