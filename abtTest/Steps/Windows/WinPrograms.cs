﻿using AbtFramework;
using AbtFramework.SSO_Classes;
using TechTalk.SpecFlow;
using Xunit;

namespace abtTest.Steps.Windows
{
    [Binding]
    public sealed class WinPrograms
    {
        [Given(@"i opened Outlook")]
        public void GivenIOpenedOutlook()
        {
            OfficeUtils.OutlookWrapper.init();
        }

        [Then(@"Outlook is logged with my Windows credentials")]
        public void ThenOutlookIsLoggedWithMyWindowsCredentials()
        {
            Assert.True(OfficeUtils.OutlookWrapper.isLoggedIn());
        }

        [Given(@"i have logged to Windows")]
        public void GivenIHaveLoggedToWindows()
        {
            SkypeConsole.init();
        }

        [Then(@"Skype for Business opened with my user")]
        public void ThenSkypeForBusinessOpenedWithMyUser()
        {
            Assert.True(SkypeConsole.BeginSkypeSignIn());
        }

    }
}
