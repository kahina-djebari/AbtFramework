using System;
using Xunit;
using AbtFramework;
using AbtFramework.Utils_Classes;
using Microsoft.Win32;
using AbtFramework.AutoIT;

namespace abtTest.Web
{
    
    public class AGI_MegaMenu:IDisposable
    {

        /// <summary>
        /// Checks Top Navigation Links on AGI
        /// </summary>

      //  [Fact(DisplayName ="Should Go To AGI Top Navigation -> Projects")]
        public void Should_Go_To_Projects()
        {
            SeleniumDriver.init(Browser.RemoteDavidIE);
            AbtPages.AgiHomePage.Go();
            AbtPages.AgiTopNavigation.GoToProjects();
            Assert.True(AbtPages.ProjectsPage.IsAt());

        }

      //  [Fact(DisplayName = "Should Go To AGI Top Navigation -> Home")]
        public void Should_Go_To_Home()
        {
            SeleniumDriver.init(Browser.RemoteDavidIE);
            AbtPages.AgiHomePage.Go();
            AbtPages.AgiTopNavigation.GoHome();
            AbtPages.AgiHomePage.isAt();
            Console.WriteLine("Home Link Opened Succesfully");
        }

      //  [Fact(DisplayName = "Should Go To AGI Top Navigation -> Home->About Abt")]
        public void Should_Go_To_AboutAbt()
        {
            SeleniumDriver.init(Browser.RemoteDavidIE);
            AbtPages.AgiHomePage.Go();
            AbtPages.AgiTopNavigation.HomeDropdown.GoTo_AboutABt();
            Assert.True(AbtPages.AgiAboutAbt.IsAt());

        }

       // [Fact(DisplayName = "Should Go To AGI Top Navigation -> Home-> Departments")]
        public void Should_Go_To_Departments()
        {
            SeleniumDriver.init(Browser.RemoteDavidIE);
            AbtPages.AgiHomePage.Go();
            AbtPages.AgiTopNavigation.HomeDropdown.GoTo_Departments();
            Assert.True(AbtPages.AgiDepartments.IsAt());
        }

      //  [Fact(DisplayName = "Should Go To AGI Top Navigation -> Home->Initiatives")]
        public void Should_Go_To_Initiatives()
        {
            SeleniumDriver.init(Browser.RemoteDavidIE);
            AbtPages.AgiHomePage.Go();
            AbtPages.AgiTopNavigation.HomeDropdown.GoTo_Initiatives();
            Assert.True(AbtPages.AgiInitiatives.IsAt());
        }

       // [Fact(DisplayName = "Should Go To AGI Top Navigation -> Home->Divisions")]
        public void Should_Go_To_Divisions()
        {
            SeleniumDriver.init(Browser.RemoteDavidIE);
            AbtPages.AgiHomePage.Go();
            AbtPages.AgiTopNavigation.HomeDropdown.GoTo_Divisions();
            Assert.True(AbtPages.AgiDivisions.IsAt());
        }

       // [Fact(DisplayName = "Should Go To AGI Top Navigation -> Home->Subsidiaries")]
        public void Should_Go_To_Subsidiaries()
        {
            SeleniumDriver.init(Browser.RemoteDavidIE);
            AbtPages.AgiHomePage.Go();
            AbtPages.AgiTopNavigation.HomeDropdown.GoTo_Subsidaries();
            Assert.True(AbtPages.AgiSubsidaries.IsAt());
        }

