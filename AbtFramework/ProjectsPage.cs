using System;
using AbtFramework.Utils_Classes;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Threading;
using OpenQA.Selenium.Support.UI;
using System.Linq;
using System.Collections.Generic;

namespace AbtFramework
{
    public class ProjectsPage : PageModel
    {
        [FindsBy(How=How.ClassName,Using = "ms-core-menu-link")]
        private IList<IWebElement> DocOptions;
        [FindsBy(How=How.LinkText,Using = "MS 2013 Upgrade")]
        private IWebElement ms2013link;
        [FindsBy(How=How.ClassName,Using = "js-callout-footerArea")]
        private IWebElement OptionWindows;

        [FindsBy(How=How.LinkText,Using = "QA Authoring Issue Replication")]
        private IWebElement QA;
        [FindsBy(How=How.LinkText,Using ="Testing")]
        private IWebElement testing;
        [FindsBy(How=How.LinkText,Using = "QA_ReadinessChecklist_v4")]
        private IWebElement WordDoc;

        [FindsBy(How = How.Id, Using = "onetidDoclibViewTbl0")]
        private IWebElement WrapperTable;
        [FindsBy(How=How.Id,Using = "WebPartTitleWPQ7")]
        private IWebElement ProjectFinancials;

        public void Goto(projectslinks link)
        {
            switch (link)
            {
                case projectslinks.MS2013upgrade:
                    wait.IgnoreExceptionTypes(typeof(StaleElementReferenceException));
                    wait.Until(e=>ms2013link.Displayed);
                    ms2013link.Click();
                    break;
                default:
                    break;
            }
        }

        public bool IsAt()
        {
            wait.Until(e => e.Title.Equals("Projects"));
            if (ProjectFinancials.Displayed)
            {
                Console.WriteLine("Projects Link Opened Succesfully");
                return true;
            }

            return false;
        }


    }
}