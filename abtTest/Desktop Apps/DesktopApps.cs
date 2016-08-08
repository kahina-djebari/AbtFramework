using System;
using AbtFramework;
using AbtFramework.SSO_Classes;
using Xunit;

namespace abtTest.SSO_Test_Cases
{
   
    public class SSO
    {
       
       // [Fact]
        public void Should_be_LoggedInSkype()
        {
            SkypeConsole.init();
           
            Assert.True(SkypeConsole.isLoggedIn());
        }

       //[Fact]
        public void Should_Be_LoggedIn_Outlook()
        {
         
            OfficeUtils.OutlookWrapper.init();
            Assert.True(OfficeUtils.OutlookWrapper.isLoggedIn());
        }
    }
}
