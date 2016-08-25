using System;
using Xunit;
using AbtFramework;
using AbtFramework.Utils_Classes;
using Xunit.Extensions;

namespace abtTest.Web
{
    
    public class ServiceNow
    {
        
        //[Fact(DisplayName ="Should Impersonate User")]
        public void Should_Impersonate_User()
        {
            Driver.init(Browser.IE);
            AbtDriver.ServiceNowHomepage.Go();
            AbtDriver.ServiceNowHomepage.ImpersonateUser("Zanira Khan");
            Assert.True(AbtDriver.ServiceNowHomepage.isRoleCorrect("Zanira Khan"));
                                  
        }

       // [Theory(DisplayName ="Should Print Names:")]
       // [ExcelData("UserRolesData.xls", "Select * from UserRolesRange")]
        public void Should_Print_Names(string name,string role)
        {
            Console.WriteLine("name: " + name);
            Console.WriteLine("role: " + role);
        }

        //[Fact(DisplayName ="Should Place HR Request ")]
        public void Should_Place_HR_Request()
        {
            Driver.init(Browser.IE);
            AbtDriver.ServiceNowHomepage.Go();
            AbtDriver.ServiceNowHomepage.ImpersonateUser("David Acuna");
            AbtDriver.ServiceNowHomepage.Goto(ServicenowLinks.ServiceHub);
            AbtDriver.ServiceHubHomepage.NewRequest(ServiceHubRequest.HRServiceRequest);
            AbtDriver.HRServiceRequestpage.NewHRServiceRequest(HRIssueCategory.Benefits,"Subject Goes Here","Description Goes Here");
            AbtDriver.ServiceNowHomepage.Go();
            AbtDriver.ServiceNowHomepage.ImpersonateUser("Michael Stinson");
            AbtDriver.ServiceNowHomepage.CloseHRServiceRequest();
        }

       // [Fact(DisplayName ="Should Close HR Request")]
        public void Should_Close_HR_Request()
        {
            Driver.init();
            AbtDriver.ServiceNowHomepage.Go();
            AbtDriver.ServiceNowHomepage.ImpersonateUser("Michael Stinson");
            AbtDriver.ServiceNowHomepage.CloseHRServiceRequest();

        }

       // [Fact(DisplayName = "Should Place IT Request or incident")]
        public void Should_Place_IT_Request()
        {
            Driver.init(Browser.IE);    //IE247
            AbtDriver.ServiceNowHomepage.Go();
            AbtDriver.ServiceNowHomepage.ImpersonateUser("David Acuna");
            AbtDriver.ServiceNowHomepage.Goto(ServicenowLinks.ServiceHub);
            AbtDriver.ServiceHubHomepage.NewRequest(ServiceHubRequest.ITServiceRequest);
            AbtDriver.ITServiceRequestpage.NewIncident("Medium", "short description goes here", "Description your issue goes Here");
            AbtDriver.ServiceNowHomepage.Go();
            AbtDriver.ServiceNowHomepage.ImpersonateUser("Valeria Rozenbaum");
            AbtDriver.ServiceNowHomepage.CloseITServiceRequest();

        }

       // [Fact(DisplayName = "Should Close IT Request")]
        public void Should_Close_IT_Request()
        {
            Driver.init(Browser.Chrome);
            AbtDriver.ServiceNowHomepage.Go();
            AbtDriver.ServiceNowHomepage.ImpersonateUser("Valeria Rozenbaum");
            AbtDriver.ServiceNowHomepage.CloseITServiceRequest();


        }


       // [Fact(DisplayName = "Should Place Office Request ")]
        public void Should_Place_Office_Request()
        {
            Driver.init(Browser.IE);
            AbtDriver.ServiceNowHomepage.Go();
            AbtDriver.ServiceNowHomepage.ImpersonateUser("David Acuna");
            AbtDriver.ServiceNowHomepage.Goto(ServicenowLinks.ServiceHub);
            AbtDriver.ServiceHubHomepage.NewRequest(ServiceHubRequest.OfficeServiceRequest);
            AbtDriver.OfficeServiceRequestpage.NewOfficeRequest("Bethesda, MD", "Office Space", "Shelvin", "Short description-3", "Notes/Comments");
            AbtDriver.ServiceNowHomepage.Go();
            AbtDriver.ServiceNowHomepage.ImpersonateUser("Steve Hunt");
            AbtDriver.ServiceNowHomepage.CloseOfficeRequest("Short description-3","work notes","Steve Hunt");
            Assert.True(AbtDriver.ServiceNowHomepage.OfficeRequestIsClosed("Short description-3"));
            Driver.Quit();
            // AbtDriver.OfficeServiceRequestpage.FillRequestWith(HRIssueCategory.Benefits, "Subject Goes Here", "Description Goes Here");

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
