using System;
using AbtFramework.Utils_Classes;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium.Support.UI;

namespace AbtFramework
{
    public class DocumentNavigation : PageModel
    {
        [FindsBy(How=How.LinkText,Using = "QA Authoring Issue Replication")]
        private IWebElement QA_Folder;
        [FindsBy(How=How.LinkText,Using ="Testing")]
        private IWebElement TestingFolder;
        [FindsBy(How = How.LinkText, Using = "QA_ReadinessChecklist_v4")]
        private IWebElement WordDoc;
        [FindsBy(How = How.ClassName, Using = "ms-core-menu-link")]
        private IList<IWebElement> DocOptions;
        


        public IWebElement OpenWordOnline
        {
            get
            {
                return DocOptions.Single(e => e.GetAttribute("title")
                                   .Equals("Open in Word Online"));
            }
        }
        public void Goto(MS2013Links link)
        {
            switch (link)
            {
                case MS2013Links.Testing:
                    TestingFolder.Click();
                    break;

                case MS2013Links.QA_AuthoringIssueReplication:
                    wait.Until(e => QA_Folder.Displayed);
                    QA_Folder.Click();
                    break;

                case MS2013Links.IE11:
                    break;
                case MS2013Links.Office2013:
                    break;
                default:
                    break;
            }
        }

        public void OpenDocumentOnline(MS2013documents document)
        {
            switch (document)
            {
                case MS2013documents.QA_ReadinessChecklist_v4:
                       wait.Until(e => WordDoc.Displayed);
                       action.ContextClick(WordDoc).Perform();
                       finder = new PopupWindowFinder(Driver.seleniumdriver);
                       popupWindowHandle = finder.Click(OpenWordOnline);
                       Driver.Close();
                       Driver.seleniumdriver.SwitchTo().Window(popupWindowHandle);
                       Driver.seleniumdriver.Manage().Window.Maximize();
                    Console.WriteLine("Word Document opened Succesfully");
                    Console.Write("\n");
                    break;
                default:
                    break;
            }

        }
    }
}