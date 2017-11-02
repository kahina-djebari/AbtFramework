using System;
using Xunit;
using AbtFramework;
using AbtFramework.Utils_Classes;
//using Xunit.Abstractions;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System.Threading;
using AbtFramework.AutoIT;
using AbtFramework.SeleniumUtils;

namespace abtTest.Web
{
    //TODO: Switch to feature/steps with spectflow
    /// <summary>
    /// DEV these test cases work they only need to be put in the specflow format
    /// Check the Features and Steps Folder.
    /// </summary>
   
    public class AGI:IDisposable
    {

        
        [Fact]
        public void Should_Click_Login_WebEx()
        {
            SeleniumDriver.init(Browser.IENoNativeEvents);
            AbtPages.WebExPage.Go(WebEnvironment.TestEnvironment);
      

        }

     [Fact(DisplayName ="Should Go to QuickLinks -> Oracle")]
        public void Should_Go_to_Quicklinks_Oracle()
        {
            SeleniumDriver.init(Browser.IENoNativeEvents);
            AbtPages.AgiHomePage.Go();
          //  AbtPages.AgiHomePage.QuickLinks.GoTo(quickLinks.Oracle);
            Assert.True(AbtPages.OraclePage.isAt());

        }

      [Fact(DisplayName ="Should Go to QuickLinks -> Staff Directory")]
        public void Should_GoTo_QuickLinks_Staff_Directory()
        {
            SeleniumDriver.init(Browser.IE);
            AbtPages.AgiHomePage.Go();
          //  AbtPages.AgiHomePage.QuickLinks.GoTo(quickLinks.Staff_Directory);
            Assert.True(AbtPages.StaffDirectoryPage.isAt());

        }

        [Fact(DisplayName ="Should Go to QuickLinks -> Forms Library")]
        public void Should_GoTo_QuickLinks_FormsLibrary()
        {
            SeleniumDriver.init();
            AbtPages.AgiHomePage.Go();
          //  AbtPages.AgiHomePage.QuickLinks.GoTo(quickLinks.FormsLibrary);
            Assert.True(AbtPages.FormsLibraryPage.isAt());

        }

        [Fact(DisplayName ="Should Go to QuickLinks -> Customize")]
        public void Should_GoTo_QuickLinks_Customize()
        {
            SeleniumDriver.init();
            AbtPages.AgiHomePage.Go();
           // AbtPages.AgiHomePage.QuickLinks.GoTo(quickLinks.Customize);
            Assert.True(AbtPages.CustomizeLinksPage.isAt());
        }


         [Fact (DisplayName ="Should Click on Abt Talent Learn and Support (AGI Website)")]
        public void Should_click_Abt_Talent_LearnAndSupport()
        { //successfactos <-
            SeleniumDriver.init(Browser.IE);
            AbtPages.AgiHomePage.Go();
            AbtPages.AgiTopNavigation.ToolsAndResources();
            AbtPages.ToolsAndResourcesPage.GoToAtlas();
           // Assert.True(AbtPages.AtlasPage.IsUserLoggedIn());


        }


       //   [Fact(DisplayName ="Should Click on ISMS (AGI Website)")]
        public void Should_click_ISMS()
        {
            SeleniumDriver.init(Browser.IENoNativeEvents);
            AbtPages.AgiHomePage.Go();
            AbtPages.AgiTopNavigation.ToolsAndResources();
            AbtPages.ToolsAndResourcesPage.GoToIsms();
            Assert.True(AbtPages.IsmsPage.IsUserLoggedIn());
       

        }


      //   [Fact(DisplayName ="Should Click on Reputational Capital Database (AGI Website)")]
        public void Should_click_ReputationalCapitalDB()
        {
            SeleniumDriver.init(Browser.IENoNativeEvents);
            AbtPages.AgiHomePage.Go();
            AbtPages.AgiTopNavigation.ToolsAndResources();
            AbtPages.ToolsAndResourcesPage.GoToRepCapDB();
            Assert.True(AbtPages.ReputationalCapDBPage.isUserLoggedIn());
            // Assert.IsTrue(AbtDriver.ReputationalCapDBPage.isAt());
        }



      //  [Fact(DisplayName ="Should Go to Today I Learned...")]
        public void Should_Goto_Today_I_Learned()
        {
            SeleniumDriver.init();
            AbtPages.AgiHomePage.Go();
            AbtPages.AgiHomePage.Goto(homelinks.todayILearned);
           // Assert.True(AbtDriver.TodayILearnedPage.isAt());


        }

      //  [Fact(DisplayName ="Should Click on News -> See More")]
        public void Should_Click_On_News()
        {
            SeleniumDriver.init();
            AbtPages.AgiHomePage.Go();
            AbtPages.AgiHomePage.Goto(homelinks.News);
        //    Assert.True(AbtDriver.NewsPage.isAt());

        }

      //  [Fact(DisplayName ="Should Click on Abt Events")]
        public void Should_Click_On_AbtEvents()
        {
            SeleniumDriver.init();
            AbtPages.AgiHomePage.Go();
            AbtPages.AgiHomePage.Goto(homelinks.AbtEvents);
        }

       // [Fact(DisplayName ="Should Go to About Abt Page and Verify Left and Top Navigation")]
        public void Should_Click_On_About_Abt_VerifyLeftNav_and_TopNav()
        {
            SeleniumDriver.init();
            AbtPages.AgiHomePage.Go();
            AbtPages.AgiHomePage.Goto(homelinks.aboutAbt);
        //    Assert.True(AbtDriver.AboutAbtPage.isAt());
        //    Assert.True(AbtDriver.TopNavigation.isActive());
         //   Assert.True(AbtDriver.AboutAbtPage.LeftNavigation.isActive());
                                 
        }

       // [Fact(DisplayName = "Should open any document from About Page")]
        public void Should_Open_Document_From_AboutPage()
        {
            SeleniumDriver.init();
            AbtPages.AgiHomePage.Go();
            AbtPages.AgiHomePage.Goto(homelinks.aboutAbt);
        //    Assert.True(AbtDriver.AboutAbtPage.DocumentOpensProperly());

        }

    

      //  [Fact(DisplayName = "Should Open Word Document Online for Reading")]
        public void A_Should_Open_Word_Document_For_Reading()
        {
            SeleniumDriver.RemoteInitDavidsPc(Browser.IE);
            AbtPages.AgiHomePage.Go();
            AbtPages.AgiTopNavigation.Goto(homelinks.Projects);
            AbtPages.ProjectsPage.Goto(projectslinks.MS2013upgrade);
            AbtPages.SharePointDocumentNavigation.Goto(MS2013Links.Testing);
            AbtPages.SharePointDocumentNavigation.Goto(MS2013Links.QA_AuthoringIssueReplication);
            AbtPages.SharePointDocumentNavigation.OpenDocumentOnline(MS2013documents.QA_ReadinessChecklist_v4,documentType.Word);
      

        }


        public void Dispose()
        {
            if(SeleniumDriver.DriverInstance!=null)
            SeleniumDriver.Quit();
        }
    }
}
