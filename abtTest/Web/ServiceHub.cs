using System;
using Xunit;
using AbtFramework;
using AbtFramework.Utils_Classes;
using AbtFramework.Enums;

namespace abtTest.Web
{
   
    public class ServiceHub
    {


     //   [Fact(DisplayName = "Should Place Office Request ")]
        public void Should_Place_Office_Request()
        {
            SeleniumDriver.init(Browser.IENoNativeEvents);
            AbtPages.ServiceNowHomepage.Go(WebEnvironment.TestEnvironment);
            AbtPages.ServiceNowHomepage.ImpersonateUser("David Acuna");
            AbtPages.ServiceNowHomepage.GoTo(ServicenowLinks.ServiceHub);
            AbtPages.ServiceHubHomepage.GoTo(ServiceHubLinks.New_OS_Request);
            AbtPages.OfficeServiceRequestpage.NewOfficeRequest("Bethesda, MD", "Office Space", "Shelving", "Short description-3", "Notes/Comments");
            AbtPages.ServiceNowHomepage.Go(WebEnvironment.TestEnvironment);
            AbtPages.ServiceNowHomepage.ImpersonateUser("Steve Hunt");
            AbtPages.ServiceNowHomepage.FacilityRequests();
            AbtPages.ServiceNowHomepage.CloseOfficeRequest("Short description-3", "work notes", "Steve Hunt");
            //Assert.True(AbtDriver.ServiceNowHomepage.OfficeRequestIsClosed("Short description-3"));
            // Driver.Quit();
            // AbtDriver.OfficeServiceRequestpage.FillRequestWith(HRIssueCategory.Benefits, "Subject Goes Here", "Description Goes Here");

        }

       // [Fact(DisplayName = "Should Check Service Hub Home Page Links")]
        public void Should_Check_Home_Page_ServiceHub_Links()
        {
            SeleniumDriver.init(Browser.IENoNativeEvents);
            AbtPages.ServiceNowHomepage.Go(WebEnvironment.TestEnvironment);
            AbtPages.ServiceNowHomepage.GoTo(ServicenowLinks.ServiceHub);
            AbtPages.ServiceHubHomepage.GoTo(ServiceHubLinks.New_HR_Request);
            AbtPages.ServiceHubHomepage.Go();
            AbtPages.ServiceHubHomepage.GoTo(ServiceHubLinks.My_Open_HR_Request);
            AbtPages.ServiceHubHomepage.Go();
            AbtPages.ServiceHubHomepage.GoTo(ServiceHubLinks.My_Closed_HR_Requests);
            AbtPages.ServiceHubHomepage.Go();
            AbtPages.ServiceHubHomepage.GoTo(ServiceHubLinks.New_IT_Request);
            AbtPages.ServiceHubHomepage.Go();
            AbtPages.ServiceHubHomepage.GoTo(ServiceHubLinks.IT_Knowledge_Base);
            AbtPages.ServiceHubHomepage.Go();
            AbtPages.ServiceHubHomepage.GoTo(ServiceHubLinks.My_Open_IT_Request);
            AbtPages.ServiceHubHomepage.Go();
            AbtPages.ServiceHubHomepage.GoTo(ServiceHubLinks.My_Open_Incidents);
            AbtPages.ServiceHubHomepage.Go();
            AbtPages.ServiceHubHomepage.GoTo(ServiceHubLinks.My_Closed_IT_Requests);
            AbtPages.ServiceHubHomepage.Go();
            AbtPages.ServiceHubHomepage.GoTo(ServiceHubLinks.My_Closed_IT_Incidents);
            AbtPages.ServiceHubHomepage.Go();
            AbtPages.ServiceHubHomepage.GoTo(ServiceHubLinks.New_OS_Request);
            AbtPages.ServiceHubHomepage.Go();
            AbtPages.ServiceHubHomepage.GoTo(ServiceHubLinks.My_Open_OS_Request);
            AbtPages.ServiceHubHomepage.Go();
            AbtPages.ServiceHubHomepage.GoTo(ServiceHubLinks.My_Closed_OS_Requests);
            AbtPages.ServiceHubHomepage.Go();

        }

