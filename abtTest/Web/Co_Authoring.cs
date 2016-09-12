using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit;
using AbtFramework;
using AbtFramework.Utils_Classes;
using AbtFramework.AutoIT;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System.Collections.Generic;

namespace abtTest.Web
{
    
    public class Co_Authoring
    {
      //  [Fact(DisplayName = "Co-Authoring Should Edit Word Document Online")]
        public void Should_Edit_Document_Online()
        {
            Driver.RemoteInitDavidsPc(Browser.IE);
            AbtDriver.HomePage.Go();
            AbtDriver.TopNavigation.Goto(homelinks.Projects);
            AbtDriver.ProjectsPage.Goto(projectslinks.MS2013upgrade);
            AbtDriver.MS2013UpgradePage.DocumentNavigation.Goto(MS2013Links.Testing);
            AbtDriver.MS2013UpgradePage.DocumentNavigation.Goto(MS2013Links.QA_AuthoringIssueReplication);
            AbtDriver.MS2013UpgradePage.DocumentNavigation.OpenDocumentOnline(MS2013documents.QA_ReadinessChecklist_v4, documentType.Word);
            AbtDriver.WordDocumentPage.Edit();
            Driver.Quit();

        }
      //  [Fact(DisplayName = "Co-Authoring Should Edit PowerPoint Document Online")]
        public void Should_Edit_PowerPoint_Online()
        {
            Driver.init(Browser.Chrome);
            AbtDriver.HomePage.Go();
            AbtDriver.TopNavigation.Goto(homelinks.Projects);
            AbtDriver.ProjectsPage.Goto(projectslinks.MS2013upgrade);
            AbtDriver.MS2013UpgradePage.DocumentNavigation.Goto(MS2013Links.Testing);
            AbtDriver.MS2013UpgradePage.DocumentNavigation.Goto(MS2013Links.QA_AuthoringIssueReplication);
            AbtDriver.MS2013UpgradePage.DocumentNavigation.OpenDocumentOnline(MS2013documents.SampleAVMetrics, documentType.PowerPoint);
            AbtDriver.PowerPointOnlinePage.Edit();


        }

     //   [Fact(DisplayName = "Co-Authoring Should Edit Excel Document Online")]
        public void Should_Edit_Excel_Online()
        {
            Driver.init(Browser.Chrome);
            AbtDriver.HomePage.Go();
            AbtDriver.TopNavigation.Goto(homelinks.Projects);
            AbtDriver.ProjectsPage.Goto(projectslinks.MS2013upgrade);
            AbtDriver.MS2013UpgradePage.DocumentNavigation.Goto(MS2013Links.Testing);
            AbtDriver.MS2013UpgradePage.DocumentNavigation.Goto(MS2013Links.QA_AuthoringIssueReplication);
            AbtDriver.MS2013UpgradePage.DocumentNavigation.OpenDocumentOnline(MS2013documents.ITMetrics, documentType.Excel);
            AbtDriver.ExcelOnlinePage.Edit();


        }

      //  [Fact(DisplayName = "Co-Authoring Should open Word Document for reading On Word Desktop Client App")]
        public void Should_Open_WordDoc_For_Reading_On_ClientApp()
        {
            Driver.init(Browser.IENoNativeEvents);
            AbtDriver.HomePage.Go();
            AbtDriver.TopNavigation.Goto(homelinks.Projects);
            AbtDriver.ProjectsPage.Goto(projectslinks.MS2013upgrade);
            AbtDriver.MS2013UpgradePage.DocumentNavigation.Goto(MS2013Links.Testing);
            AbtDriver.MS2013UpgradePage.DocumentNavigation.Goto(MS2013Links.QA_AuthoringIssueReplication);
            AbtDriver.MS2013UpgradePage.DocumentNavigation.OpenDocument(MS2013documents.QA_ReadinessChecklist_v4);
            AutoITDriver.init();
            AutoITDriver.OpenDocumentForReading(); //If have problem running AUtoIT remember that you need to register the dll with cmd
            Driver.Close();

        }
     //   [Fact(DisplayName = "Co-Authoring Should open Excel Document for reading On Excel Desktop Client App")]
        public void Should_Open_ExcelDoc_For_Reading_On_ClientApp()
        {
            Driver.init(Browser.IENoNativeEvents);
            AbtDriver.HomePage.Go();
            AbtDriver.TopNavigation.Goto(homelinks.Projects);
            AbtDriver.ProjectsPage.Goto(projectslinks.MS2013upgrade);
            AbtDriver.MS2013UpgradePage.DocumentNavigation.Goto(MS2013Links.Testing);
            AbtDriver.MS2013UpgradePage.DocumentNavigation.Goto(MS2013Links.QA_AuthoringIssueReplication);
            AbtDriver.MS2013UpgradePage.DocumentNavigation.OpenDocument(MS2013documents.ITMetrics);
            AutoITDriver.init();
            AutoITDriver.OpenDocumentForReading(); //If have problem running AUtoIT remember that you need to register the dll with cmd
            Driver.Close();

        }

