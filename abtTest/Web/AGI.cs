using System;
using Xunit;
using AbtFramework;
using AbtFramework.Utils_Classes;
using Xunit.Abstractions;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using AutoItX3Lib;
using System.Threading;
using AbtFramework.AutoIT;

namespace abtTest.Web
{
   
    public class AGI
    {

        
        // [Fact]
        public void Should_Click_Login_WebEx()
        {
            AbtDriver.WebExPage.goTo();
            AbtDriver.WebExPage.Login();

        }

     //  [Fact(DisplayName ="Should Go to QuickLinks -> Oracle")]
        public void Should_Go_to_Quicklinks_Oracle()
        {
            Driver.RemoteInit();
            AbtDriver.HomePage.Go();
            AbtDriver.HomePage.QuickLinks.GoTo(quickLinks.Oracle);
            Assert.True(AbtDriver.OraclePage.isAt());

        }

      //  [Fact(DisplayName ="Should Go to QuickLinks -> Staff Directory")]
        public void Should_GoTo_QuickLinks_Staff_Directory()
        {
            Driver.init(Browser.IE);
            AbtDriver.HomePage.Go();
            AbtDriver.HomePage.QuickLinks.GoTo(quickLinks.Staff_Directory);
            Assert.True(AbtDriver.StaffDirectoryPage.isAt());

        }

       // [Fact(DisplayName ="Should Go to QuickLinks -> Forms Library")]
        public void Should_GoTo_QuickLinks_FormsLibrary()
        {
            Driver.init();
            AbtDriver.HomePage.Go();
            AbtDriver.HomePage.QuickLinks.GoTo(quickLinks.FormsLibrary);
            Assert.True(AbtDriver.FormsLibraryPage.isAt());

        }

       // [Fact(DisplayName ="Should Go to QuickLinks -> Customize")]
        public void Should_GoTo_QuickLinks_Customize()
        {
            Driver.init();
            AbtDriver.HomePage.Go();
            AbtDriver.HomePage.QuickLinks.GoTo(quickLinks.Customize);
            Assert.True(AbtDriver.CustomizeLinksPage.isAt());
        }
        //[Fact(DisplayName ="Should Click on Tools (AGI Website)")]
        public void Should_click_ToolsAndResources()
        {

            AbtDriver.HomePage.Go();
            AbtDriver.ToolsAndResourcesPage.Go();
            // Assert.IsTrue(AbtDriver.ToolsAndResourcesPage.isAt());

        }

        // [Fact (DisplayName ="Should Click on Abt Talent Learn and Support (AGI Website)")]
        public void Should_click_Abt_Talent_LearnAndSupport()
        {
            AbtDriver.HomePage.Go();
            AbtDriver.TopNavigation.ToolsDropdown.goTo(AbtPages.Abt_Talent_Learning_and_Support);
            //Goes to the same page when click on abt talent learn and support

        }


        //  [Fact(DisplayName ="Should Click on ISMS (AGI Website)")]
        public void Should_click_ISMS()
        {
            AbtDriver.HomePage.Go();
            AbtDriver.TopNavigation.ToolsDropdown.goTo(AbtPages.ISMS);
            Assert.True(AbtDriver.IsmsPage.isAt());
       

        }


        // [Fact(DisplayName ="Should Click on Reputational Capital Database (AGI Website)")]
        public void Should_click_ReputationalCapitalDB()
        {
            AbtDriver.HomePage.Go();
            AbtDriver.TopNavigation.ToolsDropdown.goTo(AbtPages.ReputationalCapitalDB);
            // Assert.IsTrue(AbtDriver.ReputationalCapDBPage.isAt());
        }

        //  [Fact(DisplayName ="Should Click on Rep Cap Planner (AGI Website) ")]
        public void Should_click_RepCapPlanner()
        {
            AbtDriver.HomePage.Go();
            AbtDriver.TopNavigation.ToolsDropdown.goTo(AbtPages.RepCapPlanner);
            // Assert.IsTrue(AbtDriver.RepCapPlannerPage.isAt());


        }