      //  [Fact(DisplayName = "Should Check Service Hub Top Navigation Links")]
        public void Should_Check_Top_Navigation_ServiceHub_Links()
        {
            SeleniumDriver.init(Browser.IENoNativeEvents);
            AbtPages.ServiceNowHomepage.Go(WebEnvironment.TestEnvironment);
            AbtPages.ServiceNowHomepage.GoTo(ServicenowLinks.ServiceHub);
            AbtPages.ServiceHubHomepage.GoTo(ServiceHubLinks.New_HR_Request);
            AbtPages.ServiceHubHomepage.ServiceHubTopNavigation.Go(ServiceHubTopNavLinks.Home);
            AbtPages.ServiceHubHomepage.GoTo(ServiceHubLinks.New_HR_Request);
            AbtPages.ServiceHubHomepage.ServiceHubTopNavigation.Go(ServiceHubTopNavLinks.HR_Service_Center);
            AbtPages.ServiceHubHomepage.GoTo(ServiceHubLinks.New_HR_Request);
            AbtPages.ServiceHubHomepage.ServiceHubTopNavigation.Go(ServiceHubTopNavLinks.IT_Service_Center);
            AbtPages.ServiceHubHomepage.GoTo(ServiceHubLinks.New_HR_Request);
            AbtPages.ServiceHubHomepage.ServiceHubTopNavigation.Go(ServiceHubTopNavLinks.Office_Services);

        }


     //   [Fact(DisplayName = "Should Place HR Request ")]
        public void Should_Place_HR_Request()
        {
            SeleniumDriver.init(Browser.IENoNativeEvents);
            AbtPages.ServiceNowHomepage.Go(WebEnvironment.TestEnvironment);
            AbtPages.ServiceNowHomepage.ImpersonateUser("David Acuna");
            AbtPages.ServiceNowHomepage.GoTo(ServicenowLinks.ServiceHub);
            AbtPages.ServiceHubHomepage.GoTo(ServiceHubLinks.New_HR_Request);
            AbtPages.HRServiceRequestpage.NewHRServiceRequest(HRIssueCategory.Benefits, "Subject Goes Here", "Description Goes Here");
            AbtPages.ServiceNowHomepage.Go(WebEnvironment.TestEnvironment);
            AbtPages.ServiceNowHomepage.ImpersonateUser("Michael Stinson");
            AbtPages.ServiceNowHomepage.OpenHRIssues();
            AbtPages.ServiceNowHomepage.CloseHRServiceRequest();
        }


       // [Fact(DisplayName = ("Should Place IT Request (Ask a Question) - ESS"))]
        public void Should_Ask_Question_ESS()
        {
            SeleniumDriver.init(Browser.IENoNativeEvents);
            AbtPages.ServiceNowHomepage.Go(WebEnvironment.TestEnvironment);
            AbtPages.ServiceNowHomepage.ImpersonateUser("David Acuna");
            AbtPages.ServiceNowHomepage.GoTo(ServicenowLinks.ServiceHub);
            AbtPages.ServiceHubHomepage.GoTo(ServiceHubLinks.New_IT_Request);
            AbtPages.ITServiceRequestpage.NewIncident(IncidentType.Ask_A_Question);
            AbtPages.ITServiceRequestFormPage.NewRequest(Urgency.Medium, "Short Description A", "Describe your Question");
            AbtPages.ServiceHubHomepage.Go();
            AbtPages.ServiceHubHomepage.GoTo(ServiceHubLinks.My_Open_Incidents);
            Assert.True(AbtPages.MyOpenIncidentsPage.IncidentExists("Short Description A"));
            AbtPages.ServiceNowHomepage.Go(WebEnvironment.TestEnvironment);
            AbtPages.ServiceNowHomepage.ImpersonateUser("Valeria Rozenbaum");
            AbtPages.ServiceNowHomepage.OpenIncidentSection();
            Assert.True(AbtPages.ServiceNowHomepage.IncidentExist(IncidentType.Ask_A_Question, Urgency.Medium, "Short Description A", "Describe your Question"));


        }



