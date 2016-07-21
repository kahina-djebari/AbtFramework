using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AbtFramework;

namespace abtTest
{
    [TestClass]
    public class AGI
    {
        [TestInitialize]
        public void InitDriver()
        {
            Driver.init();
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
            AbtDriver.TopNavigation.HoverOverTools();
            AbtDriver.AtlasPage.goTo();
            //Assert that is at atlaspage (i dont have access)

        }

        [TestMethod]
        public void Should_click_AbtKnowledge()
        {
            AbtDriver.HomePage.goTo();
            AbtDriver.TopNavigation.HoverOverTools();
            AbtDriver.AbtKnowledgePage.goTo();
            //assert that is at AbtKnowledge page
        }

        [TestMethod]
        public void Should_click_AbtTravel()
        {
            AbtDriver.HomePage.goTo();
            AbtDriver.TopNavigation.HoverOverTools();
            AbtDriver.AbtTravelPage.goTo();
            //assert that is at abtTravelPage
        }

        [TestMethod]
        public void Should_click_Oracle()
        {
            AbtDriver.HomePage.goTo();
            AbtDriver.TopNavigation.HoverOverTools();
            AbtDriver.OraclePage.goTo();
            //assert that is at Oracle Page

        }

        [TestMethod]
        public void Should_click_ISMS()
        {
            AbtDriver.HomePage.goTo();
            AbtDriver.TopNavigation.HoverOverTools();
            AbtDriver.IsmsPage.goTo();
            Assert.IsTrue(AbtDriver.IsmsPage.isAt());

        }

        [TestMethod]
        public void Should_Open_OutlookWebAccess()
        {
            AbtDriver.HomePage.goTo();
            AbtDriver.TopNavigation.HoverOverTools();
            AbtDriver.OutlookWebPage.goTo();
            Assert.IsTrue(AbtDriver.OutlookWebPage.isAt());

        }

        [TestMethod]
        public void Should_click_ReputationalCapitalDB()
        {
            AbtDriver.HomePage.goTo();
            AbtDriver.TopNavigation.HoverOverTools();
            AbtDriver.ReputationalCapDBPage.goTo();
        }

        [TestMethod]
        public void Should_click_RepCapPlanner()
        {
            AbtDriver.HomePage.goTo();
            AbtDriver.TopNavigation.HoverOverTools();
            AbtDriver.RepCapPlannerPage.goTo();
            // assert that is at repcapPlanner page, 

        }







    }
}
