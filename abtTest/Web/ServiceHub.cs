using System;
using Xunit;
using AbtFramework;
using AbtFramework.Utils_Classes;

namespace abtTest.Web
{
   
    public class ServiceHub
    {


      //  [Fact(DisplayName = "Should Place Office Request ")]
        public void Should_Place_Office_Request()
        {
            Driver.init(Browser.IENoNativeEvents);
            AbtDriver.ServiceNowHomepage.Go(WebEnvironment.TestEnvironment);
            AbtDriver.ServiceNowHomepage.ImpersonateUser("David Acuna");
            AbtDriver.ServiceNowHomepage.GoTo(ServicenowLinks.ServiceHub);
            AbtDriver.ServiceHubHomepage.GoTo(ServiceHubLinks.New_OS_Request);
            AbtDriver.OfficeServiceRequestpage.NewOfficeRequest("Bethesda, MD", "Office Space", "Shelving", "Short description-3", "Notes/Comments");
            AbtDriver.ServiceNowHomepage.Go(WebEnvironment.TestEnvironment);
            AbtDriver.ServiceNowHomepage.ImpersonateUser("Steve Hunt");
            AbtDriver.ServiceNowHomepage.FacilityRequests();
            AbtDriver.ServiceNowHomepage.CloseOfficeRequest("Short description-3", "work notes", "Steve Hunt");
            //Assert.True(AbtDriver.ServiceNowHomepage.OfficeRequestIsClosed("Short description-3"));
            // Driver.Quit();
            // AbtDriver.OfficeServiceRequestpage.FillRequestWith(HRIssueCategory.Benefits, "Subject Goes Here", "Description Goes Here");

        }

       // [Fact(DisplayName = "Should Check Service Hub Home Page Links")]
        public void Should_Check_Home_Page_ServiceHub_Links()
        {
            Driver.init(Browser.IENoNativeEvents);
            AbtDriver.ServiceNowHomepage.Go(WebEnvironment.TestEnvironment);
            AbtDriver.ServiceNowHomepage.GoTo(ServicenowLinks.ServiceHub);
            AbtDriver.ServiceHubHomepage.GoTo(ServiceHubLinks.New_HR_Request);
            AbtDriver.ServiceHubHomepage.Go();
            AbtDriver.ServiceHubHomepage.GoTo(ServiceHubLinks.My_Open_HR_Request);
            AbtDriver.ServiceHubHomepage.Go();
            AbtDriver.ServiceHubHomepage.GoTo(ServiceHubLinks.My_Closed_HR_Requests);
            AbtDriver.ServiceHubHomepage.Go();
            AbtDriver.ServiceHubHomepage.GoTo(ServiceHubLinks.New_IT_Request);
            AbtDriver.ServiceHubHomepage.Go();
            AbtDriver.ServiceHubHomepage.GoTo(ServiceHubLinks.IT_Knowledge_Base);
            AbtDriver.ServiceHubHomepage.Go();
            AbtDriver.ServiceHubHomepage.GoTo(ServiceHubLinks.My_Open_IT_Request);
            AbtDriver.ServiceHubHomepage.Go();
            AbtDriver.ServiceHubHomepage.GoTo(ServiceHubLinks.My_Open_Incidents);
            AbtDriver.ServiceHubHomepage.Go();
            AbtDriver.ServiceHubHomepage.GoTo(ServiceHubLinks.My_Closed_IT_Requests);
            AbtDriver.ServiceHubHomepage.Go();
            AbtDriver.ServiceHubHomepage.GoTo(ServiceHubLinks.My_Closed_IT_Incidents);
            AbtDriver.ServiceHubHomepage.Go();
            AbtDriver.ServiceHubHomepage.GoTo(ServiceHubLinks.New_OS_Request);
            AbtDriver.ServiceHubHomepage.Go();
            AbtDriver.ServiceHubHomepage.GoTo(ServiceHubLinks.My_Open_OS_Request);
            AbtDriver.ServiceHubHomepage.Go();
            AbtDriver.ServiceHubHomepage.GoTo(ServiceHubLinks.My_Closed_OS_Requests);
            AbtDriver.ServiceHubHomepage.Go();

        }

