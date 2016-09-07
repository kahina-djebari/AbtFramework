using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit;
using AbtFramework;
using AbtFramework.Utils_Classes;
using AbtFramework.AutoIT;

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
      //  [Fact(DisplayName = "Co-Authoring Should Edit Word Document On Desktop Client App")]
        public void Should_Edit_WordDoc_On_ClientApp()
        {
            Driver.init(Browser.IENoNativeEvents);
            AbtDriver.HomePage.Go();
            AbtDriver.TopNavigation.Goto(homelinks.Projects);
            AbtDriver.ProjectsPage.Goto(projectslinks.MS2013upgrade);
            AbtDriver.MS2013UpgradePage.DocumentNavigation.Goto(MS2013Links.Testing);
            AbtDriver.MS2013UpgradePage.DocumentNavigation.Goto(MS2013Links.QA_AuthoringIssueReplication);
            AbtDriver.MS2013UpgradePage.DocumentNavigation.OpenDocument(MS2013documents.QA_ReadinessChecklist_v4);
            AutoITDriver.EditWordFile(); //If have problem running AUtoIT remember that you need to register the dll with cmd
            Driver.Close();

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
            AutoITDriver.EditExcelFile(); //If have problem running AUtoIT remember that you need to register the dll with cmd
            Driver.Close();

        }

        //[Fact(DisplayName = "Co-Authoring Should Edit PowerPoint Document On Desktop Client App")]
        public void Should_Edit_PowerPointDoc_On_ClientApp()
        {
            Driver.init(Browser.IENoNativeEvents);
            AbtDriver.HomePage.Go();
            AbtDriver.TopNavigation.Goto(homelinks.Projects);
            AbtDriver.ProjectsPage.Goto(projectslinks.MS2013upgrade);
            AbtDriver.MS2013UpgradePage.DocumentNavigation.Goto(MS2013Links.Testing);
            AbtDriver.MS2013UpgradePage.DocumentNavigation.Goto(MS2013Links.QA_AuthoringIssueReplication);
            AbtDriver.MS2013UpgradePage.DocumentNavigation.OpenDocument(MS2013documents.SampleAVMetrics);
            AutoITDriver.EditPowerPointFile();   //If have problem running AUtoIT remember that you need to register the dll with cmd
            Driver.Close();

        }


        //[Fact(DisplayName ="Co-Authoring - 2 people trying to edit document simultaneously")]
        public void Should_Edit_Document_By_2_People_Simultaneously()
        {

        }

    }
}
