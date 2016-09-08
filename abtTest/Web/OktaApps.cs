using System;
using Xunit;
using AbtFramework;
using AbtFramework.Utils_Classes;

namespace abtTest.Web
{

    public class OktaApps
    {

       // [Fact(DisplayName = "Should Go to WeSpire Home Page using Okta")]
        public void Should_Go_to_WeSpire_Test_HomePage() //no access
        {
            Driver.RemoteInit();
            AbtDriver.WeSpireHomePage.Go(WebEnvironment.TestEnvironment);
            Assert.True(AbtDriver.WeSpireHomePage.isAt());
            Driver.Close();

        }

     //   [Fact(DisplayName = "Should Go to WeSpire Home Page using Simieo")]
        public void Should_Go_to_WeSpire_Production_HomePage() //Done
        {
            Driver.RemoteInit();
            AbtDriver.WeSpireHomePage.Go(WebEnvironment.ProductionEnvironment);
            Assert.True(AbtDriver.WeSpireHomePage.isAt());
            Driver.Close();
        }

       // [Fact(DisplayName = "Should Go to Ebsco UAT Home Page")]
        public void Should_Go_to_Ebsco_Test_HomePage()
        {
            Driver.RemoteInitDavidsPc(Browser.IENoNativeEvents);
            AbtDriver.EbscoHomePage.Go(WebEnvironment.TestEnvironment);
            Assert.True(AbtDriver.EbscoHomePage.isAt());

        }


     //   [Fact(DisplayName = "Should Go to Success Factor UAT Home Page")]
        public void Should_Go_to_SuccessFactor_Test_HomePage()
        {
            Driver.init(Browser.IE);
            AbtDriver.SuccessFactorHomePage.Go(WebEnvironment.TestEnvironment);

        }

      //  [Fact(DisplayName = "Should Go to Success Factor Production Home Page")]
        public void Should_Go_to_SuccessFactor_Production_HomePage()
        {
            Driver.init(Browser.IE);
            AbtDriver.SuccessFactorHomePage.Go(WebEnvironment.ProductionEnvironment);
        }

         //Wants to go Trough AGI???
      //  [Fact(DisplayName = "Should Go to AbtKnowledge Production Home Page")]
        public void Should_Go_to_AbtKnowledge_Production_HomePage()
        {
            Driver.RemoteInitDavidsPc(Browser.IE);
            AbtDriver.AbtKnowledgePage.Go();
           Assert.True(AbtDriver.AbtKnowledgePage.IsUserLoggedIn());
        }


     //   [Fact(DisplayName = "Should Go to BCD Travel Portal Production Home Page")]
        public void Should_Go_to_BCD_Travel_Production_HomePage()
        {
            Driver.init(Browser.IE);
            AbtDriver.AbtTravelPage.Go();
            Assert.True(AbtDriver.AbtTravelPage.isUserLoggedIn());
        }


      [Fact(DisplayName = "Should Go to Concur UAT Home Page using Okta")]
        public void Should_Go_to_Concur_Testing_HomePage()
        {
            Driver.RemoteInit();
            AbtDriver.ConcurHomePage.Go();
             Assert.True(AbtDriver.ConcurHomePage.isUserLoggedIn());
            Driver.Close();

        }

        [Fact(DisplayName = "Should Go to Concur Production Home Page using Simieo")]
        public void Should_Go_to_Concur_Production_HomePage()
        {
            Driver.RemoteInit();
            AbtDriver.HomePage.Go();
            AbtDriver.TopNavigation.HoverOverTools();
            AbtDriver.AbtTravelPage.HoverOverAbtTravelOnline();
            AbtDriver.AbtTravelPage.AbtTravelOnlineDropdown.BookOrSearchUsTravel();
            
            Assert.True(AbtDriver.ConcurHomePage.isUserLoggedIn());
            Driver.Close();

        }

        //   [Fact(DisplayName = "Should Go to Right Find UAT Home Page")]
        public void Should_Go_to_RightFind_Test_HomePage()
        {
            Driver.init(Browser.IE);
         // AbtDriver.RightFindHomePage.Go(WebEnvironment.TestEnvironment);

        }

     //   [Fact(DisplayName = "Should Go to Right Find Production Home Page")]
        public void Should_Go_to_RightFind_Production_HomePage()
        {
            Driver.init(Browser.IE);
          //  AbtDriver.RightFindHomePage.Go(WebEnvironment.ProductionEnvironment);
        }

      //  [Fact(DisplayName = "Should Go to Oracle Production Home Page")]
        public void Should_Go_to_Oracle_Production_HomePage()
        {
            Driver.init(Browser.IENoNativeEvents);
            AbtDriver.HomePage.Go();
            AbtDriver.HomePage.QuickLinks.GoTo(quickLinks.Oracle);
            Assert.True(AbtDriver.OraclePage.isAt());

        }

      //  [Fact(DisplayName = "Should Go to Rep Cap Database Production Home Page")]
        public void Should_Go_to_RepCapDatabase_Production_HomePage()
        {
            Driver.init(Browser.IE);
            AbtDriver.ReputationalCapDBPage.Go();
            Assert.True(AbtDriver.ReputationalCapDBPage.isUserLoggedIn());
        }

     //   [Fact(DisplayName = "Should Go to Rep Cap Planner Production Home Page")]
        public void Should_Go_to_RepCapPlanner_Production_HomePage()
        {
            Driver.init(Browser.IE);
            AbtDriver.RepCapPlannerPage.Go();
            Assert.True(AbtDriver.RepCapPlannerPage.isUserLoggedIn());
        }

       // [Fact(DisplayName = "Should Go to Service Now UAT Home Page")]
        public void Should_Go_to_ServiceNow_UAT_HomePage()
        {
            Driver.RemoteInitDavidsPc(Browser.IENoNativeEvents);
            AbtDriver.ServiceNowHomepage.Go(WebEnvironment.TestEnvironment);
            Assert.True(AbtDriver.ServiceNowHomepage.isUserLoggedIn());
        }

     //  [Fact(DisplayName = "Should Go to Service Now Production Home Page")]
        public void Should_Go_to_ServiceNow_Production_HomePage()
        {
            Driver.RemoteInitDavidsPc(Browser.IENoNativeEvents);
            AbtDriver.ServiceNowHomepage.Go(WebEnvironment.ProductionEnvironment);
            Assert.True(AbtDriver.ServiceNowHomepage.isUserLoggedIn());
        }

     //   [Fact(DisplayName = "Should Go to WebEx UAT Home Page")]
        public void Should_Go_to_WebEx_Test_HomePage()
        {
            Driver.init(Browser.IE);
            AbtDriver.WebExPage.Go(WebEnvironment.TestEnvironment);
            Assert.True(AbtDriver.WebExPage.isUserLoggedIn());

        }

     //   [Fact(DisplayName = "Should Go to WebEx Production Home Page")]
        public void Should_Go_to_WebEx_Production_HomePage()
        {
            Driver.init(Browser.IE);
            AbtDriver.WebExPage.Go(WebEnvironment.ProductionEnvironment);
            Assert.True(AbtDriver.WebExPage.isUserLoggedIn());
        }





    }
}
