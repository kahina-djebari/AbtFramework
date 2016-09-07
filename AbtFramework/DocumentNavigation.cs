﻿using System;
using AbtFramework.Utils_Classes;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium.Support.UI;
using AutoItX3Lib;
using System.Threading;
using AbtFramework.AutoIT;

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
        [FindsBy(How=How.LinkText,Using ="Sample AV metrics")]
        private IWebElement PowerPointDoc;
        [FindsBy(How = How.LinkText, Using = "IT Metrics")]
        private IWebElement ExcelDoc;
        public static string currentdocTitle;

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

        public void OpenDocumentOnline(MS2013documents document,documentType doctype)
        {
            switch (document)
            {
                case MS2013documents.QA_ReadinessChecklist_v4:
                    OpenDoc(WordDoc, doctype);
                    break;
               case MS2013documents.SampleAVMetrics:
                    OpenDoc(PowerPointDoc, doctype);
                    break;
                case MS2013documents.ITMetrics:
                    OpenDoc(ExcelDoc, doctype);
                    break;
                default:
                    break;
            }

        }

        private void OpenDoc(IWebElement Doc, documentType doctype) //open documents online
        {
            wait.Until(e => Doc.Displayed);
            action.ContextClick(Doc).Perform();
            finder = new PopupWindowFinder(Driver.seleniumdriver);
            popupWindowHandle = finder.Click(OpenDocumentIn(doctype));
            Driver.Close();
            Driver.seleniumdriver.SwitchTo().Window(popupWindowHandle);
            Driver.seleniumdriver.Manage().Window.Maximize();
            Console.WriteLine(doctype.ToString() + " Document opened Succesfully");
            Console.Write("</br>");
        }

        private IWebElement OpenDocumentIn(documentType doctype)
        {
            return DocOptions.Single(e => e.GetAttribute("title")
                                   .Equals("Open in "+doctype.ToString()+" Online"));
        }

        public void OpenDocument(MS2013documents doc)
        {
            switch (doc)
            {
                case MS2013documents.QA_ReadinessChecklist_v4:
                    wait.Until(e => WordDoc.Displayed);
                    AutoITDriver.currentWorkingDocTitle = WordDoc.Text;

                    WordDoc.Click();

                    break;
                case MS2013documents.SampleAVMetrics:
                    wait.Until(e => PowerPointDoc.Displayed);
                    AutoITDriver.currentWorkingDocTitle = PowerPointDoc.Text;

                    PowerPointDoc.Click();
                    break;
                case MS2013documents.ITMetrics:
                    wait.Until(e => ExcelDoc.Displayed);
                    AutoITDriver.currentWorkingDocTitle = ExcelDoc.Text;

                    ExcelDoc.Click();
                    break;
                default:
                    break;
            }
        }

        private void OpenPowerPointClient(IWebElement powerPointDoc)
        {
            AutoItX3 autoit = new AutoItX3();

            autoit.WinActivate(currentdocTitle + " - Microsoft PowerPoint");
            autoit.WinWaitActive(currentdocTitle + " - Microsoft PowerPoint", "", 20);
            Thread.Sleep(2000);
            autoit.ControlSend(currentdocTitle + " - Microsoft PowerPoint", "Microsoft Word Document", "_WwG1", "{ENTER}");
            Thread.Sleep(1000);
            autoit.ControlSend(currentdocTitle + " - Microsoft PowerPoint", "Microsoft Word Document", "_WwG1", "{UP}");
            Thread.Sleep(1000);
            autoit.ControlSend(currentdocTitle + " - Microsoft PowerPoint", "Microsoft Word Document", "_WwG1", "Adding this line from Word Desktop Client At: " + DateTime.Now);
        }

        private void OpenExcelClient(IWebElement excelDoc)
        {
            AutoItX3 autoit = new AutoItX3();

            autoit.WinActivate("Microsoft Excel - " + currentdocTitle);
            autoit.WinWaitActive("Microsoft Excel - " + currentdocTitle, "", 20);
            Thread.Sleep(2000);
            autoit.ControlSend("Microsoft Excel - " + currentdocTitle,currentdocTitle, "EXCEL71", "{DOWN}");
            Thread.Sleep(1000);
            autoit.ControlSend("Microsoft Excel - " + currentdocTitle, currentdocTitle, "EXCEL71", "Adding this line from Word Desktop Client At: " + DateTime.Now);
        }

        private void HandleWindowPopUp(IWebElement doc)
        {
            wait.Until(e => doc.Displayed);
            currentdocTitle = doc.Text;

            doc.Click();
          
        }

        private void OpenWordClient(IWebElement doc)
        {
            AutoItX3 autoit = new AutoItX3();
           
            autoit.WinActivate(currentdocTitle+" - Microsoft Word");
            autoit.WinWaitActive(currentdocTitle + " - Microsoft Word","",20);
            Thread.Sleep(2000);
            autoit.ControlSend(currentdocTitle + " - Microsoft Word", "Microsoft Word Document", "_WwG1", "{ENTER}");
            Thread.Sleep(1000);
            autoit.ControlSend(currentdocTitle + " - Microsoft Word", "Microsoft Word Document", "_WwG1", "{UP}");
            Thread.Sleep(1000);
            autoit.ControlSend(currentdocTitle + " - Microsoft Word", "Microsoft Word Document", "_WwG1", "Adding this line from Word Desktop Client At: " + DateTime.Now);
        }


        private IWebElement OpenOnClient(documentType doctype)
        {
            return DocOptions.Single(e => e.GetAttribute("title")
                                   .Equals("Open in " + doctype.ToString()));
        }
    }
}