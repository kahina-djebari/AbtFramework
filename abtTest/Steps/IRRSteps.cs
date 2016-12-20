using AbtFramework;
using AbtFramework.Utils_Classes;
using System;
using TechTalk.SpecFlow;
using Xunit;

namespace abtTest.Steps
{
    [Binding]
    public class IRRSteps
    {
        private static string CompatibleIncidentID;
        private static string IncompatibleIncidentID;
        private static string IncidentReportId;

        [Given(@"I have Open Chrome")]
        public void GivenIHaveOpenChrome()
        {
            SeleniumDriver.init(Browser.Chrome);
        }
        
        [Given(@"I have navigated to ServiceNow Home Page")]
        public void GivenIHaveNavigatedToServiceNowHomePage()
        {
            AbtPages.ServiceNowHomepage.Go(WebEnvironment.TestEnvironment);
        }
        
        [Given(@"I have impersonated user ""(.*)""")]
        public void GivenIHaveImpersonatedUser(string user)
        {
            AbtPages.ServiceNowHomepage.ImpersonateUser(user);
        }
        
        [Given(@"I have opened Incident Response Report Section")]
        public void GivenIHaveOpenedIncidentResponseReportSection()
        {
            AbtPages.ServiceNowHomepage.OpenIRRSection();
        }

        [Given(@"I have opened Incident Section")]
        public void GivenIHaveOpenedIncidentSection()
        {
            AbtPages.ServiceNowHomepage.OpenIncidentSection();
        }


        [When(@"I click on create new")]
        public void WhenIClickOnCreateNew()
        {
            AbtPages.ServiceNowTaskBar.New();
        }
        
        [When(@"I fill the IRR form")]
        public void WhenIFillTheIRRForm()
        {
          IncidentReportId= AbtPages.ServiceNowIRRForm.GetId();
            //not filling anything on the form for now
            //since there's not mandatory fields when opening an IRR
            //fill the form in this method in case there's a mandatory field in the future
        }
        
        [When(@"I click submit")]
        public void WhenIClickSubmit()
        {
            AbtPages.ServiceNowTaskBar.Submit();
        }
        
        [When(@"I Create an Incident With Category ""(.*)"" and Subcategory ""(.*)"" and Type ""(.*)""")]
        public void WhenICreateAIncidentWithCategoryAndSubcategory(string Category, string SubCategory,string Type)
        {
            if (Category.Equals("Security") && SubCategory.Equals("Event"))
            {
                CompatibleIncidentID = AbtPages.ServiceNowHomepage.CreateNewIncident("David Acuna", Category, SubCategory, Type, "Stella Laidoson", "Client_Data_Security");
            }
            else
            {
                IncompatibleIncidentID= AbtPages.ServiceNowHomepage.CreateNewIncident("David Acuna", Category, SubCategory, Type, "Stella Laidoson", "Client_Data_Security");
            }
         
            Console.WriteLine("Incident "+CompatibleIncidentID+" has been created");
            
        }
        
        [Then(@"Incident Response Report should have been created")]
        public void ThenIncidentResponseReportShouldHaveBeenCreated()
        {
            AbtPages.ServiceNowTaskBar.PullIRRWithNumber(IncidentReportId);
            Assert.True(AbtPages.ServiceNowIRRTable.IRRExists(IncidentReportId));
            Console.WriteLine("Incident Response Report " + IncidentReportId + " has been created");
        }
        
        [Then(@"I Should be able to create an IR report from that Incident")]
        public void ThenIShouldBeAbleToCreateAnIRReportFromThatIncident()
        {
            

            IncidentReportId = AbtPages.ServiceNowIRRForm.GetId();
            Assert.NotNull(IncidentReportId);
            Assert.Equal(CompatibleIncidentID, AbtPages.ServiceNowIRRForm.GetParentIncident());

            Console.WriteLine("Incident Response Report " + IncidentReportId + " created from " + CompatibleIncidentID);
        }

