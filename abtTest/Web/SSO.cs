using System;
using AbtFramework;
using Xunit;
using Xunit.Abstractions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace abtTest.Web
{
  
    public class SSO:IDisposable
    {
        

       
        public SSO()
        {
           // Driver.init();
                   
        }              
       
       // [Fact(DisplayName ="Should Go to AGI Home Page (SSO Check)")]
        public void Should_Be_Loggedin_on_AGI_Homepage()
        {
            
            AbtDriver.HomePage.Go();
             
            Assert.IsTrue(AbtDriver.HomePage.isUserLoggedin());
          
        }

    

   
       // [Fact(DisplayName ="Should go to Abt Knowledge (SSO Check)")]
        public void Should_click_AbtKnowledge()
        {
            AbtDriver.HomePage.Go();
            AbtDriver.TopNavigation.ToolsDropdown.goTo(AbtPages.AbtKnowledge);
            Assert.IsTrue(AbtDriver.AbtKnowledgePage.isAt(),"Couldn't get to Abt Knowledge Page");
          
        }

       //  [Fact(DisplayName ="Should go to  Abt Travel (SSO Check)")]
        public void Should_click_AbtTravel()
        {
            AbtDriver.HomePage.Go();
            AbtDriver.TopNavigation.ToolsDropdown.goTo(AbtPages.AbtTravel);
           Assert.IsTrue(AbtDriver.AbtTravelPage.isAt());
        }

      //  [Fact(DisplayName ="Should Access Oracle (SSO Check)")]
        public void Should_click_Oracle()
        {
            Driver.init();
            AbtDriver.HomePage.Go();
            AbtDriver.TopNavigation.ToolsDropdown.goTo(AbtPages.Oracle);
            Assert.IsTrue(AbtDriver.OraclePage.isAt()); //need to check if logged in currently i dont have access

        }

      

       // [Fact(DisplayName ="Should Go to Outlook Web Access (SSO Check)")]
        public void Should_Open_OutlookWebAccess()
        {
            AbtDriver.HomePage.Go();
            AbtDriver.TopNavigation.ToolsDropdown.goTo(AbtPages.Outlook);
           Assert.IsTrue(AbtDriver.OutlookWebPage.isAt());

        }

   

        public void Dispose()
        {
          //  Driver.Close();
        }
    }
}
