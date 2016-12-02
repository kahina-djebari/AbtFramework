using System;
using Xunit;
using AbtFramework;
using AbtFramework.Utils_Classes;


namespace abtTest.Web
{
    
    public class ServiceNow
    {
       // [Fact(DisplayName =("Should Open Incident on Service Now as Admin"))]
         public void Should_Open_Incident()
        {
            SeleniumDriver.init(Browser.IENoNativeEvents);
            AbtPages.ServiceNowHomepage.Go(WebEnvironment.TestEnvironment);
            AbtPages.ServiceNowHomepage.ImpersonateUser("Valeria Rozenbaum");
            AbtPages.ServiceNowHomepage.OpenIncidentSection();
            AbtPages.ServiceNowHomepage.CreateNewIncident("David Acuna","Software","Application","Upgrade"
                                                           ,"Valeria Rozenbaum", "SD_General_IT");
            
        }

      //  [Fact(DisplayName = ("Should Open New HR Ticket on Service Now as Admin"))]
        public void Should_Open_New_HR_Ticket_on_Service_Now()
        {
            SeleniumDriver.init(Browser.IENoNativeEvents);
            AbtPages.ServiceNowHomepage.Go(WebEnvironment.TestEnvironment);
            AbtPages.ServiceNowHomepage.ImpersonateUser("Michael Stinson");
            AbtPages.ServiceNowHomepage.OpenHRIssues();
            AbtPages.ServiceNowHomepage.CreateNewHRTicket("David Acuna","Payroll","Subject","Description","Email");
           
        }

     //   [Fact(DisplayName = ("Should Open a Facility Request on Service Now as Admin"))]
        public void Should_Open_New_Facility_Request_on_Service_Now()
        {
            SeleniumDriver.init(Browser.IENoNativeEvents);
            AbtPages.ServiceNowHomepage.Go(WebEnvironment.TestEnvironment);
            AbtPages.ServiceNowHomepage.ImpersonateUser("Steve Hunt");
            AbtPages.ServiceNowHomepage.FacilityRequests();
            AbtPages.ServiceNowHomepage.CreateNewFacilityRequest("David Acuna","Office Furniture"
                                                                 ,"Furniture Requests","Short Description"
                                                                 ,"Assignment group");

        }

      //  [Fact(DisplayName ="Should Create a New Knowledge Base Article")]
        public void Should_Create_New_KB_Article()
        {
            SeleniumDriver.init(Browser.IE252);
            AbtPages.ServiceNowHomepage.Go(WebEnvironment.TestEnvironment);
            AbtPages.ServiceNowHomepage.ImpersonateUser("Valeria Rozenbaum");
            AbtPages.ServiceNowHomepage.OpenKnowledgeBase();
            AbtPages.ServiceNowHomepage.CreateNewKBArticle("Short article description");
        }

        // [Fact(DisplayName ="Should Sent Email To ServiceNow Test Addresses")]
        public void Should_Send_An_Email()
        {
            SeleniumDriver.init(Browser.IE);
            AbtPages.OutlookWebPage.Go();
           // AbtDriver.TopNavigation.ToolsDropdown.goTo(AbtPages.Outlook);
            AbtPages.OutlookWebPage.SendEmail("abtassoctest@abtassoc.com", "subject goes here", "Body goes here");
        }

        [Fact(DisplayName ="Should Create IRR")]
        public void Should_create_IRR()
        {
            TestCaseGenerator.SetTestCase(AbtTestCases.ServiceNowCreateIRR);
            TestCaseGenerator.SetTestCaseTemplate(AbtTemplates.DetailedReport);
            SeleniumDriver.init(Browser.Chrome);
            AbtPages.ServiceNowHomepage.Go(WebEnvironment.TestEnvironment);
            AbtPages.ServiceNowHomepage.ImpersonateUser("Stella Laidoson");
            AbtPages.ServiceNowHomepage.OpenIRRSection();
            AbtPages.ServiceNowTaskBar.New();
            AbtPages.ServiceNowIRRForm.FillWithDefaultValues();
            AbtPages.ServiceNowTaskBar.Submit();
            Assert.True(AbtPages.ServiceNowIRRTable.NewIRRExists());
           
        }
        

    }
}
