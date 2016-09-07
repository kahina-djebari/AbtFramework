using System;
using AbtFramework;
using AbtFramework.Utils_Classes;
using Xunit;

namespace abtTest.Web
{
    
    public class WeSpire
    {
      
        //[Fact(DisplayName ="Should Update a Random Interest")]
        public void Should_Update_your_Interests()
        {
            Driver.RemoteInitDavidsPc(Browser.IENoNativeEvents);
            AbtDriver.WeSpireHomePage.Go(WebEnvironment.TestEnvironment);
            AbtDriver.WeSpireHomePage.GoTo(weSpireHomeLinks.UpdateInterest);
            AbtDriver.WeSpireUpdateInterestsPage.RandomInterestUpdate();
            //Assert.True(AbtDriver.WeSpireHomePage.isAt());
               
        }

     // [Fact(DisplayName ="Should like a Random Post")]
        public void Should_Like_a_Random_Comment()
        {
            Driver.RemoteInitDavidsPc(Browser.IENoNativeEvents);
            AbtDriver.WeSpireHomePage.Go(WebEnvironment.TestEnvironment);
            AbtDriver.WeSpireHomePage.LikeOrUnlikeRandomComment();
            //Assert that the post changed to not liked or liked?
        }

       // [Fact(DisplayName ="Should Invite a user to WeSpire")]
        public void Should_Invite_User_To_WeSpire()
        {
            Driver.RemoteInitDavidsPc(Browser.IENoNativeEvents);
            AbtDriver.WeSpireHomePage.Go(WebEnvironment.TestEnvironment);
            AbtDriver.WeSpireHomePage.GoTo(weSpireHomeLinks.Invite);
            Assert.True(AbtDriver.WeSpireInvitePage.InviteUser("cristian_paulino@abtassoc.com"));
           
        }

       // [Fact(DisplayName ="Should Post on a Random Comment")]
        public void Should_Post_On_A_Random_Comment()
        {
            Driver.RemoteInitDavidsPc(Browser.IENoNativeEvents);
            AbtDriver.WeSpireHomePage.Go(WebEnvironment.TestEnvironment);
            AbtDriver.WeSpireHomePage.PostOnRandomComment();
        }




    }
}