       // [Fact(DisplayName = "Should Go To AGI Top Navigation -> Home -> Abt Strategy")]
        public void Should_Go_To_AbtStrategy()
        {
            SeleniumDriver.init(Browser.RemoteDavidIE);
            AbtPages.AgiHomePage.Go();
            AbtPages.AgiTopNavigation.HomeDropdown.GoTo_AbtStrategy();
            Assert.True(AbtPages.AgiAbtStrategy.IsAt());
        }
      //  [Fact(DisplayName = "Should Go To AGI Top Navigation -> Home -> Abt Values")]
        public void Should_Go_To_AbtValues()
        {
            SeleniumDriver.init(Browser.RemoteDavidIE);
            AbtPages.AgiHomePage.Go();
            AbtPages.AgiTopNavigation.HomeDropdown.GoTo_AbtValues();
            Assert.True(AbtPages.AgiAbtValues.IsAt());
        }
      //  [Fact(DisplayName = "Should Go To AGI Top Navigation -> Home -> Agi Help")]
        public void Should_Go_To_AgiHelp()
        {
            SeleniumDriver.init(Browser.RemoteDavidIE);
            AbtPages.AgiHomePage.Go();
            AbtPages.AgiTopNavigation.HomeDropdown.GoTo_AgiHelp();
            Assert.True(AbtPages.AgiHelpPage.IsAt());

        }
        //[Fact(DisplayName = "Should Go To AGI Top Navigation -> Home -> Communities")]
        public void Should_Go_To_Communities()
        {
            SeleniumDriver.init(Browser.RemoteDavidIE);
            AbtPages.AgiHomePage.Go();
            AbtPages.AgiTopNavigation.HomeDropdown.GoTo_Communities();
            Assert.True(AbtPages.AgiCommunities.IsAt());
        }
     //   [Fact(DisplayName = "Should Go To AGI Top Navigation -> Home -> Employee Advisory Council")]
        public void Should_Go_To_EAC()
        {
            SeleniumDriver.init(Browser.RemoteDavidIE);
            AbtPages.AgiHomePage.Go();
            AbtPages.AgiTopNavigation.HomeDropdown.GoTo_EAC();
            Assert.True(AbtPages.AgiEAC.IsAt());
        }


    //    [Fact(DisplayName = "Should Go To AGI Top Navigation -> News")]
        public void Should_Go_To_News()
        {
            SeleniumDriver.init(Browser.RemoteDavidIE);
            AbtPages.AgiHomePage.Go();
            AbtPages.AgiTopNavigation.GoTo_News();
            Assert.True(AbtPages.AgiNews.IsAt());
        }

     //   [Fact(DisplayName = "Should Go To AGI Top Navigation ->News-> Announcements")]
        public void Should_Go_To_Announcements()
        {
            SeleniumDriver.init(Browser.RemoteDavidIE);
            AbtPages.AgiHomePage.Go();
            AbtPages.AgiTopNavigation.NewsDropdown.GoTo_Announcements();
            Assert.True(AbtPages.AgiAnnouncements.IsAt());
        }

      //  [Fact(DisplayName = "Should Go To AGI Top Navigation -> News->Events")]
        public void Should_Go_To_Events()
        {
            SeleniumDriver.init(Browser.RemoteDavidIE);
            AbtPages.AgiHomePage.Go();
            AbtPages.AgiTopNavigation.NewsDropdown.GoTo_Events();
            Assert.True(AbtPages.AgiEvents.IsAt());

        }

      ////  [Fact(DisplayName = "Should Go To AGI Top Navigation ->News-> News Archive")]
        public void Should_Go_To_NewsArchive()
        {
            SeleniumDriver.init(Browser.RemoteDavidIE);
            AbtPages.AgiHomePage.Go();
            AbtPages.AgiTopNavigation.NewsDropdown.GoTo_NewsArchive();
            Assert.True(AbtPages.AgiNewsArchive.IsAt());
        }


       // [Fact(DisplayName = "Should Go To AGI Top Navigation -> Proporsals")]
        public void Should_Go_To_Proporsals()
        {
            SeleniumDriver.init(Browser.RemoteDavidIE);
            AbtPages.AgiHomePage.Go();
            AbtPages.AgiTopNavigation.GoToProporsals();
            Assert.True(AbtPages.AgiProposals.IsAt());

        }


        /// <summary>
        /// Checks the Tools & Resources Section; Tools Subsection
        /// </summary>
       // [Fact(DisplayName = "Should Get Outlook Home Page Response Time")]
        public void Should_Go_To_OWA_Through_AGI()
        {
            SeleniumDriver.init(Browser.RemoteDavidIE);

            AbtPages.AgiHomePage.Go();
            AbtPages.AgiTopNavigation.ToolsDropdown.GoTo_OWA();
            Assert.True(AbtPages.OutlookWebPage.IsAt());
            SeleniumDriver.Quit();
        }