     //   [Fact(DisplayName = "Should Place IT Incident")]
        public void Should_Place_IT_Incident()
        {
            SeleniumDriver.init(Browser.IENoNativeEvents);    //IE247
            AbtPages.ServiceNowHomepage.Go(WebEnvironment.TestEnvironment);
            AbtPages.ServiceNowHomepage.ImpersonateUser("David Acuna");
            AbtPages.ServiceNowHomepage.GoTo(ServicenowLinks.ServiceHub);
            AbtPages.ServiceHubHomepage.GoTo(ServiceHubLinks.New_IT_Request);
            AbtPages.ITServiceRequestpage.NewIncident(IncidentType.IT_Incident);
            AbtPages.ITServiceRequestFormPage.NewRequest(Urgency.High, "Short Description C", "More info for Incident");
            AbtPages.ServiceHubHomepage.Go();
            AbtPages.ServiceHubHomepage.GoTo(ServiceHubLinks.My_Open_Incidents);
            Assert.True(AbtPages.MyOpenIncidentsPage.IncidentExists("Short Description C"));
            AbtPages.ServiceNowHomepage.Go(WebEnvironment.TestEnvironment);
            AbtPages.ServiceNowHomepage.ImpersonateUser("Valeria Rozenbaum");
            AbtPages.ServiceNowHomepage.OpenIncidentSection();
            AbtPages.ServiceNowHomepage.CloseITServiceRequest();

        }


     //   [Fact(DisplayName = "Should Search on Service Hub")]
        public void Should_Search_On_Service_Hub()
        {
            SeleniumDriver.init(Browser.IENoNativeEvents);
            AbtPages.ServiceNowHomepage.Go(WebEnvironment.TestEnvironment);
            AbtPages.ServiceNowHomepage.GoTo(ServicenowLinks.ServiceHub);
            AbtPages.ServiceHubHomepage.Search("Office 2013");

        }

      //  [Fact(DisplayName = "Should Update a Knowledge Base Article")]
        public void Should_Update_Knowledge_Base_Article()
        {
            SeleniumDriver.init(Browser.IENoNativeEvents);
            AbtPages.ServiceNowHomepage.Go(WebEnvironment.TestEnvironment);
            AbtPages.ServiceNowHomepage.ImpersonateUser("Valeria Rozenbaum");
            AbtPages.ServiceNowHomepage.GoTo(ServicenowLinks.ServiceHub);
            AbtPages.ServiceHubHomepage.GoTo(ServiceHubLinks.IT_Knowledge_Base);
            AbtPages.ITKnowledgeBasePage.OpenRandomArticle();
            AbtPages.ITKnowledgeBasePage.EditArticle("Random edition");
        }

      //  [Fact(DisplayName ="Should Create New IT Conferencing Setup Request")]
        public void Should_Create_New_Conferencing_Setup_Request()
        {
            SeleniumDriver.init(Browser.IENoNativeEvents);
            AbtPages.ServiceNowHomepage.Go(WebEnvironment.TestEnvironment);
            AbtPages.ServiceNowHomepage.ImpersonateUser("Valeria Rozenbaum");
            AbtPages.ServiceNowHomepage.GoTo(ServicenowLinks.ServiceHub);
            AbtPages.ServiceHubHomepage.GoTo(ServiceHubLinks.New_IT_Request);
            AbtPages.ITServiceRequestpage.NewIncident(IncidentType.ConferencingSetup);
            AbtPages.ConferencingSetupPage.NewRequest("Bethesda, MD",DateMaker.GetStartDate(),DateMaker.GetEndDate(),
                                                       "Bethesda - Annapolis (4th fl / rm 4096)","meeting info","5");
            Assert.True(AbtPages.SubmittedOrderPage.isAt());


        }
       // [Fact(DisplayName ="Should Create a New IT Distribution List")]
        public void Should_Create_New_Distribution_List_Request()
        {
            SeleniumDriver.init(Browser.IENoNativeEvents);
            AbtPages.ServiceNowHomepage.Go(WebEnvironment.TestEnvironment);
            AbtPages.ServiceNowHomepage.ImpersonateUser("Valeria Rozenbaum");
            AbtPages.ServiceNowHomepage.GoTo(ServicenowLinks.ServiceHub);
            AbtPages.ServiceHubHomepage.GoTo(ServiceHubLinks.New_IT_Request);
            AbtPages.ITServiceRequestpage.NewIncident(IncidentType.DistributionListRequest);
            AbtPages.DistListReqFormPage.NewRequest("Dist name",TypeOfRequest.NewMailingList,"Aaron Musimenta","Add","Aaron Rice","Purpose/Comments");
            Assert.True(AbtPages.SubmittedOrderPage.isAt());
        }

        //[Fact(DisplayName ="Should Create New IT Hardware Peripheral Request")]

    }
}