        [When(@"I Try To Create an IRR for an Open Security Incident that has already an IRR created")]
        [When(@"I try to Create an IRR from that Incident")]
        public void WhenITryToCreateAnIRRFromThatIncident()
        {
            AbtPages.TablePageObject.OpenIncident(CompatibleIncidentID);
            AbtPages.ServiceNowTaskBar.CreateIncReport();
        }

        
    
        [Then(@"I Should receive an error message stating a new IRR was not created")]
        public void ThenTheIRRShouldNotBeCreated()
        {
            Console.WriteLine(AbtPages.ServiceNowHomepage.GetErrorMsg());
            Assert.Equal(AbtPages.ServiceNowHomepage.GetErrorMsg(), "Incident Response Report (IRR) " + IncidentReportId + " already exists for this Incident. A new IRR was NOT created.");
        }


        [Then(@"I Should not be able to create an IR report from that Incident")]
        public void ThenIShouldNotBeAbleToCreateAnIRReportFromThatIncident()
        {
            AbtPages.TablePageObject.OpenIncident(IncompatibleIncidentID);
            Assert.False(AbtPages.ServiceNowTaskBar.CreateIncReport());
            Console.WriteLine("Couldn't create IRR for Incident " + CompatibleIncidentID + " because Incident category should be \"Security\" and Subcategory \"Event\" ");
        }

        [When(@"I Try to pull an IRR with state ""(.*)""")]
        public void WhenITryToPullIRRWithState(string state)
        {
           // AbtPages.ServiceNowTaskBar.PullIRRWithState(state);
            AbtPages.ServiceNowTaskBar.PullIRRWithNumber(IncidentReportId);
            AbtPages.ServiceNowIRRTable.IRRExists(IncidentReportId);
            Console.WriteLine("Opening Incident Response Report " + IncidentReportId);


        }

        [When(@"I Change the IRR state to Closed Complete")]
        public void WhenICloseTheIRR()
        {
            AbtPages.ServiceNowIRRForm.UpdateIRRState("Closed Complete");
            
        }

        [When(@"I Click Update")]
        public void WhenIClickUpdate()
        {
            AbtPages.ServiceNowTaskBar.Update();
        }



        [Then(@"I should receive an error indicating what fields are mandatory before closing")]
        public void ThenIShouldReceiveAnErrorIndicatingWhatFieldsAreMandatoryBeforeClosing()
        {
           string alertText= SeleniumDriver.GetAlertText();
            Console.WriteLine(alertText);
        }

        [When(@"I Fill the IRR mandatory fields")]
        public void WhenIFillTheIRRMandatoryFields()
        {
            AbtPages.ServiceNowIRRForm.FillMandatoryFields();
        }

        [Then(@"I should receive an error indicating what boxes need to be checked before closing")]
        public void ThenIShouldReceiveAnErrorIndicatingWhatBoxesNeedToBeCheckedBeforeClosing()
        {
            Assert.True(AbtPages.ServiceNowIRRForm.InvalidUpdateFired());
            Console.WriteLine(AbtPages.ServiceNowIRRForm.GetInvalidUpdateErrorMsg());
        }

        [When(@"I Check all the required boxes on the IRR form")]
        public void WhenICheckAllTheRequiredBoxesOnTheIRRForm()
        {
            AbtPages.ServiceNowIRRForm.CheckRequiredBoxes();
        }

        [Then(@"Incident Response Report should have been closed")]
        public void ThenIncidentResponseReportShouldHaveBeenClosed()
        {
            AbtPages.ServiceNowTaskBar.PullIRRWithState("Closed Complete");
            Assert.True(AbtPages.ServiceNowIRRTable.IRRExists(IncidentReportId));
            Console.WriteLine("Incident " + IncidentReportId + " Has been closed.");

        }



        [AfterScenario]
        public void CleanUp()
        {
            //SeleniumDriver.Instance.Close();
        }


    }
}