      //  [Fact(DisplayName = "Co-Authoring Should open PowerPoint Document for reading On PowerPoint Desktop Client App")]
        public void Should_Open_PPTDoc_For_Reading_On_ClientApp()
        {
            Driver.init(Browser.IENoNativeEvents);
            AbtDriver.HomePage.Go();
            AbtDriver.TopNavigation.Goto(homelinks.Projects);
            AbtDriver.ProjectsPage.Goto(projectslinks.MS2013upgrade);
            AbtDriver.MS2013UpgradePage.DocumentNavigation.Goto(MS2013Links.Testing);
            AbtDriver.MS2013UpgradePage.DocumentNavigation.Goto(MS2013Links.QA_AuthoringIssueReplication);
            AbtDriver.MS2013UpgradePage.DocumentNavigation.OpenDocument(MS2013documents.SampleAVMetrics);
            AutoITDriver.init();
            AutoITDriver.OpenDocumentForReading(); //If have problem running AUtoIT remember that you need to register the dll with cmd
            Driver.Close();

        }

     //   [Fact(DisplayName = "Co-Authoring Should open Word Document for editing from inside Word Desktop Client App")]
        public void Should_Open_WordDoc_For_Editing_From_Inside_ClientApp()
        {
            Driver.init(Browser.IENoNativeEvents);
            AbtDriver.HomePage.Go();
            AbtDriver.TopNavigation.Goto(homelinks.Projects);
            AbtDriver.ProjectsPage.Goto(projectslinks.MS2013upgrade);
            AbtDriver.MS2013UpgradePage.DocumentNavigation.Goto(MS2013Links.Testing);
            AbtDriver.MS2013UpgradePage.DocumentNavigation.Goto(MS2013Links.QA_AuthoringIssueReplication);
            AbtDriver.MS2013UpgradePage.DocumentNavigation.OpenDocument(MS2013documents.QA_ReadinessChecklist_v4);
            AutoITDriver.init();
            AutoITDriver.OpenDocumentForReading(); //If have problem running AUtoIT remember that you need to register the dll with cmd
            AutoITDriver.EditWordFileFromInsideApp();
            Driver.Close();

        }

     //   [Fact(DisplayName = "Co-Authoring Should open Excel Document for editing from inside Excel Desktop Client App")]
        public void Should_Open_ExcelDoc_For_Editing_From_Inside_ClientApp()
        {
            Driver.init(Browser.IENoNativeEvents);
            AbtDriver.HomePage.Go();
            AbtDriver.TopNavigation.Goto(homelinks.Projects);
            AbtDriver.ProjectsPage.Goto(projectslinks.MS2013upgrade);
            AbtDriver.MS2013UpgradePage.DocumentNavigation.Goto(MS2013Links.Testing);
            AbtDriver.MS2013UpgradePage.DocumentNavigation.Goto(MS2013Links.QA_AuthoringIssueReplication);
            AbtDriver.MS2013UpgradePage.DocumentNavigation.OpenDocument(MS2013documents.ITMetrics);
            AutoITDriver.init();
            AutoITDriver.OpenDocumentForReading(); //If have problem running AUtoIT remember that you need to register the dll with cmd
            AutoITDriver.EditExcelFileFromInsideApp();
            Driver.Close();

        }

   
     //   [Fact(DisplayName = "Co-Authoring Should open PowerPoint Document for editing from inside PowerPoint Desktop Client App")]
        public void Should_Open_PPTDoc_For_Editing_From_Inside_ClientApp()
        {
            Driver.init(Browser.IENoNativeEvents);
            AbtDriver.HomePage.Go();
            AbtDriver.TopNavigation.Goto(homelinks.Projects);
            AbtDriver.ProjectsPage.Goto(projectslinks.MS2013upgrade);
            AbtDriver.MS2013UpgradePage.DocumentNavigation.Goto(MS2013Links.Testing);
            AbtDriver.MS2013UpgradePage.DocumentNavigation.Goto(MS2013Links.QA_AuthoringIssueReplication);
            AbtDriver.MS2013UpgradePage.DocumentNavigation.OpenDocument(MS2013documents.SampleAVMetrics);
            AutoITDriver.init();
            AutoITDriver.OpenDocumentForReading(); //If have problem running AUtoIT remember that you need to register the dll with cmd
            AutoITDriver.EditPPTFileFromInsideApp();
            Driver.Close();

        }
   