      //  [Fact(DisplayName = "Should Check Service Hub Top Navigation Links")]
        public void Should_Check_Top_Navigation_ServiceHub_Links()
        {
            Driver.init(Browser.IENoNativeEvents);
            AbtDriver.ServiceNowHomepage.Go(WebEnvironment.TestEnvironment);
            AbtDriver.ServiceNowHomepage.GoTo(ServicenowLinks.ServiceHub);
            AbtDriver.ServiceHubHomepage.GoTo(ServiceHubLinks.New_HR_Request);
            AbtDriver.ServiceHubHomepage.ServiceHubTopNavigation.Go(ServiceHubTopNavLinks.Home);
            AbtDriver.ServiceHubHomepage.GoTo(ServiceHubLinks.New_HR_Request);
            AbtDriver.ServiceHubHomepage.ServiceHubTopNavigation.Go(ServiceHubTopNavLinks.HR_Service_Center);
            AbtDriver.ServiceHubHomepage.GoTo(ServiceHubLinks.New_HR_Request);
            AbtDriver.ServiceHubHomepage.ServiceHubTopNavigation.Go(ServiceHubTopNavLinks.IT_Service_Center);
            AbtDriver.ServiceHubHomepage.GoTo(ServiceHubLinks.New_HR_Request);
            AbtDriver.ServiceHubHomepage.ServiceHubTopNavigation.Go(ServiceHubTopNavLinks.Office_Services);

        }


     //   [Fact(DisplayName = "Should Place HR Request ")]
        public void Should_Place_HR_Request()
        {
            Driver.init(Browser.IENoNativeEvents);
            AbtDriver.ServiceNowHomepage.Go(WebEnvironment.TestEnvironment);
            AbtDriver.ServiceNowHomepage.ImpersonateUser("David Acuna");
            AbtDriver.ServiceNowHomepage.GoTo(ServicenowLinks.ServiceHub);
            AbtDriver.ServiceHubHomepage.GoTo(ServiceHubLinks.New_HR_Request);
            AbtDriver.HRServiceRequestpage.NewHRServiceRequest(HRIssueCategory.Benefits, "Subject Goes Here", "Description Goes Here");
            AbtDriver.ServiceNowHomepage.Go(WebEnvironment.TestEnvironment);
            AbtDriver.ServiceNowHomepage.ImpersonateUser("Michael Stinson");
            AbtDriver.ServiceNowHomepage.OpenHRIssues();
            AbtDriver.ServiceNowHomepage.CloseHRServiceRequest();
        }


       // [Fact(DisplayName = ("Should Place IT Request (Ask a Question) - ESS"))]
        public void Should_Ask_Question_ESS()
        {
            Driver.init(Browser.IENoNativeEvents);
            AbtDriver.ServiceNowHomepage.Go(WebEnvironment.TestEnvironment);
            AbtDriver.ServiceNowHomepage.ImpersonateUser("David Acuna");
            AbtDriver.ServiceNowHomepage.GoTo(ServicenowLinks.ServiceHub);
            AbtDriver.ServiceHubHomepage.GoTo(ServiceHubLinks.New_IT_Request);
            AbtDriver.ITServiceRequestpage.NewIncident(IncidentType.Ask_A_Question);
            AbtDriver.ITServiceRequestFormPage.NewRequest(Urgency.Medium, "Short Description A", "Describe your Question");
            AbtDriver.ServiceHubHomepage.Go();
            AbtDriver.ServiceHubHomepage.GoTo(ServiceHubLinks.My_Open_Incidents);
            Assert.True(AbtDriver.MyOpenIncidentsPage.IncidentExists("Short Description A"));
            AbtDriver.ServiceNowHomepage.Go(WebEnvironment.TestEnvironment);
            AbtDriver.ServiceNowHomepage.ImpersonateUser("Valeria Rozenbaum");
            AbtDriver.ServiceNowHomepage.OpenIncidentSection();
            Assert.True(AbtDriver.ServiceNowHomepage.IncidentExist(IncidentType.Ask_A_Question, Urgency.Medium, "Short Description A", "Describe your Question"));


        }



