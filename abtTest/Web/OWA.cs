using System;
using Xunit;
using AbtFramework;

namespace abtTest.Web
{
    
    public class OWA:IDisposable
    {
        public OWA()
        {
            //Driver.init();
           // Driver.RemoteInit();
        }
        public void Dispose()
        {
            SeleniumDriver.Close();
        }

      //  [Fact(DisplayName ="Should Open a received email")]
        public void Should_Open_Received_Email()
        {
            SeleniumDriver.RemoteInit();
            AbtPages.AgiHomePage.Go();
            AbtPages.AgiTopNavigation.ToolsDropdown.goTo(Abtlinks.Outlook);
            AbtPages.OutlookWebPage.OpenEmail();
           // Assert.True(AbtDriver.OutlookEmailViewerPage.isEmailOpen(), "Could not Open Email");
        }

       // [Fact(DisplayName ="Should Send an email")]
        public void Should_Send_An_Email()
        {
            AbtPages.AgiHomePage.Go();
            AbtPages.AgiTopNavigation.ToolsDropdown.goTo(Abtlinks.Outlook);
          //  Assert.True(AbtDriver.OutlookWebPage.SendEmail("david_acuna@abtassoc.com", "subject goes here", "Body goes here"));
        }
    }
}
