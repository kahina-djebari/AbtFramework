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

        public IWebElement getWordDocLink
        {
            get
            {
                return WrapperTable.FindElement(By.TagName("tbody"))
                                   .FindElements(By.TagName("tr"))[1].FindElements(By.TagName("td"))[3]
                                   .FindElement(By.TagName("a"));
            }
        }

        public IWebElement OpenWordOnline
        {
            get
            {
                return DocOptions.Single(e => e.GetAttribute("title")
                                   .Equals("Open in Word Online"));
            }
        }

        public void Goto(projectslinks link)
        {
            switch (link)
            {
                case projectslinks.MS2013upgrade:

                    wait.Until(e=>ms2013link.Displayed);
                    ms2013link.Click();
                    break;
                default:
                    break;
            }
        }

        public void OpenWordDocumentOnline()
        {
            wait.Until(e => WordDoc.Displayed);
            action.ContextClick(WordDoc).Perform();


            OpenWordOnline.Click();

         //   var OpenWordOnline = Driver.seleniumdriver.FindElements(By.ClassName("ms-core-menu-link"))
             //                         .Single(e=>e.GetAttribute("title")
                  //                    .Equals("Open in Word Online"));
           

            //  var element = Driver.seleniumdriver.FindElements(By.ClassName("ms-core-menu-item       ")).Single(e => e.GetAttribute("text").Equals("Open in Word online"));
            //  element.Click();
            // action.Click(element).Perform();

            //   Thread.Sleep(2000);
            //  foreach(var el in elements.FindElements(By.TagName("span"))){
            //     Console.WriteLine(el.Text);
            //  }
            // elements.FindElements(By.ClassName("ms-core-menu-title")).Click();
        }
    }
}