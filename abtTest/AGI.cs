using System;
using AbtFramework;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace abtTest
{
   [TestClass]
    public class AGI
    {
       
        [TestInitialize]
        public void Init()
        {
            Driver.init();
        }

        [TestCleanup]
        public void cleanUp()
        {
            Driver.Close();
        }
                       
       
        [TestMethod]
        public void Should_Goto_Homepage()
        {
            
            AbtDriver.HomePage.goTo();
           Assert.IsTrue(AbtDriver.HomePage.isAt());
          
        }

        [TestMethod]
        public void Should_click_ToolsAndResources()
        {
        
            AbtDriver.HomePage.goTo();
            AbtDriver.ToolsAndResourcesPage.goTo();
            Assert.IsTrue(AbtDriver.ToolsAndResourcesPage.isAt());

        }

        [TestMethod]
        public void Should_click_Abt_Talent_LearnAndSupport()
        {
            AbtDriver.HomePage.goTo();
            // AbtDriver.TopNavigation.HoverOverTools();
            AbtDriver.ToolsAndResourcesPage.goTo();
            AbtDriver.AtlasPage.goTo();
            //Goes to the same page when click on abt talent learn and support

        }

        [TestMethod]
        public void Should_click_AbtKnowledge()
        {
            AbtDriver.HomePage.goTo();
            //  AbtDriver.TopNavigation.HoverOverTools();
            AbtDriver.ToolsAndResourcesPage.goTo();
            AbtDriver.AbtKnowledgePage.goTo();
            Assert.IsTrue(AbtDriver.AbtKnowledgePage.isAt(),"Couldn't get to Abt Knowledge Page");
          
        }

        [TestMethod]
        public void Should_click_AbtTravel()
        {
            AbtDriver.HomePage.goTo();
            //AbtDriver.TopNavigation.HoverOverTools();
            AbtDriver.ToolsAndResourcesPage.goTo();
            AbtDriver.AbtTravelPage.goTo();
             Assert.IsTrue(AbtDriver.AbtTravelPage.isAt());
        }

        [TestMethod]
        public void Should_click_Oracle()
        {
            AbtDriver.HomePage.goTo();
            // AbtDriver.TopNavigation.HoverOverTools();
            AbtDriver.ToolsAndResourcesPage.goTo();
            AbtDriver.OraclePage.goTo();
            Assert.IsTrue(AbtDriver.OraclePage.isAt());

        }

        [TestMethod]
        public void Should_click_ISMS()
        {
            AbtDriver.HomePage.goTo();
            //  AbtDriver.TopNavigation.HoverOverTools();
            AbtDriver.ToolsAndResourcesPage.goTo();
            AbtDriver.IsmsPage.goTo();
            Assert.IsTrue(AbtDriver.IsmsPage.isAt());

        }

        [TestMethod]
        public void Should_Open_OutlookWebAccess()
        {
            AbtDriver.HomePage.goTo();
            //   AbtDriver.TopNavigation.HoverOverTools();
            AbtDriver.ToolsAndResourcesPage.goTo();
            AbtDriver.OutlookWebPage.goTo();
            Assert.IsTrue(AbtDriver.OutlookWebPage.isAt());

        }

        [TestMethod]
        public void Should_click_ReputationalCapitalDB()
        {
            AbtDriver.HomePage.goTo();
            //  AbtDriver.TopNavigation.HoverOverTools();
            AbtDriver.ToolsAndResourcesPage.goTo();
            AbtDriver.ReputationalCapDBPage.goTo();
            Assert.IsTrue(AbtDriver.ReputationalCapDBPage.isAt());
        }

        [TestMethod]
        public void Should_click_RepCapPlanner()
        {
            AbtDriver.HomePage.goTo();
            // AbtDriver.TopNavigation.HoverOverTools();
            AbtDriver.ToolsAndResourcesPage.goTo();
            AbtDriver.RepCapPlannerPage.goTo();
            Assert.IsTrue(AbtDriver.RepCapPlannerPage.isAt());
         

        }

      
    }
}
