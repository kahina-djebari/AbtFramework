using AbtFramework;
using AbtFramework.Utils_Classes;
using System;
using TechTalk.SpecFlow;
using Xunit;

namespace abtTest.Steps
{
    [Binding]
    public sealed class Oracle
    {
        private static String gUser = "user";
        // kill all the selenium drivers after a successfull test.
        [AfterScenario]
        public void CleanUp()
        {
            SeleniumDriver.Quit();
        }
        // For additional details on SpecFlow step definitions see http://go.specflow.org/doc-stepdef
        //[Given(@"go to the Home screen")]
        //public void GivenGoToTheHomeScreen()
        //{
            //AbtPages.OraclePage.ClickHomeButton();
        //}
        [Given(@"I have Open IE Test")]
        public void GivenIHaveOpenIETest()
        {
            SeleniumDriver.init(Browser.Chrome);
        }
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
        [Then(@"click iProcurement request and then Non-Catalog Req")]
        public void ThenClickIProcurementRequestAndThenNon_CatalogReq()
        {
            AbtPages.OraclePage.clickIProcurementRequest();
        }
        [Then(@"click the ""(.*)"" option")]
        public void ThenClickTheOption(string p0)
        {
            AbtPages.OraclePage.ClickMainMenuTableOption(p0);
        }
        [Then(@"browse to ""(.*)""")]
        public void ThenBrowseTo(string p0)
        {
            AbtPages.OraclePage.ClickUserOptions(p0);
        }
        [Then(@"go to time entry")]
        public void ThenGoToTimeEntry()
        {
            AbtPages.OraclePage.clickTimeCard();
        }

        [Then(@"fill the TimeCard")]
        public void ThenFillTheTimeCard()
        {
            AbtPages.OraclePage.fillTimeCard();
        }
        [Then(@"close complete the timeCard request")]
        public void ThenCloseCompleteTheTimeCardRequest()
        {
            AbtPages.OraclePage.completeTimeCardRequest();
        }

        [Then(@"fill the request form")]
        public void ThenFillTheRequestForm()
        {
            AbtPages.OraclePage.fillNonCatalogRequestForm();
        }
        [Then(@"Checkout the cart")]
        public void ThenCheckoutTheCart()
        {
            AbtPages.OraclePage.clickCheckOut();
        }
        [Then(@"Fill Requisition Information")]
        public void ThenFillRequisitionInformation()
        {
            AbtPages.OraclePage.fillRequisitionInformation();
        }
        [Then(@"Submit after approvers")]
        public void ThenSubmitAfterApprovers()
        {
            AbtPages.OraclePage.SubmitAfterApprovers();
        }
        [Then(@"Click Manage Approvals")]
        public void ThenClickManageApprovals()
        {
            AbtPages.OraclePage.clickManageGraphButton();
        }
        [Then(@"complete the order")]
        public void ThenCompleteTheOrder()
        {
            AbtPages.OraclePage.SelectAndApproveOrder();
        }

        [Then(@"assign ""(.*)"" before requisition and submit")]
        public void ThenAssignBeforeRequisitionAndSubmit(string p0)
        {
            AbtPages.OraclePage.addBeforeApproverAndSubmit(p0);
        }

        [Then(@"Then assign ""(.*)"" after requisition and submit")]
        public void ThenThenAssignAfterRequisitionAndSubmit(string p0)
        {
            AbtPages.OraclePage.addAfterApprover(p0);

        }
        [When(@"i hit submit the request is done")]
        public void WhenIHitSubmitTheRequestIsDone()
        {
            AbtPages.OraclePage.submitApproval();
        }

    }
}
