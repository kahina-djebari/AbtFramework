using System;
using AbtFramework;
using AbtFramework.Utils_Classes.SeleniumUtils;
using Xunit;
//using Xunit.Abstractions;

namespace abtTest.Web
{
  
    public class SSO:IDisposable
    {
        

       
        public SSO()
        {
           // Driver.InitBrowser();
                   
        }              
       
       // [Fact(DisplayName ="Should Go to AGI Home Page (SSO Check)")]
        public void Should_Be_Loggedin_on_AGI_Homepage()
        {
            
            AbtPages.AgiHomePage.Go();
             
            Assert.True(AbtPages.AgiHomePage.isUserLoggedin());
          
        }

    

   
       // [Fact(DisplayName ="Should go to Abt Knowledge (SSO Check)")]
        public void Should_click_AbtKnowledge()
        {
            AbtPages.AgiHomePage.Go();
            AbtPages.AgiTopNavigation.ToolsDropdown.goTo(Abtlinks.AbtKnowledge);
            Assert.True(AbtPages.AbtKnowledgePage.IsUserLoggedIn(),"User is not Logged In");
          
        }

       //  [Fact(DisplayName ="Should go to  Abt Travel (SSO Check)")]
        public void Should_click_AbtTravel()
        {
            AbtPages.AgiHomePage.Go();
            AbtPages.AgiTopNavigation.ToolsDropdown.goTo(Abtlinks.AbtTravel);
           Assert.True(AbtPages.AbtTravelPage.isAt());
        }

      //  [Fact(DisplayName ="Should Access OracleSteps (SSO Check)")]
        public void Should_click_Oracle()
        {
            ///TODO refactor process
            // SeleniumDriver.InitBrowser();
            AbtPages.AgiHomePage.Go();
            AbtPages.AgiTopNavigation.ToolsDropdown.goTo(Abtlinks.Oracle);
            Assert.True(SeleniumDriver.isAt()); //need to check if logged in currently i dont have access

        }

      

       // [Fact(DisplayName ="Should Go to Outlook Web Access (SSO Check)")]
        public void Should_Open_OutlookWebAccess()
        {
            AbtPages.AgiHomePage.Go();
            AbtPages.AgiTopNavigation.ToolsDropdown.goTo(Abtlinks.Outlook);
           Assert.True(AbtPages.OutlookWebPage.IsAt());

        }

   

        public void Dispose()
        {
          //  Driver.Close();
        }
    }
}
