using System;
using Xunit;
using AbtFramework;
using AbtFramework.Utils_Classes;

namespace abtTest.Web
{
    
    public class Office365
    {
      //  [Fact(DisplayName ="Should Log into AGI withouth being prompted for Credentials")]
        public void Should_Go_To_AGI_HomePage()
        {
            SeleniumDriver.init(Browser.IENoNativeEvents);
            AbtPages.AgiHomePage.Go();
            Assert.True(AbtPages.AgiHomePage.isUserLoggedin());

        }


      //  [Fact(DisplayName = "Should Log into AGI Through Sharepoint Should ask For Credentials")]
        public void Should_Go_To_AGI_HomePage_Through_Sharepoint()
        {
            SeleniumDriver.init(Browser.IECleanSessionNoNativeEvents);
            SeleniumDriver.GoTo("https://abtassoc.sharepoint.com");
            AbtPages.Office365LoginPage.Login("david_acuna@abtassoc.com");
            Assert.True(AbtPages.AgiHomePage.isUserLoggedin());

        }

      //  [Fact(DisplayName ="Should Log into OWA without being prompted for credentials")]
        public void Should_Log_in_To_OWA_Qualified()
        {
            SeleniumDriver.init(Browser.IE);
            AbtPages.OutlookWebPage.Go();
            Assert.True(AbtPages.OutlookWebPage.IsUserLoggedIn());
        }


     //   [Fact(DisplayName = "Should Log into OWA Through Office365 Should ask for credentials")]
        public void Should_Log_in_To_OWA_UnQualified()
        {
            SeleniumDriver.init(Browser.RemoteSofianesIECleanSession);
            AbtPages.MailOffice365Page.Go();
            AbtPages.MailOffice365Page.Login("sofiane_oumsalem@abtassoc.com");
            Assert.True(AbtPages.OutlookWebPage.IsUserLoggedIn());
        }

        








    }
}
