using System;
using AbtFramework;
using AbtFramework.Utils_Classes;
using TechTalk.SpecFlow;
using Xunit;

namespace abtTest.Steps
{ 
    [Binding]
    public class ITSCSteps
    {
        private static string ITSCIncidentReportId;
        private static string ITSCCompatibleIncidentID;

        [Given(@"As an ITSC i open Incident Section")]
        public void GivenAsAnITSCIOpenIncidentSection()
        {
            AbtPages.ServiceNowHomepage.CreateNewIncidentSection();
        }

        [When(@"As an ITSC I Create an Incident With Category ""(.*)"" and Subcategory ""(.*)"" and Type ""(.*)""")]
        public void WhenAsAnITSCICreateAnIncidentWithCategoryAndSubcategoryAndType(string Category, string SubCategory, string Type)
        {
            if (Category.Equals("Software") && SubCategory.Equals("Application"))
            {   //just filds the mandatory fields without click create new again
                ITSCIncidentReportId = AbtPages.ServiceNowHomepage.CreateNewIncidentITSC("Jose Frometa", Category, SubCategory, Type, "Irving Anglon", "SD_General_IT");
            }
        }

        [Then(@"The ITSC Incident Report should have been created")]
        public void ThenTheITSCIncidentReportShouldHaveBeenCreated()
        {
           // AbtPages.ServiceNowTaskBar.PullIRRWithNumber(ITSCIncidentReportId);
            Assert.True(AbtPages.ServiceNowIRRTable.IRRExists(ITSCIncidentReportId));
            Console.WriteLine("Incident " + ITSCIncidentReportId + " has been created");
        }

        [Then(@"ITSC Opens and Process the Incident")]
        public void ThenITSCOpensAndProcessTheIncident()
        {
            AbtPages.ServiceNowHomepage.OpenIncidentSection();
            AbtPages.TablePageObject.OpenIncident(ITSCIncidentReportId);
            Console.WriteLine("Incident " + ITSCIncidentReportId + " has been Processed");
        }

        [Then(@"ITSC Opens and Updates the Incident")]
        public void ThenITSCOpensAndUpdatesTheIncident()
        {
            AbtPages.ServiceNowHomepage.OpenIncidentSection();
            AbtPages.TablePageObject.OpenIncident(ITSCIncidentReportId);
            AbtPages.ServiceNowHomepage.UpdateITSCIncident();
            Console.WriteLine("Incident " + ITSCIncidentReportId + " has been Processed");
        }

        [Given(@"I have opened the open incidents Section")]
        public void GivenIHaveOpenedTheOpenIncidentsSection()
        {
            AbtPages.ServiceNowHomepage.OpenIncidentSection();
        }


        [When(@"I Try to pull an Incident with state ""(.*)""")]
        public void WhenITryToPullAnIncidentWithState(string state)
        {
           
            AbtPages.TablePageObject.OpenIncident(ITSCIncidentReportId);
            AbtPages.ServiceNowHomepage.UpdateITSCIncident();
            Console.WriteLine("Opening Incident Response Report " + ITSCIncidentReportId);
            
        }

        [Then(@"the Incident should have been closed")]
        public void ThenTheIncidentShouldHaveBeenClosed()
        {
            //TODO!!! complete the validation of this Scenario

            //AbtPages.ServiceNowHomepage.OpenIncidentSection();
            Console.WriteLine("Incident " + ITSCIncidentReportId + " Has been closed.");
        }


    }
}
