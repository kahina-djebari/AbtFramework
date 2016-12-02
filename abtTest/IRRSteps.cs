using AbtFramework;
using AbtFramework.Utils_Classes;
using System;
using TechTalk.SpecFlow;
using Xunit;

namespace abtTest
{
    [Binding]
    public class IRRSteps
    {
        [Given(@"I have Open Chrome")]
        public void GivenIHaveOpenIE()
        {
            SeleniumDriver.init(Browser.Chrome);
        }
        
        [Given(@"I have navigated to ServiceNow Home Page")]
        public void GivenIHaveNavigatedToServiceNowHomePage()
        {
            AbtPages.ServiceNowHomepage.Go(WebEnvironment.TestEnvironment);
        }
       
        
        [Then(@"(.*) profile should load")]
        public void ThenStellaLaidosonProfileShouldLoad(string User)
        {
            Assert.True(AbtPages.ServiceNowHomepage.isCurrentUser(User));
        }
        [Given(@"I have impersonated user (.*)")]
        public void GivenIHaveImpersonatedUserStellaLaidoson(string User)
        {
            AbtPages.ServiceNowHomepage.ImpersonateUser(User);
        }

        [Given(@"I have opened Incident Response Report Section")]
        public void GivenIHaveOpenedIncidentResponseReportSection()
        {
            AbtPages.ServiceNowHomepage.OpenIRRSection();
        }

        [When(@"I click on create new")]
        public void WhenIClickOnCreateNew()
        {
            AbtPages.ServiceNowTaskBar.New();
        }

        [When(@"I fill the IRR form")]
        public void WhenIFillTheIRRForm()
        {
            AbtPages.ServiceNowIRRForm.FillWithDefaultValues();
        }


        [When(@"I click submit")]
        public void WhenIClickSubmit()
        {
            AbtPages.ServiceNowTaskBar.Submit();
        }


        [Then(@"Incident Response Report should have been created")]
        public void ThenIncidentResponseReportShouldHaveBeenCreated()
        {
            Assert.True(AbtPages.ServiceNowIRRTable.NewIRRExists());
        }


    }
}