     //  [Fact(DisplayName = "Should Get Oracle Home Page Response Time")]
        public void Should_Go_To_Oracle_Through_AGI()
        {
            SeleniumDriver.init(Browser.RemoteDavidIE);
            AbtPages.AgiHomePage.Go();
            AbtPages.AgiTopNavigation.ToolsDropdown.GoTo_Oracle();
            Assert.True(AbtPages.OraclePage.isAt());
            SeleniumDriver.Quit();

        }

      //  [Fact(DisplayName = "Should Get SuccessFactors Home Page Response Time")] //from Agi i dont have access to Successfactor
        public void Should_Go_To_Atlas_Through_AGI()
        {
            SeleniumDriver.init(Browser.RemoteDavidIE);
            AbtPages.AgiHomePage.Go();
            AbtPages.AgiTopNavigation.ToolsDropdown.GoToAtlas();
            Assert.True(AbtPages.SuccessFactorHomePage.isAt());
            SeleniumDriver.Quit();

        }

      //  [Fact(DisplayName = "Should Get AbtKnowledge Home Page Response Time")]
        public void Should_Go_To_AbtKnowledge_Through_AGI()
        {
            SeleniumDriver.init(Browser.RemoteDavidIE);
            AbtPages.AgiHomePage.Go();
            AbtPages.AgiTopNavigation.ToolsDropdown.GoToAbtKnowledge();
            Assert.True(AbtPages.AbtKnowledgePage.isAt());
            SeleniumDriver.Quit();

        }

        [Fact(DisplayName = "Should Get Concur Home Page Response Time")] //i dont have access to concur through abttravel
        public void Should_Get_Concur_HomePage_Response_Time()
        {
            SeleniumDriver.init(Browser.RemoteSofianesIE);
            AbtPages.AgiHomePage.Go();
            AbtPages.AgiTopNavigation.ToolsDropdown.GoTo_Concur();
            AbtPages.AbtTravelPage.HoverOverAbtTravelOnline();
            AbtPages.AbtTravelPage.AbtTravelOnlineDropdown.BookOrSearchUsTravel();
        }

        //[Fact(DisplayName = "Should Get ISMS Home Page Response Time")]
        public void Should_Get_ISMS_HomePage_Response_Time()
        {
            SeleniumDriver.init(Browser.RemoteDavidIE);
            AbtPages.AgiHomePage.Go();
            AbtPages.AgiTopNavigation.ToolsDropdown.GoToISMS();
            Assert.True(AbtPages.IsmsPage.isAt());
        }

     //   [Fact(DisplayName = "Should Get AbtExchange Home Page Response Time")]
        public void Should_Get_AbtExchange_Response_Time()
        {
            SeleniumDriver.init(Browser.RemoteDavidIE);
            AbtPages.AgiHomePage.Go();
            AbtPages.AgiTopNavigation.ToolsDropdown.GoToAbtExchange();
        }

       // [Fact(DisplayName = "Should Get Reputational Capital Database Home Page Response Time")]
        public void Should_Get_RepCapDB_Response_Time()
        {
            SeleniumDriver.init(Browser.RemoteDavidIE);
            AbtPages.AgiHomePage.Go();
            AbtPages.AgiTopNavigation.ToolsDropdown.GoToRepCapDB();
            Assert.True(AbtPages.AbtKnowledgePage.isAtRepCapDB());
        }

      //  [Fact(DisplayName = "Should Get RepCap Planner Home Page Response Time")]
        public void Should_Get_RepCapPlanner_Response_Time()
        {
            SeleniumDriver.init(Browser.RemoteDavidIE);
            AbtPages.AgiHomePage.Go();
            AbtPages.AgiTopNavigation.ToolsDropdown.GoToRepCap_Planner();
            Assert.True(AbtPages.RepCapPlannerPage.isAt());
        }



        /// <summary>
        /// Checks the Tools & Resources Section; Service Centers Subsection
        /// </summary>

      //  [Fact(DisplayName ="Should Go To Tools&Resources -> Service Centers-> AbtLearn")]
        public void Should_Go_To_AbtLearn()
        {
            SeleniumDriver.init(Browser.RemoteDavidIE);
            AbtPages.AgiHomePage.Go();
            AbtPages.AgiTopNavigation.ToolsDropdown.GoToAbtLearn();
           Assert.True(AbtPages.AgiAbtLearnPage.IsAt());

        }