     //     [Fact(DisplayName = "Co-Authoring Should Edit Word Document On Desktop Client App")]
        public void Should_Edit_WordDoc_On_ClientApp(Browser browser=Browser.IENoNativeEvents)
        {
            Driver.init(browser);
            AbtDriver.HomePage.Go();
            AbtDriver.TopNavigation.Goto(homelinks.Projects);
            AbtDriver.ProjectsPage.Goto(projectslinks.MS2013upgrade);
            AbtDriver.MS2013UpgradePage.DocumentNavigation.Goto(MS2013Links.Testing);
            AbtDriver.MS2013UpgradePage.DocumentNavigation.Goto(MS2013Links.QA_AuthoringIssueReplication);
            AbtDriver.MS2013UpgradePage.DocumentNavigation.OpenDocument(MS2013documents.QA_ReadinessChecklist_v4);
            AutoITDriver.init();
            AutoITDriver.EditWordFile(); //If have problem running AUtoIT remember that you need to register the dll with cmd
          //  AutoITDriver.SaveWordFile();
          //  AutoITDriver.CloseWordFile();
          //  Driver.Close();

        }

        //[Fact(DisplayName = "Co-Authoring Should Edit Excel Document On Desktop Client App")]
        public void Should_Edit_ExcelDoc_On_ClientApp()
        {
            Driver.init(Browser.IENoNativeEvents);
            AbtDriver.HomePage.Go();
            AbtDriver.TopNavigation.Goto(homelinks.Projects);
            AbtDriver.ProjectsPage.Goto(projectslinks.MS2013upgrade);
            AbtDriver.MS2013UpgradePage.DocumentNavigation.Goto(MS2013Links.Testing);
            AbtDriver.MS2013UpgradePage.DocumentNavigation.Goto(MS2013Links.QA_AuthoringIssueReplication);
            AbtDriver.MS2013UpgradePage.DocumentNavigation.OpenDocument(MS2013documents.ITMetrics);
            AutoITDriver.init();
            AutoITDriver.EditExcelFile(); //If have problem running AUtoIT remember that you need to register the dll with cmd
            AutoITDriver.SaveExcelFile();
            AutoITDriver.CloseExcelFile();
            Driver.Close();

        }

      //  [Fact(DisplayName = "Co-Authoring Should Edit PowerPoint Document On Desktop Client App")]
        public void Should_Edit_PowerPointDoc_On_ClientApp()
        {
            Driver.init(Browser.IENoNativeEvents);
            AbtDriver.HomePage.Go();
            AbtDriver.TopNavigation.Goto(homelinks.Projects);
            AbtDriver.ProjectsPage.Goto(projectslinks.MS2013upgrade);
            AbtDriver.MS2013UpgradePage.DocumentNavigation.Goto(MS2013Links.Testing);
            AbtDriver.MS2013UpgradePage.DocumentNavigation.Goto(MS2013Links.QA_AuthoringIssueReplication);
            AbtDriver.MS2013UpgradePage.DocumentNavigation.OpenDocument(MS2013documents.SampleAVMetrics);
            AutoITDriver.init();
            AutoITDriver.EditPowerPointFile();   //If have problem running AUtoIT remember that you need to register the dll with cmd
            AutoITDriver.SavePPTFile();
            AutoITDriver.ClosePPTFile();
            Driver.Close();

        }


       // [Fact(DisplayName ="Co-Authoring - 2 people trying to edit document simultaneously using Word Desktop")]
        public void Should_Edit_Word_Document_By_2_People_Simultaneously_From_Word_ClientApp()
        {
            Should_Edit_WordDoc_On_ClientApp();
            Should_Edit_WordDoc_On_ClientApp(Browser.RemoteDavidIENoNativeEvents);
            
        }

   

    }
}