      //  [Fact(DisplayName ="Should Go to Today I Learned...")]
        public void Should_Goto_Today_I_Learned()
        {
            Driver.init();
            AbtDriver.HomePage.Go();
            AbtDriver.HomePage.Goto(homelinks.todayILearned);
           // Assert.True(AbtDriver.TodayILearnedPage.isAt());


        }

      //  [Fact(DisplayName ="Should Click on News -> See More")]
        public void Should_Click_On_News()
        {
            Driver.init();
            AbtDriver.HomePage.Go();
            AbtDriver.HomePage.Goto(homelinks.News);
        //    Assert.True(AbtDriver.NewsPage.isAt());

        }

      //  [Fact(DisplayName ="Should Click on Abt Events")]
        public void Should_Click_On_AbtEvents()
        {
            Driver.init();
            AbtDriver.HomePage.Go();
            AbtDriver.HomePage.Goto(homelinks.AbtEvents);
        }

       // [Fact(DisplayName ="Should Go to About Abt Page and Verify Left and Top Navigation")]
        public void Should_Click_On_About_Abt_VerifyLeftNav_and_TopNav()
        {
            Driver.init();
            AbtDriver.HomePage.Go();
            AbtDriver.HomePage.Goto(homelinks.aboutAbt);
        //    Assert.True(AbtDriver.AboutAbtPage.isAt());
        //    Assert.True(AbtDriver.TopNavigation.isActive());
         //   Assert.True(AbtDriver.AboutAbtPage.LeftNavigation.isActive());
                                 
        }

       // [Fact(DisplayName = "Should open any document from About Page")]
        public void Should_Open_Document_From_AboutPage()
        {
            Driver.init();
            AbtDriver.HomePage.Go();
            AbtDriver.HomePage.Goto(homelinks.aboutAbt);
        //    Assert.True(AbtDriver.AboutAbtPage.DocumentOpensProperly());

        }

    

      //  [Fact(DisplayName = "Should Open Word Document Online for Reading")]
        public void A_Should_Open_Word_Document_For_Reading()
        {
            Driver.RemoteInitDavidsPc(Browser.IE);
            AbtDriver.HomePage.Go();
            AbtDriver.TopNavigation.Goto(homelinks.Projects);
            AbtDriver.ProjectsPage.Goto(projectslinks.MS2013upgrade);
            AbtDriver.MS2013UpgradePage.DocumentNavigation.Goto(MS2013Links.Testing);
            AbtDriver.MS2013UpgradePage.DocumentNavigation.Goto(MS2013Links.QA_AuthoringIssueReplication);
            AbtDriver.MS2013UpgradePage.DocumentNavigation.OpenDocumentOnline(MS2013documents.QA_ReadinessChecklist_v4,documentType.Word);
      

        }

      

     //   [Fact(DisplayName ="Desktop Apps")]
        public void Should_Handle_Desktop_Apps()
        {
            AutoItX3 autoit = new AutoItX3();
            autoit.WinActivate("Sample AV metrics - Microsoft PowerPoint");
            autoit.WinWaitActive("Sample AV metrics - Microsoft PowerPoint", "", 20);
            Thread.Sleep(2000);
            autoit.ControlClick("Sample AV metrics - Microsoft PowerPoint", "", "NetUIHWND1", "LEFT", 1, 177, 76);
            Thread.Sleep(500);
            autoit.ControlSend("Sample AV metrics - Microsoft PowerPoint", "Slide", "paneClassDC1", "Adding this line from Word Desktop Client At: " + DateTime.Now);
            Thread.Sleep(2000);
            autoit.ControlClick("Sample AV metrics - Microsoft PowerPoint", "", "NetUIHWND1", "LEFT", 1, 35, 19); //Click on Save Btn
            Thread.Sleep(5000);
            autoit.WinClose("Sample AV metrics - Microsoft PowerPoint", "");                                                                                             //  autoit.ControlSend("Sample AV metrics - Microsoft PowerPoint","",)

        }






    }
}
