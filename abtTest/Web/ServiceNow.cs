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
            Driver.init(Browser.IENoNativeEvents);
            AbtDriver.ServiceNowHomepage.Go(WebEnvironment.TestEnvironment);
            AbtDriver.ServiceNowHomepage.ImpersonateUser("Valeria Rozenbaum");
            AbtDriver.ServiceNowHomepage.OpenIncidentSection();
            AbtDriver.ServiceNowHomepage.CreateNewIncident("David Acuna","Software","Application","Upgrade"
                                                           ,"Valeria Rozenbaum", "SD_General_IT");
            
        }

       // [Fact(DisplayName = ("Should Open New HR Ticket on Service Now as Admin"))]
        public void Should_Open_New_HR_Ticket_on_Service_Now()
        {
            Driver.init(Browser.IENoNativeEvents);
            AbtDriver.ServiceNowHomepage.Go(WebEnvironment.TestEnvironment);
            AbtDriver.ServiceNowHomepage.ImpersonateUser("Michael Stinson");
            AbtDriver.ServiceNowHomepage.OpenHRIssues();
            AbtDriver.ServiceNowHomepage.CreateNewHRTicket("David Acuna","Payroll","Subject","Description","Email");
           
        }

     //   [Fact(DisplayName = ("Should Open a Facility Request on Service Now as Admin"))]
        public void Should_Open_New_Facility_Request_on_Service_Now()
        {
            Driver.init(Browser.IENoNativeEvents);
            AbtDriver.ServiceNowHomepage.Go(WebEnvironment.TestEnvironment);
            AbtDriver.ServiceNowHomepage.ImpersonateUser("Steve Hunt");
            AbtDriver.ServiceNowHomepage.FacilityRequests();
            AbtDriver.ServiceNowHomepage.CreateNewFacilityRequest("David Acuna","Office Furniture"
                                                                 ,"Furniture Requests","Short Description"
                                                                 ,"Assignment group");

        }

      //  [Fact(DisplayName ="Should Create a New Knowledge Base Article")]
        public void Should_Create_New_KB_Article()
        {
            Driver.init(Browser.IE252);
            AbtDriver.ServiceNowHomepage.Go(WebEnvironment.TestEnvironment);
            AbtDriver.ServiceNowHomepage.ImpersonateUser("Valeria Rozenbaum");
            AbtDriver.ServiceNowHomepage.OpenKnowledgeBase();
            AbtDriver.ServiceNowHomepage.CreateNewKBArticle("Short article description");
        }

        // [Fact(DisplayName ="Should Sent Email To ServiceNow Test Addresses")]
        public void Should_Send_An_Email()
        {
            Driver.init(Browser.IE);
            AbtDriver.OutlookWebPage.Go();
           // AbtDriver.TopNavigation.ToolsDropdown.goTo(AbtPages.Outlook);
            AbtDriver.OutlookWebPage.SendEmail("abtassoctest@abtassoc.com", "subject goes here", "Body goes here");
        }

    }
}