      //  [Fact(DisplayName = "Should Go To Tools&Resources -> Service Centers-> Business Development")]
        public void Should_Go_To_BusinessDevelopment()
        {
            SeleniumDriver.init(Browser.RemoteDavidIE);
            AbtPages.AgiHomePage.Go();
            AbtPages.AgiTopNavigation.ToolsDropdown.GoToBusinessDevelopment();
            Assert.True(AbtPages.AgiBusinessDevelopmentPage.IsAt());

        }

      //  [Fact(DisplayName = "Should Go To Tools&Resources -> Service Centers-> Client Technology Center")]
        public void Should_Go_To_CTC()
        {
            SeleniumDriver.init(Browser.RemoteDavidIE);
            AbtPages.AgiHomePage.Go();
            AbtPages.AgiTopNavigation.ToolsDropdown.GoTo_CTC();
            Assert.True(AbtPages.AgiCTCPage.IsAt());

        }


      //  [Fact(DisplayName = "Should Go To Tools&Resources -> Service Centers-> Contract Operations")]
        public void Should_Go_To_ContractOperations()
        {
            SeleniumDriver.init(Browser.RemoteDavidIE);
            AbtPages.AgiHomePage.Go();
            AbtPages.AgiTopNavigation.ToolsDropdown.GoTo_ContractOperations();
            Assert.True(AbtPages.AgiContractOperationsPage.IsAt());

        }


       // [Fact(DisplayName = "Should Go To Tools&Resources -> Service Centers-> Creative Services")]
        public void Should_Go_To_CreativeServices()
        {
            SeleniumDriver.init(Browser.RemoteDavidIE);
            AbtPages.AgiHomePage.Go();
            AbtPages.AgiTopNavigation.ToolsDropdown.GoTo_CreativeServices();
            Assert.True(AbtPages.AgiCreativeServices.IsAt());

        }


       // [Fact(DisplayName = "Should Go To Tools&Resources -> Service Centers-> Finance")]
        public void Should_Go_To_Finance()
        {
            SeleniumDriver.init(Browser.RemoteDavidIE);
            AbtPages.AgiHomePage.Go();
            AbtPages.AgiTopNavigation.ToolsDropdown.GoTo_Finance();
            Assert.True(AbtPages.AgiFinance.IsAt());

        }

      //  [Fact(DisplayName = "Should Go To Tools&Resources -> Service Centers-> HR Service Center")]
        public void Should_Go_To_HR_ServiceCenter()
        {
            SeleniumDriver.init(Browser.RemoteDavidIE);
            AbtPages.AgiHomePage.Go();
            AbtPages.AgiTopNavigation.ToolsDropdown.GoTo_HRServiceCenter();
            Assert.True(AbtPages.AgiHRServiceCenter.IsAt());

        }

        //[Fact(DisplayName = "Should Go To Tools&Resources -> Service Centers-> IT Service Center")]
        public void Should_Go_To_IT_ServiceCenter()
        {
            SeleniumDriver.init(Browser.RemoteDavidIE);
            AbtPages.AgiHomePage.Go();
            AbtPages.AgiTopNavigation.ToolsDropdown.GoTo_ITServiceCenter();
            Assert.True(AbtPages.AgiITServiceCenter.IsAt());

        }


        //[Fact(DisplayName = "Should Go To Tools&Resources -> Service Centers-> Office Services")]
        public void Should_Go_To_OfficeServices()
        {
            SeleniumDriver.init(Browser.RemoteDavidIE);
            AbtPages.AgiHomePage.Go();
            AbtPages.AgiTopNavigation.ToolsDropdown.GoTo_OfficeServices();
            Assert.True(AbtPages.AgiOfficeServices.IsAt());

        }

        //[Fact(DisplayName = "Should Go To Tools&Resources -> Service Centers-> Reputational Capital")]
        public void Should_Go_To_ReputationalCapital()
        {
            SeleniumDriver.init(Browser.RemoteDavidIE);
            AbtPages.AgiHomePage.Go();
            AbtPages.AgiTopNavigation.ToolsDropdown.GoTo_ReputationalCapital();
            Assert.True(AbtPages.AgiReputationalCapital.IsAt());

        }

