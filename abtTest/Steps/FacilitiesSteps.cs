using System;
using TechTalk.SpecFlow;
using AbtFramework;
using AbtFramework.Utils_Classes;
using TechTalk.SpecFlow;
using Xunit;

namespace abtTest.Steps
{
    [Binding]
    public class FacilitiesSteps
    {

        private static string FAIncidentReportId;
        private static string FACompatibleIncidentID;

        [Given(@"I have opened Facilities")]
        public void GivenIHaveOpenedFacilities()
        {
            AbtPages.ServiceNowHomepage.ButtonCreateNewFacilityRequest();
        }
        
        [When(@"I Create a facilities request With Category ""(.*)"" and Subcategory ""(.*)"" and assignment grp ""(.*)""")]
        public void WhenICreateAFacilitiesRequestWithCategoryAndSubcategoryAndAssignmentGrp(string Category, string SubCategory, string Assignmentgrp)
        {
            FAIncidentReportId = AbtPages.ServiceNowHomepage.CreateNewFacilityRequestAndReadyToWork("Sofiane Oumsalem",
                        Category, SubCategory, "Facilities Automated Text", Assignmentgrp);
        }

        
        [When(@"I click ready for work")]
        public void WhenIClickReadyForWork()
        {
            AbtPages.ServiceNowHomepage.ClickFacilitiesReadyForWork();
        }
        
        [Then(@"facilities request should have been created")]
        public void ThenFacilitiesRequestShouldHaveBeenCreated()
        {
            AbtPages.ServiceNowHomepage.ClickFacilitiesCreatedByMe();
            AbtPages.TablePageObject.OpenIncident(FAIncidentReportId);
            Assert.True(AbtPages.ServiceNowHomepage.isFacilitiesIncidentNumberCreated(FAIncidentReportId));
            Console.WriteLine("Facilities Ticket " + FAIncidentReportId + " has been Processed");  
        }


        [Given(@"Under the facilites section i click on Assigned to me and click a ticket")]
        public void GivenUnderTheFacilitesSectionIClickOnAssignedToMeAndClickATicket()
        {
            AbtPages.ServiceNowHomepage.ClickFacilitiesAssignedToMe();
            AbtPages.TablePageObject.OpenFirstRowItem();
        }

        [Given(@"I click start work to start procesing the ticket")]
        public void GivenIClickStartWorkToStartProcesingTheTicket()
        {
            AbtPages.ServiceNowHomepage.ClickFacilitiesStartWork();
        }

        [When(@"im done with the ticket i click Close Complete")]
        public void WhenImDoneWithTheTicketIClickCloseComplete()
        {
            AbtPages.ServiceNowHomepage.CloseCompleteFacilitiesIncident();
        }

        [Then(@"facilities request should have been closed")]
        public void ThenFacilitiesRequestShouldHaveBeenClosed()
        {
            AbtPages.ServiceNowHomepage.AllRequestFacilityRequest();
            AbtPages.TablePageObject.OpenIncident(FAIncidentReportId);
            Assert.True(AbtPages.ServiceNowHomepage.isFacilitiesIncidentNumberCreated(FAIncidentReportId));
        }
    }
}
