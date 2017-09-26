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
        // For additional details on SpecFlow step definitions see http://go.specflow.org/doc-stepdef

        [Given(@"I have Open IE Test")]
        public void GivenIHaveOpenIETest()
        {
            SeleniumDriver.init(Browser.IE);
        }
        [Given(@"I have navigated to Oracle Dev")]
        public void GivenIHaveNavigatedToOracleDev()
        {
            AbtPages.OraclePage.GoToOracleDev();
        }
        [Given(@"put my user and password")]
        public void GivenPutMyUserAndPassword()
        {
            AbtPages.OraclePage.inputUserName();
            AbtPages.OraclePage.inputPasswordField();
            AbtPages.OraclePage.clickSubmitButton();
        }
        [Then(@"click iProcurement request and then Non-Catalog Req")]
        public void ThenClickIProcurementRequestAndThenNon_CatalogReq()
        {
            AbtPages.OraclePage.clickIProcurementRequest();
        }
        [Then(@"click Abt US Timecards")]
        public void ThenClickAbtUSTimecards()
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
        [Then(@"Click Manage Approvals")]
        public void ThenClickManageApprovals()
        {
            AbtPages.OraclePage.clickManageGraphButton();
        }
        [Then(@"assign ""(.*)"" before requisition and submit")]
        public void ThenAssignBeforeRequisitionAndSubmit(string p0)
        {
            AbtPages.OraclePage.addBeforeApproverAndSubmit(p0);
        }

        [Then(@"Then assign ""(.*)"" after requisition and submit")]
        public void ThenThenAssignAfterRequisitionAndSubmit(string p0)
        {
            AbtPages.OraclePage.addAfterApproverAndSubmit(p0);

        }
        [When(@"i hit submit the request is done")]
        public void WhenIHitSubmitTheRequestIsDone()
        {
            AbtPages.OraclePage.submitApproval();
        }


    }
}