       // [Fact(DisplayName = "Should Go To Tools&Resources -> Service Centers-> Travel")]
        public void Should_Go_To_Travel()
        {
            SeleniumDriver.init(Browser.RemoteDavidIE);
            AbtPages.AgiHomePage.Go();
            AbtPages.AgiTopNavigation.ToolsDropdown.GoTo_Travel();
            Assert.True(AbtPages.AgiTravelPage.IsAt());

        }


        /// <summary>
        /// Checks the Tools & Resources Section; Libraries Subsection
        /// </summary>
    //    [Fact(DisplayName = "Should Go to Tools&Resources -> Libraries-> Abt Research Library")]
        public void Should_Go_To_AbtResearchLibrary()
        {
            SeleniumDriver.init(Browser.RemoteDavidIE);
            AbtPages.AgiHomePage.Go();
            AbtPages.AgiTopNavigation.ToolsDropdown.GoTo_AbtResearchLibrary();
            Assert.True(AbtPages.AgiAbtResearch.IsAt());
        }

    //    [Fact(DisplayName = "Should Go to Tools&Resources -> Libraries-> Form Library")]
        public void Should_Go_To_FormLibrary()
        {
            SeleniumDriver.init(Browser.RemoteDavidIE);
            AbtPages.AgiHomePage.Go();
            AbtPages.AgiTopNavigation.ToolsDropdown.GoTo_FormLibrary();
            Assert.True(AbtPages.AgiFormLibrary.IsAt());
        }


      //  [Fact(DisplayName = "Should Go to Tools&Resources -> Libraries-> Image Libraries")]
        public void Should_Go_To_ImageLibraries()
        {
            SeleniumDriver.init(Browser.RemoteDavidIE);
            AbtPages.AgiHomePage.Go();
            AbtPages.AgiTopNavigation.ToolsDropdown.GoTo_ImageLibraries();
            Assert.True(AbtPages.Agi_ImageLibraries.IsAt());
        }


      //  [Fact(DisplayName = "Should Go to Tools&Resources -> Libraries-> Policy Library")]
        public void Should_Go_To_PolicyLibrary()
        {
            SeleniumDriver.init(Browser.RemoteDavidIE);
            AbtPages.AgiHomePage.Go();
            AbtPages.AgiTopNavigation.ToolsDropdown.GoTo_PolicyLibrary();
            Assert.True(AbtPages.Agi_PolicyLibraryPage.IsAt());
        }

     //   [Fact(DisplayName = "Should Go to Tools&Resources -> Libraries-> Proposal Resume Library")]
        public void Should_Go_To_ProposalLibrary()
        {
            SeleniumDriver.init(Browser.RemoteDavidIE);
            AbtPages.AgiHomePage.Go();
            AbtPages.AgiTopNavigation.ToolsDropdown.GoTo_ProposalLibrary();
            Assert.True(AbtPages.Agi_ProposalLibrary.IsAt());
        }

      //  [Fact(DisplayName = "Should Go to Tools&Resources -> Libraries-> Expertise Centers")]
        public void Should_Go_To_ExpertiseCenters()
        {
            SeleniumDriver.init(Browser.RemoteDavidIE);
            AbtPages.AgiHomePage.Go();
            AbtPages.AgiTopNavigation.ToolsDropdown.GoTo_ExpertiseCenters();
            Assert.True(AbtPages.Agi_ExpertiseCenter.IsAt());
        }

       // [Fact(DisplayName = "Should Go to Tools&Resources -> Libraries-> Resources")]
        public void Should_Go_To_Resources()
        {
            SeleniumDriver.init(Browser.RemoteDavidIE);
            AbtPages.AgiHomePage.Go();
            AbtPages.AgiTopNavigation.ToolsDropdown.GoTo_Resources();
            Assert.True(AbtPages.ToolsAndResourcesPage.isAt());
            Console.WriteLine("Resources Link Opened Succesfully");
            
        }

       // [Fact(DisplayName = "Should Go to Tools&Resources -> Libraries-> Emergency Communications")]
        public void Should_Go_To_EmergencyComunications()
        {
            SeleniumDriver.init(Browser.RemoteDavidIE);
            AbtPages.AgiHomePage.Go();
            AbtPages.AgiTopNavigation.ToolsDropdown.GoTo_EmergencyCommunications();
            Assert.True(AbtPages.AgiEmergencyCommunications.isAt());
         
        }

        public void Dispose()
        {
            SeleniumDriver.Quit();
        }
    }
}
