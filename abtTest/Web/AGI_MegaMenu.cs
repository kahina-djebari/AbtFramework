using System;
using Xunit;
using AbtFramework;
using AbtFramework.Utils_Classes;

namespace abtTest.Web
{
    
    public class AGI_MegaMenu
    {
       /// <summary>
       /// Checks the Tools & Resources Section; Tools Subsection
       /// </summary>
     //   [Fact(DisplayName = "Should Get Outlook Home Page Response Time")]
        public void Should_Go_To_OWA_Through_AGI()
        {
            SeleniumDriver.init(Browser.IE);

            AbtPages.AgiHomePage.Go();
            AbtPages.AgiTopNavigation.ToolsDropdown.GoTo_OWA();
            Assert.True(AbtPages.OutlookWebPage.IsAt());
            SeleniumDriver.Quit();
        }


      //  [Fact(DisplayName = "Should Get Oracle Home Page Response Time")]
        public void Should_Go_To_Oracle_Through_AGI()
        {
            SeleniumDriver.init(Browser.RemoteSofianesIE);
            AbtPages.AgiHomePage.Go();
            AbtPages.AgiTopNavigation.ToolsDropdown.GoTo_Oracle();
            Assert.True(AbtPages.OraclePage.isAt());
            SeleniumDriver.Quit();

        }

      //  [Fact(DisplayName = "Should Get SuccessFactors Home Page Response Time")] //from Agi i dont have access to Successfactor
        public void Should_Go_To_Atlas_Through_AGI()
        {
            SeleniumDriver.init(Browser.IE);
            AbtPages.AgiHomePage.Go();
            AbtPages.AgiTopNavigation.ToolsDropdown.GoToAtlas();
            Assert.True(AbtPages.SuccessFactorHomePage.isAt());
            SeleniumDriver.Quit();

        }

      //  [Fact(DisplayName = "Should Get AbtKnowledge Home Page Response Time")]
        public void Should_Go_To_AbtKnowledge_Through_AGI()
        {
            SeleniumDriver.init(Browser.IE);
            AbtPages.AgiHomePage.Go();
            AbtPages.AgiTopNavigation.ToolsDropdown.GoToAbtKnowledge();
            Assert.True(AbtPages.AbtKnowledgePage.isAt());
            SeleniumDriver.Quit();

        }

     //   [Fact(DisplayName = "Should Get Concur Home Page Response Time")] //i dont have access to concur through abttravel
        public void Should_Get_Concur_HomePage_Response_Time()
        {
            SeleniumDriver.init(Browser.IE);
            AbtPages.AgiHomePage.Go();
            AbtPages.AgiTopNavigation.ToolsDropdown.GoTo_Concur();
            AbtPages.AbtTravelPage.HoverOverAbtTravelOnline();
            AbtPages.AbtTravelPage.AbtTravelOnlineDropdown.BookOrSearchUsTravel();
        }

     //   [Fact(DisplayName = "Should Get ISMS Home Page Response Time")]
        public void Should_Get_ISMS_HomePage_Response_Time()
        {
            SeleniumDriver.init(Browser.IE);
            AbtPages.AgiHomePage.Go();
            AbtPages.AgiTopNavigation.ToolsDropdown.GoToISMS();
            Assert.True(AbtPages.IsmsPage.isAt());
        }

       // [Fact(DisplayName = "Should Get AbtExchange Home Page Response Time")]
        public void Should_Get_AbtExchange_Response_Time()
        {
            SeleniumDriver.init(Browser.IE);
            AbtPages.AgiHomePage.Go();
            AbtPages.AgiTopNavigation.ToolsDropdown.GoToAbtExchange();
        }

      //  [Fact(DisplayName = "Should Get Reputational Capital Database Home Page Response Time")]
        public void Should_Get_RepCapDB_Response_Time()
        {
            SeleniumDriver.init(Browser.IE);
            AbtPages.AgiHomePage.Go();
            AbtPages.AgiTopNavigation.ToolsDropdown.GoToRepCapDB();
            Assert.True(AbtPages.AbtKnowledgePage.isAtRepCapDB());
        }

//        [Fact(DisplayName = "Should Get RepCap Planner Home Page Response Time")]
        public void Should_Get_RepCapPlanner_Response_Time()
        {
            SeleniumDriver.init(Browser.IE);
            AbtPages.AgiHomePage.Go();
            AbtPages.AgiTopNavigation.ToolsDropdown.GoToRepCap_Planner();
            Assert.True(AbtPages.RepCapPlannerPage.isAt());
        }



        /// <summary>
        /// Checks the Tools & Resources Section; Service Centers Subsection
        /// </summary>

     




    }
}
