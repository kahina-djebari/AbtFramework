using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;

namespace AbtFramework
{
    public class IncidentTablePageObject : PageModel
    {
        [FindsBy(How = How.ClassName, Using = "list_row")]
        private IList<IWebElement> IncidentRows;

        internal IWebElement FirstIncident
        {
            get
            {
                return IncidentRows[0].FindElements(By.TagName("td"))[2].FindElement(By.TagName("a"));
            }
        }
        internal string FirstIncidentDescription
        {
            get
            {

                return IncidentRows[0].FindElements(By.TagName("td"))[3].Text;

            }
        }
    }
}