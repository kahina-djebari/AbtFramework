using AbtFramework;
using System;
using TechTalk.SpecFlow;
using Xunit;

namespace abtTest.Steps
{
    [Binding]
    public class AGISteps
    {
        private string OracleWinHandle;

        [When(@"I Hover over Quick Links")]
        public void WhenIHoverOverQuickLinks()
        {
            AbtPages.AgiHomePage.HoverOverQuickLinks();
        }
        
        [When(@"I Click on Oracle")]
        public void WhenIClickOnOracle()
        {
           OracleWinHandle= AbtPages.AgiHomePage.QuickLinks.OpenOracle();
        }
        
        [Then(@"The Oracle Home Page Should Load Succesfully")]
        public void ThenTheOracleHomePageShouldLoadSuccesfully()
        {
           // Assert.True(AbtPages.OraclePage.isAt());
        }

        [When(@"I Click on Staff Directory")]
        public void WhenIClickOnStaffDirectory()
        {
            AbtPages.AgiHomePage.QuickLinks.OpenStaffDirectory();
        }

        [Then(@"I should be redirected to a page where you can Search the Staff people")]
        public void ThenIShouldBeRedirectedToAPageWhereYouCanSearchTheStaffPeople()
        {
            Assert.True(AbtPages.StaffDirectoryPage.isAt());
        }

    }
}
