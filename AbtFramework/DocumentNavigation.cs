using System;
using AbtFramework.Utils_Classes;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium.Support.UI;
using AutoItX3Lib;
using System.Threading;
using AbtFramework.AutoIT;
using AbtFramework.SeleniumUtils;

namespace AbtFramework
{
    public class SharePointDocumentNavigation : PageModel
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
        [FindsBy(How=How.LinkText,Using = "Topic")]
        private IList<IWebElement> Topics;
        [FindsBy(How=How.Id,Using = "QCB1_Button5")]
        private IWebElement MoreOptions;
        [FindsBy(How=How.ClassName,Using = "s4-itm-cbx")]
        private IList<IWebElement> ChkBoxList;
        [FindsBy(How=How.Id,Using = "QCB1_Button1")]
        private IWebElement NewBtn;
        
        // Knowledge Hub Element.
        [FindsBy(How = How.LinkText, Using = "Test Document")]
        private IWebElement WordDocHub;



        public IWebElement OpenWordOnline
        {
            get
            {
                return DocOptions.Single(e => e.GetAttribute("title")
                                   .Equals("Open in Word Online"));
            }
        }

         public IWebElement DocumentCheckbox { get
            { return ChkBoxList.Single(e => e.GetAttribute("aria-label").
            Split(',')[0].Equals(currentdocTitle)); } }
   
        public IWebElement SecondTopic { get { return Topics[1]; } }

        /// <summary>
        /// opens the desired folder in sharepoint
        /// </summary>
        /// <param name="link"></param>
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

                    while (true)
                    {
                        try
                        {
                            wait.Until(e => Topics.Count >= 2);
                            SecondTopic.Click(); // this try catch is to expand the topic dropdown if you are on the km workspace 
                                                 // if you're not in the km workspace program wil continue.
                            if (WordDoc.Displayed)
                            {
                                break;
                            }
                        }
                        catch (Exception e)
                        {

                        }

                    }


                    OpenDoc(WordDoc, documentType.Word);

                    break;
               case MS2013documents.SampleAVMetrics:

                    while (true)
                    {
                        try
                        {
                            wait.Until(e => Topics.Count >= 2);
                            SecondTopic.Click(); // this try catch is to expand the topic dropdown if you are on the km workspace 
                                                 // if you're not in the km workspace program wil continue.

                            if (PowerPointDoc.Displayed)
                            {
                                break;
                            }
                        }
                        catch (Exception e)
                        {

                        }
                    }
                  
                    OpenDoc(PowerPointDoc, doctype);
                    break;
                case MS2013documents.ITMetrics:

                    while (true)
                    {
                        try
                        {
                            wait.Until(e => Topics.Count >= 2);
                            SecondTopic.Click(); // this try catch is to expand the topic dropdown if you are on the km workspace 
                                                 // if you're not in the km workspace program wil continue.

                            if (ExcelDoc.Displayed)
                            {
                                break;
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }

                    }
                    OpenDoc(ExcelDoc, doctype);
                    break;

                case MS2013documents.KnowledgeHub:

                
                  OpenDoc(WordDocHub, documentType.Word);

                    break;

                default:
                    break;
            }

        }

        private void OpenDoc(IWebElement Doc, documentType doctype) //open documents online
        {
                                 
           // wait.Until(e => Doc.Displayed);
            currentdocTitle = Doc.Text;
            //DocumentCheckbox.Click();
          //  MoreOptions.Click();
             action.ContextClick(Doc).Perform();
             finder = new PopupWindowFinder(SeleniumDriver.DriverInstance);
              popupWindowHandle = finder.Click(OpenDocumentIn(doctype));
           //   OpenDocumentIn(doctype).Click();
          //  action.Click(OpenDocumentIn(doctype)).Perform();
            //            SeleniumDriver.DriverInstance.FindElements(By.TagName("li")).Single(e => e.Text.Equals("Open in " + doctype.ToString() + " Online")).Click();
        
            wait.Until(e => SeleniumDriver.DriverInstance.WindowHandles.Count >= 2);
            SeleniumDriver.Close();
            SeleniumDriver.DriverInstance.SwitchTo().Window(popupWindowHandle);
            SeleniumDriver.DriverInstance.Manage().Window.Maximize();
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
                    try
                    {
                        wait.Until(ExpectedConditions.PresenceOfAllElementsLocatedBy(By.TagName("a")));
                        SecondTopic.Click(); // this try catch is to expand the topic dropdown if you are on the km workspace 
                                             // if you're not in the km workspace program wil continue.
                    }
                    catch (Exception e)
                    {

                    }
                    wait.Timeout = TimeSpan.FromSeconds(5);
                    wait.Until(e => WordDoc.Displayed);
                    AutoITDriver.currentWorkingDocTitle = WordDoc.Text;

                    WordDoc.Click();

                    break;
                case MS2013documents.SampleAVMetrics:
                    try
                    {
                        wait.Until(ExpectedConditions.PresenceOfAllElementsLocatedBy(By.TagName("a")));
                        SecondTopic.Click(); // this try catch is to expand the topic dropdown if you are on the km workspace 
                                             // if you're not in the km workspace program wil continue.
                    }
                    catch (Exception e)
                    {

                    }
                    wait.Timeout = TimeSpan.FromSeconds(5);
                    wait.Until(e => PowerPointDoc.Displayed);
                    AutoITDriver.currentWorkingDocTitle = PowerPointDoc.Text;

                    PowerPointDoc.Click();
                    break;
                case MS2013documents.ITMetrics:
                    try
                    {
                        wait.Until(ExpectedConditions.PresenceOfAllElementsLocatedBy(By.TagName("a")));
                        SecondTopic.Click(); // this try catch is to expand the topic dropdown if you are on the km workspace 
                                             // if you're not in the km workspace program wil continue.
                    }
                    catch (Exception e)
                    {
                        
                    }
                    wait.Timeout = TimeSpan.FromSeconds(5);
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

        public void CreateDocument(documentType doctype)
        {
            NewBtn.Click();
        }
    }
}