using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AbtFramework;
using AbtFramework.SSO_Classes;

namespace abtTest.SSO_Test_Cases
{
    [TestClass]
    public class SSO
    {
        [TestMethod]
        public void Should_be_LoggedInSkype()
        {
            SkypeConsole.init();
            SkypeConsole.SignIn();
            Assert.IsTrue(SkypeConsole.userIsloggedin);
        }

        [TestMethod]
        public void Should_Send_Outlookemail()
        {
            OfficeUtils.OutlookWrapper.SendLog();
        }
    }
}
