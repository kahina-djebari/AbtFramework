using System;
using AbtFramework;
using AbtFramework.SSO_Classes;


namespace abtTest.SSO_Test_Cases
{
   
    public class SSO
    {
       
        public void Should_be_LoggedInSkype()
        {
            SkypeConsole.init();
            SkypeConsole.SignIn();
            //Assert.IsTrue(SkypeConsole.userIsloggedin);
        }

       
        public void Should_Be_LoggedIn_Outlook()
        {
         
            OfficeUtils.OutlookWrapper.init();
           // Assert.True(OfficeUtils.OutlookWrapper.isLoggedIn());
        }
    }
}
