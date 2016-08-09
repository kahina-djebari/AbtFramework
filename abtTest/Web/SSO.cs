using System;
using AbtFramework;
using Xunit;
using Xunit.Abstractions;

namespace abtTest.Web
{
  
    public class AGI:IDisposable
    {
        

        //[TestInitialize]
        //public void Init()
        //{
        //    Driver.init();
        //}

        //[TestCleanup]
        //public void cleanUp()
        //{
        //    Driver.Close();
        //}
        public AGI()
        {
            Driver.init();
                   
        }              
       
       // [Fact(DisplayName ="Should Go to AGI Home Page")]
        public void Should_Goto_Homepage()
        {
            
            AbtDriver.HomePage.Go();
             
            Assert.True(AbtDriver.HomePage.isUserLoggedin());
          
        }

      //  [Fact]
        public void Should_Click_Login_WebEx()
        {
            AbtDriver.WebExPage.goTo();
            AbtDriver.WebExPage.Login();

        }

     //   [Fact]
        public void QuickLinks()
        {
            AbtDriver.HomePage.Go();
           AbtDriver.HomePage.QuickLinks.OracleLink();
            
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

       // [Fact(DisplayName ="Should click on Abt Knowledge (AGI Website)")]
        public void Should_click_AbtKnowledge()
        {
            AbtDriver.HomePage.Go();
            AbtDriver.TopNavigation.ToolsDropdown.goTo(AbtPages.AbtKnowledge);
            Assert.True(AbtDriver.AbtKnowledgePage.isAt(),"Couldn't get to Abt Knowledge Page");
          
        }

       //  [Fact(DisplayName ="Should click on Abt Travel (AGI Website)")]
        public void Should_click_AbtTravel()
        {
            AbtDriver.HomePage.Go();
            AbtDriver.TopNavigation.ToolsDropdown.goTo(AbtPages.AbtTravel);
           Assert.True(AbtDriver.AbtTravelPage.isAt());
        }

       //  [Fact(DisplayName ="Should Click on Oracle (AGI Website)")]
        public void Should_click_Oracle()
        {
            AbtDriver.HomePage.Go();
            AbtDriver.TopNavigation.ToolsDropdown.goTo(AbtPages.Oracle);
            Assert.True(AbtDriver.OraclePage.isAt()); //need to check if logged in currently i dont have access

        }

        //  [Fact(DisplayName ="Should Click on ISMS (AGI Website)")]
        public void Should_click_ISMS()
        {
            AbtDriver.HomePage.Go();
            AbtDriver.TopNavigation.ToolsDropdown.goTo(AbtPages.ISMS);
          //  Assert.IsTrue(AbtDriver.IsmsPage.isAt());

        }

       // [Fact(DisplayName ="Should Click on Outlook Web Access (AGI Website)")]
        public void Should_Open_OutlookWebAccess()
        {
            AbtDriver.HomePage.Go();
            AbtDriver.TopNavigation.ToolsDropdown.goTo(AbtPages.Outlook);
           Assert.True(AbtDriver.OutlookWebPage.isAt());

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

        public void Dispose()
        {
          //  Driver.Close();
        }
    }
}
