using System;
using Xunit;
using AbtFramework;
using AbtFramework.Utils_Classes;
using AbtFramework.AutoIT;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace abtTest.Web
{
    
    public class Co_Authoring
    {
      //  [Fact(DisplayName = "Co-Authoring Should Edit Word Document Online")]
        public void Should_Edit_Document_Online()
        {
            SeleniumDriver.init(Browser.IE);
            AbtPages.AgiHomePage.Go();
            AbtPages.AgiTopNavigation.Goto(homelinks.Projects);
            AbtPages.ProjectsPage.Goto(projectslinks.MS2013upgrade);
            AbtPages.SharePointDocumentNavigation.Goto(MS2013Links.Testing);
            AbtPages.SharePointDocumentNavigation.Goto(MS2013Links.QA_AuthoringIssueReplication);
            AbtPages.SharePointDocumentNavigation.OpenDocumentOnline(MS2013documents.QA_ReadinessChecklist_v4, documentType.Word);
            AbtPages.WordOnlinePage.Edit();
            SeleniumDriver.Quit();

        }
      //  [Fact(DisplayName = "Co-Authoring Should Edit PowerPoint Document Online")]
        public void Should_Edit_PowerPoint_Online()
        {
            SeleniumDriver.init(Browser.Chrome);
            AbtPages.AgiHomePage.Go();
            AbtPages.AgiTopNavigation.Goto(homelinks.Projects);
            AbtPages.ProjectsPage.Goto(projectslinks.MS2013upgrade);
            AbtPages.SharePointDocumentNavigation.Goto(MS2013Links.Testing);
            AbtPages.SharePointDocumentNavigation.Goto(MS2013Links.QA_AuthoringIssueReplication);
            AbtPages.SharePointDocumentNavigation.OpenDocumentOnline(MS2013documents.SampleAVMetrics, documentType.PowerPoint);
            AbtPages.PowerPointOnlinePage.Edit();


        }

     //   [Fact(DisplayName = "Co-Authoring Should Edit Excel Document Online")]
        public void Should_Edit_Excel_Online()
        {
            SeleniumDriver.init(Browser.Chrome);
            AbtPages.AgiHomePage.Go();
            AbtPages.AgiTopNavigation.Goto(homelinks.Projects);
            AbtPages.ProjectsPage.Goto(projectslinks.MS2013upgrade);
            AbtPages.SharePointDocumentNavigation.Goto(MS2013Links.Testing);
            AbtPages.SharePointDocumentNavigation.Goto(MS2013Links.QA_AuthoringIssueReplication);
            AbtPages.SharePointDocumentNavigation.OpenDocumentOnline(MS2013documents.ITMetrics, documentType.Excel);
            AbtPages.ExcelOnlinePage.Edit();


        }

      // [Fact(DisplayName = "Co-Authoring Should open Word Document for reading On Word Desktop Client App")]
        public void Should_Open_WordDoc_For_Reading_On_ClientApp()
        {
            SeleniumDriver.init(Browser.IENoNativeEvents);
            AbtPages.AgiHomePage.Go();
            AbtPages.AgiTopNavigation.Goto(homelinks.Projects);
            AbtPages.ProjectsPage.Goto(projectslinks.MS2013upgrade);
            AbtPages.SharePointDocumentNavigation.Goto(MS2013Links.Testing);
            AbtPages.SharePointDocumentNavigation.Goto(MS2013Links.QA_AuthoringIssueReplication);
            AbtPages.SharePointDocumentNavigation.OpenDocument(MS2013documents.QA_ReadinessChecklist_v4);
            AutoITDriver.init();
            AutoITDriver.OpenDocumentForReading(); //If have problem running AUtoIT remember that you need to register the dll with cmd
            SeleniumDriver.Close();

        }
     //   [Fact(DisplayName = "Co-Authoring Should open Excel Document for reading On Excel Desktop Client App")]
        public void Should_Open_ExcelDoc_For_Reading_On_ClientApp()
        {
            SeleniumDriver.init(Browser.IENoNativeEvents);
            AbtPages.AgiHomePage.Go();
            AbtPages.AgiTopNavigation.Goto(homelinks.Projects);
            AbtPages.ProjectsPage.Goto(projectslinks.MS2013upgrade);
            AbtPages.SharePointDocumentNavigation.Goto(MS2013Links.Testing);
            AbtPages.SharePointDocumentNavigation.Goto(MS2013Links.QA_AuthoringIssueReplication);
            AbtPages.SharePointDocumentNavigation.OpenDocument(MS2013documents.ITMetrics);
            AutoITDriver.init();
            AutoITDriver.OpenDocumentForReading(); //If have problem running AUtoIT remember that you need to register the dll with cmd
            SeleniumDriver.Close();

        }

      //  [Fact(DisplayName = "Co-Authoring Should open PowerPoint Document for reading On PowerPoint Desktop Client App")]
        public void Should_Open_PPTDoc_For_Reading_On_ClientApp()
        {
            SeleniumDriver.init(Browser.IENoNativeEvents);
            AbtPages.AgiHomePage.Go();
            AbtPages.AgiTopNavigation.Goto(homelinks.Projects);
            AbtPages.ProjectsPage.Goto(projectslinks.MS2013upgrade);
            AbtPages.SharePointDocumentNavigation.Goto(MS2013Links.Testing);
            AbtPages.SharePointDocumentNavigation.Goto(MS2013Links.QA_AuthoringIssueReplication);
            AbtPages.SharePointDocumentNavigation.OpenDocument(MS2013documents.SampleAVMetrics);
            AutoITDriver.init();
            AutoITDriver.OpenDocumentForReading(); //If have problem running AUtoIT remember that you need to register the dll with cmd
            SeleniumDriver.Close();

        }

     //   [Fact(DisplayName = "Co-Authoring Should open Word Document for editing from inside Word Desktop Client App")]
        public void Should_Open_WordDoc_For_Editing_From_Inside_ClientApp()
        {
            SeleniumDriver.init(Browser.IENoNativeEvents);
            AbtPages.AgiHomePage.Go();
            AbtPages.AgiTopNavigation.Goto(homelinks.Projects);
            AbtPages.ProjectsPage.Goto(projectslinks.MS2013upgrade);
            AbtPages.SharePointDocumentNavigation.Goto(MS2013Links.Testing);
            AbtPages.SharePointDocumentNavigation.Goto(MS2013Links.QA_AuthoringIssueReplication);
            AbtPages.SharePointDocumentNavigation.OpenDocument(MS2013documents.QA_ReadinessChecklist_v4);
            AutoITDriver.init();
            AutoITDriver.OpenDocumentForReading(); //If have problem running AUtoIT remember that you need to register the dll with cmd
            AutoITDriver.EditWordFileFromInsideApp();
            SeleniumDriver.Close();

        }

     //   [Fact(DisplayName = "Co-Authoring Should open Excel Document for editing from inside Excel Desktop Client App")]
        public void Should_Open_ExcelDoc_For_Editing_From_Inside_ClientApp()
        {
            SeleniumDriver.init(Browser.IENoNativeEvents);
            AbtPages.AgiHomePage.Go();
            AbtPages.AgiTopNavigation.Goto(homelinks.Projects);
            AbtPages.ProjectsPage.Goto(projectslinks.MS2013upgrade);
            AbtPages.SharePointDocumentNavigation.Goto(MS2013Links.Testing);
            AbtPages.SharePointDocumentNavigation.Goto(MS2013Links.QA_AuthoringIssueReplication);
            AbtPages.SharePointDocumentNavigation.OpenDocument(MS2013documents.ITMetrics);
            AutoITDriver.init();
            AutoITDriver.OpenDocumentForReading(); //If have problem running AUtoIT remember that you need to register the dll with cmd
            AutoITDriver.EditExcelFileFromInsideApp();
            SeleniumDriver.Close();

        }

   
     //   [Fact(DisplayName = "Co-Authoring Should open PowerPoint Document for editing from inside PowerPoint Desktop Client App")]
        public void Should_Open_PPTDoc_For_Editing_From_Inside_ClientApp()
        {
            SeleniumDriver.init(Browser.IENoNativeEvents);
            AbtPages.AgiHomePage.Go();
            AbtPages.AgiTopNavigation.Goto(homelinks.Projects);
            AbtPages.ProjectsPage.Goto(projectslinks.MS2013upgrade);
            AbtPages.SharePointDocumentNavigation.Goto(MS2013Links.Testing);
            AbtPages.SharePointDocumentNavigation.Goto(MS2013Links.QA_AuthoringIssueReplication);
            AbtPages.SharePointDocumentNavigation.OpenDocument(MS2013documents.SampleAVMetrics);
            AutoITDriver.init();
            AutoITDriver.OpenDocumentForReading(); //If have problem running AUtoIT remember that you need to register the dll with cmd
            AutoITDriver.EditPPTFileFromInsideApp();
            SeleniumDriver.Close();

        }
   

     //     [Fact(DisplayName = "Co-Authoring Should Edit Word Document On Desktop Client App")]
        public void Should_Edit_WordDoc_On_ClientApp(Browser browser=Browser.IENoNativeEvents)
        {
            SeleniumDriver.init(browser);
            AbtPages.AgiHomePage.Go();
            AbtPages.AgiTopNavigation.Goto(homelinks.Projects);
            AbtPages.ProjectsPage.Goto(projectslinks.MS2013upgrade);
            AbtPages.SharePointDocumentNavigation.Goto(MS2013Links.Testing);
            AbtPages.SharePointDocumentNavigation.Goto(MS2013Links.QA_AuthoringIssueReplication);
            AbtPages.SharePointDocumentNavigation.OpenDocument(MS2013documents.QA_ReadinessChecklist_v4);
            AutoITDriver.init();
            AutoITDriver.EditWordFile(); //If have problem running AUtoIT remember that you need to register the dll with cmd
          //  AutoITDriver.SaveWordFile();
          //  AutoITDriver.CloseWordFile();
          //  Driver.Close();

        }

        //[Fact(DisplayName = "Co-Authoring Should Edit Excel Document On Desktop Client App")]
        public void Should_Edit_ExcelDoc_On_ClientApp()
        {
            SeleniumDriver.init(Browser.IENoNativeEvents);
            AbtPages.AgiHomePage.Go();
            AbtPages.AgiTopNavigation.Goto(homelinks.Projects);
            AbtPages.ProjectsPage.Goto(projectslinks.MS2013upgrade);
            AbtPages.SharePointDocumentNavigation.Goto(MS2013Links.Testing);
            AbtPages.SharePointDocumentNavigation.Goto(MS2013Links.QA_AuthoringIssueReplication);
            AbtPages.SharePointDocumentNavigation.OpenDocument(MS2013documents.ITMetrics);
            AutoITDriver.init();
            AutoITDriver.EditExcelFile(); //If have problem running AUtoIT remember that you need to register the dll with cmd
            AutoITDriver.SaveExcelFile();
            AutoITDriver.CloseExcelFile();
            SeleniumDriver.Close();

        }

      //  [Fact(DisplayName = "Co-Authoring Should Edit PowerPoint Document On Desktop Client App")]
        public void Should_Edit_PowerPointDoc_On_ClientApp()
        {
            SeleniumDriver.init(Browser.IENoNativeEvents);
            AbtPages.AgiHomePage.Go();
            AbtPages.AgiTopNavigation.Goto(homelinks.Projects);
            AbtPages.ProjectsPage.Goto(projectslinks.MS2013upgrade);
            AbtPages.SharePointDocumentNavigation.Goto(MS2013Links.Testing);
            AbtPages.SharePointDocumentNavigation.Goto(MS2013Links.QA_AuthoringIssueReplication);
            AbtPages.SharePointDocumentNavigation.OpenDocument(MS2013documents.SampleAVMetrics);
            AutoITDriver.init();
            AutoITDriver.EditPowerPointFile();   //If have problem running AUtoIT remember that you need to register the dll with cmd
            AutoITDriver.SavePPTFile();
            AutoITDriver.ClosePPTFile();
            SeleniumDriver.Close();

        }


       // [Fact(DisplayName ="Co-Authoring - 2 people trying to edit document simultaneously using Word Desktop")]
        public void Should_Edit_Word_Document_By_2_People_Simultaneously_From_Word_ClientApp()
        {
            Should_Edit_WordDoc_On_ClientApp();
            Should_Edit_WordDoc_On_ClientApp(Browser.RemoteDavidIENoNativeEvents);
            
        }

      //  [Fact(DisplayName = "Edit Word Document on KM Workspace")]
        public void Should_Edit_Word_Doc_KM_WorkSpace()
        {
            SeleniumDriver.init(Browser.RemoteDavidIENoNativeEvents);
            AbtPages.KmWorkSpacePage.Go();
            AbtPages.SharePointDocumentNavigation.OpenDocument(MS2013documents.QA_ReadinessChecklist_v4);
            AutoITDriver.init();
            AutoITDriver.EditWordFile(); //If have problem running AUtoIT remember that you need to register the dll with cmd
            AutoITDriver.SaveWordFile();
            AutoITDriver.CloseWordFile();
            SeleniumDriver.Close();
        }

       // [Fact(DisplayName = "Edit PowerPoint Document on KM Workspace")]
        public void Should_Edit_PPT_Doc_KM_WorkSpace()
        {
            SeleniumDriver.init(Browser.RemoteDavidIENoNativeEvents);
            AbtPages.KmWorkSpacePage.Go();
            AbtPages.SharePointDocumentNavigation.OpenDocument(MS2013documents.SampleAVMetrics);
            AutoITDriver.init();
            AutoITDriver.EditPowerPointFile(); //If have problem running AUtoIT remember that you need to register the dll with cmd
            AutoITDriver.SavePPTFile();
            AutoITDriver.ClosePPTFile();
            SeleniumDriver.Close();

        }



       // [Fact(DisplayName = "Edit Excel Document on KM Workspace")]
        public void Should_Edit_Excel_Doc_KM_WorkSpace()
        {
            SeleniumDriver.init(Browser.RemoteDavidIENoNativeEvents);
            AbtPages.KmWorkSpacePage.Go();
            AbtPages.SharePointDocumentNavigation.OpenDocument(MS2013documents.ITMetrics);
            AutoITDriver.init();
            Assert.True(AutoITDriver.EditExcelFile()); //If have problem running AUtoIT remember that you need to register the dll with cmd
            Assert.True(AutoITDriver.SaveExcelFile());
            Assert.True(AutoITDriver.CloseExcelFile());
            SeleniumDriver.Close();
        }

      //  [Fact(DisplayName = "Open Word Document for Reading on KM Workspace")]
        public void Should_Open_Word_Doc_KM_WorkSpace()
        {
            SeleniumDriver.init(Browser.IENoNativeEvents);
            AbtPages.KmWorkSpacePage.Go();
            AbtPages.SharePointDocumentNavigation.OpenDocument(MS2013documents.QA_ReadinessChecklist_v4);
            AutoITDriver.init();
            AutoITDriver.OpenDocumentForReading(); //If have problem running AUtoIT remember that you need to register the dll with cmd
            SeleniumDriver.Close();
        }

      //  [Fact(DisplayName = "Open PowerPoint Document for Reading on KM Workspace")]
        public void Should_Open_PPT_Doc_KM_WorkSpace()
        {
            SeleniumDriver.init(Browser.IENoNativeEvents);
            AbtPages.KmWorkSpacePage.Go();
            AbtPages.SharePointDocumentNavigation.OpenDocument(MS2013documents.SampleAVMetrics);
            AutoITDriver.init();
            AutoITDriver.OpenDocumentForReading();
            SeleniumDriver.Close();

        }



       // [Fact(DisplayName = "Open Excel Document for Reading on KM Workspace")]
        public void Should_Open_Excel_Doc_KM_WorkSpace()
        {
            SeleniumDriver.init(Browser.IENoNativeEvents);
            AbtPages.KmWorkSpacePage.Go();
            AbtPages.SharePointDocumentNavigation.OpenDocument(MS2013documents.ITMetrics);
            AutoITDriver.init();
            AutoITDriver.OpenDocumentForReading();
            SeleniumDriver.Close();
        }

       // [Fact(DisplayName = "Edit Word Document Online on KM Workspace")]
        public void Should_Open_Word_Doc_Online_KM_WorkSpace(Browser browser=Browser.IE)
        {
            SeleniumDriver.init(browser);
            AbtPages.KmWorkSpacePage.Go();
            AbtPages.SharePointDocumentNavigation.OpenDocumentOnline(MS2013documents.QA_ReadinessChecklist_v4,documentType.Word);
            AbtPages.WordOnlinePage.Edit();
            SeleniumDriver.Close();
        }

     //  [Fact(DisplayName =  "Edit Excel Document Online on KM Workspace")]
        public void Should_Open_Excel_Doc_Online_KM_WorkSpace()
        {
            SeleniumDriver.init(Browser.RemoteDavidIE);
            AbtPages.KmWorkSpacePage.Go();
            AbtPages.SharePointDocumentNavigation.OpenDocumentOnline(MS2013documents.ITMetrics, documentType.Excel);
            AbtPages.ExcelOnlinePage.Edit();
            SeleniumDriver.Close();
        }


       // [Fact(DisplayName = "Edit PPT Document Online on KM Workspace")]
        public void Should_Open_PPT_Doc_Online_KM_WorkSpace()
        {
            SeleniumDriver.init(Browser.IE);
            AbtPages.KmWorkSpacePage.Go();
            AbtPages.SharePointDocumentNavigation.OpenDocumentOnline(MS2013documents.SampleAVMetrics, documentType.PowerPoint);
            AbtPages.PowerPointOnlinePage.Edit();
            //SeleniumDriver.Close();
        }

     //   [Fact(DisplayName ="Should Create New Document on KM Workspace")]
        public void Should_Create_New_Doc_KM_WorkSpace()
        {
            SeleniumDriver.init(Browser.IE);
            AbtPages.KmWorkSpacePage.Go();
            AbtPages.SharePointDocumentNavigation.CreateDocument(documentType.Word);
        }

        /*
        [Fact]
        public  void TestingParallelTest()
        {

          Task.Run(()=> {

              SeleniumDriver.init(Browser.IE);
            
              SeleniumDriver.FiringDriver.Navigate().GoToUrl("www.google.com.do");
       
            SeleniumDriver.FiringDriver.FindElement(By.Id("lst-ib")).SendKeys("Testing driver 1");

              });
            SeleniumDriver.init(Browser.RemoteDavidIEDriver2);
            SeleniumDriver.FiringDriver2.Navigate().GoToUrl("www.google.com.do");
            SeleniumDriver.FiringDriver2.FindElement(By.Id("lst-ib")).SendKeys("Testing driver 2");

        }*/


    }
}