     //   [Fact(DisplayName = "Should Place IT Incident")]
        public void Should_Place_IT_Incident()
        {
            Driver.init(Browser.IENoNativeEvents);    //IE247
            AbtDriver.ServiceNowHomepage.Go(WebEnvironment.TestEnvironment);
            AbtDriver.ServiceNowHomepage.ImpersonateUser("David Acuna");
            AbtDriver.ServiceNowHomepage.GoTo(ServicenowLinks.ServiceHub);
            AbtDriver.ServiceHubHomepage.GoTo(ServiceHubLinks.New_IT_Request);
            AbtDriver.ITServiceRequestpage.NewIncident(IncidentType.IT_Incident);
            AbtDriver.ITServiceRequestFormPage.NewRequest(Urgency.High, "Short Description C", "More info for Incident");
            AbtDriver.ServiceHubHomepage.Go();
            AbtDriver.ServiceHubHomepage.GoTo(ServiceHubLinks.My_Open_Incidents);
            Assert.True(AbtDriver.MyOpenIncidentsPage.IncidentExists("Short Description C"));
            AbtDriver.ServiceNowHomepage.Go(WebEnvironment.TestEnvironment);
            AbtDriver.ServiceNowHomepage.ImpersonateUser("Valeria Rozenbaum");
            AbtDriver.ServiceNowHomepage.OpenIncidentSection();
            AbtDriver.ServiceNowHomepage.CloseITServiceRequest();

        }


     //   [Fact(DisplayName = "Should Search on Service Hub")]
        public void Should_Search_On_Service_Hub()
        {
            Driver.init(Browser.IENoNativeEvents);
            AbtDriver.ServiceNowHomepage.Go(WebEnvironment.TestEnvironment);
            AbtDriver.ServiceNowHomepage.GoTo(ServicenowLinks.ServiceHub);
            AbtDriver.ServiceHubHomepage.Search("Office 2013");

        }

      //  [Fact(DisplayName = "Should Update a Knowledge Base Article")]
        public void Should_Update_Knowledge_Base_Article()
        {
            Driver.init(Browser.IENoNativeEvents);
            AbtDriver.ServiceNowHomepage.Go(WebEnvironment.TestEnvironment);
            AbtDriver.ServiceNowHomepage.ImpersonateUser("Valeria Rozenbaum");
            AbtDriver.ServiceNowHomepage.GoTo(ServicenowLinks.ServiceHub);
            AbtDriver.ServiceHubHomepage.GoTo(ServiceHubLinks.IT_Knowledge_Base);
            AbtDriver.ITKnowledgeBasePage.OpenRandomArticle();
            AbtDriver.ITKnowledgeBasePage.EditArticle("Random edition");
        }

      //  [Fact(DisplayName ="Should Create New Conferencing Setup Request")]
        public void Should_Create_New_Conferencing_Setup_Request()
        {
            Driver.init(Browser.IENoNativeEvents);
            AbtDriver.ServiceNowHomepage.Go(WebEnvironment.TestEnvironment);
            AbtDriver.ServiceNowHomepage.ImpersonateUser("Valeria Rozenbaum");
            AbtDriver.ServiceNowHomepage.GoTo(ServicenowLinks.ServiceHub);
            AbtDriver.ServiceHubHomepage.GoTo(ServiceHubLinks.New_IT_Request);
            AbtDriver.ITServiceRequestpage.NewIncident(IncidentType.ConferencingSetup);
            AbtDriver.ConferencingSetupPage.NewRequest("Bethesda, MD",DateMaker.GetStartDate(),DateMaker.GetEndDate(),
                                                       "Bethesda - Annapolis (4th fl / rm 4096)","meeting info","5");
            Assert.True(AbtDriver.ConfSetupConfirmationPage.isAt());


        }

    }
}
