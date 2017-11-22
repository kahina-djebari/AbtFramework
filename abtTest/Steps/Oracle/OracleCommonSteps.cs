using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AbtFramework;
using AbtFramework.Utils_Classes.SeleniumUtils;
using TechTalk.SpecFlow;

namespace abtTest.Steps.Oracle
{
    /// <summary>
    /// Holds all common steps for Oracle. Any step that is going 
    /// to be used in more than one feature should be here.
    /// </summary>
    [Binding]
    public sealed class OracleCommonSteps
    {
        private static String gUser = "user";

        [Given(@"I have navigated to Oracle Dev")]
        public void GivenIHaveNavigatedToOracleDev()
        {
            AbtPages.OraclePage.GoToOracleDev();
        }


        [Given(@"i login as ""(.*)""")]
        public void GivenILoginAs(string user)
        {
            gUser = user;
            AbtPages.OraclePage.inputUserName(gUser);
            AbtPages.OraclePage.inputPasswordField(gUser);
            AbtPages.OraclePage.clickSubmitButton();
        }
    }
}
